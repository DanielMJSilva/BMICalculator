
namespace Daniel_MachadoJustoDaSilva_Ex_01
{
    partial class FormFilterCategory
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
            this.labelWeight = new System.Windows.Forms.Label();
            this.buttonCalculateImperial = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelHeightParam = new System.Windows.Forms.Label();
            this.labelWeightParam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.comboBoxFeet = new System.Windows.Forms.ComboBox();
            this.comboBoxInch = new System.Windows.Forms.ComboBox();
            this.labelFeet = new System.Windows.Forms.Label();
            this.labelInch = new System.Windows.Forms.Label();
            this.textBoxPounds = new System.Windows.Forms.TextBox();
            this.labelPound = new System.Windows.Forms.Label();
            this.linkLabelReadMe = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMetric = new System.Windows.Forms.TabPage();
            this.labelBMIMet = new System.Windows.Forms.Label();
            this.buttonCalculateMetric = new System.Windows.Forms.Button();
            this.tabPageImperial = new System.Windows.Forms.TabPage();
            this.labelBMIImp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textBoxPrint = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.radioButtonJSON = new System.Windows.Forms.RadioButton();
            this.radioButtonXML = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUnder = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.labelOver = new System.Windows.Forms.Label();
            this.labelObesity = new System.Windows.Forms.Label();
            this.labelFilterSex = new System.Windows.Forms.Label();
            this.labelFilterName = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.labelFilterCategory = new System.Windows.Forms.Label();
            this.labelFilterAge = new System.Windows.Forms.Label();
            this.textBoxFilterAge = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonFilterClear = new System.Windows.Forms.Button();
            this.comboBoxFilterAge = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.checkBoxFilterMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterFemale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMetric.SuspendLayout();
            this.tabPageImperial.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxSex.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(16, 55);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Weight";
            // 
            // buttonCalculateImperial
            // 
            this.buttonCalculateImperial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalculateImperial.Location = new System.Drawing.Point(267, 11);
            this.buttonCalculateImperial.Name = "buttonCalculateImperial";
            this.buttonCalculateImperial.Size = new System.Drawing.Size(69, 98);
            this.buttonCalculateImperial.TabIndex = 2;
            this.buttonCalculateImperial.Text = "Calculate";
            this.buttonCalculateImperial.UseVisualStyleBackColor = false;
            this.buttonCalculateImperial.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(63, 22);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(63, 20);
            this.textBoxHeight.TabIndex = 5;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(63, 52);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(63, 20);
            this.textBoxWeight.TabIndex = 6;
            // 
            // labelHeightParam
            // 
            this.labelHeightParam.AutoSize = true;
            this.labelHeightParam.Location = new System.Drawing.Point(132, 25);
            this.labelHeightParam.Name = "labelHeightParam";
            this.labelHeightParam.Size = new System.Drawing.Size(21, 13);
            this.labelHeightParam.TabIndex = 7;
            this.labelHeightParam.Text = "cm";
            // 
            // labelWeightParam
            // 
            this.labelWeightParam.AutoSize = true;
            this.labelWeightParam.Location = new System.Drawing.Point(132, 55);
            this.labelWeightParam.Name = "labelWeightParam";
            this.labelWeightParam.Size = new System.Drawing.Size(19, 13);
            this.labelWeightParam.TabIndex = 8;
            this.labelWeightParam.Text = "kg";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 147);
            this.dataGridView1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(170, 45);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(50, 13);
            this.labelBirthDay.TabIndex = 15;
            this.labelBirthDay.Text = "Birth Day";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(370, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Location = new System.Drawing.Point(16, 25);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(38, 13);
            this.LabelHeight.TabIndex = 17;
            this.LabelHeight.Text = "Height";
            // 
            // comboBoxFeet
            // 
            this.comboBoxFeet.FormattingEnabled = true;
            this.comboBoxFeet.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxFeet.Location = new System.Drawing.Point(59, 24);
            this.comboBoxFeet.Name = "comboBoxFeet";
            this.comboBoxFeet.Size = new System.Drawing.Size(42, 21);
            this.comboBoxFeet.TabIndex = 18;
            // 
            // comboBoxInch
            // 
            this.comboBoxInch.FormattingEnabled = true;
            this.comboBoxInch.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBoxInch.Location = new System.Drawing.Point(138, 24);
            this.comboBoxInch.Name = "comboBoxInch";
            this.comboBoxInch.Size = new System.Drawing.Size(59, 21);
            this.comboBoxInch.TabIndex = 19;
            // 
            // labelFeet
            // 
            this.labelFeet.AutoSize = true;
            this.labelFeet.Location = new System.Drawing.Point(107, 28);
            this.labelFeet.Name = "labelFeet";
            this.labelFeet.Size = new System.Drawing.Size(25, 13);
            this.labelFeet.TabIndex = 20;
            this.labelFeet.Text = "feet";
            // 
            // labelInch
            // 
            this.labelInch.AutoSize = true;
            this.labelInch.Location = new System.Drawing.Point(203, 27);
            this.labelInch.Name = "labelInch";
            this.labelInch.Size = new System.Drawing.Size(45, 13);
            this.labelInch.TabIndex = 21;
            this.labelInch.Text = "Inch(es)";
            // 
            // textBoxPounds
            // 
            this.textBoxPounds.Location = new System.Drawing.Point(59, 51);
            this.textBoxPounds.Name = "textBoxPounds";
            this.textBoxPounds.Size = new System.Drawing.Size(100, 20);
            this.textBoxPounds.TabIndex = 22;
            // 
            // labelPound
            // 
            this.labelPound.AutoSize = true;
            this.labelPound.Location = new System.Drawing.Point(165, 54);
            this.labelPound.Name = "labelPound";
            this.labelPound.Size = new System.Drawing.Size(42, 13);
            this.labelPound.TabIndex = 23;
            this.labelPound.Text = "pounds";
            // 
            // linkLabelReadMe
            // 
            this.linkLabelReadMe.AutoSize = true;
            this.linkLabelReadMe.Location = new System.Drawing.Point(20, 492);
            this.linkLabelReadMe.Name = "linkLabelReadMe";
            this.linkLabelReadMe.Size = new System.Drawing.Size(98, 13);
            this.linkLabelReadMe.TabIndex = 25;
            this.linkLabelReadMe.TabStop = true;
            this.linkLabelReadMe.Text = "Open README file";
            this.linkLabelReadMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMetric);
            this.tabControl.Controls.Add(this.tabPageImperial);
            this.tabControl.Location = new System.Drawing.Point(6, 74);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(347, 141);
            this.tabControl.TabIndex = 26;
            // 
            // tabPageMetric
            // 
            this.tabPageMetric.Controls.Add(this.labelBMIMet);
            this.tabPageMetric.Controls.Add(this.buttonCalculateMetric);
            this.tabPageMetric.Controls.Add(this.textBoxWeight);
            this.tabPageMetric.Controls.Add(this.labelWeight);
            this.tabPageMetric.Controls.Add(this.textBoxHeight);
            this.tabPageMetric.Controls.Add(this.labelHeightParam);
            this.tabPageMetric.Controls.Add(this.labelWeightParam);
            this.tabPageMetric.Controls.Add(this.LabelHeight);
            this.tabPageMetric.Location = new System.Drawing.Point(4, 22);
            this.tabPageMetric.Name = "tabPageMetric";
            this.tabPageMetric.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMetric.Size = new System.Drawing.Size(339, 115);
            this.tabPageMetric.TabIndex = 0;
            this.tabPageMetric.Text = "Metric";
            this.tabPageMetric.UseVisualStyleBackColor = true;
            // 
            // labelBMIMet
            // 
            this.labelBMIMet.AutoSize = true;
            this.labelBMIMet.Location = new System.Drawing.Point(60, 96);
            this.labelBMIMet.Name = "labelBMIMet";
            this.labelBMIMet.Size = new System.Drawing.Size(0, 13);
            this.labelBMIMet.TabIndex = 37;
            // 
            // buttonCalculateMetric
            // 
            this.buttonCalculateMetric.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalculateMetric.Location = new System.Drawing.Point(267, 11);
            this.buttonCalculateMetric.Name = "buttonCalculateMetric";
            this.buttonCalculateMetric.Size = new System.Drawing.Size(69, 98);
            this.buttonCalculateMetric.TabIndex = 36;
            this.buttonCalculateMetric.Text = "Calculate";
            this.buttonCalculateMetric.UseVisualStyleBackColor = false;
            this.buttonCalculateMetric.Click += new System.EventHandler(this.buttonCalculateMetric_Click);
            // 
            // tabPageImperial
            // 
            this.tabPageImperial.Controls.Add(this.labelBMIImp);
            this.tabPageImperial.Controls.Add(this.label1);
            this.tabPageImperial.Controls.Add(this.label2);
            this.tabPageImperial.Controls.Add(this.textBoxPounds);
            this.tabPageImperial.Controls.Add(this.comboBoxFeet);
            this.tabPageImperial.Controls.Add(this.comboBoxInch);
            this.tabPageImperial.Controls.Add(this.labelPound);
            this.tabPageImperial.Controls.Add(this.labelFeet);
            this.tabPageImperial.Controls.Add(this.labelInch);
            this.tabPageImperial.Controls.Add(this.buttonCalculateImperial);
            this.tabPageImperial.Location = new System.Drawing.Point(4, 22);
            this.tabPageImperial.Name = "tabPageImperial";
            this.tabPageImperial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImperial.Size = new System.Drawing.Size(339, 115);
            this.tabPageImperial.TabIndex = 1;
            this.tabPageImperial.Text = "Imperial";
            this.tabPageImperial.UseVisualStyleBackColor = true;
            // 
            // labelBMIImp
            // 
            this.labelBMIImp.AutoSize = true;
            this.labelBMIImp.Location = new System.Drawing.Point(59, 95);
            this.labelBMIImp.Name = "labelBMIImp";
            this.labelBMIImp.Size = new System.Drawing.Size(0, 13);
            this.labelBMIImp.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Height";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonPrint);
            this.flowLayoutPanel1.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 242);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 80);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(3, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(276, 40);
            this.buttonPrint.TabIndex = 36;
            this.buttonPrint.Text = "Print Info";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(3, 49);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 23);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(97, 49);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(191, 49);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(84, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.Location = new System.Drawing.Point(6, 33);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(160, 35);
            this.groupBoxSex.TabIndex = 28;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Sex";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(84, 12);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(30, 12);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // textBoxPrint
            // 
            this.textBoxPrint.Location = new System.Drawing.Point(18, 328);
            this.textBoxPrint.Multiline = true;
            this.textBoxPrint.Name = "textBoxPrint";
            this.textBoxPrint.Size = new System.Drawing.Size(405, 147);
            this.textBoxPrint.TabIndex = 26;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonUpdate);
            this.flowLayoutPanel2.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(477, 291);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(162, 28);
            this.flowLayoutPanel2.TabIndex = 36;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(807, 244);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(103, 78);
            this.buttonExport.TabIndex = 37;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // radioButtonJSON
            // 
            this.radioButtonJSON.AutoSize = true;
            this.radioButtonJSON.Location = new System.Drawing.Point(6, 19);
            this.radioButtonJSON.Name = "radioButtonJSON";
            this.radioButtonJSON.Size = new System.Drawing.Size(53, 17);
            this.radioButtonJSON.TabIndex = 38;
            this.radioButtonJSON.Text = "JSON";
            this.radioButtonJSON.UseVisualStyleBackColor = true;
            this.radioButtonJSON.CheckedChanged += new System.EventHandler(this.radioButtonJSON_CheckedChanged);
            // 
            // radioButtonXML
            // 
            this.radioButtonXML.AutoSize = true;
            this.radioButtonXML.Location = new System.Drawing.Point(6, 42);
            this.radioButtonXML.Name = "radioButtonXML";
            this.radioButtonXML.Size = new System.Drawing.Size(47, 17);
            this.radioButtonXML.TabIndex = 39;
            this.radioButtonXML.Text = "XML";
            this.radioButtonXML.UseVisualStyleBackColor = true;
            this.radioButtonXML.CheckedChanged += new System.EventHandler(this.radioButtonXML_CheckedChanged);
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Checked = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(6, 65);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTXT.TabIndex = 40;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            this.radioButtonTXT.CheckedChanged += new System.EventHandler(this.radioButtonTXT_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonJSON);
            this.groupBox1.Controls.Add(this.radioButtonTXT);
            this.groupBox1.Controls.Add(this.radioButtonXML);
            this.groupBox1.Location = new System.Drawing.Point(916, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(61, 84);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // labelUnder
            // 
            this.labelUnder.AutoSize = true;
            this.labelUnder.Location = new System.Drawing.Point(351, 105);
            this.labelUnder.Name = "labelUnder";
            this.labelUnder.Size = new System.Drawing.Size(133, 13);
            this.labelUnder.TabIndex = 42;
            this.labelUnder.Text = "Underweight = 18.5 or less";
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(351, 128);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(139, 13);
            this.labelNormal.TabIndex = 43;
            this.labelNormal.Text = "Normal weight = 18.5 – 24.9";
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.Location = new System.Drawing.Point(351, 152);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(117, 13);
            this.labelOver.TabIndex = 44;
            this.labelOver.Text = "Overweight = 25 – 29.9";
            // 
            // labelObesity
            // 
            this.labelObesity.AutoSize = true;
            this.labelObesity.Location = new System.Drawing.Point(351, 176);
            this.labelObesity.Name = "labelObesity";
            this.labelObesity.Size = new System.Drawing.Size(114, 13);
            this.labelObesity.TabIndex = 45;
            this.labelObesity.Text = "Obesity = 30 or greater";
            // 
            // labelFilterSex
            // 
            this.labelFilterSex.AutoSize = true;
            this.labelFilterSex.Location = new System.Drawing.Point(525, 47);
            this.labelFilterSex.Name = "labelFilterSex";
            this.labelFilterSex.Size = new System.Drawing.Size(25, 13);
            this.labelFilterSex.TabIndex = 47;
            this.labelFilterSex.Text = "Sex";
            // 
            // labelFilterName
            // 
            this.labelFilterName.AutoSize = true;
            this.labelFilterName.Location = new System.Drawing.Point(515, 15);
            this.labelFilterName.Name = "labelFilterName";
            this.labelFilterName.Size = new System.Drawing.Size(35, 13);
            this.labelFilterName.TabIndex = 49;
            this.labelFilterName.Text = "Name";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Location = new System.Drawing.Point(569, 12);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterName.TabIndex = 48;
            // 
            // labelFilterCategory
            // 
            this.labelFilterCategory.AutoSize = true;
            this.labelFilterCategory.Location = new System.Drawing.Point(707, 47);
            this.labelFilterCategory.Name = "labelFilterCategory";
            this.labelFilterCategory.Size = new System.Drawing.Size(49, 13);
            this.labelFilterCategory.TabIndex = 51;
            this.labelFilterCategory.Text = "Category";
            // 
            // labelFilterAge
            // 
            this.labelFilterAge.AutoSize = true;
            this.labelFilterAge.Location = new System.Drawing.Point(707, 15);
            this.labelFilterAge.Name = "labelFilterAge";
            this.labelFilterAge.Size = new System.Drawing.Size(26, 13);
            this.labelFilterAge.TabIndex = 53;
            this.labelFilterAge.Text = "Age";
            // 
            // textBoxFilterAge
            // 
            this.textBoxFilterAge.Location = new System.Drawing.Point(739, 12);
            this.textBoxFilterAge.Name = "textBoxFilterAge";
            this.textBoxFilterAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterAge.TabIndex = 55;
            //this.textBoxFilterAge.TextChanged += new System.EventHandler(this.textBoxFilterWeight_TextChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(787, 74);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(99, 28);
            this.buttonFilter.TabIndex = 56;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonFilterClear
            // 
            this.buttonFilterClear.Location = new System.Drawing.Point(892, 74);
            this.buttonFilterClear.Name = "buttonFilterClear";
            this.buttonFilterClear.Size = new System.Drawing.Size(77, 27);
            this.buttonFilterClear.TabIndex = 57;
            this.buttonFilterClear.Text = "Clear";
            this.buttonFilterClear.UseVisualStyleBackColor = true;
            this.buttonFilterClear.Click += new System.EventHandler(this.buttonFilterClear_Click);
            // 
            // comboBoxFilterAge
            // 
            this.comboBoxFilterAge.FormattingEnabled = true;
            this.comboBoxFilterAge.Items.AddRange(new object[] {
            "equals to",
            "equal or greater than",
            "less than"});
            this.comboBoxFilterAge.Location = new System.Drawing.Point(845, 12);
            this.comboBoxFilterAge.Name = "comboBoxFilterAge";
            this.comboBoxFilterAge.Size = new System.Drawing.Size(123, 21);
            this.comboBoxFilterAge.TabIndex = 58;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Obesity",
            "Underweight",
            "Overweight",
            "Normal"});
            this.comboBoxCategory.Location = new System.Drawing.Point(762, 42);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(206, 21);
            this.comboBoxCategory.TabIndex = 59;
            // 
            // checkBoxFilterMale
            // 
            this.checkBoxFilterMale.AutoSize = true;
            this.checkBoxFilterMale.Location = new System.Drawing.Point(561, 45);
            this.checkBoxFilterMale.Name = "checkBoxFilterMale";
            this.checkBoxFilterMale.Size = new System.Drawing.Size(49, 17);
            this.checkBoxFilterMale.TabIndex = 60;
            this.checkBoxFilterMale.Text = "Male";
            this.checkBoxFilterMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterFemale
            // 
            this.checkBoxFilterFemale.AutoSize = true;
            this.checkBoxFilterFemale.Location = new System.Drawing.Point(616, 45);
            this.checkBoxFilterFemale.Name = "checkBoxFilterFemale";
            this.checkBoxFilterFemale.Size = new System.Drawing.Size(60, 17);
            this.checkBoxFilterFemale.TabIndex = 61;
            this.checkBoxFilterFemale.Text = "Female";
            this.checkBoxFilterFemale.UseVisualStyleBackColor = true;
            // 
            // FormFilterCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 517);
            this.Controls.Add(this.checkBoxFilterFemale);
            this.Controls.Add(this.checkBoxFilterMale);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxFilterAge);
            this.Controls.Add(this.buttonFilterClear);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxFilterAge);
            this.Controls.Add(this.labelFilterAge);
            this.Controls.Add(this.labelFilterCategory);
            this.Controls.Add(this.labelFilterName);
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.labelFilterSex);
            this.Controls.Add(this.labelObesity);
            this.Controls.Add(this.labelOver);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.labelUnder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.textBoxPrint);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.linkLabelReadMe);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFilterCategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMetric.ResumeLayout(false);
            this.tabPageMetric.PerformLayout();
            this.tabPageImperial.ResumeLayout(false);
            this.tabPageImperial.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button buttonCalculateImperial;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelHeightParam;
        private System.Windows.Forms.Label labelWeightParam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.ComboBox comboBoxFeet;
        private System.Windows.Forms.ComboBox comboBoxInch;
        private System.Windows.Forms.Label labelFeet;
        private System.Windows.Forms.Label labelInch;
        private System.Windows.Forms.TextBox textBoxPounds;
        private System.Windows.Forms.Label labelPound;
        private System.Windows.Forms.LinkLabel linkLabelReadMe;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMetric;
        private System.Windows.Forms.TabPage tabPageImperial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button buttonCalculateMetric;
        private System.Windows.Forms.TextBox textBoxPrint;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelBMIImp;
        private System.Windows.Forms.Label labelBMIMet;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.RadioButton radioButtonJSON;
        private System.Windows.Forms.RadioButton radioButtonXML;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelUnder;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label labelObesity;
        private System.Windows.Forms.Label labelFilterSex;
        private System.Windows.Forms.Label labelFilterName;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Label labelFilterCategory;
        private System.Windows.Forms.Label labelFilterAge;
        private System.Windows.Forms.TextBox textBoxFilterAge;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonFilterClear;
        private System.Windows.Forms.ComboBox comboBoxFilterAge;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxFilterMale;
        private System.Windows.Forms.CheckBox checkBoxFilterFemale;
    }
}

