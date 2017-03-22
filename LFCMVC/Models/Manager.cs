using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string Image { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        [Display(Name = "Years")]
        public string Period { get; set; }
        public virtual ICollection<Honour> Honours { get; set; }
       

    }
}