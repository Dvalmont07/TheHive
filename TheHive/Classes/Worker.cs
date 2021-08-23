using System.Collections.Generic;

namespace TheHive.Classes
{
    public class Worker
    {

        private int _shiftsToWork;
        private int _shiftsWorked;
        public string CurrentJob { get; set; }
        public int ShiftsLeft { get; set; }
        public List<string> JobsICandDo;

        public MessageResult DoThisJob(string job, int shifts)
        {
                 if (!JobsICandDo.Contains(job))
            {
                return new MessageResult { BoolResponse = false, StringResponse = "can't do this job" };
            }
            else if (ShiftsLeft > 0)
            {
                return new MessageResult { BoolResponse = false, StringResponse = "is doing a assined job" };
            }
            else
            {
                CurrentJob = job;
                ShiftsLeft = shifts;
                return new MessageResult { BoolResponse = true, StringResponse = "has a new job was assigned" };
            }
        }
        public void WorkOneShift()
        {
            ShiftsLeft--;

            if (ShiftsLeft == 0)
            {
                CurrentJob = string.Empty;
            }
        }
    }
}
