namespace carDealershipProject.forms
{
    partial class userMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.forSale = new System.Windows.Forms.Label();
            this.forSaleCars = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForLease = new System.Windows.Forms.Label();
            this.forLeaseCars = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.forSale);
            this.panel2.Controls.Add(this.forSaleCars);
            this.panel2.Location = new System.Drawing.Point(515, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 195);
            this.panel2.TabIndex = 6;
            // 
            // forSale
            // 
            this.forSale.AutoSize = true;
            this.forSale.Font = new System.Drawing.Font("Traditional Arabic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forSale.Location = new System.Drawing.Point(67, 12);
            this.forSale.Name = "forSale";
            this.forSale.Size = new System.Drawing.Size(180, 66);
            this.forSale.TabIndex = 2;
            this.forSale.Text = "سيارات للبيع";
            // 
            // forSaleCars
            // 
            this.forSaleCars.BackColor = System.Drawing.Color.Transparent;
            this.forSaleCars.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.forSaleCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forSaleCars.Cursor = System.Windows.Forms.Cursors.Default;
            this.forSaleCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forSaleCars.Font = new System.Drawing.Font("Traditional Arabic", 20F, System.Drawing.FontStyle.Bold);
            this.forSaleCars.ForeColor = System.Drawing.Color.White;
            this.forSaleCars.Location = new System.Drawing.Point(87, 93);
            this.forSaleCars.Name = "forSaleCars";
            this.forSaleCars.Size = new System.Drawing.Size(147, 65);
            this.forSaleCars.TabIndex = 0;
            this.forSaleCars.Text = "عرض";
            this.forSaleCars.UseVisualStyleBackColor = false;
            this.forSaleCars.Click += new System.EventHandler(this.forSaleCars_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ForLease);
            this.panel1.Controls.Add(this.forLeaseCars);
            this.panel1.Location = new System.Drawing.Point(92, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 195);
            this.panel1.TabIndex = 5;
            // 
            // ForLease
            // 
            this.ForLease.AutoSize = true;
            this.ForLease.Font = new System.Drawing.Font("Traditional Arabic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForLease.Location = new System.Drawing.Point(58, 12);
            this.ForLease.Name = "ForLease";
            this.ForLease.Size = new System.Drawing.Size(198, 66);
            this.ForLease.TabIndex = 2;
            this.ForLease.Text = "سيارات للإيجار";
            // 
            // forLeaseCars
            // 
            this.forLeaseCars.BackColor = System.Drawing.Color.Transparent;
            this.forLeaseCars.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.forLeaseCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forLeaseCars.Cursor = System.Windows.Forms.Cursors.Default;
            this.forLeaseCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forLeaseCars.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLeaseCars.ForeColor = System.Drawing.Color.White;
            this.forLeaseCars.Location = new System.Drawing.Point(82, 95);
            this.forLeaseCars.Name = "forLeaseCars";
            this.forLeaseCars.Size = new System.Drawing.Size(147, 64);
            this.forLeaseCars.TabIndex = 0;
            this.forLeaseCars.Text = "عرض";
            this.forLeaseCars.UseVisualStyleBackColor = false;
            this.forLeaseCars.Click += new System.EventHandler(this.forLeaseCars_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitButton.Location = new System.Drawing.Point(908, 36);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "x";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::carDealershipProject.Properties.Resources.mainFormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 734);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userMainForm";
            this.Text = "لوحة المستخدم";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label forSale;
        private System.Windows.Forms.Button forSaleCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ForLease;
        private System.Windows.Forms.Button forLeaseCars;
        private System.Windows.Forms.Button exitButton;
    }
}