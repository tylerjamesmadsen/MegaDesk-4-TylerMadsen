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

        private static void ReadFileIntoDataGridView()
        {
            
            
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            string quotesFile = @"quotes.txt";
            StreamReader reader = new StreamReader(quotesFile);
            try
            {
                string quotesFileLine = reader.ReadLine();
                do
                {
                    string[] quotesFileLineValues = quotesFileLine.Split(',');
                    //foreach (string value in quotesFileLineValues)
                    viewAllQuotesDataGridView.Rows.Add();
                    for (var i = 0; i < quotesFileLineValues.Length; i++)
                    {
                        viewAllQuotesDataGridView.Rows[i].Cells[i].Value = quotesFileLineValues[i];
                    }
                } while (true);
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
