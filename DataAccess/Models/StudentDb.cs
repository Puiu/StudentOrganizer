using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public class StudentDb
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddedDate { get; set; }

        public virtual IEnumerable<EnrollmentDb> Enrollments { get; set; }
    }
}
