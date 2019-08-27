using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phd.Models
{
    public class DisCouncil
    {
        public int Id { get; set; }
        [Display(Name = "Номер приказа")]
        public string OrderNumber { get; set; }
        [Display(Name = "Председатель")]
        public string CouncilChairman { get; set; }
        [Display(Name = "Секретарь")]
        public string CouncilSecretary { get; set; }
        [Display(Name = "Члены совета")]
        public string CouncilMember { get; set; }
        [Display(Name = "Дата защиты")]
        public DateTime DefenceDate { get; set; }

        public ICollection<User> User { get; set; }
        public ICollection<PhdStudent> PhdStudent {get; set; }
        


    }
}
