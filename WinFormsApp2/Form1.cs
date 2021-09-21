using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class mostrargenero : Form
    {
        public mostrargenero()
        {
            InitializeComponent();
        }

        private void mostrardni_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Txdni.Text))//valida que no este vacio
            {
                MessageBox.Show("el dni no debe estar vacio.");
                Txdni.Focus();//posiciona el cursor
            }
            else
            {
                MessageBox.Show(Txdni.Text);//muestra lo que esta escrito en el textbox
            }
            

        }

        private void borrardni_Click(object sender, EventArgs e)
        {
            Txdni.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mostrardeporte_Click(object sender, EventArgs e)
        {
            string acumulador = "";

            if (tenis.Checked)//controlo si esta chequeado o no
            {
                acumulador += "tenis" + System.Environment.NewLine;

            }
            if (futbol.Checked)
            {
                acumulador += "futbol" + System.Environment.NewLine;

            }
            if (string.IsNullOrEmpty(acumulador))//valido que no este vacio
            {
                MessageBox.Show("usted no selecciono ningun deporte.");

            }
            else
            {
                MessageBox.Show("sus deportes son: " + acumulador);
            }
        }



    }
}
