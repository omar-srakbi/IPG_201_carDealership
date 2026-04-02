namespace carDealershipProject
{
    partial class signupForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.saveNewUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitButton.Location = new System.Drawing.Point(926, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "x";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.backToLoginButton.BackgroundImage = global::carDealershipProject.Properties.Resources.square_2;
            this.backToLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backToLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backToLoginButton.FlatAppearance.BorderSize = 0;
            this.backToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToLoginButton.Font = new System.Drawing.Font("PNU Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.backToLoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backToLoginButton.Location = new System.Drawing.Point(66, 442);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Padding = new System.Windows.Forms.Padding(1);
            this.backToLoginButton.Size = new System.Drawing.Size(150, 50);
            this.backToLoginButton.TabIndex = 17;
            this.backToLoginButton.Text = "عودة";
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // saveNewUserButton
            // 
            this.saveNewUserButton.BackColor = System.Drawing.Color.Transparent;
            this.saveNewUserButton.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.saveNewUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveNewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveNewUserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveNewUserButton.FlatAppearance.BorderSize = 0;
            this.saveNewUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.saveNewUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveNewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveNewUserButton.Font = new System.Drawing.Font("PNU Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saveNewUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveNewUserButton.Location = new System.Drawing.Point(241, 442);
            this.saveNewUserButton.Name = "saveNewUserButton";
            this.saveNewUserButton.Padding = new System.Windows.Forms.Padding(1);
            this.saveNewUserButton.Size = new System.Drawing.Size(150, 50);
            this.saveNewUserButton.TabIndex = 16;
            this.saveNewUserButton.Text = "حفظ";
            this.saveNewUserButton.UseVisualStyleBackColor = false;
            this.saveNewUserButton.Click += new System.EventHandler(this.saveNewUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(170, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(179, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("PNU Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(196, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "الايميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("PNU Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(590, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 59);
            this.label4.TabIndex = 21;
            this.label4.Text = "تسجيل مستخدم جديد";
            // 
            // emailInput
            // 
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(48, 174);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(366, 38);
            this.emailInput.TabIndex = 32;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(48, 358);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(366, 38);
            this.passwordInput.TabIndex = 31;
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Sakkal Majalla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(48, 270);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(366, 38);
            this.usernameInput.TabIndex = 30;
            // 
            // signupForm
            // 
            this.AcceptButton = this.saveNewUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::carDealershipProject.Properties.Resources.loginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.backToLoginButton;
            this.ClientSize = new System.Drawing.Size(973, 613);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.saveNewUserButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.Button saveNewUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
    }
}