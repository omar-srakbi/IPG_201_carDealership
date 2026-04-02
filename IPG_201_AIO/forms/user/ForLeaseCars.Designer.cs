namespace carDealershipProject.forms.user
{
    partial class ForLeaseCars
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label manufactureYearLabel;
            System.Windows.Forms.Label rentPerDayLabel;
            System.Windows.Forms.Label rentPricePerMonthLabel;
            System.Windows.Forms.Label rentPricePerYearLabel;
            System.Windows.Forms.Label carPhotoLabel;
            System.Windows.Forms.Label infoLabel;
            System.Windows.Forms.Label dateAddedLabel;
            System.Windows.Forms.Label bookedUpDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForLeaseCars));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.canBeRentedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDBDataSet = new carDealershipProject.datasets.carDealershipDBDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufactureYearTextBox = new System.Windows.Forms.TextBox();
            this.rentPerDayTextBox = new System.Windows.Forms.TextBox();
            this.rentPricePerMonthTextBox = new System.Windows.Forms.TextBox();
            this.rentPricePerYearTextBox = new System.Windows.Forms.TextBox();
            this.carPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.bookUpCar = new System.Windows.Forms.Button();
            this.dateAddedTextBox = new System.Windows.Forms.TextBox();
            this.whoRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canBeRentedTableAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.canBeRentedTableAdapter();
            this.tableAdapterManager = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager();
            this.canBeRentedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.canBeRentedBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.canBeRentedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canRentTAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.canRentTAdapter();
            this.bookedUpDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            manufactureYearLabel = new System.Windows.Forms.Label();
            rentPerDayLabel = new System.Windows.Forms.Label();
            rentPricePerMonthLabel = new System.Windows.Forms.Label();
            rentPricePerYearLabel = new System.Windows.Forms.Label();
            carPhotoLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            dateAddedLabel = new System.Windows.Forms.Label();
            bookedUpDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canBeRentedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoRentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeRentedBindingNavigator)).BeginInit();
            this.canBeRentedBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canBeRentedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            nameLabel.Location = new System.Drawing.Point(1184, 492);
            nameLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 26);
            nameLabel.TabIndex = 2;
            nameLabel.Text = ":الاسم";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            idLabel.Location = new System.Drawing.Point(1184, 443);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(86, 26);
            idLabel.TabIndex = 4;
            idLabel.Text = ":المتسلسل";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            modelLabel.Location = new System.Drawing.Point(1184, 540);
            modelLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(67, 26);
            modelLabel.TabIndex = 6;
            modelLabel.Text = ":الموديل";
            // 
            // manufactureYearLabel
            // 
            manufactureYearLabel.AutoSize = true;
            manufactureYearLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            manufactureYearLabel.Location = new System.Drawing.Point(1184, 589);
            manufactureYearLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            manufactureYearLabel.Name = "manufactureYearLabel";
            manufactureYearLabel.Size = new System.Drawing.Size(84, 26);
            manufactureYearLabel.TabIndex = 8;
            manufactureYearLabel.Text = ":سنة الصنع";
            // 
            // rentPerDayLabel
            // 
            rentPerDayLabel.AutoSize = true;
            rentPerDayLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            rentPerDayLabel.Location = new System.Drawing.Point(819, 443);
            rentPerDayLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            rentPerDayLabel.Name = "rentPerDayLabel";
            rentPerDayLabel.Size = new System.Drawing.Size(94, 26);
            rentPerDayLabel.TabIndex = 10;
            rentPerDayLabel.Text = ":الايجار باليوم";
            // 
            // rentPricePerMonthLabel
            // 
            rentPricePerMonthLabel.AutoSize = true;
            rentPricePerMonthLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            rentPricePerMonthLabel.Location = new System.Drawing.Point(819, 492);
            rentPricePerMonthLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            rentPricePerMonthLabel.Name = "rentPricePerMonthLabel";
            rentPricePerMonthLabel.Size = new System.Drawing.Size(100, 26);
            rentPricePerMonthLabel.TabIndex = 12;
            rentPricePerMonthLabel.Text = ":الايجار بالشهر";
            // 
            // rentPricePerYearLabel
            // 
            rentPricePerYearLabel.AutoSize = true;
            rentPricePerYearLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            rentPricePerYearLabel.Location = new System.Drawing.Point(819, 541);
            rentPricePerYearLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            rentPricePerYearLabel.Name = "rentPricePerYearLabel";
            rentPricePerYearLabel.Size = new System.Drawing.Size(100, 26);
            rentPricePerYearLabel.TabIndex = 14;
            rentPricePerYearLabel.Text = ":الايجار بالسنة";
            // 
            // carPhotoLabel
            // 
            carPhotoLabel.AutoSize = true;
            carPhotoLabel.Location = new System.Drawing.Point(468, 392);
            carPhotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            carPhotoLabel.Name = "carPhotoLabel";
            carPhotoLabel.Size = new System.Drawing.Size(91, 26);
            carPhotoLabel.TabIndex = 16;
            carPhotoLabel.Text = "car Photo:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            infoLabel.Location = new System.Drawing.Point(819, 590);
            infoLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(118, 26);
            infoLabel.TabIndex = 18;
            infoLabel.Text = ":معلومات اضافية";
            // 
            // dateAddedLabel
            // 
            dateAddedLabel.AutoSize = true;
            dateAddedLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dateAddedLabel.Location = new System.Drawing.Point(1184, 629);
            dateAddedLabel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            dateAddedLabel.Name = "dateAddedLabel";
            dateAddedLabel.Size = new System.Drawing.Size(97, 26);
            dateAddedLabel.TabIndex = 20;
            dateAddedLabel.Text = ":تاريخ الاضافة";
            // 
            // bookedUpDateLabel
            // 
            bookedUpDateLabel.AutoSize = true;
            bookedUpDateLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            bookedUpDateLabel.Location = new System.Drawing.Point(819, 635);
            bookedUpDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bookedUpDateLabel.Name = "bookedUpDateLabel";
            bookedUpDateLabel.Size = new System.Drawing.Size(81, 26);
            bookedUpDateLabel.TabIndex = 64;
            bookedUpDateLabel.Text = ":تاريخ الحجز";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameTextBox.Location = new System.Drawing.Point(1003, 482);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 31);
            this.nameTextBox.TabIndex = 3;
            // 
            // canBeRentedBindingSource
            // 
            this.canBeRentedBindingSource.DataMember = "canBeRented";
            this.canBeRentedBindingSource.DataSource = this.carDealershipDBDataSet;
            // 
            // carDealershipDBDataSet
            // 
            this.carDealershipDBDataSet.DataSetName = "carDealershipDBDataSet";
            this.carDealershipDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.idTextBox.Location = new System.Drawing.Point(1003, 433);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(162, 31);
            this.idTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "model", true));
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.modelTextBox.Location = new System.Drawing.Point(1003, 530);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(162, 31);
            this.modelTextBox.TabIndex = 7;
            // 
            // manufactureYearTextBox
            // 
            this.manufactureYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "manufactureYear", true));
            this.manufactureYearTextBox.Enabled = false;
            this.manufactureYearTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.manufactureYearTextBox.Location = new System.Drawing.Point(1003, 579);
            this.manufactureYearTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.manufactureYearTextBox.Name = "manufactureYearTextBox";
            this.manufactureYearTextBox.Size = new System.Drawing.Size(162, 31);
            this.manufactureYearTextBox.TabIndex = 9;
            // 
            // rentPerDayTextBox
            // 
            this.rentPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "rentPerDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.rentPerDayTextBox.Enabled = false;
            this.rentPerDayTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rentPerDayTextBox.Location = new System.Drawing.Point(633, 433);
            this.rentPerDayTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rentPerDayTextBox.Name = "rentPerDayTextBox";
            this.rentPerDayTextBox.Size = new System.Drawing.Size(162, 31);
            this.rentPerDayTextBox.TabIndex = 11;
            // 
            // rentPricePerMonthTextBox
            // 
            this.rentPricePerMonthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "rentPricePerMonth", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.rentPricePerMonthTextBox.Enabled = false;
            this.rentPricePerMonthTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rentPricePerMonthTextBox.Location = new System.Drawing.Point(633, 482);
            this.rentPricePerMonthTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rentPricePerMonthTextBox.Name = "rentPricePerMonthTextBox";
            this.rentPricePerMonthTextBox.Size = new System.Drawing.Size(162, 31);
            this.rentPricePerMonthTextBox.TabIndex = 13;
            // 
            // rentPricePerYearTextBox
            // 
            this.rentPricePerYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "rentPricePerYear", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.rentPricePerYearTextBox.Enabled = false;
            this.rentPricePerYearTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rentPricePerYearTextBox.Location = new System.Drawing.Point(633, 531);
            this.rentPricePerYearTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rentPricePerYearTextBox.Name = "rentPricePerYearTextBox";
            this.rentPricePerYearTextBox.Size = new System.Drawing.Size(162, 31);
            this.rentPricePerYearTextBox.TabIndex = 15;
            // 
            // carPhotoPictureBox
            // 
            this.carPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.canBeRentedBindingSource, "carPhoto", true));
            this.carPhotoPictureBox.Location = new System.Drawing.Point(15, 421);
            this.carPhotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carPhotoPictureBox.Name = "carPhotoPictureBox";
            this.carPhotoPictureBox.Size = new System.Drawing.Size(546, 479);
            this.carPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPhotoPictureBox.TabIndex = 17;
            this.carPhotoPictureBox.TabStop = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.canBeRentedBindingSource, "info", true));
            this.infoTextBox.Enabled = false;
            this.infoTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.infoTextBox.Location = new System.Drawing.Point(633, 580);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(162, 31);
            this.infoTextBox.TabIndex = 19;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(760, 712);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(177, 68);
            this.closeButton.TabIndex = 62;
            this.closeButton.Text = "إغلاق";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bookUpCar
            // 
            this.bookUpCar.BackColor = System.Drawing.SystemColors.Control;
            this.bookUpCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookUpCar.BackgroundImage")));
            this.bookUpCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookUpCar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bookUpCar.FlatAppearance.BorderSize = 0;
            this.bookUpCar.Font = new System.Drawing.Font("PNU Medium", 8F, System.Drawing.FontStyle.Bold);
            this.bookUpCar.Location = new System.Drawing.Point(966, 712);
            this.bookUpCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookUpCar.Name = "bookUpCar";
            this.bookUpCar.Size = new System.Drawing.Size(177, 68);
            this.bookUpCar.TabIndex = 60;
            this.bookUpCar.Text = "حجز السيارة";
            this.bookUpCar.UseVisualStyleBackColor = false;
            this.bookUpCar.Click += new System.EventHandler(this.bookUpCar_Click);
            // 
            // dateAddedTextBox
            // 
            this.dateAddedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.whoRentBindingSource, "dateAdded", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateAddedTextBox.Enabled = false;
            this.dateAddedTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateAddedTextBox.Location = new System.Drawing.Point(1010, 624);
            this.dateAddedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateAddedTextBox.Name = "dateAddedTextBox";
            this.dateAddedTextBox.Size = new System.Drawing.Size(162, 31);
            this.dateAddedTextBox.TabIndex = 63;
            // 
            // whoRentBindingSource
            // 
            this.whoRentBindingSource.DataMember = "whoRent";
            this.whoRentBindingSource.DataSource = this.carDealershipDBDataSetBindingSource;
            // 
            // carDealershipDBDataSetBindingSource
            // 
            this.carDealershipDBDataSetBindingSource.DataSource = this.carDealershipDBDataSet;
            this.carDealershipDBDataSetBindingSource.Position = 0;
            // 
            // canBeRentedTableAdapter
            // 
            this.canBeRentedTableAdapter.ClearBeforeFill = true;
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
            // canBeRentedBindingNavigator
            // 
            this.canBeRentedBindingNavigator.AddNewItem = null;
            this.canBeRentedBindingNavigator.BindingSource = this.canBeRentedBindingSource;
            this.canBeRentedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.canBeRentedBindingNavigator.DeleteItem = null;
            this.canBeRentedBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.canBeRentedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.canBeRentedBindingNavigatorSaveItem});
            this.canBeRentedBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.canBeRentedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.canBeRentedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.canBeRentedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.canBeRentedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.canBeRentedBindingNavigator.Name = "canBeRentedBindingNavigator";
            this.canBeRentedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.canBeRentedBindingNavigator.Size = new System.Drawing.Size(1312, 27);
            this.canBeRentedBindingNavigator.TabIndex = 64;
            this.canBeRentedBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(63, 27);
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
            // canBeRentedBindingNavigatorSaveItem
            // 
            this.canBeRentedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.canBeRentedBindingNavigatorSaveItem.Enabled = false;
            this.canBeRentedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("canBeRentedBindingNavigatorSaveItem.Image")));
            this.canBeRentedBindingNavigatorSaveItem.Name = "canBeRentedBindingNavigatorSaveItem";
            this.canBeRentedBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.canBeRentedBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // canBeRentedDataGridView
            // 
            this.canBeRentedDataGridView.AllowUserToAddRows = false;
            this.canBeRentedDataGridView.AllowUserToDeleteRows = false;
            this.canBeRentedDataGridView.AutoGenerateColumns = false;
            this.canBeRentedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canBeRentedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.canBeRentedDataGridView.DataSource = this.canBeRentedBindingSource;
            this.canBeRentedDataGridView.Location = new System.Drawing.Point(0, 46);
            this.canBeRentedDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canBeRentedDataGridView.Name = "canBeRentedDataGridView";
            this.canBeRentedDataGridView.ReadOnly = true;
            this.canBeRentedDataGridView.RowTemplate.Height = 26;
            this.canBeRentedDataGridView.Size = new System.Drawing.Size(1569, 316);
            this.canBeRentedDataGridView.TabIndex = 64;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "manufactureYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "manufactureYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "info";
            this.dataGridViewTextBoxColumn8.HeaderText = "info";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dateAdded";
            this.dataGridViewTextBoxColumn9.HeaderText = "dateAdded";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isVisable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isVisable";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // canRentTAdapter
            // 
            this.canRentTAdapter.ClearBeforeFill = true;
            // 
            // bookedUpDateDateTimePicker
            // 
            this.bookedUpDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.canBeRentedBindingSource, "bookedUpDate", true));
            this.bookedUpDateDateTimePicker.Enabled = false;
            this.bookedUpDateDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bookedUpDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bookedUpDateDateTimePicker.Location = new System.Drawing.Point(633, 626);
            this.bookedUpDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookedUpDateDateTimePicker.Name = "bookedUpDateDateTimePicker";
            this.bookedUpDateDateTimePicker.Size = new System.Drawing.Size(162, 31);
            this.bookedUpDateDateTimePicker.TabIndex = 65;
            // 
            // ForLeaseCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 933);
            this.Controls.Add(bookedUpDateLabel);
            this.Controls.Add(this.bookedUpDateDateTimePicker);
            this.Controls.Add(this.canBeRentedDataGridView);
            this.Controls.Add(this.canBeRentedBindingNavigator);
            this.Controls.Add(this.dateAddedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bookUpCar);
            this.Controls.Add(dateAddedLabel);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(carPhotoLabel);
            this.Controls.Add(this.carPhotoPictureBox);
            this.Controls.Add(rentPricePerYearLabel);
            this.Controls.Add(this.rentPricePerYearTextBox);
            this.Controls.Add(rentPricePerMonthLabel);
            this.Controls.Add(this.rentPricePerMonthTextBox);
            this.Controls.Add(rentPerDayLabel);
            this.Controls.Add(this.rentPerDayTextBox);
            this.Controls.Add(manufactureYearLabel);
            this.Controls.Add(this.manufactureYearTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForLeaseCars";
            this.Text = "السيارات المعروضة للايجار";
            this.Load += new System.EventHandler(this.editForLeaseCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canBeRentedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoRentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBeRentedBindingNavigator)).EndInit();
            this.canBeRentedBindingNavigator.ResumeLayout(false);
            this.canBeRentedBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canBeRentedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufactureYearTextBox;
        private System.Windows.Forms.TextBox rentPerDayTextBox;
        private System.Windows.Forms.TextBox rentPricePerMonthTextBox;
        private System.Windows.Forms.TextBox rentPricePerYearTextBox;
        private System.Windows.Forms.PictureBox carPhotoPictureBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button bookUpCar;
        private System.Windows.Forms.TextBox dateAddedTextBox;
        private datasets.carDealershipDBDataSet carDealershipDBDataSet;
        private System.Windows.Forms.BindingSource canBeRentedBindingSource;
        private datasets.carDealershipDBDataSetTableAdapters.canBeRentedTableAdapter canBeRentedTableAdapter;
        private datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator canBeRentedBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton canBeRentedBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView canBeRentedDataGridView;
        private System.Windows.Forms.BindingSource carDealershipDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource whoRentBindingSource;
        private datasets.carDealershipDBDataSetTableAdapters.canRentTAdapter canRentTAdapter;
        private System.Windows.Forms.DateTimePicker bookedUpDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

    }
}