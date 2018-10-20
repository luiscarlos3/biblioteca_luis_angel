using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Yonatan_Carrillo
{
    public class libro
    {
        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private DateTime Fecha;

        public DateTime fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }

        private string nombre_libro;

        public string Nombre_Libro
        {
            get { return nombre_libro; }
            set { nombre_libro = value; }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        private string masculino;

        public string Masculino
        {
            get { return masculino; }
            set { masculino = value; }
        }
        private string femenino;

        public string Femenino
        {
            get { return femenino; }
            set { femenino = value; }
        }







    }
}
