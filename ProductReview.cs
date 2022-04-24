using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementwithLinq
{
    public class ProductReview
    {
        public int ProductID
        {
            get;
            set;
        }
        public int Userid
        {
            get;
            set;
        }
        public double Rating
        {
            get;
            set;
        }
        public bool IsLike
        {
            get;
            set;
        }
        public string Review
        {
            get;
            set;
        }
    }
}
