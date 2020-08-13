using HenE.Aeolus.Blazor.Common.Navigatie.Models;
using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.Navigatie.Interfaces
{
    public interface INavigatieService
    {
        List<NavigatieItemModel> GetItems();
    }
}
