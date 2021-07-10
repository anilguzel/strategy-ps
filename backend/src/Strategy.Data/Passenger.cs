using Strategy.Core;
using System;

namespace Strategy.Data
{
    public class Passenger
    {
        public Guid UniquePassengerId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Enums.Gender Gender { get; set; }

        public int DocumentNo { get; set; }

        public Enums.DocumentType DocumentType { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.Now;
    }
}
