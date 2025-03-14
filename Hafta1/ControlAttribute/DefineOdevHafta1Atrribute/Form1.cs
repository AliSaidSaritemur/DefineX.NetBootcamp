using Denetim;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefineOdevHafta1Atrribute
{
    public partial class Form1 : Form
    {
        private ArrayList ogrenciler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = txtAd.Text.ToString().Trim();
            ogr.Soyadi = txtSoyad.Text.ToString().Trim();
            ogr.Bolum = txtBolum.Text.ToString().Trim();

            if (ogr.KontrolEt())
            {
                ogrenciler.Add(ogr);
                MessageBox.Show("Öğrenci Eklendi");
            }
            else
            {
                MessageBox.Show("Zorunlu Alanları Doldurunuz");
            }
        }
    }
}
