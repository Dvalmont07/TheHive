namespace TheHive.Classes
{
    public class Worker
    {
        private string[] _jobsICandDo;
        private int _shiftsToWork;
        private int _shiftsWorked;
        public string CurrentJOb { get; set; }
        public int ShiftsLeft { get; set; }

        public void DoThisJob(){        }
        public void WorkOneShift() { }
    }
}
