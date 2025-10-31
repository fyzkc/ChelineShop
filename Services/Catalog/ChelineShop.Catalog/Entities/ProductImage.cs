using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChelineShop.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string ProductImageUrl { get; set; } = null!;
        public bool ProductImageIsPrimary { get; set; }
        public int ProductImageSortOrder { get; set; }

        [BsonIgnore]
        public Product Product { get; set; } = null!; // to take a reference from Product
    }
}
