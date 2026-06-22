using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMang.Presntaiton.Dilg
{
    public partial class dilo : Form
    {
        string state = "";
        string subject = "";
        public dilo(string state, string subject)
        {
            InitializeComponent();
            this.state = state;
            this.subject = subject;
            label1.Text = $"{subject} {state} Successfully";
        }

        private void dilo_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
