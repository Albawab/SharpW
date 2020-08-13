using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    public interface IHandleMenubar
    {
       public List<ToolMenuItemModel> GetMenubarItems();

    }
}
