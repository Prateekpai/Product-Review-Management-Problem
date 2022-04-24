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


        public void ShowProductIDAndReview(List<ProductReview> reviews)
        {
            var RecordData = (from products in reviews
                              orderby products.ProductID
                              select products).ToList();


            foreach (var list in RecordData)
            {
                Console.WriteLine("Product ID" + list.ProductID + "......................." + "Review  :" + list.Review);
            }
        }


    }
}
