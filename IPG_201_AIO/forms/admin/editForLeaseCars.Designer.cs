namespace carDealershipProject.forms.admin
{
    partial class editForLeaseCars
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
            System.Windows.Forms.Label isVisableLabel;
            System.Windows.Forms.Label bookedUpDateLabel;
            System.Windows.Forms.Label endOfRentDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editForLeaseCars));
            this.carsForRentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.carsForRentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDBDataSet = new carDealershipProject.datasets.carDealershipDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carsForRentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carsForRentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endOfRentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufactureYearTextBox = new System.Windows.Forms.TextBox();
            this.rentPerDayTextBox = new System.Windows.Forms.TextBox();
            this.rentPricePerMonthTextBox = new System.Windows.Forms.TextBox();
            this.rentPricePerYearTextBox = new System.Windows.Forms.TextBox();
            this.carPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.dateAddedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isVisableCheckBox = new System.Windows.Forms.CheckBox();
            this.bookedUpDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endOfRentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateCarPicture = new System.Windows.Forms.Button();
            this.carsForRentTableAdapter = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.carsForRentTableAdapter();
            this.tableAdapterManager = new carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager();
            this.closeButton = new System.Windows.Forms.Button();
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
            isVisableLabel = new System.Windows.Forms.Label();
            bookedUpDateLabel = new System.Windows.Forms.Label();
            endOfRentDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsForRentBindingNavigator)).BeginInit();
            this.carsForRentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsForRentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsForRentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            nameLabel.Location = new System.Drawing.Point(910, 350);
            nameLabel.Margin = new System.Windows.Forms.Padding(5);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 26);
            nameLabel.TabIndex = 2;
            nameLabel.Text = ":الاسم";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            idLabel.Location = new System.Drawing.Point(910, 316);
            idLabel.Margin = new System.Windows.Forms.Padding(5);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(86, 26);
            idLabel.TabIndex = 4;
            idLabel.Text = ":المتسلسل";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            modelLabel.Location = new System.Drawing.Point(910, 384);
            modelLabel.Margin = new System.Windows.Forms.Padding(5);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(67, 26);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "الموديل:";
            // 
            // manufactureYearLabel
            // 
            manufactureYearLabel.AutoSize = true;
            manufactureYearLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            manufactureYearLabel.Location = new System.Drawing.Point(910, 418);
            manufactureYearLabel.Margin = new System.Windows.Forms.Padding(5);
            manufactureYearLabel.Name = "manufactureYearLabel";
            manufactureYearLabel.Size = new System.Drawing.Size(84, 26);
            manufactureYearLabel.TabIndex = 8;
            manufactureYearLabel.Text = ":سنة الصنع";
            // 
            // rentPerDayLabel
            // 
            rentPerDayLabel.AutoSize = true;
            rentPerDayLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            rentPerDayLabel.Location = new System.Drawing.Point(914, 536);
            rentPerDayLabel.Margin = new System.Windows.Forms.Padding(5);
            rentPerDayLabel.Name = "rentPerDayLabel";
            rentPerDayLabel.Size = new System.Drawing.Size(93, 26);
            rentPerDayLabel.TabIndex = 10;
            rentPerDayLabel.Text = ":الاجرة باليوم";
            // 
            // rentPricePerMonthLabel
            // 
            rentPricePerMonthLabel.AutoSize = true;
            rentPricePerMonthLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            rentPricePerMonthLabel.Location = new System.Drawing.Point(914, 570);
            rentPricePerMonthLabel.Margin = new System.Windows.Forms.Padding(5);
            rentPricePerMonthLabel.Name = "rentPricePerMonthLabel";
            rentPricePerMonthLabel.Size = new System.Drawing.Size(99, 26);
            rentPricePerMonthLabel.TabIndex = 12;
            rentPricePerMonthLabel.Text = ":الاجرة بالشهر";
            // 
            // rentPricePerYearLabel
            // 
            rentPricePerYearLabel.AutoSize = true;
            rentPricePerYearLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            rentPricePerYearLabel.Location = new System.Drawing.Point(914, 604);
            rentPricePerYearLabel.Margin = new System.Windows.Forms.Padding(5);
            rentPricePerYearLabel.Name = "rentPricePerYearLabel";
            rentPricePerYearLabel.Size = new System.Drawing.Size(99, 26);
            rentPricePerYearLabel.TabIndex = 14;
            rentPricePerYearLabel.Text = ":الاجرة بالسنة";
            // 
            // carPhotoLabel
            // 
            carPhotoLabel.AutoSize = true;
            carPhotoLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            carPhotoLabel.Location = new System.Drawing.Point(336, 264);
            carPhotoLabel.Name = "carPhotoLabel";
            carPhotoLabel.Size = new System.Drawing.Size(101, 26);
            carPhotoLabel.TabIndex = 16;
            carPhotoLabel.Text = ":صورة السيارة";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            infoLabel.Location = new System.Drawing.Point(914, 638);
            infoLabel.Margin = new System.Windows.Forms.Padding(5);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(116, 26);
            infoLabel.TabIndex = 18;
            infoLabel.Text = ":معلومت اضافية";
            // 
            // dateAddedLabel
            // 
            dateAddedLabel.AutoSize = true;
            dateAddedLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dateAddedLabel.Location = new System.Drawing.Point(619, 322);
            dateAddedLabel.Margin = new System.Windows.Forms.Padding(5);
            dateAddedLabel.Name = "dateAddedLabel";
            dateAddedLabel.Size = new System.Drawing.Size(97, 26);
            dateAddedLabel.TabIndex = 20;
            dateAddedLabel.Text = ":تاريخ الاضافة";
            // 
            // isVisableLabel
            // 
            isVisableLabel.AutoSize = true;
            isVisableLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            isVisableLabel.Location = new System.Drawing.Point(914, 452);
            isVisableLabel.Margin = new System.Windows.Forms.Padding(5);
            isVisableLabel.Name = "isVisableLabel";
            isVisableLabel.Size = new System.Drawing.Size(111, 26);
            isVisableLabel.TabIndex = 22;
            isVisableLabel.Text = ":معروضة للايجار";
            // 
            // bookedUpDateLabel
            // 
            bookedUpDateLabel.AutoSize = true;
            bookedUpDateLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            bookedUpDateLabel.Location = new System.Drawing.Point(619, 356);
            bookedUpDateLabel.Margin = new System.Windows.Forms.Padding(5);
            bookedUpDateLabel.Name = "bookedUpDateLabel";
            bookedUpDateLabel.Size = new System.Drawing.Size(81, 26);
            bookedUpDateLabel.TabIndex = 24;
            bookedUpDateLabel.Text = ":تاريخ الحجز";
            // 
            // endOfRentDateLabel
            // 
            endOfRentDateLabel.AutoSize = true;
            endOfRentDateLabel.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            endOfRentDateLabel.Location = new System.Drawing.Point(619, 390);
            endOfRentDateLabel.Margin = new System.Windows.Forms.Padding(5);
            endOfRentDateLabel.Name = "endOfRentDateLabel";
            endOfRentDateLabel.Size = new System.Drawing.Size(130, 26);
            endOfRentDateLabel.TabIndex = 26;
            endOfRentDateLabel.Text = ":موعد انتهاء الايجار";
            // 
            // carsForRentBindingNavigator
            // 
            this.carsForRentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carsForRentBindingNavigator.BindingSource = this.carsForRentBindingSource;
            this.carsForRentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carsForRentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carsForRentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.carsForRentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carsForRentBindingNavigatorSaveItem});
            this.carsForRentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carsForRentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carsForRentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carsForRentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carsForRentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carsForRentBindingNavigator.Name = "carsForRentBindingNavigator";
            this.carsForRentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carsForRentBindingNavigator.Size = new System.Drawing.Size(1059, 27);
            this.carsForRentBindingNavigator.TabIndex = 0;
            this.carsForRentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // carsForRentBindingSource
            // 
            this.carsForRentBindingSource.DataMember = "carsForRent";
            this.carsForRentBindingSource.DataSource = this.carDealershipDBDataSet;
            // 
            // carDealershipDBDataSet
            // 
            this.carDealershipDBDataSet.DataSetName = "carDealershipDBDataSet";
            this.carDealershipDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // carsForRentBindingNavigatorSaveItem
            // 
            this.carsForRentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carsForRentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carsForRentBindingNavigatorSaveItem.Image")));
            this.carsForRentBindingNavigatorSaveItem.Name = "carsForRentBindingNavigatorSaveItem";
            this.carsForRentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.carsForRentBindingNavigatorSaveItem.Text = "Save Data";
            this.carsForRentBindingNavigatorSaveItem.Click += new System.EventHandler(this.carsForRentBindingNavigatorSaveItem_Click);
            // 
            // carsForRentDataGridView
            // 
            this.carsForRentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsForRentDataGridView.AutoGenerateColumns = false;
            this.carsForRentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsForRentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.endOfRentDate,
            this.bookedUpDate});
            this.carsForRentDataGridView.DataSource = this.carsForRentBindingSource;
            this.carsForRentDataGridView.Location = new System.Drawing.Point(0, 30);
            this.carsForRentDataGridView.Name = "carsForRentDataGridView";
            this.carsForRentDataGridView.RowTemplate.Height = 26;
            this.carsForRentDataGridView.Size = new System.Drawing.Size(1059, 230);
            this.carsForRentDataGridView.TabIndex = 1;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn3.HeaderText = "model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "manufactureYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "manufactureYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "info";
            this.dataGridViewTextBoxColumn8.HeaderText = "info";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // endOfRentDate
            // 
            this.endOfRentDate.DataPropertyName = "endOfRentDate";
            this.endOfRentDate.HeaderText = "endOfRentDate";
            this.endOfRentDate.Name = "endOfRentDate";
            // 
            // bookedUpDate
            // 
            this.bookedUpDate.DataPropertyName = "bookedUpDate";
            this.bookedUpDate.HeaderText = "bookedUpDate";
            this.bookedUpDate.Name = "bookedUpDate";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameTextBox.Location = new System.Drawing.Point(769, 350);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(127, 31);
            this.nameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.idTextBox.Location = new System.Drawing.Point(769, 316);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(127, 31);
            this.idTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "model", true));
            this.modelTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.modelTextBox.Location = new System.Drawing.Point(769, 384);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(127, 31);
            this.modelTextBox.TabIndex = 7;
            // 
            // manufactureYearTextBox
            // 
            this.manufactureYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "manufactureYear", true));
            this.manufactureYearTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.manufactureYearTextBox.Location = new System.Drawing.Point(769, 418);
            this.manufactureYearTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.manufactureYearTextBox.Name = "manufactureYearTextBox";
            this.manufactureYearTextBox.Size = new System.Drawing.Size(127, 31);
            this.manufactureYearTextBox.TabIndex = 9;
            // 
            // rentPerDayTextBox
            // 
            this.rentPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "rentPerDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.rentPerDayTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rentPerDayTextBox.Location = new System.Drawing.Point(769, 531);
            this.rentPerDayTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.rentPerDayTextBox.Name = "rentPerDayTextBox";
            this.rentPerDayTextBox.Size = new System.Drawing.Size(127, 31);
            this.rentPerDayTextBox.TabIndex = 11;
            // 
            // rentPricePerMonthTextBox
            // 
            this.rentPricePerMonthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "rentPricePerMonth", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.rentPricePerMonthTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rentPricePerMonthTextBox.Location = new System.Drawing.Point(769, 565);
            this.rentPricePerMonthTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.rentPricePerMonthTextBox.Name = "rentPricePerMonthTextBox";
            this.rentPricePerMonthTextBox.Size = new System.Drawing.Size(127, 31);
            this.rentPricePerMonthTextBox.TabIndex = 13;
            // 
            // rentPricePerYearTextBox
            // 
            this.rentPricePerYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "rentPricePerYear", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.rentPricePerYearTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rentPricePerYearTextBox.Location = new System.Drawing.Point(769, 599);
            this.rentPricePerYearTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.rentPricePerYearTextBox.Name = "rentPricePerYearTextBox";
            this.rentPricePerYearTextBox.Size = new System.Drawing.Size(127, 31);
            this.rentPricePerYearTextBox.TabIndex = 15;
            // 
            // carPhotoPictureBox
            // 
            this.carPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.carsForRentBindingSource, "carPhoto", true));
            this.carPhotoPictureBox.Location = new System.Drawing.Point(12, 293);
            this.carPhotoPictureBox.Name = "carPhotoPictureBox";
            this.carPhotoPictureBox.Size = new System.Drawing.Size(425, 382);
            this.carPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPhotoPictureBox.TabIndex = 17;
            this.carPhotoPictureBox.TabStop = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsForRentBindingSource, "info", true));
            this.infoTextBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.infoTextBox.Location = new System.Drawing.Point(769, 633);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(127, 31);
            this.infoTextBox.TabIndex = 19;
            // 
            // dateAddedDateTimePicker
            // 
            this.dateAddedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsForRentBindingSource, "dateAdded", true));
            this.dateAddedDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateAddedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAddedDateTimePicker.Location = new System.Drawing.Point(475, 316);
            this.dateAddedDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.dateAddedDateTimePicker.Name = "dateAddedDateTimePicker";
            this.dateAddedDateTimePicker.Size = new System.Drawing.Size(127, 31);
            this.dateAddedDateTimePicker.TabIndex = 21;
            // 
            // isVisableCheckBox
            // 
            this.isVisableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.carsForRentBindingSource, "isVisable", true));
            this.isVisableCheckBox.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.isVisableCheckBox.Location = new System.Drawing.Point(872, 456);
            this.isVisableCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.isVisableCheckBox.Name = "isVisableCheckBox";
            this.isVisableCheckBox.Size = new System.Drawing.Size(24, 24);
            this.isVisableCheckBox.TabIndex = 23;
            this.isVisableCheckBox.UseVisualStyleBackColor = true;
            // 
            // bookedUpDateDateTimePicker
            // 
            this.bookedUpDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsForRentBindingSource, "bookedUpDate", true));
            this.bookedUpDateDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bookedUpDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bookedUpDateDateTimePicker.Location = new System.Drawing.Point(475, 350);
            this.bookedUpDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.bookedUpDateDateTimePicker.Name = "bookedUpDateDateTimePicker";
            this.bookedUpDateDateTimePicker.Size = new System.Drawing.Size(127, 31);
            this.bookedUpDateDateTimePicker.TabIndex = 25;
            // 
            // endOfRentDateDateTimePicker
            // 
            this.endOfRentDateDateTimePicker.CustomFormat = "تهتنا";
            this.endOfRentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsForRentBindingSource, "endOfRentDate", true));
            this.endOfRentDateDateTimePicker.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.endOfRentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endOfRentDateDateTimePicker.Location = new System.Drawing.Point(475, 384);
            this.endOfRentDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.endOfRentDateDateTimePicker.Name = "endOfRentDateDateTimePicker";
            this.endOfRentDateDateTimePicker.Size = new System.Drawing.Size(127, 31);
            this.endOfRentDateDateTimePicker.TabIndex = 27;
            this.endOfRentDateDateTimePicker.ValueChanged += new System.EventHandler(this.endOfRentDateDateTimePicker_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saveButton.Location = new System.Drawing.Point(464, 536);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 47);
            this.saveButton.TabIndex = 60;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateCarPicture
            // 
            this.updateCarPicture.BackColor = System.Drawing.SystemColors.Control;
            this.updateCarPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateCarPicture.BackgroundImage")));
            this.updateCarPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateCarPicture.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.updateCarPicture.FlatAppearance.BorderSize = 0;
            this.updateCarPicture.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.updateCarPicture.Location = new System.Drawing.Point(611, 536);
            this.updateCarPicture.Name = "updateCarPicture";
            this.updateCarPicture.Size = new System.Drawing.Size(138, 47);
            this.updateCarPicture.TabIndex = 61;
            this.updateCarPicture.Text = "رفع صورة السيارة";
            this.updateCarPicture.UseVisualStyleBackColor = false;
            this.updateCarPicture.Click += new System.EventHandler(this.updateCarPicture_Click);
            // 
            // carsForRentTableAdapter
            // 
            this.carsForRentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carsForRentTableAdapter = this.carsForRentTableAdapter;
            this.tableAdapterManager.carsForSaleTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = carDealershipProject.datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.Font = new System.Drawing.Font("PNU Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.closeButton.Location = new System.Drawing.Point(537, 589);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(138, 47);
            this.closeButton.TabIndex = 62;
            this.closeButton.Text = "إغلاق";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editForLeaseCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 704);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateCarPicture);
            this.Controls.Add(endOfRentDateLabel);
            this.Controls.Add(this.endOfRentDateDateTimePicker);
            this.Controls.Add(bookedUpDateLabel);
            this.Controls.Add(this.bookedUpDateDateTimePicker);
            this.Controls.Add(isVisableLabel);
            this.Controls.Add(this.isVisableCheckBox);
            this.Controls.Add(dateAddedLabel);
            this.Controls.Add(this.dateAddedDateTimePicker);
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
            this.Controls.Add(this.carsForRentDataGridView);
            this.Controls.Add(this.carsForRentBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editForLeaseCars";
            this.Text = "editForLeaseCars";
            this.Load += new System.EventHandler(this.editForLeaseCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsForRentBindingNavigator)).EndInit();
            this.carsForRentBindingNavigator.ResumeLayout(false);
            this.carsForRentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsForRentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsForRentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private datasets.carDealershipDBDataSet carDealershipDBDataSet;
        private System.Windows.Forms.BindingSource carsForRentBindingSource;
        private datasets.carDealershipDBDataSetTableAdapters.carsForRentTableAdapter carsForRentTableAdapter;
        private datasets.carDealershipDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carsForRentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carsForRentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView carsForRentDataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufactureYearTextBox;
        private System.Windows.Forms.TextBox rentPerDayTextBox;
        private System.Windows.Forms.TextBox rentPricePerMonthTextBox;
        private System.Windows.Forms.TextBox rentPricePerYearTextBox;
        private System.Windows.Forms.PictureBox carPhotoPictureBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.DateTimePicker dateAddedDateTimePicker;
        private System.Windows.Forms.CheckBox isVisableCheckBox;
        private System.Windows.Forms.DateTimePicker bookedUpDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endOfRentDateDateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateCarPicture;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn endOfRentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedUpDate;

    }
}