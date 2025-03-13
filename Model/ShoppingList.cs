namespace DemoBlazor.Model
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

    }
}
