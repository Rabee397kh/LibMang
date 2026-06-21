using LibMang.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMang.Presntaiton
{
    public partial class Main : Form
    {
        string state = "";
        int id = 0;
        ClsCategory clsCategory = new ClsCategory();
        public Main()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxiBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void collapseBtn_Click(object sender, EventArgs e)
        {
            if (RightPanel.Width == 171)
            {
                RightPanel.Width = 60;
                userImgBox.Visible = false;
            }
            else
            {
                RightPanel.Width = 171;
                userImgBox.Visible = true;
            }
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            state = "category";
            HomePanel.Visible = false;
            mainPanel.Visible = true;
            topLb.Text = "Category";

            try
            {
                categoryGridView.DataSource = clsCategory.load();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
