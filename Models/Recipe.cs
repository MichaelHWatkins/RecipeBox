using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }

    public int RecipeId { get; set; }
    public int Name { get; set; }
    public string IngredientList { get; set; }
    public string Instruction { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<RecipeTag> JoinEntities { get; }
  }
}