using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2Alum
{
    class Alumnos
    {
        int id;
        string nombre;
        string apellidop;
        string apellidom;
        int edad;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidop
        {
            get { return apellidop; }
            set { apellidop = value; }
        }
        public string Apellidom
        {
            get { return apellidom; }
            set { apellidom = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
       //ublic override string ToString()
       //
         // return id + " " + nombre + apellidop + apellidom + edad + "";
      //}
        
    }
}
