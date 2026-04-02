namespace carDealershipProject.forms.user
{
    partial class ForSaleCars
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
            System.Windows.Forms.Label carPhotoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label isNewLabel;
            System.Windows.Forms.Label dateAddedLabel;
            System.Windows.Forms.Label infoLabel;
            System.Windows.Forms.Label isNegotiableLabel;
            System.Windows.Forms.Label sellingPriceLabel;
            System.Windows.Forms.Label knownIssuesLabel;
            System.Windows.Forms.Label isAutoGearLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label manufactureYearLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ownershipCPLabel;
            System.Windows.Forms.Label isSoldLabel;
            System.Windows.Forms.Label sellingDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForSaleCars));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ownershipCPPictureBox = new System.Windows.Forms.PictureBox();
            this.canBeSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDBDataSet = new carDealershipProject.datasets.carDealershipDBDataSet();
            this.carPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.isNewCheckBox = new System.Windows.Forms.CheckBox();
            this.dateAddedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.isFinalPriceCheckBox = new System.Windows.Forms.CheckBox();
            this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.knownIssuesTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.isAutoGearCheckBox = new System.Windows.Forms.CheckBox();
            this.ManufactureYear = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.bookupCar = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.whoBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.canBeSoldDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canSellTAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.canSellTAdapter();
            this.tableAdapterManager = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager();
            this.whoBuyTableAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.whoBuyTableAdapter();
            this.isSoldCheckBox = new System.Windows.Forms.CheckBox();
            this.sellingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            carPhotoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            isNewLabel = new System.Windows.Forms.Label();
            dateAddedLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            isNegotiableLabel = new System.Windows.Forms.Label();
            sellingPriceLabel = new System.Windows.Forms.Label();
            knownIssuesLabel = new System.Windows.Forms.Label();
            isAutoGearLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            manufactureYearLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ownershipCPLabel = new System.Windows.Forms.Label();
            isSoldLabel = new System.Windows.Forms.Label();
            sellingDateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipCPPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoBuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingNavigator)).BeginInit();
            this.canBeSoldBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carPhotoLabel
            // 
            carPhotoLabel.AutoSize = true;
            carPhotoLabel.Font = new System.Drawing.Font("PNU Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            carPhotoLabel.Location = new System.Drawing.Point(617, 20);
            carPhotoLabel.Name = "carPhotoLabel";
            carPhotoLabel.Size = new System.Drawing.Size(117, 30);
            carPhotoLabel.TabIndex = 17;
            carPhotoLabel.Text = ":صورة السيارة";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            idLabel.Location = new System.Drawing.Point(977, 269);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(86, 26);
            idLabel.TabIndex = 66;
            idLabel.Text = ":المتسلسل";
            // 
            // isNewLabel
            // 
            isNewLabel.AutoSize = true;
            isNewLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            isNewLabel.Location = new System.Drawing.Point(969, 576);
            isNewLabel.Margin = new System.Windows.Forms.Padding(4);
            isNewLabel.Name = "isNewLabel";
            isNewLabel.Size = new System.Drawing.Size(131, 26);
            isNewLabel.TabIndex = 62;
            isNewLabel.Text = ":هل السيارة جديدة";
            // 
            // dateAddedLabel
            // 
            dateAddedLabel.AutoSize = true;
            dateAddedLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dateAddedLabel.Location = new System.Drawing.Point(969, 652);
            dateAddedLabel.Margin = new System.Windows.Forms.Padding(4);
            dateAddedLabel.Name = "dateAddedLabel";
            dateAddedLabel.Size = new System.Drawing.Size(97, 26);
            dateAddedLabel.TabIndex = 60;
            dateAddedLabel.Text = ":تاريخ الاضافة";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            infoLabel.Location = new System.Drawing.Point(969, 610);
            infoLabel.Margin = new System.Windows.Forms.Padding(4);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(72, 26);
            infoLabel.TabIndex = 58;
            infoLabel.Text = ":ملاحظات";
            // 
            // isNegotiableLabel
            // 
            isNegotiableLabel.AutoSize = true;
            isNegotiableLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            isNegotiableLabel.Location = new System.Drawing.Point(969, 542);
            isNegotiableLabel.Margin = new System.Windows.Forms.Padding(4);
            isNegotiableLabel.Name = "isNegotiableLabel";
            isNegotiableLabel.Size = new System.Drawing.Size(119, 26);
            isNegotiableLabel.TabIndex = 57;
            isNegotiableLabel.Text = ":هل السعر نهائي";
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            sellingPriceLabel.Location = new System.Drawing.Point(969, 508);
            sellingPriceLabel.Margin = new System.Windows.Forms.Padding(4);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new System.Drawing.Size(53, 26);
            sellingPriceLabel.TabIndex = 55;
            sellingPriceLabel.Text = ":السعر";
            // 
            // knownIssuesLabel
            // 
            knownIssuesLabel.AutoSize = true;
            knownIssuesLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            knownIssuesLabel.Location = new System.Drawing.Point(969, 474);
            knownIssuesLabel.Margin = new System.Windows.Forms.Padding(4);
            knownIssuesLabel.Name = "knownIssuesLabel";
            knownIssuesLabel.Size = new System.Drawing.Size(73, 26);
            knownIssuesLabel.TabIndex = 52;
            knownIssuesLabel.Text = ":المشاكل";
            // 
            // isAutoGearLabel
            // 
            isAutoGearLabel.AutoSize = true;
            isAutoGearLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            isAutoGearLabel.Location = new System.Drawing.Point(969, 440);
            isAutoGearLabel.Margin = new System.Windows.Forms.Padding(4);
            isAutoGearLabel.Name = "isAutoGearLabel";
            isAutoGearLabel.Size = new System.Drawing.Size(105, 26);
            isAutoGearLabel.TabIndex = 49;
            isAutoGearLabel.Text = ":غيار اوتوماتيك";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            colorLabel.Location = new System.Drawing.Point(969, 406);
            colorLabel.Margin = new System.Windows.Forms.Padding(4);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(49, 26);
            colorLabel.TabIndex = 47;
            colorLabel.Text = ":اللون";
            // 
            // manufactureYearLabel
            // 
            manufactureYearLabel.AutoSize = true;
            manufactureYearLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            manufactureYearLabel.Location = new System.Drawing.Point(969, 370);
            manufactureYearLabel.Margin = new System.Windows.Forms.Padding(4);
            manufactureYearLabel.Name = "manufactureYearLabel";
            manufactureYearLabel.Size = new System.Drawing.Size(87, 26);
            manufactureYearLabel.TabIndex = 44;
            manufactureYearLabel.Text = ":تاريخ الصنع";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            modelLabel.Location = new System.Drawing.Point(969, 338);
            modelLabel.Margin = new System.Windows.Forms.Padding(4);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(57, 26);
            modelLabel.TabIndex = 41;
            modelLabel.Text = ":موديل";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            nameLabel.Location = new System.Drawing.Point(969, 304);
            nameLabel.Margin = new System.Windows.Forms.Padding(4);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(94, 26);
            nameLabel.TabIndex = 39;
            nameLabel.Text = ":اسم السيارة";
            // 
            // ownershipCPLabel
            // 
            ownershipCPLabel.AutoSize = true;
            ownershipCPLabel.Font = new System.Drawing.Font("PNU Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ownershipCPLabel.Location = new System.Drawing.Point(207, 19);
            ownershipCPLabel.Name = "ownershipCPLabel";
            ownershipCPLabel.Size = new System.Drawing.Size(158, 30);
            ownershipCPLabel.TabIndex = 26;
            ownershipCPLabel.Text = ":صورة عقد الملكية";
            // 
            // isSoldLabel
            // 
            isSoldLabel.AutoSize = true;
            isSoldLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            isSoldLabel.Location = new System.Drawing.Point(969, 721);
            isSoldLabel.Name = "isSoldLabel";
            isSoldLabel.Size = new System.Drawing.Size(49, 26);
            isSoldLabel.TabIndex = 34;
            isSoldLabel.Text = ":حجزت";
            // 
            // sellingDateLabel
            // 
            sellingDateLabel.AutoSize = true;
            sellingDateLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            sellingDateLabel.Location = new System.Drawing.Point(964, 685);
            sellingDateLabel.Name = "sellingDateLabel";
            sellingDateLabel.Size = new System.Drawing.Size(84, 26);
            sellingDateLabel.TabIndex = 33;
            sellingDateLabel.Text = ":موعد البيع";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ownershipCPLabel);
            this.groupBox1.Controls.Add(this.ownershipCPPictureBox);
            this.groupBox1.Controls.Add(this.carPhotoPictureBox);
            this.groupBox1.Controls.Add(carPhotoLabel);
            this.groupBox1.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(28, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 404);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصور";
            // 
            // ownershipCPPictureBox
            // 
            this.ownershipCPPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.canBeSoldBindingSource, "ownershipCP", true));
            this.ownershipCPPictureBox.Location = new System.Drawing.Point(6, 52);
            this.ownershipCPPictureBox.Name = "ownershipCPPictureBox";
            this.ownershipCPPictureBox.Size = new System.Drawing.Size(359, 332);
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
            // carPhotoPictureBox
            // 
            this.carPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.canBeSoldBindingSource, "carPhoto", true));
            this.carPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.canBeSoldBindingSource, "carPhoto", true));
            this.carPhotoPictureBox.Location = new System.Drawing.Point(371, 52);
            this.carPhotoPictureBox.Name = "carPhotoPictureBox";
            this.carPhotoPictureBox.Size = new System.Drawing.Size(365, 332);
            this.carPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPhotoPictureBox.TabIndex = 24;
            this.carPhotoPictureBox.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.idTextBox.Location = new System.Drawing.Point(826, 269);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(132, 31);
            this.idTextBox.TabIndex = 67;
            this.idTextBox.TabStop = false;
            // 
            // isNewCheckBox
            // 
            this.isNewCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.canBeSoldBindingSource, "isNew", true));
            this.isNewCheckBox.Enabled = false;
            this.isNewCheckBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.isNewCheckBox.Location = new System.Drawing.Point(939, 581);
            this.isNewCheckBox.Name = "isNewCheckBox";
            this.isNewCheckBox.Size = new System.Drawing.Size(20, 20);
            this.isNewCheckBox.TabIndex = 48;
            this.isNewCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateAddedDateTimePicker
            // 
            this.dateAddedDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateAddedDateTimePicker.CustomFormat = "dd-mm-yyyy";
            this.dateAddedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.canBeSoldBindingSource, "dateAdded", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateAddedDateTimePicker.Enabled = false;
            this.dateAddedDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateAddedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAddedDateTimePicker.Location = new System.Drawing.Point(824, 646);
            this.dateAddedDateTimePicker.MaxDate = new System.DateTime(2049, 12, 31, 0, 0, 0, 0);
            this.dateAddedDateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateAddedDateTimePicker.Name = "dateAddedDateTimePicker";
            this.dateAddedDateTimePicker.Size = new System.Drawing.Size(135, 31);
            this.dateAddedDateTimePicker.TabIndex = 51;
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "info", true));
            this.infoTextBox.Enabled = false;
            this.infoTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.infoTextBox.Location = new System.Drawing.Point(826, 612);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(133, 31);
            this.infoTextBox.TabIndex = 50;
            // 
            // isFinalPriceCheckBox
            // 
            this.isFinalPriceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.canBeSoldBindingSource, "isFinalPrice", true));
            this.isFinalPriceCheckBox.Enabled = false;
            this.isFinalPriceCheckBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.isFinalPriceCheckBox.Location = new System.Drawing.Point(939, 548);
            this.isFinalPriceCheckBox.Name = "isFinalPriceCheckBox";
            this.isFinalPriceCheckBox.Size = new System.Drawing.Size(20, 20);
            this.isFinalPriceCheckBox.TabIndex = 46;
            this.isFinalPriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellingPriceTextBox
            // 
            this.sellingPriceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.sellingPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "sellingPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.sellingPriceTextBox.Enabled = false;
            this.sellingPriceTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sellingPriceTextBox.Location = new System.Drawing.Point(825, 510);
            this.sellingPriceTextBox.Name = "sellingPriceTextBox";
            this.sellingPriceTextBox.Size = new System.Drawing.Size(134, 31);
            this.sellingPriceTextBox.TabIndex = 45;
            // 
            // knownIssuesTextBox
            // 
            this.knownIssuesTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.knownIssuesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "knownIssues", true));
            this.knownIssuesTextBox.Enabled = false;
            this.knownIssuesTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.knownIssuesTextBox.Location = new System.Drawing.Point(825, 476);
            this.knownIssuesTextBox.Name = "knownIssuesTextBox";
            this.knownIssuesTextBox.Size = new System.Drawing.Size(134, 31);
            this.knownIssuesTextBox.TabIndex = 43;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "color", true));
            this.colorTextBox.Enabled = false;
            this.colorTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.colorTextBox.Location = new System.Drawing.Point(825, 408);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(134, 31);
            this.colorTextBox.TabIndex = 40;
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "model", true));
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.modelTextBox.Location = new System.Drawing.Point(825, 340);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(134, 31);
            this.modelTextBox.TabIndex = 37;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameTextBox.Location = new System.Drawing.Point(825, 306);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(134, 31);
            this.nameTextBox.TabIndex = 36;
            // 
            // isAutoGearCheckBox
            // 
            this.isAutoGearCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.canBeSoldBindingSource, "isAutoGear", true));
            this.isAutoGearCheckBox.Enabled = false;
            this.isAutoGearCheckBox.Location = new System.Drawing.Point(939, 446);
            this.isAutoGearCheckBox.Name = "isAutoGearCheckBox";
            this.isAutoGearCheckBox.Size = new System.Drawing.Size(23, 24);
            this.isAutoGearCheckBox.TabIndex = 70;
            this.isAutoGearCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManufactureYear
            // 
            this.ManufactureYear.BackColor = System.Drawing.SystemColors.Control;
            this.ManufactureYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeSoldBindingSource, "manufactureYear", true));
            this.ManufactureYear.Enabled = false;
            this.ManufactureYear.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ManufactureYear.Location = new System.Drawing.Point(824, 374);
            this.ManufactureYear.Name = "ManufactureYear";
            this.ManufactureYear.Size = new System.Drawing.Size(134, 31);
            this.ManufactureYear.TabIndex = 71;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(28, 691);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(138, 47);
            this.closeButton.TabIndex = 59;
            this.closeButton.Text = "إغلاق";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bookupCar
            // 
            this.bookupCar.BackColor = System.Drawing.SystemColors.Control;
            this.bookupCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookupCar.BackgroundImage")));
            this.bookupCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookupCar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bookupCar.FlatAppearance.BorderSize = 0;
            this.bookupCar.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.bookupCar.Location = new System.Drawing.Point(615, 691);
            this.bookupCar.Name = "bookupCar";
            this.bookupCar.Size = new System.Drawing.Size(138, 47);
            this.bookupCar.TabIndex = 59;
            this.bookupCar.Text = "حجز السيارة";
            this.bookupCar.UseVisualStyleBackColor = false;
            this.bookupCar.Click += new System.EventHandler(this.bookupCar_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(320, 691);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 47);
            this.saveButton.TabIndex = 59;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // whoBuyBindingSource
            // 
            this.whoBuyBindingSource.DataMember = "whoBuy";
            this.whoBuyBindingSource.DataSource = this.carDealershipDBDataSet;
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
            this.canBeSoldBindingNavigator.Size = new System.Drawing.Size(1171, 27);
            this.canBeSoldBindingNavigator.TabIndex = 72;
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
            // canBeSoldDataGridView
            // 
            this.canBeSoldDataGridView.AllowUserToAddRows = false;
            this.canBeSoldDataGridView.AllowUserToDeleteRows = false;
            this.canBeSoldDataGridView.AutoGenerateColumns = false;
            this.canBeSoldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canBeSoldDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn10});
            this.canBeSoldDataGridView.DataSource = this.canBeSoldBindingSource;
            this.canBeSoldDataGridView.Location = new System.Drawing.Point(0, 32);
            this.canBeSoldDataGridView.Name = "canBeSoldDataGridView";
            this.canBeSoldDataGridView.ReadOnly = true;
            this.canBeSoldDataGridView.RowTemplate.Height = 26;
            this.canBeSoldDataGridView.Size = new System.Drawing.Size(1151, 220);
            this.canBeSoldDataGridView.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn3.HeaderText = "model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "info";
            this.dataGridViewTextBoxColumn8.HeaderText = "info";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "isVisable";
            this.dataGridViewCheckBoxColumn4.HeaderText = "isVisable";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "sellingDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "sellingDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
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
            // whoBuyTableAdapter
            // 
            this.whoBuyTableAdapter.ClearBeforeFill = true;
            // 
            // isSoldCheckBox
            // 
            this.isSoldCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.canBeSoldBindingSource, "isSold", true));
            this.isSoldCheckBox.Enabled = false;
            this.isSoldCheckBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.isSoldCheckBox.Location = new System.Drawing.Point(937, 727);
            this.isSoldCheckBox.Name = "isSoldCheckBox";
            this.isSoldCheckBox.Size = new System.Drawing.Size(26, 24);
            this.isSoldCheckBox.TabIndex = 36;
            this.isSoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellingDateDateTimePicker
            // 
            this.sellingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.canBeSoldBindingSource, "sellingDate", true));
            this.sellingDateDateTimePicker.Enabled = false;
            this.sellingDateDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sellingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sellingDateDateTimePicker.Location = new System.Drawing.Point(826, 685);
            this.sellingDateDateTimePicker.Name = "sellingDateDateTimePicker";
            this.sellingDateDateTimePicker.Size = new System.Drawing.Size(132, 31);
            this.sellingDateDateTimePicker.TabIndex = 35;
            // 
            // ForSaleCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 778);
            this.Controls.Add(isSoldLabel);
            this.Controls.Add(this.canBeSoldDataGridView);
            this.Controls.Add(this.isSoldCheckBox);
            this.Controls.Add(this.canBeSoldBindingNavigator);
            this.Controls.Add(sellingDateLabel);
            this.Controls.Add(this.sellingDateDateTimePicker);
            this.Controls.Add(this.ManufactureYear);
            this.Controls.Add(this.isAutoGearCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bookupCar);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(isNewLabel);
            this.Controls.Add(this.isNewCheckBox);
            this.Controls.Add(dateAddedLabel);
            this.Controls.Add(this.dateAddedDateTimePicker);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(isNegotiableLabel);
            this.Controls.Add(this.isFinalPriceCheckBox);
            this.Controls.Add(sellingPriceLabel);
            this.Controls.Add(this.sellingPriceTextBox);
            this.Controls.Add(knownIssuesLabel);
            this.Controls.Add(this.knownIssuesTextBox);
            this.Controls.Add(isAutoGearLabel);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(manufactureYearLabel);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForSaleCars";
            this.Text = "السيارات المعروضة للبيع";
            this.Load += new System.EventHandler(this.editForSaleCars_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipCPPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoBuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldBindingNavigator)).EndInit();
            this.canBeSoldBindingNavigator.ResumeLayout(false);
            this.canBeSoldBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canBeSoldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox carPhotoPictureBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.CheckBox isNewCheckBox;
        private System.Windows.Forms.DateTimePicker dateAddedDateTimePicker;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.CheckBox isFinalPriceCheckBox;
        private System.Windows.Forms.TextBox sellingPriceTextBox;
        private System.Windows.Forms.TextBox knownIssuesTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox isAutoGearCheckBox;
        private System.Windows.Forms.TextBox ManufactureYear;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button bookupCar;
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
        private System.Windows.Forms.DataGridView canBeSoldDataGridView;
        private System.Windows.Forms.BindingSource whoBuyBindingSource;
        private datasets.carDealershipDBDataSetTableAdapters.whoBuyTableAdapter whoBuyTableAdapter;
        private System.Windows.Forms.PictureBox ownershipCPPictureBox;
        private System.Windows.Forms.CheckBox isSoldCheckBox;
        private System.Windows.Forms.DateTimePicker sellingDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}