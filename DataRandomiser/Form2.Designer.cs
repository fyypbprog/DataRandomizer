namespace DataRandomizer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dblToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияОХарактерныхТочкахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всячинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ОХТГ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.МОК = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Форм = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СКП = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОЗТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generate_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ОПЧГ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СЧ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dblToolStripMenuItem,
            this.таблицаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dblToolStripMenuItem
            // 
            this.dblToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкиToolStripMenuItem,
            this.таблицаToolStripMenuItem});
            this.dblToolStripMenuItem.Name = "dblToolStripMenuItem";
            this.dblToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dblToolStripMenuItem.Text = "Генерация";
            // 
            // строкиToolStripMenuItem
            // 
            this.строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            this.строкиToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.строкиToolStripMenuItem.Text = "Построчно";
            this.строкиToolStripMenuItem.Click += new System.EventHandler(this.строкиToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem1
            // 
            this.таблицаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведенияОХарактерныхТочкахToolStripMenuItem,
            this.всячинаToolStripMenuItem});
            this.таблицаToolStripMenuItem1.Name = "таблицаToolStripMenuItem1";
            this.таблицаToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.таблицаToolStripMenuItem1.Text = "Таблица";
            // 
            // сведенияОХарактерныхТочкахToolStripMenuItem
            // 
            this.сведенияОХарактерныхТочкахToolStripMenuItem.Name = "сведенияОХарактерныхТочкахToolStripMenuItem";
            this.сведенияОХарактерныхТочкахToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сведенияОХарактерныхТочкахToolStripMenuItem.Text = "Сведения о характерных точках";
            this.сведенияОХарактерныхТочкахToolStripMenuItem.Click += new System.EventHandler(this.сведенияОХарактерныхТочкахToolStripMenuItem_Click);
            // 
            // всячинаToolStripMenuItem
            // 
            this.всячинаToolStripMenuItem.Name = "всячинаToolStripMenuItem";
            this.всячинаToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.всячинаToolStripMenuItem.Text = "Всячина";
            this.всячинаToolStripMenuItem.Click += new System.EventHandler(this.всячинаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ОХТГ,
            this.X,
            this.Y,
            this.МОК,
            this.Форм,
            this.СКП,
            this.ОЗТ});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 322);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ОХТГ
            // 
            this.ОХТГ.HeaderText = "Обозначение характерных точек границ";
            this.ОХТГ.Name = "ОХТГ";
            this.ОХТГ.ReadOnly = true;
            this.ОХТГ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // МОК
            // 
            this.МОК.HeaderText = "Метод определения координат";
            this.МОК.Name = "МОК";
            this.МОК.ReadOnly = true;
            this.МОК.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Форм
            // 
            this.Форм.HeaderText = "Формулы, примененные для расчета средней...";
            this.Форм.Name = "Форм";
            this.Форм.ReadOnly = true;
            this.Форм.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // СКП
            // 
            this.СКП.HeaderText = "Средняя квадратическая погрешность";
            this.СКП.Name = "СКП";
            this.СКП.ReadOnly = true;
            this.СКП.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ОЗТ
            // 
            this.ОЗТ.HeaderText = "Описание закрепления точки";
            this.ОЗТ.Name = "ОЗТ";
            this.ОЗТ.ReadOnly = true;
            this.ОЗТ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(12, 27);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(126, 34);
            this.generate_button.TabIndex = 2;
            this.generate_button.Text = "Сгенерировать";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ОПЧГ,
            this.КН,
            this.СЧ});
            this.dataGridView2.Location = new System.Drawing.Point(0, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(744, 322);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Visible = false;
            // 
            // ОПЧГ
            // 
            this.ОПЧГ.HeaderText = "Описание прохождения части границ";
            this.ОПЧГ.Name = "ОПЧГ";
            this.ОПЧГ.ReadOnly = true;
            this.ОПЧГ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // КН
            // 
            this.КН.HeaderText = "Кадастровые номера";
            this.КН.Name = "КН";
            this.КН.ReadOnly = true;
            this.КН.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // СЧ
            // 
            this.СЧ.HeaderText = "Случайное число";
            this.СЧ.Name = "СЧ";
            this.СЧ.ReadOnly = true;
            this.СЧ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 389);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1175, 612);
            this.MinimumSize = new System.Drawing.Size(760, 428);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Randomizer - Таблица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResizeBegin += new System.EventHandler(this.Form2_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dblToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ОХТГ;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn МОК;
        private System.Windows.Forms.DataGridViewTextBoxColumn Форм;
        private System.Windows.Forms.DataGridViewTextBoxColumn СКП;
        private System.Windows.Forms.DataGridViewTextBoxColumn ОЗТ;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сведенияОХарактерныхТочкахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всячинаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ОПЧГ;
        private System.Windows.Forms.DataGridViewTextBoxColumn КН;
        private System.Windows.Forms.DataGridViewTextBoxColumn СЧ;
    }
}