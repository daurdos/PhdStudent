using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phd.Models
{
    public class DisCouncil
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string CouncilChairman { get; set; }
        public string CouncilSecretary { get; set; }
        public string CouncilMember { get; set; }
        public DateTime DefenceDate { get; set; }

        public ICollection<User> User { get; set; }
        public ICollection<PhdStudent> PhdStudent {get; set; }
        


    }
}
