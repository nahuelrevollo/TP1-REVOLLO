using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIMETA_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {

            if (txtTextBox.Text == "")

            {
                MessageBox.Show("Ingrese nombre");

            }
            else
            {

                MessageBox.Show("HOLA " + txtTextBox.Text);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la super App","HOLA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            labelNombre.Text = txtTextBox.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hasta pronto...!!", "ADIOS");
        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("De verdad queres salir?","Salir",MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                Dispose();

            }

        }
                
    }
              //Form1_FormClosing(sender, e);
}
