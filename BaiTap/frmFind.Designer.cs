namespace BaiTap
{
    partial class frmFind
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
            gboxMethod = new GroupBox();
            rbtnID = new RadioButton();
            rbtnName = new RadioButton();
            rbtnClass = new RadioButton();
            tboxKey = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
            lbKey = new Label();
            gboxMethod.SuspendLayout();
            SuspendLayout();
            // 
            // gboxMethod
            // 
            gboxMethod.Controls.Add(rbtnClass);
            gboxMethod.Controls.Add(rbtnName);
            gboxMethod.Controls.Add(rbtnID);
            gboxMethod.Location = new Point(12, 12);
            gboxMethod.Name = "gboxMethod";
            gboxMethod.Size = new Size(167, 75);
            gboxMethod.TabIndex = 0;
            gboxMethod.TabStop = false;
            gboxMethod.Text = "Method";
            // 
            // rbtnID
            // 
            rbtnID.AutoSize = true;
            rbtnID.Checked = true;
            rbtnID.Location = new Point(21, 22);
            rbtnID.Name = "rbtnID";
            rbtnID.Size = new Size(36, 19);
            rbtnID.TabIndex = 0;
            rbtnID.TabStop = true;
            rbtnID.Text = "ID";
            rbtnID.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            rbtnName.AutoSize = true;
            rbtnName.Location = new Point(92, 22);
            rbtnName.Name = "rbtnName";
            rbtnName.Size = new Size(57, 19);
            rbtnName.TabIndex = 0;
            rbtnName.Text = "Name";
            rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnClass
            // 
            rbtnClass.AutoSize = true;
            rbtnClass.Location = new Point(21, 47);
            rbtnClass.Name = "rbtnClass";
            rbtnClass.Size = new Size(52, 19);
            rbtnClass.TabIndex = 0;
            rbtnClass.Text = "Class";
            rbtnClass.UseVisualStyleBackColor = true;
            // 
            // tboxKey
            // 
            tboxKey.Location = new Point(79, 93);
            tboxKey.Name = "tboxKey";
            tboxKey.Size = new Size(100, 23);
            tboxKey.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(23, 122);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(104, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.Location = new Point(14, 96);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(59, 15);
            lbKey.TabIndex = 3;
            lbKey.Text = "Keyword: ";
            // 
            // frmFind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 165);
            Controls.Add(lbKey);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(tboxKey);
            Controls.Add(gboxMethod);
            Name = "frmFind";
            Text = "Find";
            gboxMethod.ResumeLayout(false);
            gboxMethod.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxMethod;
        private RadioButton rbtnClass;
        private RadioButton rbtnName;
        private RadioButton rbtnID;
        private TextBox tboxKey;
        private Button btnApply;
        private Button btnCancel;
        private Label lbKey;
    }
}