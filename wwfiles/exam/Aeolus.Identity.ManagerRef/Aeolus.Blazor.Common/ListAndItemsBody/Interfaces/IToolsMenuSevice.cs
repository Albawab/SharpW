using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    public interface IToolsMenuSevice
    {
        List<ToolMenuItemModel> GetToolItems();

        void Update(BodyModel item);
    }
}
