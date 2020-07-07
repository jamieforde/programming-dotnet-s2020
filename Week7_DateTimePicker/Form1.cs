using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_DateTimePicker
{


    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void dropOffDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dropOffDateTimePicker.Value;

            switch (dropOffDate.DayOfWeek)
            {
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
                    break;
                default:
                    outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
                    break;
            }
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            dropOffDateTimePicker.MinDate = DateTime.Today;

            dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}
