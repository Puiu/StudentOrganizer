using System;

namespace DomainModels
{
    public class ClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime AddedDate { get; set; }

        public bool IsActive { get; set; }

    }
}
