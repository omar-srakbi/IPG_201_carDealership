namespace carDealershipProject.forms.admin
{
    partial class adminMainForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.showUsers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forSell = new System.Windows.Forms.Label();
            this.forSellCars = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForLease = new System.Windows.Forms.Label();
            this.forLeaseCars = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.showUsers);
            this.panel5.Location = new System.Drawing.Point(332, 487);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 216);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "بيانات المستخدمين";
            // 
            // showUsers
            // 
            this.showUsers.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.showUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showUsers.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsers.ForeColor = System.Drawing.Color.White;
            this.showUsers.Location = new System.Drawing.Point(62, 106);
            this.showUsers.Name = "showUsers";
            this.showUsers.Size = new System.Drawing.Size(147, 57);
            this.showUsers.TabIndex = 0;
            this.showUsers.Text = "عرض المستخدمين";
            this.showUsers.UseVisualStyleBackColor = true;
            this.showUsers.Click += new System.EventHandler(this.showUsers_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.forSell);
            this.panel2.Controls.Add(this.forSellCars);
            this.panel2.Location = new System.Drawing.Point(652, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 213);
            this.panel2.TabIndex = 8;
            // 
            // forSell
            // 
            this.forSell.AutoSize = true;
            this.forSell.BackColor = System.Drawing.Color.Transparent;
            this.forSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forSell.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Bold);
            this.forSell.ForeColor = System.Drawing.Color.Black;
            this.forSell.Location = new System.Drawing.Point(56, 28);
            this.forSell.Name = "forSell";
            this.forSell.Size = new System.Drawing.Size(166, 61);
            this.forSell.TabIndex = 2;
            this.forSell.Text = "سيارات للبيع";
            // 
            // forSellCars
            // 
            this.forSellCars.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.forSellCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forSellCars.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forSellCars.ForeColor = System.Drawing.Color.White;
            this.forSellCars.Location = new System.Drawing.Point(68, 111);
            this.forSellCars.Name = "forSellCars";
            this.forSellCars.Size = new System.Drawing.Size(147, 57);
            this.forSellCars.TabIndex = 0;
            this.forSellCars.Text = "عرض وتعديل";
            this.forSellCars.UseVisualStyleBackColor = true;
            this.forSellCars.Click += new System.EventHandler(this.forSellCars_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ForLease);
            this.panel1.Controls.Add(this.forLeaseCars);
            this.panel1.Location = new System.Drawing.Point(12, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 211);
            this.panel1.TabIndex = 7;
            // 
            // ForLease
            // 
            this.ForLease.AutoSize = true;
            this.ForLease.BackColor = System.Drawing.Color.Transparent;
            this.ForLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForLease.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Bold);
            this.ForLease.ForeColor = System.Drawing.Color.Black;
            this.ForLease.Location = new System.Drawing.Point(38, 27);
            this.ForLease.Name = "ForLease";
            this.ForLease.Size = new System.Drawing.Size(183, 61);
            this.ForLease.TabIndex = 2;
            this.ForLease.Text = "سيارات للإيجار";
            // 
            // forLeaseCars
            // 
            this.forLeaseCars.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.forLeaseCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forLeaseCars.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLeaseCars.ForeColor = System.Drawing.Color.White;
            this.forLeaseCars.Location = new System.Drawing.Point(54, 106);
            this.forLeaseCars.Name = "forLeaseCars";
            this.forLeaseCars.Size = new System.Drawing.Size(147, 57);
            this.forLeaseCars.TabIndex = 0;
            this.forLeaseCars.Text = "عرض وتعديل";
            this.forLeaseCars.UseVisualStyleBackColor = true;
            this.forLeaseCars.Click += new System.EventHandler(this.forLeaseCars_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitButton.Location = new System.Drawing.Point(897, 35);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "x";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // adminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(171)))), ((int)(((byte)(210)))));
            this.BackgroundImage = global::carDealershipProject.Properties.Resources.adminCPBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 710);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم المدير";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label forSell;
        private System.Windows.Forms.Button forSellCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ForLease;
        private System.Windows.Forms.Button forLeaseCars;
        private System.Windows.Forms.Button exitButton;
    }
}