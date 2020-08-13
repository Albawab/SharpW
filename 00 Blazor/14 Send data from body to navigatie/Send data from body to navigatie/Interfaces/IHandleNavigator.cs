using Send_data_from_body_to_navigatie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Send_data_from_body_to_navigatie.Interfaces
{
    /// <summary>
    /// Interface om de navigator te handelen.
    /// </summary>
    public interface IHandleNavigator
    {
        /// <summary>
        /// Het gaat de item van de navigatie updaten.
        /// </summary>
        event Action<IHandleNavigator> OnNavigationItemUpdate;

        /// <summary>
        /// Gets or sets het omschrijving item.
        /// </summary>
        public OmschrijvingNavigatorModel OmschrijvingNavigatorModel { get; set; }

        /// <summary>
        /// Het gaat de navigator updaten.
        /// </summary>
        /// <param name="handleNavigator">Een handler van het navigator.</param>
        public void InvokeOmschrijvigNavigatorItem();
    }
}
