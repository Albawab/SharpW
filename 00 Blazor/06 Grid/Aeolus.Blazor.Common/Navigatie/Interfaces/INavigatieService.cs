namespace Aeolus.Blazor.Common.Navigatie.Interfaces
{
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface INavigatieService
    {
        IList<NavigatieItemModel> GetItems();
    }
}
