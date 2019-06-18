using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Phd.Models
{
    public class PhdStudent
    {
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string Fname { get; set; }

        [Display(Name = "Фамилия")]
        public string Lname { get; set; }

        [Display(Name = "Отчество")]
        public string Mname { get; set; }

        [Display(Name = "Специальность")]
        public string MajName { get; set; }

        [Display(Name = "Диссертация на каз.яз")]
        public string DisNameKaz { get; set; }

        [Display(Name = "Диссертация на русс.яз")]
        public string DisNameRus { get; set; }

        [Display(Name = "Диссертация на англ.яз")]
        public string DisNameEng { get; set; }

        [Display(Name = "Дата защиты")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Шифр специальности")]
        public string MajorCode { get; set; }
        public ICollection<Vote> Vote { get; set; }

    }
}
