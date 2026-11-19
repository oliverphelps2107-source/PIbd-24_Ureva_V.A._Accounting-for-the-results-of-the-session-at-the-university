namespace WinFormsApp1.Forms
{
    partial class FormGroup
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
            textBoxNumber = new TextBox();
            numericUpDownDepartmentId = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartmentId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(160, 69);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "Номер группы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(172, 214);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "ID кафедры";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(172, 138);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 2;
            // 
            // numericUpDownDepartmentId
            // 
            numericUpDownDepartmentId.Location = new Point(157, 273);
            numericUpDownDepartmentId.Name = "numericUpDownDepartmentId";
            numericUpDownDepartmentId.Size = new Size(150, 27);
            numericUpDownDepartmentId.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.Location = new Point(82, 341);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(116, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10F);
            buttonCancel.Location = new Point(269, 341);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(116, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownDepartmentId);
            Controls.Add(textBoxNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormGroup";
            Text = "FormGroup";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartmentId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNumber;
        private NumericUpDown numericUpDownDepartmentId;
        private Button buttonSave;
        private Button buttonCancel;
    }
}