using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TheHive.Classes;

namespace TheHive
{
    public partial class Hive : Form
    {
        private List<Worker> _workers;
        Queen queen;

        public Hive()
        {
            InitializeComponent();

            IEnumerable<Job> tasks = InitJobs();

            this.cmbxTasks.DataSource = tasks;
            this.cmbxTasks.DisplayMember = "Name";
            this.cmbxTasks.ValueMember = "Id";
            this.cmbxShifts.SelectedIndex = 0;
            this.btnNextShift.Enabled = false;

            InitEntities();
        }

        private void InitEntities()
        {
            _workers = new List<Worker>
            {
                new Worker{ JobsICandDo = new List<string>{
                    JobTypes.CollectHoney,
                    JobTypes.ProduceHoney,
                    JobTypes.TakeCareEggs
                }},
                new Worker{ JobsICandDo = new List<string>{
                    JobTypes.CollectHoney,
                    JobTypes.ProduceHoney,
                    JobTypes.TeachBabyBees
                }},
                new Worker{ JobsICandDo = new List<string>{
                    JobTypes.CollectHoney,
                    JobTypes.ProduceHoney,
                    JobTypes.MaintainHive,
                    JobTypes.Patrol
                }},

            };
            queen = new Queen(_workers);
        }

        private static IEnumerable<Job> InitJobs()
        {
            return new List<Job>
            {
                new Job{Name = JobTypes.CollectHoney, ShiftsRequired = 2},
                new Job{Name = JobTypes.ProduceHoney , ShiftsRequired = 2},
                new Job{Name = JobTypes.TakeCareEggs, ShiftsRequired = 3},
                new Job{Name = JobTypes.TeachBabyBees, ShiftsRequired = 5},
                new Job{Name = JobTypes.MaintainHive, ShiftsRequired = 3},
                new Job{Name = JobTypes.Patrol, ShiftsRequired = 2},
            };
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            int.TryParse(cmbxShifts.Text, out int shifts);
            if (shifts > 0)
            {
                MessageResult messageResult = queen.AssingWork(cmbxTasks.Text, shifts);
                MessageBox.Show(messageResult.StringResponse);

                if (_workers.Any(w => !string.IsNullOrEmpty(w.CurrentJob)))
                {
                    btnNextShift.Enabled = true;
                }
                else
                {
                    btnNextShift.Enabled = false;
                }

            }


        }

        private void btnNextShift_Click(object sender, EventArgs e)
        {
            queen.ShiftNumber++;
            txtReport.Text += queen.WorkTheNextShift().StringResponse;

            if (!_workers.Any(w => !string.IsNullOrEmpty(w.CurrentJob)))
            {
                btnNextShift.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            InitEntities();
            txtReport.Text = string.Empty;
            queen.ShiftNumber = 0;
            btnNextShift.Enabled = false;
        }
    }
}
