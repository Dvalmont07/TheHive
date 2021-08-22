using System.Collections.Generic;
using System.Windows.Forms;
using TheHive.Classes;

namespace TheHive
{
    public partial class Hive : Form
    {
        public Hive()
        {
            InitializeComponent();

            IEnumerable<WorkerTask> tasks = new List<WorkerTask>
            {
                new WorkerTask{Name = JobTypes.CollectHoney, ShiftsRequired = 2},
                new WorkerTask{Name = JobTypes.ProduceHoney , ShiftsRequired = 2},
                new WorkerTask{Name = JobTypes.TakeCareEggs, ShiftsRequired = 3},
                new WorkerTask{Name = JobTypes.TeachBabyBees, ShiftsRequired = 5},
                new WorkerTask{Name = JobTypes.MaintainHive, ShiftsRequired = 3},
                new WorkerTask{Name = JobTypes.Patrol, ShiftsRequired = 2},
            };

            this.tasks.DataSource = tasks;
            this.tasks.DisplayMember = "Name";
            this.tasks.ValueMember = "Id";
        }

    }
}
