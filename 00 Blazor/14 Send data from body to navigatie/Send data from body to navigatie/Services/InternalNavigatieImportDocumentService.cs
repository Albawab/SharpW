using Send_data_from_body_to_navigatie.Interfaces;
using Send_data_from_body_to_navigatie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Send_data_from_body_to_navigatie.Services
{
    public class InternalNavigatieImportDocumentService : IHandleNavigator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalNavigatieImportDocumentService"/> class.
        /// </summary>
        public InternalNavigatieImportDocumentService()
        {
            this.NavigatieItems.AddRange(this.GetNavigatieItems());
        }

        /// <summary>
        /// Gets or sets het element van de tool bar.
        /// </summary>
        public List<OmschrijvingNavigatorModel> NavigatieItems { get; set; } = new List<OmschrijvingNavigatorModel>();
        public OmschrijvingNavigatorModel OmschrijvingNavigatorModel { get; set; } = new OmschrijvingNavigatorModel() { Omschrijving = "Hallo 4" };

        public event Action<IHandleNavigator> OnNavigationItemUpdate;

        /// <inheritdoc/>
        public List<OmschrijvingNavigatorModel> GetItems()
        {
            return this.NavigatieItems;
        }

        public void InvokeOmschrijvigNavigatorItem()
        {
            this.OnNavigationItemUpdate?.Invoke(this);
        }

        /// <summary>
        /// creëren de items van de navigatie.
        /// Geeft de items van de navigatie terug.
        /// </summary>
        /// <returns>De elementen van de navigatie.</returns>
        private List<OmschrijvingNavigatorModel> GetNavigatieItems()
        {
            return new List<OmschrijvingNavigatorModel>()
            {
                new OmschrijvingNavigatorModel(){Omschrijving = "Hallo 1" },
                new OmschrijvingNavigatorModel(){Omschrijving = "Hallo 2" },
                new OmschrijvingNavigatorModel(){Omschrijving = "Hallo 3" },
            };
        }
    }
}
