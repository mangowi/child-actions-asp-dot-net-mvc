namespace ChildAction.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Items
        {
            get
            {
                return CategoryManager.GetCategories().Count;
            }
        }
    }
}