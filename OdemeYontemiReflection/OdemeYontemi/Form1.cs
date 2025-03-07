using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdemeYontemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type type = Type.GetType("OdemeYontemi.OdemeYontemleri." + comboBox1.Text.ToString());
            var odemeYontemi =Activator.CreateInstance(type);
            object[] parameters = { Double.Parse(txtTutar.Text.ToString()) };
            string message = (string)type.GetMethod("OdemeYap").Invoke(odemeYontemi, parameters);
            MessageBox.Show(message);
        }
    }
}
