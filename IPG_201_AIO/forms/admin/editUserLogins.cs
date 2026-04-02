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
    public partial class editUserLogins : Form
    {
        public editUserLogins()
        {
            InitializeComponent();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDealershipDBDataSet);

        }

        private void editUserLogins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealershipDBDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.carDealershipDBDataSet.login);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
