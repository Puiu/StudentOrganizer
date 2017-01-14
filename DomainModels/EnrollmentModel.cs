﻿using System;

namespace DomainModels
{
    public class EnrollmentModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        public int ClassId { get; set; }

        public DateTime AddedDate { get; set; }

    }
}
