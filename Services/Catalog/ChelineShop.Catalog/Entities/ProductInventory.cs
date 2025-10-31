using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChelineShop.Catalog.Entities
{
    public class ProductInventory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProductDetailId { get; set; }
        public int ProductInventoryQuantity { get; set; }

        [BsonIgnore]
        public ProductDetail ProductDetail { get; set; }
        //to take a reference from ProductDetail
    }
}
