using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije_vjezba
{
    public partial class Form1 : Form
    {
        List<Osobe> osoba = new List<Osobe>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Unesi_Click(object sender, EventArgs e)
        {
            try
            {
                Osobe osobe = new Osobe(textBox_podatak1.Text, textBox_podatak2.Text, textBox_podatak3.Text, comboBox_podatak4.Text);

                osoba.Add(osobe);

                textBox_podatak1.Clear();
                textBox_podatak2.Clear();
                textBox_podatak3.Clear();

                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ispisi_Click(object sender, EventArgs e)
        {
            richTextBox_ispis.Text = "Podatak1 " + "\t\t" + "Podatak2" + "\t\t" + "podatak3" + "\t\t" + "podatak4" + "\t\t" + "Dodatak" + "\r\n";
            foreach (Osobe osobe in osoba)
            {
                richTextBox_ispis.AppendText(osobe.ToString() + "\r\n");

            }
        }

        private void button_obradi_Click(object sender, EventArgs e)
        {
            if (comboBox_podatak4.Text == "M")
            {
                richTextBox_ispis.AppendText("Ima brkove");
            }

            else
            {
                richTextBox_ispis.AppendText("Nema brkove");
            }
        }

        private void label_podatak3_Click(object sender, EventArgs e)
        {

        }
    }
}
