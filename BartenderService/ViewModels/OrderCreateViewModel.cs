namespace BartenderService.ViewModels
{
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public class OrderCreateViewModel
    {
        public string CustomerName { get; set; }

        // For selecting cocktails
        
        public List<int> SelectedCocktailIds { get; set; } = new List<int>();
        [ValidateNever]
        public List<SelectListItem> AvailableCocktails { get; set; }
    }

}
