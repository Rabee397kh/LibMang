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
       
        public AddCategory()
        {
            InitializeComponent();
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
            cate.addCategory(categoryNameTxt.Text);
            //MessageBox.Show("category added succesfully");
            dilo dil = new dilo("added", "Category");
            dil.Show();
            
        }
    }
}
