namespace DemoBlazor.Model
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<string> Products { get; set; } = new List<string>();

    }
}
