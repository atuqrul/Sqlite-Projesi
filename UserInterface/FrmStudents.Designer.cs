namespace UserInterface
{
    partial class FrmStudents
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MskNote2 = new System.Windows.Forms.MaskedTextBox();
            this.MskNote1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLesson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgStudents = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tmrList = new System.Windows.Forms.Timer(this.components);
            this.BtnBranch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBranch);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.MskNote2);
            this.groupBox1.Controls.Add(this.MskNote1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtLesson);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgisi    ";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(407, 128);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(65, 36);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(251, 128);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(111, 36);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(115, 128);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(91, 36);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // MskNote2
            // 
            this.MskNote2.Location = new System.Drawing.Point(510, 79);
            this.MskNote2.Mask = "000";
            this.MskNote2.Name = "MskNote2";
            this.MskNote2.Size = new System.Drawing.Size(40, 24);
            this.MskNote2.TabIndex = 6;
            this.MskNote2.ValidatingType = typeof(int);
            // 
            // MskNote1
            // 
            this.MskNote1.Location = new System.Drawing.Point(510, 38);
            this.MskNote1.Mask = "000";
            this.MskNote1.Name = "MskNote1";
            this.MskNote1.Size = new System.Drawing.Size(40, 24);
            this.MskNote1.TabIndex = 5;
            this.MskNote1.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "2. Sınav Notu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "1. Sınav Notu :";
            // 
            // TxtLesson
            // 
            this.TxtLesson.Location = new System.Drawing.Point(112, 79);
            this.TxtLesson.Name = "TxtLesson";
            this.TxtLesson.Size = new System.Drawing.Size(211, 24);
            this.TxtLesson.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(112, 35);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(211, 24);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgStudents);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 295);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Listesi   ";
            // 
            // DtgStudents
            // 
            this.DtgStudents.AllowUserToAddRows = false;
            this.DtgStudents.AllowUserToDeleteRows = false;
            this.DtgStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name_,
            this.Lesson,
            this.Note1,
            this.Note2,
            this.State});
            this.DtgStudents.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.DtgStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgStudents.Location = new System.Drawing.Point(3, 20);
            this.DtgStudents.MultiSelect = false;
            this.DtgStudents.Name = "DtgStudents";
            this.DtgStudents.ReadOnly = true;
            this.DtgStudents.RowHeadersVisible = false;
            this.DtgStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgStudents.Size = new System.Drawing.Size(614, 272);
            this.DtgStudents.TabIndex = 0;
            this.DtgStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgStudents_CellMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Ad Soyad";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // Lesson
            // 
            this.Lesson.HeaderText = "Ders";
            this.Lesson.Name = "Lesson";
            this.Lesson.ReadOnly = true;
            // 
            // Note1
            // 
            this.Note1.HeaderText = "1. Sınav Notu";
            this.Note1.Name = "Note1";
            this.Note1.ReadOnly = true;
            // 
            // Note2
            // 
            this.Note2.HeaderText = "2. Sınav Notu";
            this.Note2.Name = "Note2";
            this.Note2.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "Durum";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // tmrList
            // 
            this.tmrList.Interval = 60000;
            this.tmrList.Tick += new System.EventHandler(this.tmrList_Tick);
            // 
            // BtnBranch
            // 
            this.BtnBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBranch.Location = new System.Drawing.Point(522, 138);
            this.BtnBranch.Name = "BtnBranch";
            this.BtnBranch.Size = new System.Drawing.Size(91, 36);
            this.BtnBranch.TabIndex = 10;
            this.BtnBranch.Text = "Branşlar";
            this.BtnBranch.UseVisualStyleBackColor = true;
            this.BtnBranch.Click += new System.EventHandler(this.BtnBranch_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudents";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Paneli";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MskNote2;
        private System.Windows.Forms.MaskedTextBox MskNote1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLesson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn State;
        private System.Windows.Forms.Timer tmrList;
        private System.Windows.Forms.Button BtnBranch;
    }
}