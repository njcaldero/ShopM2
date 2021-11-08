namespace ShopM2.Core.Entities
{
    public partial class Product : BaseEntity
    {
        public string Description { get; set; }
        public int Price { get; set; }
        public System.DateTime Created_at { get; set; }
    }
}
