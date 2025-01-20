using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cookbook.Inventory.Components.Ingredients.Persistence;

public class Ingredient
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("unit")]
    public string Unit { get; set; }
    [BsonElement("quantity")]
    public int Quantity { get; set; }
}