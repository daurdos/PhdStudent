using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Phd.Models
{
    public class PhdStudent
    {

        public int Id { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Display(Name = "Шифр специальности")]
        public string MajorCode { get; set; }

        [Display(Name = "Специальность")]
        public string MajorName { get; set; }

        [Display(Name = "Название диссертации")]
        public string ThesisNameRus { get; set; }

        [Display(Name = "Дата диссертационного совета")]
        [DataType(DataType.Date)]
        public DateTime ThesisComDate { get; set; }

        [Display(Name = "Всего членов совета")]
        public int ComMemberNumberTotal { get; set; }

        [Display(Name = "Членов совета по специальности")]
        public int ComMemberNumberSpecific { get; set; }

        [Display(Name = "Направление подготовки кадров")]
        public string EducationDirection { get; set; }



        public ICollection<Vote> Vote { get; set; } // one PhdStudent - many Votes



        public int MajorId { get; set; } // many PhdStudents - one Major

        public Major Major { get; set; } // many PhdStudents - one Major



        public int TrainingDirectionId { get; set; } // many PhdStudents - one TrainingDirection

        public TrainingDirection TrainingDirection { get; set; } // many PhdStudents - one TrainingDirection


        
        public int DisCouncilId { get; set; } // many PhdStudents - one Dissertation Council

        public DisCouncil DisCouncil { get; set; } // many PhdStudents - one Dissertation Council

    



    }
}
