using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebApp.Models
{
    public class RecipeDatabaseSettings: IRecipeDatabaseSettings
    {
        public string RecipeCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRecipeDatabaseSettings
    {
        string RecipeCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
