namespace Aeolus.Blazor.Common.Navigatie.Interfaces
{
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;
    using System.Collections.Generic;


    public interface INavigatieService
    {
        List<NavigatieItemModel> GetItems();
    }
}
