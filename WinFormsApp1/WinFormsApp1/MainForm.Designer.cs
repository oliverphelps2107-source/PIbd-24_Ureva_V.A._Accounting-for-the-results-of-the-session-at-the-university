namespace WinFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            facultyToolStripMenuItem = new ToolStripMenuItem();
            groupToolStripMenuItem = new ToolStripMenuItem();
            disciplineToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            examToolStripMenuItem = new ToolStripMenuItem();
            sessionResultToolStripMenuItem = new ToolStripMenuItem();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчётыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { departmentToolStripMenuItem, facultyToolStripMenuItem, groupToolStripMenuItem, disciplineToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(117, 24);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(224, 26);
            departmentToolStripMenuItem.Text = "Кафедры";
            departmentToolStripMenuItem.Click += departmentToolStripMenuItem_Click;
            // 
            // facultyToolStripMenuItem
            // 
            facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            facultyToolStripMenuItem.Size = new Size(224, 26);
            facultyToolStripMenuItem.Text = "Факультеты";
            facultyToolStripMenuItem.Click += facultyToolStripMenuItem_Click;
            // 
            // groupToolStripMenuItem
            // 
            groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            groupToolStripMenuItem.Size = new Size(224, 26);
            groupToolStripMenuItem.Text = "Группы";
            groupToolStripMenuItem.Click += groupToolStripMenuItem_Click;
            // 
            // disciplineToolStripMenuItem
            // 
            disciplineToolStripMenuItem.Name = "disciplineToolStripMenuItem";
            disciplineToolStripMenuItem.Size = new Size(224, 26);
            disciplineToolStripMenuItem.Text = "Дисциплины";
            disciplineToolStripMenuItem.Click += disciplineToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem, examToolStripMenuItem, sessionResultToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(95, 24);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(224, 26);
            studentToolStripMenuItem.Text = "Студенты";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // examToolStripMenuItem
            // 
            examToolStripMenuItem.Name = "examToolStripMenuItem";
            examToolStripMenuItem.Size = new Size(224, 26);
            examToolStripMenuItem.Text = "Экзамены";
            examToolStripMenuItem.Click += examToolStripMenuItem_Click;
            // 
            // sessionResultToolStripMenuItem
            // 
            sessionResultToolStripMenuItem.Name = "sessionResultToolStripMenuItem";
            sessionResultToolStripMenuItem.Size = new Size(224, 26);
            sessionResultToolStripMenuItem.Text = "Результаты сессии";
            sessionResultToolStripMenuItem.Click += examToolStripMenuItem_Click;
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            отчётыToolStripMenuItem.Size = new Size(73, 24);
            отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem facultyToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripMenuItem disciplineToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem examToolStripMenuItem;
        private ToolStripMenuItem sessionResultToolStripMenuItem;
        private ToolStripMenuItem отчётыToolStripMenuItem;
    }
}
