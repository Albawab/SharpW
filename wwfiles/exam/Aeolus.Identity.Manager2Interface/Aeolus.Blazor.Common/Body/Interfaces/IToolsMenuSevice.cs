using HenE.Aeolus.Blazor.Common.Body.Models;
using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.Body.Interfaces
{
    public interface IToolsMenuSevice
    {
        List<ToolMenuItemModel> GetToolItems();

        void Update(BodyModel item);
    }
}
