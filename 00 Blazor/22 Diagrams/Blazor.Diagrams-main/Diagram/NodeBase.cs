﻿using Excubo.Blazor.Canvas.Contexts;
using Excubo.Blazor.Diagrams.__Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Threading.Tasks;

namespace Excubo.Blazor.Diagrams
{
    public abstract class NodeBase : ComponentBase, IDisposable
    {
        #region properties
        private double x;
        private double y;
        /// <summary>
        /// Horizontal position of the node
        /// </summary>
        [Parameter] public double X { get => x; set { if (value == x) { return; } x = value; PositionChanged?.Invoke(this, EventArgs.Empty); } }
        [Parameter] public EventCallback<double> XChanged { get; set; }
        internal event EventHandler PositionChanged;
        /// <summary>
        /// Vertical position of the node
        /// </summary>
        [Parameter] public double Y { get => y; set { if (value == y) { return; } y = value; PositionChanged?.Invoke(this, EventArgs.Empty); } }
        [Parameter] public EventCallback<double> YChanged { get; set; }
        protected string PositionAndScale => $"translate({Zoom * X} {Zoom * Y}) scale({Zoom})";
        [CascadingParameter] public Diagram Diagram { get; set; }
        [CascadingParameter] public NodeLibrary NodeLibrary { get; set; }
        protected bool Movable => NodeLibrary != null || IsInternallyGenerated || (XChanged.HasDelegate && YChanged.HasDelegate);
        protected double Zoom => (NodeLibrary == null) ? Diagram.NavigationSettings.Zoom : 1; // if we are in the node library, we do not want the nodes to be zoomed.
        private double width = 100;
        private double height = 100;
        /// <summary>
        /// Unique Id of the node
        /// </summary>
        [Parameter] public string Id { get; set; }
        /// <summary>
        /// The fill color of the node
        /// </summary>
        [Parameter] public string Fill { get; set; } = "#f5f5f5";
        /// <summary>
        /// The stroke color of the node
        /// </summary>
        [Parameter] public string Stroke { get; set; } = "#e8e8e8";
        /// <summary>
        /// Any child content of the node is placed inside a div. To apply CSS classes to that div, use this property.
        /// </summary>
        [Parameter] public string ContentClasses { get; set; }
        /// <summary>
        /// Any child content of the node is placed inside a div. To apply CSS style to that div, use this property.
        /// </summary>
        [Parameter] public string ContentStyle { get; set; }
        /// <summary>
        /// The minimum height the node should have. (Default: 0).
        /// </summary>
        [Parameter] public double MinHeight { get; set; }
        /// <summary>
        /// The minimum width the node should have. (Default: 0).
        /// </summary>
        [Parameter] public double MinWidth { get; set; }
        /// <summary>
        /// The node's content.
        /// </summary>
        [Parameter] public RenderFragment<NodeBase> ChildContent { get; set; }
        /// <summary>
        /// NOT INTENDED FOR USE BY USERS.
        /// Callback for when the node has been created. This is only invoked for nodes that are created during interactive usage of the diagram, not for nodes that are provided declaratively.
        /// </summary>
        [Parameter] public Action<NodeBase> OnCreate { get; set; }
        [CascadingParameter] public Nodes Nodes { get; set; }
        [CascadingParameter(Name = nameof(IsInternallyGenerated))] public bool IsInternallyGenerated { get; set; }
        public double Width { get => width; set { if (value == width) { return; } width = Math.Max(MinWidth, value); } }
        public double Height { get => height; set { if (value == height) { return; } height = Math.Max(MinHeight, value); } }
        protected bool Selected { get; private set; }
        protected bool Hovered { get; private set; }
        public bool Deleted { get; private set; }
        protected bool OffCanvas { get; set; }
        internal void ReRenderIfOffCanvasChanged()
        {
            var (LeftMargin, TopMargin, RightMargin, BottomMargin) = GetDrawingMargins();
            var left = X - LeftMargin;
            var right = X + Width + RightMargin;
            var top = Y - TopMargin;
            var bottom = Y + Height + BottomMargin;
            var value = right < Diagram.NavigationSettings.Origin.X
                || bottom < Diagram.NavigationSettings.Origin.Y
                || left > Diagram.NavigationSettings.Origin.X + Diagram.CanvasWidth / Diagram.NavigationSettings.Zoom
                || top > Diagram.NavigationSettings.Origin.Y + Diagram.CanvasHeight / Diagram.NavigationSettings.Zoom;
            if (value != OffCanvas)
            {
                OffCanvas = value;
                StateHasChanged();
            }
        }
        #endregion
        #region hover
        internal void MarkDeleted() { Deleted = true; }
        internal void MarkUndeleted() { Deleted = false; }
        protected void OnNodeOver(MouseEventArgs _) { Hovered = true; Diagram.SetActiveElement(this, (NodeLibrary == null) ? HoverType.Node : HoverType.NewNode); }
        protected void OnNodeOut(MouseEventArgs _) { Hovered = false; Diagram.DeactivateElement(); }
        protected void OnBorderOver(MouseEventArgs _) { Hovered = true; Diagram.SetActiveElement(this, HoverType.Border); }
        protected void OnBorderOut(MouseEventArgs _) { Hovered = false; Diagram.DeactivateElement(); }
        #endregion
        public void UpdatePosition(double x, double y)
        {
            if (!Movable)
            {
                return;
            }
            X = x;
            Y = y;
            _ = XChanged.InvokeAsync(X);
            _ = YChanged.InvokeAsync(y);
            ReRenderIfOffCanvasChanged();
            StateHasChanged();
        }
        internal void TriggerStateHasChanged() => StateHasChanged();
        protected override void OnParametersSet()
        {
            if (GetType() != typeof(Node)) // Node type is just a wrapper for the actual node, so adding this would prevent the actual node from being recognised.
            {
                if (!Deleted)
                {
                    AddNodeContent();
                }
                if (Nodes != null)
                {
                    Nodes.Register(this);
                }
                base.OnParametersSet();
            }
        }
        #region node content
        internal void RemoveBorderAndContent()
        {
            if (actual_border != null)
            {
                Diagram.RemoveNodeBorderFragment(actual_border);
            }
            if (content != null)
            {
                Diagram.RemoveNodeContentFragment(content);
            }
        }
        internal void AddBorderAndContent()
        {
            Diagram.AddNodeContentFragment(content);
            Diagram.AddNodeBorderFragment(actual_border);
        }
        private bool content_added;
        private void AddNodeContent()
        {
            if (content_added)
            {
                return;
            }
            content_added = true;
            if (GetType() == typeof(Node))
            {
                return;
            }
            content = GetChildContentWrapper();
            actual_border = GetBorderWrapper();
            if (NodeLibrary == null)
            {
                Diagram.AddNodeContentFragment(content);
                Diagram.AddNodeBorderFragment(actual_border);
            }
            else
            {
                Diagram.AddNodeTemplateContentFragment(content);
            }
        }
        private RenderFragment<string> GetBorderWrapper()
        {
            return (key) => (builder) =>
            {
                if (OffCanvas)
                {
                    return;
                }
                builder.OpenComponent<NodeBorder>(0);
                builder.AddAttribute(1, nameof(NodeBorder.ChildContent), border);
                builder.AddComponentReferenceCapture(2, (reference) => node_border_reference = (NodeBorder)reference);
                builder.SetKey(key);
                builder.CloseComponent();
            };
        }
        private RenderFragment<string> GetChildContentWrapper()
        {
            return (key) => (builder) =>
            {
                if (OffCanvas)
                {
                    return;
                }
                builder.OpenComponent<NodeContent>(0);
                builder.AddAttribute(1, nameof(NodeContent.X), X);
                builder.AddAttribute(2, nameof(NodeContent.Y), Y);
                builder.AddAttribute(3, nameof(NodeContent.Width), Width);
                builder.AddAttribute(4, nameof(NodeContent.Height), Height);
                builder.AddAttribute(5, nameof(NodeContent.Zoom), Zoom);
                if (ChildContent != null)
                {
                    builder.AddAttribute(6, nameof(NodeContent.ChildContent), ChildContent(this));
                }
                if (ContentClasses != null)
                {
                    builder.AddAttribute(7, nameof(NodeContent.ContentClasses), ContentClasses);
                }
                if (ContentStyle != null)
                {
                    builder.AddAttribute(8, nameof(NodeContent.ContentStyle), ContentStyle);
                }
                builder.AddAttribute(9, nameof(NodeContent.SizeCallback), (Action<(double Width, double Height)>)GetSize);
                builder.AddComponentReferenceCapture(10, (reference) => content_reference = (NodeContent)reference);
                builder.SetKey(key);
                builder.CloseComponent();
            };
        }
        internal void Select() { Selected = true; }
        internal void Deselect() { Selected = false; }
        protected bool Hidden { get; set; } = true;
        protected void GetSize((double Width, double Height) result)
        {
            (Width, Height) = result;
            if (NodeLibrary != null)
            {
                (X, Y, _, _) = NodeLibrary.GetPosition(this);
            }
            Hidden = false;
            StateHasChanged();
        }
        protected override void OnAfterRender(bool first_render)
        {
            if (GetType() == typeof(Node))
            {
                return;
            }
            if (first_render)
            {
                OnCreate?.Invoke(this);
            }
            if (Deleted)
            {
                Diagram.RemoveNodeBorderFragment(actual_border);
                Diagram.RemoveNodeContentFragment(content);
            }
            if (NodeLibrary != null)
            {
                content_reference?.TriggerRender(
                    X,
                    Y,
                    Width,
                    Height,
                    1);
            }
            else
            {
                content_reference?.TriggerRender(
                    Zoom * X,
                    Zoom * Y,
                    Width,
                    Height,
                    Diagram.NavigationSettings.Zoom);
                node_border_reference?.TriggerStateHasChanged();
            }
            base.OnAfterRender(first_render);
        }
        #endregion
        protected internal virtual async Task DrawShapeAsync(IContext2DWithoutGetters context)
        {
            await context.DrawingRectangles.FillRectAsync(X, Y, Width, Height);
        }
        public virtual (double RelativeX, double RelativeY) GetDefaultPort(Position position = Position.Any)
        {
            return (0, 0);
        }
        public abstract RenderFragment border { get; }
        protected internal virtual (double Left, double Top, double Right, double Bottom) GetDrawingMargins()
        {
            return (0, 0, 0, 0);
        }
        private RenderFragment<string> actual_border;
        private RenderFragment<string> content;
        protected NodeContent content_reference;
        protected NodeBorder node_border_reference;
        internal void MoveTo(double x, double y)
        {
            X = x;
            Y = y;
            _ = XChanged.InvokeAsync(X);
            _ = YChanged.InvokeAsync(Y);
            StateHasChanged();
        }
        public void Dispose()
        {
            Nodes?.Deregister(this);
            RemoveBorderAndContent();
        }
    }
}
