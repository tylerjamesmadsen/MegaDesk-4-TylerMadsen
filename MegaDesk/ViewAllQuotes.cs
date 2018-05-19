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

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

        }

        private void exitViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            string quotesFile = @"quotes.txt";
            StreamReader reader = new StreamReader(quotesFile);
            try
            {
                for (var row = 0; !reader.EndOfStream ; row++)
                {
                    viewAllQuotesDataGridView.Rows.Add();
                    string quotesFileLine = reader.ReadLine();
                    string[] quotesFileLineValues = quotesFileLine.Split(',');
                    for (var col = 0; col < quotesFileLineValues.Length; col++)
                    {
                        viewAllQuotesDataGridView.Rows[row].Cells[col].Value = quotesFileLineValues[col];
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
