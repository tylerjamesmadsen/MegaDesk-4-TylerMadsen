using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            ReadQuotesFile();
        }

        private void ReadQuotesFile()
        {
            const string quotesFile = @"quotes.txt";
            StreamReader reader = new StreamReader(quotesFile);
            try
            {
                bool insertRow = true;
                for (var row = 0; !reader.EndOfStream; row++)
                {
                    if (insertRow == false && row != 0)
                    {
                        row--;
                    }
                    else
                    {
                        viewAllQuotesDataGridView.Rows.Add();
                    }

                    string quotesFileLine = reader.ReadLine();
                    if (quotesFileLine == null)
                    {
                        continue;
                    }

                    string[] quotesFileLineValues = quotesFileLine.Split(',');

                    if (surfaceMaterialSelectionComboBox.Text == "" ||
                        surfaceMaterialSelectionComboBox.Text == @"*All Materials*")
                    {
                        for (var col = 0; col < quotesFileLineValues.Length; col++)
                        {
                            viewAllQuotesDataGridView.Rows[row].Cells[col].Value = quotesFileLineValues[col];
                        }

                        insertRow = true;
                    }
                    else if (quotesFileLineValues.Contains(surfaceMaterialSelectionComboBox.Text))
                    {
                        for (var col = 0; col < quotesFileLineValues.Length; col++)
                        {
                            viewAllQuotesDataGridView.Rows[row].Cells[col].Value = quotesFileLineValues[col];
                        }

                        insertRow = true;
                    }
                    else
                    {
                        insertRow = false;
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

        private void exitViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void surfaceMaterialSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAllQuotesDataGridView.Rows.Clear();
            ReadQuotesFile();
        }
    }
}
