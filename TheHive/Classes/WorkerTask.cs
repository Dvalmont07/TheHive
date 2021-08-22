using System;

namespace TheHive.Classes
{
    public class WorkerTask
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int ShiftsRequired { get; set; }
    }

}
