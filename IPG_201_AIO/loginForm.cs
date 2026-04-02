using carDealershipProject.datasets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carDealershipProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        carDealershipDBEntities1 dbcontext = new carDealershipDBEntities1();


        private void loginButton_Click(object sender, EventArgs e)
        {

 /*           try
                {
 */               
               if (dbcontext.login.Where(r => r.username == usernameInput.Text
                    && r.password == passwordInput.Text && r.isActive == true && r.isAdmin == true).Count() > 0)
                    {
                    new forms.admin.adminMainForm().Show();
                    this.Hide(); 
                    }
                else if (dbcontext.login.Where(r => r.username == usernameInput.Text
                    && r.password == passwordInput.Text && r.isActive == true && r.isAdmin == false).Count() > 0)
                    {
                        new forms.userMainForm().Show();
                        this.Hide();
                    }
                else if (dbcontext.login.Where(r => r.username == usernameInput.Text
                    && r.password == passwordInput.Text && r.isActive == false).Count() > 0)
                    {
                        MessageBox.Show("تم تعطليل حسابك من قبل الادارة"); 
                    }
                else
                    {
                        MessageBox.Show("شو جايب كلمة السر من سوق الجمعة! دخيل عينك صحصح، تذكر، بعدين حاول مجددا");
                        usernameInput.Text = "";
                        passwordInput.Text = "";
                    }

                    /*
                     * \omar270000\تجريب  الحماية من تعطل البرنامج
                     int upt = Convert.ToInt32 (usernameInput.Text);
                     int ppt = Convert.ToInt32 (passwordInput.Text);
                     int rr = upt / ppt; 
                    MessageBox.Show(rr.ToString());
                    */
                
/*
            }
            catch (Exception err)
            {
                MessageBox.Show(":محاولة بائسة اتصل بمدير النظام, رمز العطل" + " \n" + err.Message);
            }
*/      }

        private void signupButton_Click(object sender, EventArgs e)
        {
            new signupForm().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDealershipDBDataSet);
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
