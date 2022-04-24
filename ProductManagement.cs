using ProductReviewManagementwithLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementwithLINQ
{
    public class Management
    {
        public void TopRecordList(List<ProductReview> reviews)
        {
            var recordData = (from productreview in reviews
                              orderby productreview.Rating descending
                              select productreview).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID" + list.ProductID + "User ID :" + list.Userid + " Rating : " + list.Rating + "Review : " + list.Rating + "Is Like : " + list.IsLike);

            }

        }
    }
}
