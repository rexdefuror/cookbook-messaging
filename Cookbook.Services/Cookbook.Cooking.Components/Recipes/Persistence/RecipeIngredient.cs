using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Cooking.Components.Recipes.Persistence
{
    public class RecipeIngredient
    {
        [BsonElement("ingredientId")]
        public string IngredientId { get; init; }
        [BsonElement("quantity")]
        public int Quantity { get; init; }
    }
}
