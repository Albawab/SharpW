namespace Aeolus.Blazor.Common.Body.Interfaces
{
    using Aeolus.Blazor.Common.Body.Models;
    using System.Collections.Generic;


    public interface IBodyService
    {
        List<ToolMenuItemModel> GetToolItems();
    }
}
