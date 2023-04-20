
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class ProductHub:Hub
    {
        private readonly DBContext _context;

        public ProductHub(DBContext context)
        {
            _context = context;
        }
        public void  BuyProduct(int pID, int Quantity)
        {

            var Product=_context.products.Where(e=>e.Id == pID).FirstOrDefault();

            if (Product.Quantity == 0 || Product.Quantity<Quantity)
            {
                Clients.Others.SendAsync("Quantity Not Enough", pID, Product.Quantity);
            }
            else
            {
                Product.Quantity -= Quantity;
                _context.SaveChanges();
                Clients.Others.SendAsync("QuantityChange", pID, Product.Quantity);
            }
        }

        public void AddComments(string Comment,int pID)
        {
            Comments comments = new Comments();
            comments.Text= Comment;
            comments.ProductID= pID;
            comments.Username= Comment;
            _context.Add(comments);
            _context.SaveChanges();
            Clients.All.SendAsync("CommentADD", comments.Text);
        }

    }
}
