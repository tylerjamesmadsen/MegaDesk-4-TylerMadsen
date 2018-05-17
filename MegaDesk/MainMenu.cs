using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openAddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void openViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewAllQuotesForm = new ViewAllQuotes();
            addViewAllQuotesForm.Tag = this;
            addViewAllQuotesForm.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e) => Close();
    }
}
