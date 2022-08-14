namespace homework35.ASP.Net.Core._2._0.Models
{
    public class ProductModel
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public ProductModel() { }

        public ProductModel(string title, float price)
        {
            this.Title = title;
            this.Price = price;
        }
    }
}
