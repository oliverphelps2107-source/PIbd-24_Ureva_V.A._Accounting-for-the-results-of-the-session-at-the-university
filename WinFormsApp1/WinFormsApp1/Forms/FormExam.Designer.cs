namespace WinFormsApp1.Forms
{
    partial class FormExam
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxStudent = new ComboBox();
            comboBoxDiscipline = new ComboBox();
            comboBoxGrade = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(62, 63);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Студент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(62, 142);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 1;
            label2.Text = "Дисциплина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(62, 231);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Оценка";
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(237, 67);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(151, 28);
            comboBoxStudent.TabIndex = 3;
            // 
            // comboBoxDiscipline
            // 
            comboBoxDiscipline.FormattingEnabled = true;
            comboBoxDiscipline.Location = new Point(237, 142);
            comboBoxDiscipline.Name = "comboBoxDiscipline";
            comboBoxDiscipline.Size = new Size(151, 28);
            comboBoxDiscipline.TabIndex = 4;
            // 
            // comboBoxGrade
            // 
            comboBoxGrade.FormattingEnabled = true;
            comboBoxGrade.Location = new Point(237, 231);
            comboBoxGrade.Name = "comboBoxGrade";
            comboBoxGrade.Size = new Size(151, 28);
            comboBoxGrade.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.Location = new Point(117, 336);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10F);
            buttonCancel.Location = new Point(267, 336);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxGrade);
            Controls.Add(comboBoxDiscipline);
            Controls.Add(comboBoxStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormExam";
            Text = "FormExam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxStudent;
        private ComboBox comboBoxDiscipline;
        private ComboBox comboBoxGrade;
        private Button buttonSave;
        private Button buttonCancel;
    }
}