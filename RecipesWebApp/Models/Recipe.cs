using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RecipesWebApp.Models
{
    public class Recipe
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Title")]
        public string RecipeTitle { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }
    }
}
