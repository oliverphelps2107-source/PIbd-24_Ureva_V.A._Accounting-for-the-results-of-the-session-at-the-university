namespace WinFormsApp1.Forms
{
    partial class FormStudent
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
            textBoxFullName = new TextBox();
            numericUpDownGroupId = new NumericUpDown();
            checkedListBoxStatus = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGroupId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(170, 32);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "ФИО студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(191, 128);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "ID группы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(170, 221);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Статус(льготы)";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(170, 75);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(140, 27);
            textBoxFullName.TabIndex = 3;
            // 
            // numericUpDownGroupId
            // 
            numericUpDownGroupId.Location = new Point(170, 170);
            numericUpDownGroupId.Name = "numericUpDownGroupId";
            numericUpDownGroupId.Size = new Size(140, 27);
            numericUpDownGroupId.TabIndex = 4;
            // 
            // checkedListBoxStatus
            // 
            checkedListBoxStatus.FormattingEnabled = true;
            checkedListBoxStatus.Location = new Point(170, 261);
            checkedListBoxStatus.Name = "checkedListBoxStatus";
            checkedListBoxStatus.Size = new Size(140, 114);
            checkedListBoxStatus.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F);
            buttonSave.Location = new Point(116, 399);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 10F);
            buttonCancel.Location = new Point(261, 399);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxStatus);
            Controls.Add(numericUpDownGroupId);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormStudent";
            Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGroupId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFullName;
        private NumericUpDown numericUpDownGroupId;
        private CheckedListBox checkedListBoxStatus;
        private Button buttonSave;
        private Button buttonCancel;
    }
}