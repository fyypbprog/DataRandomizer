using DataRandomiser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataRandomiser.Program;

namespace DataRandomizer
{
    public partial class Form2 : Form
    {
        Size formGridSizeDiff = new Size(16, 105);
        Random rnd = new Random();
        string cache;
        string[] MOK = { "Геодезический метод", "Фотограмметрический метод", "Картометрический метод", "Иное описание", "Метод спутниковых геодезических измерений (определений)", "Аналитический метод" };
        int a, b;
        string[] Zakrep = { "-", "данные отсутствуют", "закреп " };
        string[] Prohojd = { "-", "данные отсутствуют", "прохожд " };
        int gridVisibility = 1;
        int[] CadastralNumber;
        public Form2()
        {
            InitializeComponent();
        }

        private void строкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            rows.Show();
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("");
                dataGridView2.Rows.Add("");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            switch (gridVisibility)
            {
                case 1:
                    dataGridView1.Size = Size - formGridSizeDiff;
                    break;
                case 2:
                    dataGridView2.Size = Size - formGridSizeDiff;
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void всячинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Size = dataGridView1.Size;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            gridVisibility = 2;
        }

        private void сведенияОХарактерныхТочкахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = dataGridView2.Size;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            gridVisibility = 1;
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            switch (gridVisibility)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        cache = rnd.Next(1, 999).ToString();
                        dataGridView1.Rows[i].Cells[ОХТГ.Index].Value = cache;

                        cache = rnd.Next(100000, 999999).ToString() + "." + rnd.Next(10, 99).ToString();
                        dataGridView1.Rows[i].Cells[X.Index].Value = cache;
                        cache = rnd.Next(100000, 999999).ToString() + "." + rnd.Next(10, 99).ToString();
                        dataGridView1.Rows[i].Cells[Y.Index].Value = cache;

                        cache = MOK[rnd.Next(0, 6)];
                        dataGridView1.Rows[i].Cells[МОК.Index].Value = cache;

                        a = rnd.Next(1, 9);
                        b = rnd.Next(1, 9);
                        cache = "Mt=√(" + a + "²+" + b + "²)=0.12" + Math.Sqrt((a * a) + (b * b));
                        dataGridView1.Rows[i].Cells[Форм.Index].Value = cache;

                        cache = "0," + rnd.Next(1, 9) + rnd.Next(1, 9);
                        dataGridView1.Rows[i].Cells[СКП.Index].Value = cache;

                        cache = Zakrep[rnd.Next(0, 3)];
                        if (cache == Zakrep[2])
                        {
                            cache += rnd.Next(0, 9999);
                        }
                        dataGridView1.Rows[i].Cells[ОЗТ.Index].Value = cache;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 10; i++)
                    {
                        cache = Prohojd[rnd.Next(0, 3)];
                        if (cache == Prohojd[2])
                        {
                            cache += rnd.Next(0, 9999);
                        }
                        dataGridView2.Rows[i].Cells[ОПЧГ.Index].Value = cache;
                        cache = null;

                        CadastralNumber = new int[rnd.Next(12, 17)];
                        for (int j = 0; j < CadastralNumber.Length; j++)
                        {
                            CadastralNumber[j] = rnd.Next(1, 9);
                            cache += CadastralNumber[j];
                            if (j == 1 || j == 3 || j == 10)
                            {
                                cache += ":";
                            }
                        }
                        dataGridView2.Rows[i].Cells[КН.Index].Value = cache;

                        cache = rnd.Next(0, 999999).ToString();
                        dataGridView2.Rows[i].Cells[СЧ.Index].Value = cache;
                    }
                    break;
            }
            
        }
    }
}
