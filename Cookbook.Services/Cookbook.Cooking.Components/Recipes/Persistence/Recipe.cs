using Cookbook.Contracts.Cooking;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cookbook.Cooking.Components.Recipes.Persistence;

public class Recipe
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }

    [BsonElement("instructions")]
    public string Instructions { get; set; }

    [BsonElement("imageUrl")]
    public string ImageUrl { get; set; }

    [BsonElement("prepTime")]
    public int PrepTime { get; set; }

    [BsonElement("cookTime")]
    public int CookTime { get; set; }

    [BsonElement("servings")]
    public int Servings { get; set; }

    [BsonElement("ingredients")]
    public List<RecipeIngredient> Ingredients { get; set; }
}