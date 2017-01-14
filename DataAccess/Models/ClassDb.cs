using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public class ClassDb
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime AddedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual IEnumerable<EnrollmentDb> Enrollments { get; set; }

    }
}
