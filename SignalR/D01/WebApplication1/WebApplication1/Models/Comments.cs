using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }    
        public string Username { get; set; }

    }
}
