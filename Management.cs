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
        public void SelectRecords(List<ProductReview> reviews)
        {
            var RecordData = from products in reviews
                             where (products.Rating > 3 && products.ProductID == 1) ||
                             (products.Rating > 3 && products.ProductID == 4) ||
                             (products.Rating > 3 && products.ProductID == 9)
                             select products;
            foreach (var list in RecordData)
            {
                Console.WriteLine("Product ID" + list.ProductID + "User ID :" + list.Userid + " Rating : " + list.Rating + "Review : " + list.Rating + "Is Like : " + list.IsLike);

            }

        }

    }
}
