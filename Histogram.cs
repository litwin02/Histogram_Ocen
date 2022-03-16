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
        public string ProductName { get; set; }
        public List<int> Marks { get; set; }
        public List<ReviewElement> Reviews { get; set; }
        public int ParsingStringToInt(string data)
        {
            int result = 0;
            int.TryParse(data, out result);
            return result;
        }
        public void GenerateHistogram()
        {
            Marks = new List<int>();
            SearchForNumbers(Marks)           
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
            if (Marks.Any() == true)
            {
                Reviews = new List<ReviewElement>();
                
                for (int i = 0; i < Marks.Count; i++)
                {
                    Reviews.Add(new ReviewElement(Marks[i], 0));
                    for (int j = 0; j < Marks.Count; j++)
                    {                       
                        if (Reviews[i].ReviewStar == Marks[j])
                        {
                            Reviews[i].Occurance++;
                        }
                       
                    }
                }
            }
        }
    }
}
