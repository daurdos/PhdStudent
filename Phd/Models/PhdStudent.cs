using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Phd.Models
{
    public class PhdStudent
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public string MajName { get; set; }
        public string DisNameKaz { get; set; }
        public string DisNameRus { get; set; }
        public string DisNameEng { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string MajorCode { get; set; }
        public ICollection<Vote> Vote { get; set; }

    }
}
