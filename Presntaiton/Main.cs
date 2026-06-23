using LibMang.Business;
using LibMang.Presntaiton.Dilg;
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
            state = "home";
            HomePanel.Visible = true;
            mainPanel.Visible = false;
            topLb.Text = "Home";
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            string st = "add";
            AddCategory addCategory = new AddCategory(st);
            addCategory.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string st = "add";
            if (state == "category")
            {
                AddCategory addCategory = new AddCategory(st);
                addCategory.Show();
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if(state == "category")
            {
                try
                {
                    categoryGridView.DataSource = clsCategory.load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string st = "edit";
            if(state == "category")
            {
                
                id = (int)categoryGridView.CurrentRow.Cells[0].Value;
                AddCategory addCategory = new AddCategory(st,id);
                addCategory.Show();

               

            }
        }

       
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure?", "Deletion", MessageBoxButtons.YesNo,
            //       MessageBoxIcon.Warning) == DialogResult.No)
            //{

            //    return;

            //}
            if (state == "category")
            {
                id = Convert.ToInt32(categoryGridView.CurrentRow.Cells["id"].Value);
                //MessageBox.Show(categoryGridView.CurrentRow.Cells["id"].Value.ToString());
                clsCategory.deleteCategory(id);
                dilo dil = new dilo("Deleted",state);
                dil.Show();
            }
        }
    }
}
