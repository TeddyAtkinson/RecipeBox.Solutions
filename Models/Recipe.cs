using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    [Required(ErrorMessage = "The recipe's instructions can't be empty!")]
    public string Instructions { get; set; }
    [Required(ErrorMessage = "You must add name of your recipe.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "You must add ingredients to your recipe.")]
    public string Ingredients { get; set; }
    [Range(1,5, ErrorMessage = "Must enter a number between 1-5")]
    public int Rating { get; set; }
    public List<RecipeTag> JoinEntities { get;}
    public ApplicationUser User { get; set; }  
  }
}