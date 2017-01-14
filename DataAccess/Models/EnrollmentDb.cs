using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class EnrollmentDb
    {
        [Key]
        public int Id { get; set; }
       
        public DateTime AddedDate { get; set; }

        public int ClassId { get; set; }

        public int StudentId { get; set; }

        public virtual ClassDb Class { get; set; }

        public virtual StudentDb Student { get; set; }


    }
}
