using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture08
{
    public class FileInfo
    {
        public int YearOfRelease { get; set; }
        public int LengthinMinutes { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public string Director { get; set; }
        public int Popularity { get; set; }
        public bool AwardWon { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Popularity: {Popularity}, Awarded: {AwardWon}";
        }
    }
}
