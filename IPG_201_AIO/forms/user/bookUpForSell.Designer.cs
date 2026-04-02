namespace carDealershipProject.forms.user
{
    partial class bookUpForSell
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
            System.Windows.Forms.Label ownershipCPLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label infoLabel;
            System.Windows.Forms.Label sellingDateLabel;
            System.Windows.Forms.Label isSoldLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookUpForSell));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ownershipCPPictureBox = new System.Windows.Forms.PictureBox();
            this.canBeSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDBDataSet = new carDealershipProject.datasets.carDealershipDBDataSet();
            this.canSellTAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.canSellTAdapter();
            this.tableAdapterManager = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager();
            this.canBeSoldBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.canBeSoldBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookUpOk = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.sellingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isSoldCheckBox = new System.Windows.Forms.CheckBox();
            this.canBeSoldId = new System.Windows.Forms.TextBox();
            ownershipCPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            sellingDateLabel = new System.Windows.Forms.Label();
            isSoldLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipCPPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingNavigator)).BeginInit();
            this.canBeSoldBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownershipCPLabel
            // 
            ownershipCPLabel.AutoSize = true;
            ownershipCPLabel.Font = new System.Drawing.Font("PNU Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ownershipCPLabel.Location = new System.Drawing.Point(300, 1);
            ownershipCPLabel.Name = "ownershipCPLabel";
            ownershipCPLabel.Size = new System.Drawing.Size(158, 30);
            ownershipCPLabel.TabIndex = 24;
            ownershipCPLabel.Text = ":صورة عقد الملكية";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("PNU Medium", 20F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(93, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(394, 62);
            label1.TabIndex = 26;
            label1.Text = "هل تريد حجز هذه السيارة؟";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            infoLabel.Location = new System.Drawing.Point(671, 313);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(71, 26);
            infoLabel.TabIndex = 29;
            infoLabel.Text = ":معلومات";
            // 
            // sellingDateLabel
            // 
            sellingDateLabel.AutoSize = true;
            sellingDateLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            sellingDateLabel.Location = new System.Drawing.Point(671, 349);
            sellingDateLabel.Name = "sellingDateLabel";
            sellingDateLabel.Size = new System.Drawing.Size(84, 26);
            sellingDateLabel.TabIndex = 30;
            sellingDateLabel.Text = "موعد البيع:";
            // 
            // isSoldLabel
            // 
            isSoldLabel.AutoSize = true;
            isSoldLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            isSoldLabel.Location = new System.Drawing.Point(671, 391);
            isSoldLabel.Name = "isSoldLabel";
            isSoldLabel.Size = new System.Drawing.Size(49, 26);
            isSoldLabel.TabIndex = 31;
            isSoldLabel.Text = ":حجزت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.Location = new System.Drawing.Point(671, 274);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 26);
            label2.TabIndex = 33;
            label2.Text = ":متسلسل";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ownershipCPPictureBox);
            this.panel1.Controls.Add(ownershipCPLabel);
            this.panel1.Location = new System.Drawing.Point(49, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 394);
            this.panel1.TabIndex = 27;
            // 
            // ownershipCPPictureBox
            // 
            this.ownershipCPPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ownershipCPPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.canBeSoldBindingSource, "ownershipCP", true));
            this.ownershipCPPictureBox.Location = new System.Drawing.Point(19, 34);
            this.ownershipCPPictureBox.Name = "ownershipCPPictureBox";
            this.ownershipCPPictureBox.Size = new System.Drawing.Size(439, 343);
            this.ownershipCPPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ownershipCPPictureBox.TabIndex = 25;
            this.ownershipCPPictureBox.TabStop = false;
            // 
            // canBeSoldBindingSource
            // 
            this.canBeSoldBindingSource.DataMember = "canBeSold";
            this.canBeSoldBindingSource.DataSource = this.carDealershipDBDataSet;
            // 
            // carDealershipDBDataSet
            // 
            this.carDealershipDBDataSet.DataSetName = "carDealershipDBDataSet";
            this.carDealershipDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // canSellTAdapter
            // 
            this.canSellTAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carsForRentTableAdapter = null;
            this.tableAdapterManager.carsForSaleTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // canBeSoldBindingNavigator
            // 
            this.canBeSoldBindingNavigator.AddNewItem = null;
            this.canBeSoldBindingNavigator.BindingSource = this.canBeSoldBindingSource;
            this.canBeSoldBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.canBeSoldBindingNavigator.DeleteItem = null;
            this.canBeSoldBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.canBeSoldBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.canBeSoldBindingNavigatorSaveItem});
            this.canBeSoldBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.canBeSoldBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.canBeSoldBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.canBeSoldBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.canBeSoldBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.canBeSoldBindingNavigator.Name = "canBeSoldBindingNavigator";
            this.canBeSoldBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.canBeSoldBindingNavigator.Size = new System.Drawing.Size(803, 27);
            this.canBeSoldBindingNavigator.TabIndex = 28;
            this.canBeSoldBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // canBeSoldBindingNavigatorSaveItem
            // 
            this.canBeSoldBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.canBeSoldBindingNavigatorSaveItem.Enabled = false;
            this.canBeSoldBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("canBeSoldBindingNavigatorSaveItem.Image")));
            this.canBeSoldBindingNavigatorSaveItem.Name = "canBeSoldBindingNavigatorSaveItem";
            this.canBeSoldBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.canBeSoldBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bookUpOk
            // 
            this.bookUpOk.BackColor = System.Drawing.Color.Transparent;
            this.bookUpOk.BackgroundImage = global::carDealershipProject.Properties.Resources.square_1;
            this.bookUpOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookUpOk.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookUpOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookUpOk.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookUpOk.ForeColor = System.Drawing.Color.White;
            this.bookUpOk.Location = new System.Drawing.Point(573, 440);
            this.bookUpOk.Name = "bookUpOk";
            this.bookUpOk.Size = new System.Drawing.Size(147, 64);
            this.bookUpOk.TabIndex = 29;
            this.bookUpOk.Text = "حجز";
            this.bookUpOk.UseVisualStyleBackColor = false;
            this.bookUpOk.Click += new System.EventHandler(this.bookUpOk_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "info", true));
            this.infoTextBox.Enabled = false;
            this.infoTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.infoTextBox.Location = new System.Drawing.Point(552, 310);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(113, 31);
            this.infoTextBox.TabIndex = 30;
            // 
            // sellingDateDateTimePicker
            // 
            this.sellingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.canBeSoldBindingSource, "sellingDate", true));
            this.sellingDateDateTimePicker.Enabled = false;
            this.sellingDateDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sellingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sellingDateDateTimePicker.Location = new System.Drawing.Point(552, 349);
            this.sellingDateDateTimePicker.Name = "sellingDateDateTimePicker";
            this.sellingDateDateTimePicker.Size = new System.Drawing.Size(113, 31);
            this.sellingDateDateTimePicker.TabIndex = 31;
            // 
            // isSoldCheckBox
            // 
            this.isSoldCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.canBeSoldBindingSource, "isSold", true));
            this.isSoldCheckBox.Enabled = false;
            this.isSoldCheckBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.isSoldCheckBox.Location = new System.Drawing.Point(639, 388);
            this.isSoldCheckBox.Name = "isSoldCheckBox";
            this.isSoldCheckBox.Size = new System.Drawing.Size(26, 24);
            this.isSoldCheckBox.TabIndex = 32;
            this.isSoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // canBeSoldId
            // 
            this.canBeSoldId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "Id", true));
            this.canBeSoldId.Enabled = false;
            this.canBeSoldId.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.canBeSoldId.Location = new System.Drawing.Point(552, 271);
            this.canBeSoldId.Name = "canBeSoldId";
            this.canBeSoldId.Size = new System.Drawing.Size(113, 31);
            this.canBeSoldId.TabIndex = 34;
            // 
            // bookUpForSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 524);
            this.Controls.Add(label2);
            this.Controls.Add(this.canBeSoldId);
            this.Controls.Add(isSoldLabel);
            this.Controls.Add(this.isSoldCheckBox);
            this.Controls.Add(sellingDateLabel);
            this.Controls.Add(this.sellingDateDateTimePicker);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.bookUpOk);
            this.Controls.Add(this.canBeSoldBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label1);
            this.Name = "bookUpForSell";
            this.Text = "bookUpForSell";
            this.Load += new System.EventHandler(this.bookUpForSell_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipCPPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingNavigator)).EndInit();
            this.canBeSoldBindingNavigator.ResumeLayout(false);
            this.canBeSoldBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private datasets.carDealershipDBDataSet carDealershipDBDataSet;
        private System.Windows.Forms.BindingSource canBeSoldBindingSource;
        private datasets.carDealershipDBDataSetTableAdapters.canSellTAdapter canSellTAdapter;
        private datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator canBeSoldBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton canBeSoldBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox ownershipCPPictureBox;
        private System.Windows.Forms.Button bookUpOk;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.DateTimePicker sellingDateDateTimePicker;
        private System.Windows.Forms.CheckBox isSoldCheckBox;
        private System.Windows.Forms.TextBox canBeSoldId;
    }
}