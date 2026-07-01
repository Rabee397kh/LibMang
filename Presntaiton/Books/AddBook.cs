using LibMang.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMang.Presntaiton.Books
{
    
    public partial class AddBook : Form
    {
        string imgpath;
        public AddBook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(this);
            _fillCombo();
        }

        private void _fillCombo()
        {
            ClsCategory category = new ClsCategory();
            categoryCombo.DataSource = category.load();

            categoryCombo.DisplayMember = "name"; 
            categoryCombo.ValueMember = "id";
        }

        private void addCoverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgpath = fileDialog.FileName;
                pictureBox1.ImageLocation = imgpath;
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if(bookNameTxt.Text == "" )
            {
                MessageBox.Show("Fill Book Name Fileds!");
                return;
            }

            string name = bookNameTxt.Text;
            string author = authorTxt.Text;
            int categoryid = (int)categoryCombo.SelectedValue;
            decimal price = bookPriceNu.Value;
            DateTime dt = bunifuDatepicker1.Value;
            string rating = bookRating.Value.ToString();
            string newImg = "";
            if (imgpath != null)
            {
               newImg = $"{Environment.CurrentDirectory}\\images\\covers\\{name+author+rating}.png";
               File.Copy(imgpath, newImg);
            }

            ClsBook book = new ClsBook();
            book.AddBook(name, categoryid, price, author, dt, rating, newImg);
            MessageBox.Show("Book Added Successfully!");
        }
    }
}
