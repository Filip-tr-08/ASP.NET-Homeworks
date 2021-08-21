using SEDC.PizzaApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;


namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
   public class PizzaDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Name")]
        public string Name { get; set; }
        [Display(Name = "Pizza Size")]
        public PizzaSizeEnum PizzaSize { get; set; }
        [Display(Name="Price")]
        public int Price { get; set; }
        [Display(Name = "Is on Promotion")]
        public bool IsOnPromotion { get; set; }
    }
}
