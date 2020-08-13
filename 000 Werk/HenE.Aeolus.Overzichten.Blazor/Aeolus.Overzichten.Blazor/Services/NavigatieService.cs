// <copyright file="NavigatieService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Overzichten.Blazor.Services
{

    /// <summary>
    /// De server van de navigatie waarvan de applicatie haalt de items op.
    /// </summary>
    public class NavigatieService
    {
        /* private readonly List<NavigatieItem> items = new List<NavigatieItem>();

         /// <summary>
         /// Initializes a new instance of the <see cref="NavigatieService"/> class.
         /// </summary>
         public NavigatieService()
         {
             this.Seed();
         }

         /// <summary>
         /// functie om de data op te halen.
         /// </summary>
         public void Seed()
         {
             this.items.Add(this.GetgroepEen());
             this.items.Add(this.GetgroepTwee());
             this.items.Add(this.GetgroepDrie());
             this.items.Add(this.GetgroepVier());
             this.items.Add(this.GetgroepVijf());
         }

         /// <summary>
         /// Geeft de navigati Items terug.
         /// </summary>
         /// <returns>Een lijst waar de items van de navigatie staat in.</returns>
         public List<NavigatieItem> GetNavigatieItems()
         {
             return this.items;
         }

         /// <summary>
         /// Geeft de favorit elementen terug.
         /// </summary>
         /// <returns>Lijst van elementen.</returns>
         public List<NavigatieItem> GetFavorietenNavigatieItems()
         {
             List<NavigatieItem> result = new List<NavigatieItem>();

             foreach (var item in this.items)
             {
                 result.AddRange(this.GetFavorietenNavigatieItems(item));
             }

             return result;
         }

         /// <summary>
         /// Geeft alle mappen elementen terug.
         /// </summary>
         /// <returns>Lijst van elementen.</returns>
         public List<NavigatieItem> GetAlleMappenNavigatieItems()
         {
             List<NavigatieItem> result = new List<NavigatieItem>();

             foreach (var item in this.items)
             {
                 result.AddRange(this.GetAlleMappenNavigatieItems(item));
             }

             return result;
         }

         private List<NavigatieItem> GetFavorietenNavigatieItems(NavigatieItem parentItem)
         {
             List<NavigatieItem> result = new List<NavigatieItem>();

             if (parentItem.IsFavoriet)
             {
                 result.Add(parentItem);
             }

             if (parentItem.SubItems != null)
             {
                 foreach (var item in parentItem.SubItems)
                 {
                     result.AddRange(this.GetFavorietenNavigatieItems(item));
                 }
             }

             return result;
         }

         private List<NavigatieItem> GetAlleMappenNavigatieItems(NavigatieItem parentItem)
         {
             List<NavigatieItem> result = new List<NavigatieItem>();

             if (!parentItem.IsFavoriet)
             {
                 result.Add(parentItem);
             }

             if (parentItem.SubItems != null)
             {
                 foreach (var item in parentItem.SubItems)
                 {
                     result.AddRange(this.GetAlleMappenNavigatieItems(item));
                 }
             }

             return result;
         }

         private NavigatieItem GetgroepEen()
         {
             GroepNavigatieItem groep = new GroepNavigatieItem(1, "Woningen 1");
             groep.AddSubItem(new PageNavigatieItem(1, "Vwaangepastewoningen", "vwaangepastewoningen"));
             groep.AddSubItem(new PageNavigatieItem(2, "Order", "order"));
             groep.AddSubItem(new PageNavigatieItem(3, "Items 4", "vw.."));

             return groep;
         }

         private NavigatieItem GetgroepTwee()
         {
             GroepNavigatieItem groep = new GroepNavigatieItem(2, "Woningen 2");
             groep.AddSubItem(new PageNavigatieItem(1, "Items 2", "vw.."));
             groep.AddSubItem(new PageNavigatieItem(2, "Items 3", "vw..", true));
             var subitem = new PageNavigatieItem(3, "Items 4", "vw..");
             subitem.AddSubItem(new PageNavigatieItem(4, "Items 5", "vw..", true));
             groep.AddSubItem(subitem);

             return groep;
         }

         private NavigatieItem GetgroepDrie()
         {
             GroepNavigatieItem groep = new GroepNavigatieItem(3, "Woningen 3");
             return groep;
         }

         private NavigatieItem GetgroepVier()
         {
             GroepNavigatieItem groep = new GroepNavigatieItem(4, "Woningen 4");
             return groep;
         }

         private NavigatieItem GetgroepVijf()
         {
             GroepNavigatieItem groep = new GroepNavigatieItem(5, "Index", true);
             return groep;
         }*/
    }
}
