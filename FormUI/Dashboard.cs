using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class SQLDataAccessDemo : Form
    {
        List<Person> people = new List<Person>();
        public SQLDataAccessDemo()
        {
            InitializeComponent();

            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

          people = db.GetPeople(lastNameText.Text);
        }

        private void SQLDataAccessDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
