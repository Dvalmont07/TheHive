using System;

namespace TheHive.Classes
{
    public class Job
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int ShiftsRequired { get; set; }
    }

}
