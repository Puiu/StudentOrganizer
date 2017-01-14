using System;

namespace DomainModels
{
    public class StudentModel
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddedDate { get; set; }

    }
}
