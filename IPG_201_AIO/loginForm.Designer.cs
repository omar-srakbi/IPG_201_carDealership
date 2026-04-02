namespace carDealershipProject
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NIPcoverForThirdLine = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.carDealershipDBDataSet = new carDealershipProject.datasets.carDealershipDBDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.loginTableAdapter();
            this.tableAdapterManager = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NIPcoverForThirdLine
            // 
            this.NIPcoverForThirdLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NIPcoverForThirdLine.AutoSize = true;
            this.NIPcoverForThirdLine.BackColor = System.Drawing.Color.White;
            this.NIPcoverForThirdLine.Location = new System.Drawing.Point(19, 206);
            this.NIPcoverForThirdLine.Name = "NIPcoverForThirdLine";
            this.NIPcoverForThirdLine.Size = new System.Drawing.Size(468, 17);
            this.NIPcoverForThirdLine.TabIndex = 15;
            this.NIPcoverForThirdLine.Text = "                                                                                 " +
    "                                  ";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitButton.Location = new System.Drawing.Point(934, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "x";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(179, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(170, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "اسم المستخدم";
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.passwordInput.Location = new System.Drawing.Point(50, 365);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(366, 24);
            this.passwordInput.TabIndex = 11;
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.usernameInput.Location = new System.Drawing.Point(50, 278);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(366, 24);
            this.usernameInput.TabIndex = 10;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.Transparent;
            this.signupButton.BackgroundImage = global::carDealershipProject.Properties.Resources.square_2;
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupButton.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.signupButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signupButton.Location = new System.Drawing.Point(66, 440);
            this.signupButton.Name = "signupButton";
            this.signupButton.Padding = new System.Windows.Forms.Padding(1);
            this.signupButton.Size = new System.Drawing.Size(150, 50);
            this.signupButton.TabIndex = 13;
            this.signupButton.Text = "مستخدم جديد";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.Location = new System.Drawing.Point(241, 440);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(1);
            this.loginButton.Size = new System.Drawing.Size(150, 50);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "تسجيل الدخول";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("PNU Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(654, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 59);
            this.label4.TabIndex = 22;
            this.label4.Text = "تسجيل الدخول";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carDealershipDBDataSet
            // 
            this.carDealershipDBDataSet.DataSetName = "carDealershipDBDataSet";
            this.carDealershipDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.carDealershipDBDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carsForRentTableAdapter = null;
            this.tableAdapterManager.carsForSaleTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.UpdateOrder = carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::carDealershipProject.Properties.Resources.loginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NIPcoverForThirdLine);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIPcoverForThirdLine;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label4;
        private datasets.carDealershipDBDataSet carDealershipDBDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private datasets.carDealershipDBDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

