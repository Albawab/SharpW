using HenE.Aeolus.Blazor.Common.Body.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Aeolus.Blazor.Common.Body.Interfaces
{
    public interface IHandleMenubar
    {
        List<ToolMenuItemModel> GetMenubarItems();
    }
}
