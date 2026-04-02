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
    public partial class editForSaleCars : Form
    {
        public editForSaleCars()
        {
            InitializeComponent();
        }

        private void carsForSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carsForSaleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.carDealershipDBDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(":محاولة بائسة اتصل بمدير النظام, رمز العطل" + " \n" + err.Message);
            }
        }

        private void editForSaleCars_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'carDealershipDBDataSet.carsForSale' table. You can move, or remove it, as needed.
            this.carsForSaleTableAdapter.Fill(this.carDealershipDBDataSet.carsForSale);

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

        private void updateCarCP_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnCarOwnersipCPFD = new OpenFileDialog();
            opnCarOwnersipCPFD.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnCarOwnersipCPFD.ShowDialog() == DialogResult.OK)
            {
                ownershipCPPictureBox.Image = new Bitmap(opnCarOwnersipCPFD.FileName);
            }  
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carsForSaleBindingSource.EndEdit();
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
    }
}
