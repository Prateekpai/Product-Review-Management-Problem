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
        public void RetrieveCountofRecord(List<ProductReview> reviews)
        {
            var RecordData = reviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in RecordData)
            {
                Console.WriteLine("Product ID" + list.ProductID + "......................." + "Count :" + list.Count);
            }

        }

    }
}
