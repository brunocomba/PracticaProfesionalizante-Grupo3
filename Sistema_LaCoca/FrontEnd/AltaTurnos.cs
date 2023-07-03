using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class AltaTurnos : Form
    {
        public AltaTurnos()
        {
            InitializeComponent();
        }

        private void AltaTurnos_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh':'mm'";

            DateTime maxDateTime = DateTime.Today.AddHours(24);
            dateTimePicker1.MaxDate = maxDateTime;
        }
    }
}
