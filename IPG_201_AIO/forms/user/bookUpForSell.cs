using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carDealershipProject.forms.user
{
    public partial class bookUpForSell : Form
    {
        public bookUpForSell()
        {
            InitializeComponent();
        }



        private void bookUpForSell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.canBeSold' table. You can move, or remove it, as needed.
            this.canSellTAdapter.Fill(this.carDealershipDBDataSet.canBeSold);
            
        }

        private void bookUpOk_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd/mm/yyyy");
            infoTextBox.Text = infoTextBox.Text + "car has been bookedup for sale";
            sellingDateDateTimePicker.Text = currentDate;
            isSoldCheckBox.Checked = true;
        }
        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }
}
