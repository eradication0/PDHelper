using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PD_Helper
{
    //Class for PDCard
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<PDCard>>(myJsonResponse);
    public class PDCard : IComparable
    {
        // Comparator(s)
        private class SortTypeHelper : IComparer<PDCard>
        {
            int IComparer<PDCard>.Compare(PDCard a, PDCard b)
            {
                int typeIntA = a.typeToInt();
                int typeIntB = b.typeToInt();

                if (typeIntA > typeIntB) return 1;
                else if (typeIntA < typeIntB) return -1;
                else return string.Compare(a.HEX, b.HEX);
            }
        }

        // Default Comparison
        int IComparable.CompareTo(object? obj)
        {
            PDCard card = (PDCard)obj;
            return string.Compare(this.HEX, card.HEX);
        }

        // Return Comparators
        public static IComparer<PDCard> SortType()
        {
            return new SortTypeHelper();
        }

        // Type to int for the purpose of ordering
        public int typeToInt()
        {
            switch (TYPE)
            {
                case "Attack":
                    return 0;
                case "Defense":
                    return 1;
                case "Erase":
                    return 2;
                case "Status":
                    return 3;
                case "Special":
                    return 4;
                case "Environment":
                    return 5;
                default:
                    return 6;
            }
        }

        // JSON Properties
        [JsonProperty("NAME")]
        public string NAME { get; set; }
        [JsonProperty("ID")]
        public int? ID { get; set; }
        [JsonProperty("SCHOOL")]
        public string SCHOOL { get; set; }
        [JsonProperty("DAMAGE")]
        public string DAMAGE { get; set; }
        [JsonProperty("COST")]
        public string COST { get; set; }
        [JsonProperty("USAGE")]
        public string USAGE { get; set; }
        [JsonProperty("RANGE")]
        public string RANGE { get; set; }
        [JsonProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
        [JsonProperty("TYPE")]
        public string TYPE { get; set; }
        [JsonProperty("HEX")]
        public string HEX { get; set; }
    }
}
