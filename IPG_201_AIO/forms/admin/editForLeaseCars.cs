using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carDealershipProject.forms.admin
{
    public partial class editForLeaseCars : Form
    {
        public editForLeaseCars()
        {
            InitializeComponent();
        }

        private void carsForRentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carsForRentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.carDealershipDBDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(":محاولة بائسة اتصل بمدير النظام, رمز العطل" + " \n" + err.Message);
            } 

        }

        private void editForLeaseCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.carsForRent' table. You can move, or remove it, as needed.
            this.carsForRentTableAdapter.Fill(this.carDealershipDBDataSet.carsForRent);
            // تصحيح شكل منتقي التواريخ
            if (endOfRentDateDateTimePicker.Value > DateTime.Today)
            {
                endOfRentDateDateTimePicker.Format = DateTimePickerFormat.Short;
            }
            else
            {
                endOfRentDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                endOfRentDateDateTimePicker.CustomFormat = "تهتنا";
            }
        }

        private void updateCarPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnCarPhotoFD = new OpenFileDialog();
            opnCarPhotoFD.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnCarPhotoFD.ShowDialog() == DialogResult.OK)
            {
                carPhotoPictureBox.Image = new Bitmap(opnCarPhotoFD.FileName);
            }  
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carsForRentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.carDealershipDBDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(":محاولة بائسة اتصل بمدير النظام, رمز العطل" + " \n" + err.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void endOfRentDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
                // تصحيح شكل منتقي التواريخ
              if (endOfRentDateDateTimePicker.Value > DateTime.Today)
                {
                endOfRentDateDateTimePicker.Format = DateTimePickerFormat.Short;
                }
            else
                {
                endOfRentDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                endOfRentDateDateTimePicker.CustomFormat = "تهتنا";
                }
        }
    }
}
