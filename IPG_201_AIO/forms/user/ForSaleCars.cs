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
    public partial class ForSaleCars : Form
    {
        public ForSaleCars()
        {
            InitializeComponent();
        }


        private void editForSaleCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.whoBuy' table. You can move, or remove it, as needed.
            this.whoBuyTableAdapter.Fill(this.carDealershipDBDataSet.whoBuy);
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.buyer' table. You can move, or remove it, as needed.
            this.canSellTAdapter.Fill(this.carDealershipDBDataSet.canBeSold);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        

        private void bookupCar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("حجز سيارة", "هل انت متأكد أنك تريد حجز هذه السيارة", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime currentDate = DateTime.Now;
                infoTextBox.Text = infoTextBox.Text + "car has been bookedup for sale by: " ;
                sellingDateDateTimePicker.Value = currentDate;
                isSoldCheckBox.Checked = true;
                MessageBox.Show("تم حجز السيارة بنجاح");
            }
            else if (dialogResult == DialogResult.No)
            {
            }

        }
    }
}
