using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    class Base
    {
        public Base(string nombre, int tiempo)
        {
            _nombre = nombre;
            _tiempo = tiempo;
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _tiempo;

        public int Tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }

        private Base _siguiente;

        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        private Base _anterior;

        public Base Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }


        public override string ToString()
        {
            return "Nombre: " + _nombre + " Tiempo: " + _tiempo + " A: " + _anterior.Nombre + " S: " + _siguiente.Nombre + "\r\n";
        }



    }
}
