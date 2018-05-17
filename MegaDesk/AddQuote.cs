using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.DesktopSurfaceMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopSurfaceMaterial))
                            .Cast<Desk.DesktopSurfaceMaterial>()
                            .ToList();

            surfaceMaterialSelectionComboBox.DataSource = materials;

            shippingSelectionComboBox.DataSource = DeskQuote.SHIPPING_SPEEDS;
        }

        private void CancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk
            {
                Width = (int)widthNumericUpDown.Value,
                Depth = (int)depthNumericUpDown.Value,
                NumberOfDrawers = (int)numberOfDrawersNumericUpDown.Value,
                SurfaceMaterial = Desk.DesktopSurfaceMaterial.Laminate // TODO:

            };

            DeskQuote deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = customerNameTextBox.Text,
                ShippingSpeed = DeskQuote.ShippingSpeedChoice.Rush5Days, // TODO

                QuoteDate = DateTime.Now
            };

            totalPriceAmountLabel.Text = $"${deskQuote.CalculateQuote()}";
            shippingPriceLabel.Text = $"${deskQuote.GetShippingPrice()}";

            /* TODO: write to file */
            // if file exists

            // append to file

            // otherwise create and write to new file

            DisplayQuote();
        }

        private void DisplayQuote()
        {
            // disable input fields
            customerNameTextBox.Enabled = false;
            widthNumericUpDown.Enabled = false;
            depthNumericUpDown.Enabled = false;
            numberOfDrawersNumericUpDown.Enabled = false;
            surfaceMaterialSelectionComboBox.Enabled = false;
            shippingSelectionComboBox.Enabled = false;

            // display price
            totalPriceLabel.Visible = true;
            totalPriceAmountLabel.Visible = true;

            // hide get quote button
            getQuoteButton.Visible = false;

            // change text of cancel button to "Main Menu"
            cancelQuoteButton.Text = "Main Menu";
        }
    }
}
