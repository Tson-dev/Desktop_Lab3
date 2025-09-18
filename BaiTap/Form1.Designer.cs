namespace BaiTap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtID = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            mtxtPresidentID = new MaskedTextBox();
            mtxtPhone = new MaskedTextBox();
            dtimeBirth = new DateTimePicker();
            cobxClass = new ComboBox();
            txtAddress = new TextBox();
            lcbxSelect = new CheckedListBox();
            lcbxSelec_cms = new ContextMenuStrip(components);
            lcbxSelec_cms_tsmiAdd = new ToolStripMenuItem();
            lcbxSelec_cms_tsmiRemove = new ToolStripMenuItem();
            lvwList = new ListView();
            colID = new ColumnHeader();
            colLName = new ColumnHeader();
            colFName = new ColumnHeader();
            colBirth = new ColumnHeader();
            colClass = new ColumnHeader();
            colPresidentID = new ColumnHeader();
            colPhone = new ColumnHeader();
            colAddress = new ColumnHeader();
            lvwList_cms = new ContextMenuStrip(components);
            lvwList_cms_tsmiRemove = new ToolStripMenuItem();
            btnFind = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            label1 = new Label();
            rcbxMale = new RadioButton();
            rcbxFemale = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            gbxList = new GroupBox();
            frmMain_ms = new MenuStrip();
            tsmiImport = new ToolStripMenuItem();
            tsmiImport_File = new ToolStripMenuItem();
            tsmiImport_Recent = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            tsmiExport_Json = new ToolStripMenuItem();
            tsmiExport_Xml = new ToolStripMenuItem();
            tsmiExport_Text = new ToolStripMenuItem();
            lcbxSelec_cms.SuspendLayout();
            lvwList_cms.SuspendLayout();
            gbxList.SuspendLayout();
            frmMain_ms.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(93, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 23);
            txtID.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(93, 69);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(200, 23);
            txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(413, 69);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(121, 23);
            txtFName.TabIndex = 5;
            // 
            // mtxtPresidentID
            // 
            mtxtPresidentID.Location = new Point(93, 127);
            mtxtPresidentID.Mask = "________";
            mtxtPresidentID.Name = "mtxtPresidentID";
            mtxtPresidentID.Size = new Size(200, 23);
            mtxtPresidentID.TabIndex = 8;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(413, 127);
            mtxtPhone.Mask = "0000-000-000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(121, 23);
            mtxtPhone.TabIndex = 9;
            // 
            // dtimeBirth
            // 
            dtimeBirth.CustomFormat = "dd/MM/yyyy";
            dtimeBirth.Format = DateTimePickerFormat.Custom;
            dtimeBirth.Location = new Point(93, 98);
            dtimeBirth.Name = "dtimeBirth";
            dtimeBirth.Size = new Size(200, 23);
            dtimeBirth.TabIndex = 6;
            // 
            // cobxClass
            // 
            cobxClass.FormattingEnabled = true;
            cobxClass.Location = new Point(413, 98);
            cobxClass.Name = "cobxClass";
            cobxClass.Size = new Size(121, 23);
            cobxClass.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(93, 156);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(441, 23);
            txtAddress.TabIndex = 10;
            // 
            // lcbxSelect
            // 
            lcbxSelect.ColumnWidth = 200;
            lcbxSelect.ContextMenuStrip = lcbxSelec_cms;
            lcbxSelect.FormattingEnabled = true;
            lcbxSelect.Items.AddRange(new object[] { "An toàn và bảo mật hệ thống", "Đồ án cơ sở", "Hệ Điều Hành", "Lập trình database", "Lập trình mạng", "Lập trinh trên thiết bị di động", "Mạng máy tính", "Phương pháp NCKH" });
            lcbxSelect.Location = new Point(17, 185);
            lcbxSelect.MultiColumn = true;
            lcbxSelect.Name = "lcbxSelect";
            lcbxSelect.RightToLeft = RightToLeft.No;
            lcbxSelect.Size = new Size(448, 76);
            lcbxSelect.Sorted = true;
            lcbxSelect.TabIndex = 11;
            // 
            // lcbxSelec_cms
            // 
            lcbxSelec_cms.Items.AddRange(new ToolStripItem[] { lcbxSelec_cms_tsmiAdd, lcbxSelec_cms_tsmiRemove });
            lcbxSelec_cms.Name = "lcbxSelec_mstp";
            lcbxSelec_cms.Size = new Size(118, 48);
            // 
            // lcbxSelec_cms_tsmiAdd
            // 
            lcbxSelec_cms_tsmiAdd.Name = "lcbxSelec_cms_tsmiAdd";
            lcbxSelec_cms_tsmiAdd.Size = new Size(117, 22);
            lcbxSelec_cms_tsmiAdd.Text = "Add";
            // 
            // lcbxSelec_cms_tsmiRemove
            // 
            lcbxSelec_cms_tsmiRemove.Name = "lcbxSelec_cms_tsmiRemove";
            lcbxSelec_cms_tsmiRemove.Size = new Size(117, 22);
            lcbxSelec_cms_tsmiRemove.Text = "Remove";
            // 
            // lvwList
            // 
            lvwList.Columns.AddRange(new ColumnHeader[] { colID, colLName, colFName, colBirth, colClass, colPresidentID, colPhone, colAddress });
            lvwList.ContextMenuStrip = lvwList_cms;
            lvwList.Dock = DockStyle.Fill;
            lvwList.Location = new Point(3, 19);
            lvwList.Name = "lvwList";
            lvwList.Size = new Size(597, 135);
            lvwList.TabIndex = 6;
            lvwList.UseCompatibleStateImageBehavior = false;
            lvwList.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 40;
            // 
            // colLName
            // 
            colLName.Text = "Last Name";
            colLName.Width = 100;
            // 
            // colFName
            // 
            colFName.Text = "Name";
            // 
            // colBirth
            // 
            colBirth.Text = "Birth";
            colBirth.Width = 100;
            // 
            // colClass
            // 
            colClass.Text = "Class";
            // 
            // colPresidentID
            // 
            colPresidentID.Text = "President ID";
            colPresidentID.Width = 80;
            // 
            // colPhone
            // 
            colPhone.Text = "Phone Number";
            colPhone.Width = 100;
            // 
            // colAddress
            // 
            colAddress.Text = "Address";
            colAddress.Width = 100;
            // 
            // lvwList_cms
            // 
            lvwList_cms.Items.AddRange(new ToolStripItem[] { lvwList_cms_tsmiRemove });
            lvwList_cms.Name = "contextMenuStrip1";
            lvwList_cms.Size = new Size(118, 26);
            // 
            // lvwList_cms_tsmiRemove
            // 
            lvwList_cms_tsmiRemove.Name = "lvwList_cms_tsmiRemove";
            lvwList_cms_tsmiRemove.Size = new Size(117, 22);
            lvwList_cms_tsmiRemove.Text = "Remove";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(214, 267);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 12;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(297, 267);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(378, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(459, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 48);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 8;
            label1.Text = "ID:";
            // 
            // rcbxMale
            // 
            rcbxMale.AutoSize = true;
            rcbxMale.Checked = true;
            rcbxMale.Location = new Point(413, 40);
            rcbxMale.Name = "rcbxMale";
            rcbxMale.Size = new Size(51, 19);
            rcbxMale.TabIndex = 2;
            rcbxMale.TabStop = true;
            rcbxMale.Text = "Male";
            rcbxMale.UseVisualStyleBackColor = true;
            // 
            // rcbxFemale
            // 
            rcbxFemale.AutoSize = true;
            rcbxFemale.Location = new Point(492, 41);
            rcbxFemale.Name = "rcbxFemale";
            rcbxFemale.Size = new Size(63, 19);
            rcbxFemale.TabIndex = 3;
            rcbxFemale.Text = "Female";
            rcbxFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 135);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "President ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 164);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 135);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 8;
            label6.Text = "Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 106);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 8;
            label7.Text = "Class";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 77);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 8;
            label8.Text = "Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 48);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 8;
            label9.Text = "Sex:";
            // 
            // gbxList
            // 
            gbxList.Controls.Add(lvwList);
            gbxList.Dock = DockStyle.Bottom;
            gbxList.Location = new Point(0, 307);
            gbxList.Name = "gbxList";
            gbxList.Size = new Size(603, 157);
            gbxList.TabIndex = 11;
            gbxList.TabStop = false;
            gbxList.Text = "List";
            // 
            // frmMain_ms
            // 
            frmMain_ms.Items.AddRange(new ToolStripItem[] { tsmiImport, exportToolStripMenuItem });
            frmMain_ms.Location = new Point(0, 0);
            frmMain_ms.Name = "frmMain_ms";
            frmMain_ms.Size = new Size(603, 24);
            frmMain_ms.TabIndex = 0;
            frmMain_ms.Text = "menuStrip1";
            // 
            // tsmiImport
            // 
            tsmiImport.DropDownItems.AddRange(new ToolStripItem[] { tsmiImport_File, tsmiImport_Recent });
            tsmiImport.Name = "tsmiImport";
            tsmiImport.Size = new Size(55, 20);
            tsmiImport.Text = "Import";
            // 
            // tsmiImport_File
            // 
            tsmiImport_File.Name = "tsmiImport_File";
            tsmiImport_File.Size = new Size(110, 22);
            tsmiImport_File.Text = "File";
            tsmiImport_File.Click += tsmiImport_File_Click;
            // 
            // tsmiImport_Recent
            // 
            tsmiImport_Recent.Name = "tsmiImport_Recent";
            tsmiImport_Recent.Size = new Size(110, 22);
            tsmiImport_Recent.Text = "Recent";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiExport_Json, tsmiExport_Xml, tsmiExport_Text });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(52, 20);
            exportToolStripMenuItem.Text = "Export";
            // 
            // tsmiExport_Json
            // 
            tsmiExport_Json.Name = "tsmiExport_Json";
            tsmiExport_Json.Size = new Size(118, 22);
            tsmiExport_Json.Text = "Json File";
            tsmiExport_Json.Click += tsmiExport_Json_Click;
            // 
            // tsmiExport_Xml
            // 
            tsmiExport_Xml.Name = "tsmiExport_Xml";
            tsmiExport_Xml.Size = new Size(118, 22);
            tsmiExport_Xml.Text = "Xml File";
            tsmiExport_Xml.Click += tsmiExport_Xml_Click;
            // 
            // tsmiExport_Text
            // 
            tsmiExport_Text.Name = "tsmiExport_Text";
            tsmiExport_Text.Size = new Size(118, 22);
            tsmiExport_Text.Text = "Text File";
            tsmiExport_Text.Click += tsmiExport_Text_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 464);
            Controls.Add(frmMain_ms);
            Controls.Add(gbxList);
            Controls.Add(rcbxFemale);
            Controls.Add(rcbxMale);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnFind);
            Controls.Add(lcbxSelect);
            Controls.Add(txtAddress);
            Controls.Add(cobxClass);
            Controls.Add(dtimeBirth);
            Controls.Add(mtxtPhone);
            Controls.Add(mtxtPresidentID);
            Controls.Add(txtFName);
            Controls.Add(txtLName);
            Controls.Add(txtID);
            MainMenuStrip = frmMain_ms;
            Name = "Form1";
            Text = "Main";
            Load += Form1_Load;
            lcbxSelec_cms.ResumeLayout(false);
            lvwList_cms.ResumeLayout(false);
            gbxList.ResumeLayout(false);
            frmMain_ms.ResumeLayout(false);
            frmMain_ms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtLName;
        private TextBox txtFName;
        private MaskedTextBox mtxtPresidentID;
        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtimeBirth;
        private ComboBox cobxClass;
        private TextBox txtAddress;
        private CheckedListBox lcbxSelect;
        private ListView lvwList;
        private Button btnFind;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnExit;
        private Label label1;
        private RadioButton rcbxMale;
        private RadioButton rcbxFemale;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ColumnHeader colID;
        private ColumnHeader colLName;
        private ColumnHeader colFName;
        private ColumnHeader colBirth;
        private ColumnHeader colClass;
        private ColumnHeader colPresidentID;
        private ColumnHeader colPhone;
        private ColumnHeader colAddress;
        private ContextMenuStrip lcbxSelec_cms;
        private ToolStripMenuItem lcbxSelec_cms_tsmiAdd;
        private ToolStripMenuItem lcbxSelec_cms_tsmiRemove;
        private GroupBox gbxList;
        private MenuStrip frmMain_ms;
        private ToolStripMenuItem tsmiImport;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem tsmiImport_File;
        private ToolStripMenuItem tsmiImport_Recent;
        private ToolStripMenuItem tsmiExport_Json;
        private ToolStripMenuItem tsmiExport_Xml;
        private ToolStripMenuItem tsmiExport_Text;
        private ContextMenuStrip lvwList_cms;
        private ToolStripMenuItem lvwList_cms_tsmiRemove;
    }
}
