namespace DataRandomiser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.табицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.generate_buton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкиToolStripMenuItem,
            this.табицаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.видToolStripMenuItem.Text = "Генерация";
            this.видToolStripMenuItem.Click += new System.EventHandler(this.видToolStripMenuItem_Click);
            // 
            // строкиToolStripMenuItem
            // 
            this.строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            this.строкиToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.строкиToolStripMenuItem.Text = "Построчно";
            this.строкиToolStripMenuItem.Click += new System.EventHandler(this.строкиToolStripMenuItem_Click);
            // 
            // табицаToolStripMenuItem
            // 
            this.табицаToolStripMenuItem.Name = "табицаToolStripMenuItem";
            this.табицаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.табицаToolStripMenuItem.Text = "Таблица";
            this.табицаToolStripMenuItem.Click += new System.EventHandler(this.табицаToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Дата",
            "Номер телефона",
            "Email",
            "СНИЛС (ХХХ-ХХХ-ХХХ YY)",
            "СНИЛС (ХХХХХХХХХYY)",
            "ИНН (ФЛ, ИП)",
            "ИНН (ЮЛ)",
            "ОГРНИП",
            "ОГРН",
            "КПП",
            "Кад. номер",
            "Кад. номер (образуем.)",
            "Обозначение образуем.",
            "12 случ. символов"});
            this.listBox1.Location = new System.Drawing.Point(32, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 214);
            this.listBox1.TabIndex = 37;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(32, 247);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(245, 23);
            this.result_textBox.TabIndex = 38;
            // 
            // generate_buton
            // 
            this.generate_buton.Location = new System.Drawing.Point(202, 276);
            this.generate_buton.Name = "generate_buton";
            this.generate_buton.Size = new System.Drawing.Size(75, 23);
            this.generate_buton.TabIndex = 39;
            this.generate_buton.Text = "Generate";
            this.generate_buton.UseVisualStyleBackColor = true;
            this.generate_buton.Click += new System.EventHandler(this.generate_buton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 311);
            this.Controls.Add(this.generate_buton);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 350);
            this.MinimumSize = new System.Drawing.Size(323, 350);
            this.Name = "Form1";
            this.Text = "Data Randomizer - Построчно";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem табицаToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button generate_buton;
    }
}
