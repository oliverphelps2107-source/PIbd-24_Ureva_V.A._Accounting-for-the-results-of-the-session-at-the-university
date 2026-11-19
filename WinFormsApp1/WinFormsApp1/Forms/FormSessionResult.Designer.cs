namespace WinFormsApp1.Forms
{
    partial class FormSessionResult
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
            numericUpDownAverageGrade = new NumericUpDown();
            numericUpDownScholarship = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAverageGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScholarship).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(48, 81);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Студент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 166);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 1;
            label2.Text = "Средний балл";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(48, 262);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Стипендия";
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(236, 81);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(151, 28);
            comboBoxStudent.TabIndex = 3;
            // 
            // numericUpDownAverageGrade
            // 
            numericUpDownAverageGrade.DecimalPlaces = 2;
            numericUpDownAverageGrade.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownAverageGrade.Location = new Point(237, 166);
            numericUpDownAverageGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownAverageGrade.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownAverageGrade.Name = "numericUpDownAverageGrade";
            numericUpDownAverageGrade.Size = new Size(150, 27);
            numericUpDownAverageGrade.TabIndex = 4;
            numericUpDownAverageGrade.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numericUpDownScholarship
            // 
            numericUpDownScholarship.Location = new Point(237, 263);
            numericUpDownScholarship.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownScholarship.Name = "numericUpDownScholarship";
            numericUpDownScholarship.Size = new Size(150, 27);
            numericUpDownScholarship.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.Location = new Point(130, 362);
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
            buttonCancel.Location = new Point(282, 361);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormSessionResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownScholarship);
            Controls.Add(numericUpDownAverageGrade);
            Controls.Add(comboBoxStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSessionResult";
            Text = "FormSessionResult";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAverageGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScholarship).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxStudent;
        private NumericUpDown numericUpDownAverageGrade;
        private NumericUpDown numericUpDownScholarship;
        private Button buttonSave;
        private Button buttonCancel;
    }
}