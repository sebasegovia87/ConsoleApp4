using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Auto> Auto = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAutomoviles();

        }
        private void CargarAutomoviles()
        {
            string Path = "C:\\Users\\Sebastian\\Desktop\\Automovil.txt";
            FileInfo FI = new FileInfo(Path);

            if (!FI.Exists)
            {
                MessageBox.Show("No existe el archivo en el Path" + Path + ".");
            }
            else
            {
                StreamReader SR = FI.OpenText();

                while (!SR.EndOfStream)
                {
                    string Linea = SR.ReadLine();
                    string[] Vector = Linea.Split(';');

                    Auto A = new Auto();
                    A.Dominio = Vector[0];
                    A.Kilometraje = Convert.ToInt32(Vector[1]);
                    A.Marca = Vector[2];
                    A.Modelo = Vector[3];
                    A.AñoFabricacion = Convert.ToInt32(Vector[4]);
                    A.Tipo = Vector[5];
                    A.Alquilado = Convert.ToBoolean(Vector[6]);

                    Auto.Add(A);
                     
                }


                comboBox1.Items.Add("Grande");
                comboBox1.Items.Add("Mediano");
                comboBox1.Items.Add("Chico");
                comboBox1.Items.Add("Lujoso");

                SR.Close();
                MessageBox.Show("Se cargo el archivo" + Path + ".");
                textBox1.Focus();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Dominio = textBox1.Text;
            

             if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El dominio no debe estar vacio");
            }
            else
            {
                Auto A = BuscarAutomovil(Dominio);
                if(A==null)
                {
                    MessageBox.Show("no existe el automovil con ese dominio.");

                }
                textBox2.Text = Convert.ToString(A.Kilometraje);
                textBox4.Text = A.Marca;
                textBox5.Text = A.Modelo;
                textBox3.Text = Convert.ToString(A.AñoFabricacion);
            }
            

        }
        private Auto BuscarAutomovil(string Dominio)
        {
            return Auto.Find(A => A.Dominio == Dominio);
        }
      
    }
}

