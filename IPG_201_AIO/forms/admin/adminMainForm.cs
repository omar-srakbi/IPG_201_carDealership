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
    public partial class adminMainForm : Form
    {
        public adminMainForm()
        {
            InitializeComponent();
        }

        private void showUsers_Click(object sender, EventArgs e)
        {
            new editUserLogins().Show();
        }

        private void forSellCars_Click(object sender, EventArgs e)
        {
            new editForSaleCars().Show();
        }

        private void forLeaseCars_Click(object sender, EventArgs e)
        {
            new editForLeaseCars().Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
