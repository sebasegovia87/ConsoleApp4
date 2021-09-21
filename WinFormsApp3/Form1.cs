using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)//agrega nombres a una lista
        {
            if (string.IsNullOrEmpty(txnombre.Text))//validacion string vacio
            {
                MessageBox.Show("el nombre a agregar esta vacio.");
            }
            else
            {
                listanombres.Items.Add(txnombre.Text);
                txnombre.Clear();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int indiceseleccionado = listanombres.SelectedIndex;
            
            if (indiceseleccionado == -1)//si esta en -1 es xq no hay nombres
            {
                MessageBox.Show("no hay ningun nombre seleccionado para eliminar.");
            }
            else
            {
                listanombres.Items.RemoveAt(indiceseleccionado);//borra el seleccionado
                MessageBox.Show("se elimino correctamente.");

            }


        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la lista contiene " + listanombres.Items.Count + " elementos.");
        }
    }
}
