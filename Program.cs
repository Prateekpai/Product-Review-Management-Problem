using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review managament program ");

            List<ProductReview> Product=new List<ProductReview>()

            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 6, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 8, Rating = 1, Review = "bad", isLike = false }
            };

            foreach (var list in Product)
            {
                Console.WriteLine(" Product ID :" + list.ProductId + " User ID :" + list.UserId  + "Rating :" + list.Rating+ " Review: "+ list.Review+ "Is Liked: "+list.isLike );

            }

        }
    }
}
