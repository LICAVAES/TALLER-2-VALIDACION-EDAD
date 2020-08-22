using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2_ValidacionEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(TxtEdad.Text);
            if (TxtEdad.Text.Length >2 )
            {
                MessageBox.Show("LA EDAD INGRESADA NO ES PERMITIDA","ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                TxtEdad.Text = String.Empty;
                TxtEdad.Focus();
            } else if (edad > 18)
         
            {
                MessageBox.Show("ES MAYOR DE EDAD", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ES MENOR DE EDAD", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEdad.Text = String.Empty;
            TxtEdad.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
             
    }
}
