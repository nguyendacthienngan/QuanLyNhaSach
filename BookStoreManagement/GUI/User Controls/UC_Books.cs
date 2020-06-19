using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms;

namespace GUI.User_Controls
{
    public partial class UC_Books : UserControl
    {
        public UC_Books()
        {
            InitializeComponent();
            flowPanelDisplay.AutoScroll = true;
        }

        private void CreateNewBook(Image cover, string title, string author, float price)
        {
            var book = new UC_BookDisplay();
            book.Cover = cover;
            book.BookTitle = title;
            book.Author = author;
            book.Price = price.ToString();
            book.Margin = new Padding(18, 18, 18, 18);
            flowPanelDisplay.Controls.Add(book);
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            using(Form_AddNewBook form = new Form_AddNewBook() )
            {
                form.ShowDialog();
            }
        }
    }
}
