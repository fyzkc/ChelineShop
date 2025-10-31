using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChelineShop.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProductId { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }
        //to take a reference from Product

        [BsonIgnore]
        public ICollection<ProductInventory> ProductInventory { get; set; } = new List<ProductInventory>();
        //to take a reference from ProductInventory
    }
}
