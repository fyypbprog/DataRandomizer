using DataRandomizer;
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

namespace DataRandomiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void строкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void табицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            table.Show();
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            result_textBox.Text = "";
            try
            {
                switch (listBox1.GetItemText(listBox1.SelectedItem))
                {
                    case "Дата":
                        result_textBox.Text = generate_methods.generate_data();
                        break;
                    case "Номер телефона":
                        result_textBox.Text = generate_methods.generate_phone();
                        break;
                    case "Email":
                        result_textBox.Text = generate_methods.generate_email();
                        break;
                    case "СНИЛС (ХХХ-ХХХ-ХХХ YY)":
                        result_textBox.Text = generate_methods.generate_formatted_SNILS();
                        break;
                    case "СНИЛС (ХХХХХХХХХYY)":
                        result_textBox.Text = generate_methods.generate_unformatted_SNILS();
                        break;
                    case "ИНН (ФЛ, ИП)":
                        result_textBox.Text = generate_methods.generate_INN_FL();
                        break;
                    case "ИНН (ЮЛ)":
                        result_textBox.Text = generate_methods.generate_INN_UL();
                        break;
                    case "ОГРНИП":
                        result_textBox.Text = generate_methods.generate_OGRNIP();
                        break;
                    case "ОГРН":
                        result_textBox.Text = generate_methods.generate_OGRN();
                        break;
                    case "КПП":
                        result_textBox.Text = generate_methods.generate_KPP();
                        break;
                    case "Нр/с":
                        result_textBox.Text = generate_methods.generate_checking_account_number();
                        break;
                    case "Кад. номер":
                        result_textBox.Text = generate_methods.generate_cadastral_number();
                        break;
                    case "Кад. номер (образуем.)":
                        result_textBox.Text = generate_methods.generate_cadastral_number_with_new_parcel_definition();
                        break;
                    case "Обозначение образуем.":
                        result_textBox.Text = generate_methods.generate_new_parcel_definition();
                        break;
                    case "12 случ. символов":
                        int i = 0;
                        while (i++ < 14)
                        {
                            result_textBox.Text += generate_methods.generate_ASCII_symbol();
                        }
                        break;
                }
                Clipboard.SetText(result_textBox.Text);
            }
            catch
            {
                result_textBox.Text = "Error! Please, try again.";
            }
        }

        private void generate_buton_Click(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, e);
        }
    }
}
