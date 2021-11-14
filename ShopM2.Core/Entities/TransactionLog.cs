namespace ShopM2.Core.Entities
{
    public partial class TransactionLog
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public string IdRequest { get; set; }
        public string ResponseTransaction { get; set; }
        public System.DateTime DateTime { get; set; }
    }
}
