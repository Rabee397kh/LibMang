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
    public partial class AddCategory : Form
    {
        string state = "";
        int id = 0;
        public AddCategory(string state)
        {
            InitializeComponent();
            this.state = state;
            _changeDetails();
        }
        public AddCategory(string state , int id)
        {
            InitializeComponent();
            this.state = state;
            this.id = id;
            _changeDetails();

        }

        private void _changeDetails()
        {
            if(this.state == "add")
            {
                label1.Text = "Add Category";
                addBtn.Text = "Add";
            }else if(this.state == "edit")
            {
                label1.Text = "Edit Category";
                addBtn.Text = "Edit";
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(categoryNameTxt.Text == "")
            {
                MessageBox.Show("Fill empty field!");
                return;
            }

            ClsCategory cate = new ClsCategory();
            if(state == "add")
            {
                
                cate.addCategory(categoryNameTxt.Text);
                //MessageBox.Show("category added succesfully");
                dilo dil = new dilo("added", "Category");
                dil.Show();
            }else if (state == "edit")
            {
                
                cate.editCategory(categoryNameTxt.Text,id);
                //MessageBox.Show("category added succesfully");
                dilo dil = new dilo("Edited", "Category");
                dil.Show();
            }


        }
    }
}
