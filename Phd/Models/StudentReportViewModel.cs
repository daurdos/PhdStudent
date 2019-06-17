using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phd.Models
{
    public class StudentReportViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int PositiveVoteQuantity { get; set; }
        public int NegativeVoteQuantity { get; set; }
        public int OverallVoteQuantity { get; set; }
    }
}
