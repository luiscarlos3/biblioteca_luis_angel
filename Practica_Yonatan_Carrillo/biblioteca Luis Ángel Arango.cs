using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Yonatan_Carrillo
{
    public partial class biblioteca_Luis_Ángel_Arango : Form
    {
        public List<libro> libros = new List<libro>();
        public biblioteca_Luis_Ángel_Arango()
        {
            InitializeComponent();
        }

        public bool isEmptyforms(Control Form)
        {
            bool status = false;
            foreach (Control inputs in Form.Controls)
            {
                if (inputs is TextBox)
                {
                    TextBox elements = inputs as TextBox;
                    if (isEmpty(elements.Text))
                    {
                        elements.Text = string.Empty;
                        getFocus(elements);
                        status = true;
                    }
                }
            }

            return status;
        }

        public bool isEmpty(String str)
        {
            bool status = false;
            if (String.IsNullOrEmpty(str))
                status = true;
            else if (String.IsNullOrEmpty(str.Trim()))
                status = true;
            else
                status = false;

            return status;

        }

        public void getFocus(TextBox textbox)
        {
            ActiveControl = textbox;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (isEmptyforms(groupBoxInformacion))
            {
                MessageBox.Show("todos los campos son obligatorios");
            }
            else
            {
                libro apps = new libro();
                apps.Nombre = TxtNombre.Text;
                apps.Identificacion = TxtIndentificacion.Text;
                apps.Nombre_Libro = TxtNombre_libro.Text;
                apps.fecha = DateTime.Value;
                apps.Genero = comBGenero.Text;

                // masculiono y femenino contar

                if (radioButtonMasculino.Checked==true)
                {
                    apps.Masculino = radioButtonMasculino.Text;

                  
                    
                }

                if (radioButtonFemenino.Checked== true)
                {
                    apps.Femenino = radioButtonFemenino.Text;
                    return;
                }




                libros.Add(apps);
                DgvDatos.DataSource = null;
                DgvDatos.DataSource = libros;
            }
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStripReportes_Click(object sender, EventArgs e)
        {
            Reportes abrir = new Reportes();
            abrir.Show();
        }
    }
}
