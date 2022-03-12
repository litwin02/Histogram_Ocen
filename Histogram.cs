using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Histogram_Ocen
{
    public class Histogram
    {
        public string productName { get; set; }
        public int axisX_min { get; set; }
        public int axisX_max { get; set; }
        public int axisY_min { get; set; }
        public int axisY_max { get; set; }

        public void GenerateGraph(string content_of_file)
        {
            bool containsInt = content_of_file.Any(char.IsDigit);
            if(containsInt==true)
            {
                Regex rx = new Regex(@"[""]");
                MatchCollection match = rx.Matches(content_of_file);
                string zwrot = match;

            }
        }

    }
}
