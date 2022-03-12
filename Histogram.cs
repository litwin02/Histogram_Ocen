using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Histogram_Ocen
{
    public class Histogram
    {
        public Histogram(string file_string)
        {
            fileContent = file_string;
        }
        public string fileContent { get; set; }
        public string productName { get; set; }
        public int axisX_min { get; set; }
        public int axisX_max { get; set; }
        public int axisY_min { get; set; }
        public int axisY_max { get; set; }
        public ArrayList Marks { get; set; }

        public int ParsingStringToInt(string data)
        {
            int result = 0;
            int.TryParse(data, out result);
            return result;
        }
        public void GenerateHistogram()
        {
            Marks = new ArrayList();
            string reg_pattern_for_numbers= @"\d+";
            bool containsInt = fileContent.Any(char.IsDigit);
            if(containsInt==true)
            {
                Regex regex = new Regex(reg_pattern_for_numbers);
                foreach(Match match in regex.Matches(fileContent))
                {
                    Marks.Add(ParsingStringToInt(match.Value));
                }
                
            }
        }

    }
}
