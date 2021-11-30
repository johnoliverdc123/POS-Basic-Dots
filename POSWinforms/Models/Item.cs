namespace POSWinforms.Models
{
    public class Item
    {
        public long ID { get; set; }
        public long ItemNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int Stocks { get; set; }
        public int Committed { get; set; }
        public int Sold { get; set; }
        public int Returned { get; set; }
        public int ReStockLevel { get; set; }
        public bool IsActive { get; set; }

    }
}
