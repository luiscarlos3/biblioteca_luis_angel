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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text=="yonatan" && TxtContraseña.Text =="123")
            {
                MessageBox.Show("bienvenidos", " biblioteca Luis Ángel Arango", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                biblioteca_Luis_Ángel_Arango iniciar = new biblioteca_Luis_Ángel_Arango();
                iniciar.Show();
            }
            else
            {
                MessageBox.Show(" error de usuario o contraseña");
            }
            if (isEmptyforms(groupBox1))
            {
                MessageBox.Show("todos los campos son obligatorios", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
