using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbAdSoyad.Items.Add(txtAdSoyad.Text);
            lbVize.Items.Add(txtVize.Text);
            lbOdev.Items.Add(txtOdev.Text);
            lbProje.Items.Add(txtProje.Text);
            lbFinal.Items.Add(txtFinal.Text);
            // Burada artık sen yapıcan oranlarına göre hesapla :)
            lbOrtalama.Items.Add(txtFinal.Text);
            lbHarfNotu.Items.Add(txtFinal.Text);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {
            int id = 1;
            if (lbAdSoyad.SelectedIndex != -1) id = lbAdSoyad.SelectedIndex;
            else if (lbVize.SelectedIndex != -1) id = lbVize.SelectedIndex;
            else if (lbOdev.SelectedIndex != -1) id = lbOdev.SelectedIndex;
            else if (lbProje.SelectedIndex != -1) id = lbProje.SelectedIndex;
            else if (lbFinal.SelectedIndex != -1) id = lbFinal.SelectedIndex;
            else if (lbOrtalama.SelectedIndex != -1) id = lbOrtalama.SelectedIndex;
            else if (lbHarfNotu.SelectedIndex != -1) id = lbHarfNotu.SelectedIndex;
            lbAdSoyad.Items.RemoveAt(id);
            lbVize.Items.RemoveAt(id);
            lbOdev.Items.RemoveAt(id);
            lbProje.Items.RemoveAt(id);
            lbFinal.Items.RemoveAt(id);
            lbOrtalama.Items.RemoveAt(id);
            lbHarfNotu.Items.RemoveAt(id);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtVize.Text = "";
            txtOdev.Text = "";
            txtProje.Text = "";
            txtFinal.Text = "";
            lblVize.Text = "0";
            lblOdev.Text = "0";
            lblProje.Text = "0";
            lblFinal.Text = "0";
            lblGecmeNotu.Text = "0";
            lbAdSoyad.Items.Clear();
            lbVize.Items.Clear();
            lbOdev.Items.Clear();
            lbProje.Items.Clear();
            lbFinal.Items.Clear();
            lbOrtalama.Items.Clear();
            lbHarfNotu.Items.Clear();
        }
    }
}
