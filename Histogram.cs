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
            FileContent = file_string;
        }
        public string FileContent { get; set; }
        public int[] Review { get; set; }
        public int[] Occuarance { get; set; }
        public int AxisX_min { get; set; }
        public int AxisX_max { get; set; }
        public int Freq { get; set; }
        public List<int> Marks { get; set; }
        public int ParsingStringToInt(string data)
        {
            int result = 0;
            int.TryParse(data, out result);
            return result;
        }
        public void GenerateHistogram()
        {
            Marks = new List<int>();
            SearchForNumbers(Marks);
            CreateListOfReviews();
        }
        public void SearchForNumbers(List<int> list)
        {
            string reg_pattern_for_numbers = @"\d+";
            bool containsInt = FileContent.Any(char.IsDigit);
            if (containsInt == true)
            {
                Regex regex = new Regex(reg_pattern_for_numbers);
                foreach (Match match in regex.Matches(FileContent))
                {
                    list.Add(ParsingStringToInt(match.Value));
                }
            }
        }

        public void CreateListOfReviews()
        { 
            AxisX_min = Marks.Min();
            AxisX_max = Marks.Max();
            Freq = AxisX_max-AxisX_min+1;
            Review = Marks.ToArray();
            Occuarance = new int[Freq];
            for(int i=0; i<Review.Length; i++)
            {
                int index = Review[i] - AxisX_min;
                Occuarance[index]++;
            }
        }
    }
}
