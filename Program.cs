using ProductReviewManagementwithLINQ;
using System;
using System.Data;
namespace ProductReviewManagementwithLinq
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Product Review Management Problem");

            List<ProductReview> productreview = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, Userid = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 2, Userid = 2, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, Userid = 3, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 4, Userid = 4, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 5, Userid = 5, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 6, Userid = 6, Rating = 1, Review = "Bad", IsLike=false },
                new ProductReview() { ProductID = 7, Userid = 7, Rating = 1, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 8, Userid = 7, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductID = 9, Userid = 7, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 10, Userid = 7, Rating = 5, Review = "Nice", IsLike = true }

            };

            Management management = new ProductReviewManagementwithLINQ.Management();

            management.ShowProductIDAndReview(productreview);


        }
    }
}
