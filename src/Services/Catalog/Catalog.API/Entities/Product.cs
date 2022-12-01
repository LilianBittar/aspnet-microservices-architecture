namespace  Catalog.API.Entities;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.Object)]
    public string Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }
    public string Catagory { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }
    public decimal Price { get; set; }
}
