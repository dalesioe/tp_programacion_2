using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emiliano.Dalesio2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is Label)
                {
                    ((Label)c).Text = "";
                }
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                Numero num01 = new Numero(txtNum01.Text);
                Numero num02 = new Numero(txtNum02.Text);
                lblResultado.Text = Calculadora.Operar(num01, num02, cboxOp.SelectedItem.ToString()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione operador"," ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            cboxOp.Items.Add("/");
            cboxOp.Items.Add("*");
            cboxOp.Items.Add("-");
            cboxOp.Items.Add("+");
        }
    }
}
