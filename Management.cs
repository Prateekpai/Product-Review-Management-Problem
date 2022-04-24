using ProductReviewManagementwithLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementwithLINQ
{
    internal class Management
    {
        public void SkipTop5Record(List<ProductReview> reviews)
        {
            var recordData = (from productreview in reviews
                              orderby productreview.Rating descending
                              select productreview).Skip(5);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID" + list.ProductID + "User ID :" + list.Userid + " Rating : " + list.Rating + "Review : " + list.Rating + "Is Like : " + list.IsLike);

            }
        }

    }
}
