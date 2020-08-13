using System.Collections.Generic;

namespace HenE.Aeolus.Blazor.Common.Body.Models
{
    public class LijstItemsModel
    {
        public LijstItemsModel(string title)
        {
            this.Title = title;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public List<LijstItemsModel> Kinderen { get; set; }
    }
}
