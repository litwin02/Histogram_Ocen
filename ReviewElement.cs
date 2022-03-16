using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_Ocen
{
    public class ReviewElement
    {
        public int ReviewStar { get; set; }
        public int Occurance { get; set; }
        public ReviewElement(int review, int occurance)
        {
            ReviewStar = review;
            Occurance = occurance;
        }
    }
}
