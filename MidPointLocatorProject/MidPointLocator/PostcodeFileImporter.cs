using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace MidPointLocator
{
    public class PostcodeFileImporter
    {
        private readonly string filePath;

        public PostcodeFileImporter(string filePath)
        {
            this.filePath = filePath;
        }

        public List<string> GetPostcodes()
        {
            string[] lines = File.ReadAllLines(filePath);
            var validPostcodes = GetValidPostcodes(lines);

            return validPostcodes;
        }

        private List<string> GetValidPostcodes(string[] postcodes)
        {
            var result = new List<string>();
            foreach (var postcode in postcodes)
            {
                if (IsValidPostcode(postcode))
                {
                    result.Add(postcode);
                }
            }

            return result;
        }

        private bool IsValidPostcode(string postcode)
        {
            string pattern = "([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|" +
            "(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|" +
            "([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\\s?[0-9][A-Za-z]{2})";
            Match match = Regex.Match(postcode, pattern, RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
