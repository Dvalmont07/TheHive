using System;
using System.Collections.Generic;
using System.Text;

namespace TheHive.Classes
{
    public class Queen
    {
        private List<Worker> _workers;
        public int ShiftNumber { get; set; }
        public Queen(List<Worker> workers)
        {
            _workers = workers;
        }

        public MessageResult AssingWork(string job, int shifts)
        {
            MessageResult messageResult = new MessageResult { BoolResponse = false };

            for (var i = 0; i < _workers.Count; i++)
            {
                if (string.IsNullOrEmpty(_workers[i].CurrentJob))
                {
                    messageResult.StringResponse += $"\n Worker {i + 1} {_workers[i].DoThisJob(job, shifts).StringResponse}";
                }
                else
                {
                    messageResult.StringResponse += $"\n The worker {i + 1} is currently assigned to another job";
                }
            }

            return messageResult;

        }
        public MessageResult WorkTheNextShift()
        {
            StringBuilder result = new StringBuilder();
            _ = result.AppendLine($"Report shift {ShiftNumber}");

            for (var i = 0; i < _workers.Count; i++)
            {
                if (!string.IsNullOrEmpty(_workers[i].CurrentJob))
                {
                    _workers[i].WorkOneShift();

                    if (_workers[i].ShiftsLeft > 0)
                    {
                        _ = result.AppendLine($" --The Worker {i + 1} will do {_workers[i].CurrentJob} for more {_workers[i].ShiftsLeft} turns");
                    }
                    else
                    {
                        _ = result.AppendLine($" --The Worker {i + 1} finished the job");
                    }
                }
            }

            return new MessageResult { StringResponse = result.ToString() };

        }
    }
}
