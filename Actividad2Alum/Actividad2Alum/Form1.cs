using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2Alum
{
    public partial class Form1 : Form
    {
        string dato;
        int i = 0;
        int cantidad;
        Alumnos[] arreglo = new Alumnos[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtCantidadAlum.Text);
            arreglo = new Alumnos[cantidad];
            grpInicial.Visible = false;
            grpInfo.Visible = true;
            txtId.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (i < cantidad)
            {
                // Se agrega un nueva numero al arreglo
                arreglo[i] = new Alumnos();
                arreglo[i].Id = int.Parse(txtId.Text);
                arreglo[i].Nombre = txtNombre.Text;
                arreglo[i].Apellidop = txtApellidoP.Text;
                arreglo[i].Apellidom = txtApellidoM.Text;
                arreglo[i].Edad = int.Parse(txtEdad.Text);
                txtId.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtEdad.Clear();
                txtId.Focus();
                i++;
            }
            if (i == cantidad)
            {
                //Mostrar mensaje
                MessageBox.Show("Arreglo Lleno!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LVInfo.Items.Clear();

                // Se agregan todos los numeros del arreglo a la lista
                for (int x = 0; x < cantidad; x++)
                {
                    ListViewItem lista = new ListViewItem(arreglo[x].Id.ToString());
                    lista.SubItems.Add(arreglo[x].Nombre);
                    lista.SubItems.Add(arreglo[x].Apellidop);
                    lista.SubItems.Add(arreglo[x].Apellidom);
                    lista.SubItems.Add(arreglo[x].Edad.ToString());
                    LVInfo.Items.Add(lista);
                }
            }


        }
    }
}

