using NuGet.Protocol;

namespace WebApplication1.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
        public int  Price { get; set; }

        public int Quantity { get; set; }

        public List<Comments> Comments { get; set; }= new List<Comments>();
    }
}
