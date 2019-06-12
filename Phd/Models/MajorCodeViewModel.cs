using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Phd.Models
{
    public class MajorCodeViewModel
    {
        public List<PhdStudent> PhdStudents { get; set; }
        public SelectList Codes { get; set; }
        public string MajorCode { get; set; }
        public string SearchString { get; set; }
    }
}
