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
    public partial class ForLeaseCars : Form
    {
        public ForLeaseCars()
        {
            InitializeComponent();
        }



        private void editForLeaseCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.whoRent' table. You can move, or remove it, as needed.
            this.canRentTAdapter.Fill(this.carDealershipDBDataSet.whoRent);
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.canBeRented' table. You can move, or remove it, as needed.
            this.canBeRentedTableAdapter.Fill(this.carDealershipDBDataSet.canBeRented);
        }




        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bookUpCar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("حجز سيارة", "هل انت متأكد أنك تريد حجز هذه السيارة", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime currentDate = DateTime.Now;
                infoTextBox.Text = infoTextBox.Text + "car has been bookedup for rent by: ";
                bookedUpDateDateTimePicker.Value = currentDate;
                MessageBox.Show("تم حجز السيارة بنجاح");
            }
            else if (dialogResult == DialogResult.No)
            {
            }

        }



        
    }
}
