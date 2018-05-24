using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    class CrudBases
    {
        Base inicio = null;

        public void AgregarFinal(Base nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = inicio;
                inicio.Anterior = inicio;
            } else
            {
                Base b = inicio;
                while (b.Siguiente != inicio)
                {
                    b = b.Siguiente;
                }
                b.Siguiente = nuevo;
                nuevo.Siguiente = inicio;
                nuevo.Anterior = b;
                inicio.Anterior = nuevo;
                
            }
        }

        public void Insertar(Base nuevo, int pos)
        {
            if(pos == 0)
            {
                nuevo.Siguiente = inicio;
                nuevo.Anterior = inicio.Anterior;
                inicio.Anterior.Siguiente = nuevo;
                inicio.Anterior = nuevo;
                inicio = nuevo;
            }
            else
            {
                int i = 0;
                Base b = inicio;
                while (i < pos)
                {
                    b = b.Siguiente;
                    i++;
                }
                nuevo.Anterior = b.Anterior;
                nuevo.Siguiente = b;
                b.Anterior.Siguiente = nuevo;
                b.Anterior = nuevo;
                
            }
        }

        public string Ruta(string nombreInicio, int ini, int fin)
        {
            Base b = Buscar(nombreInicio);
            string recorrido = "";
            int total = fin - ini;
            int transcurrido = 0;
            while(transcurrido < total)
            {
                transcurrido += b.Tiempo;
                recorrido += transcurrido + "/" + total + " => " + b.ToString();
                b = b.Siguiente;
            }
            return recorrido;
        }

        public Base Eliminar(string nombre)
        {
            Base e = Buscar(nombre); 
           
            if(e.Nombre == inicio.Nombre)
            {
                if(inicio.Anterior == inicio && inicio.Siguiente == inicio)
                {
                    inicio = null;
                }
                else
                {
                    inicio.Anterior.Siguiente = inicio.Siguiente;
                    inicio.Siguiente.Anterior = inicio.Anterior;
                    inicio = inicio.Siguiente;
                }

            } else
            {
                e.Anterior.Siguiente = e.Siguiente;
                e.Siguiente.Anterior = e.Anterior;
            }
            return e;
        }

        public Base Buscar(string nombre)
        {
            
            if(inicio.Nombre == nombre)
            {
                return inicio;
            }
            else
            {
                Base b = inicio.Siguiente;
                while (b != inicio)
                {
                    if(b.Nombre == nombre)
                    {
                        return b;
                    }
                    b = b.Siguiente;
                }
                return null;
            }
        }

        public Base EliminarUltimo()
        {
            if(inicio == null)
            {
                return null;
            }
            else if(inicio.Anterior == inicio && inicio.Siguiente == inicio)
            {
                Base eliminado = inicio;
                inicio = null;
                return eliminado;
            } else
            {
                Base eliminado = inicio.Anterior;
                inicio.Anterior.Anterior.Siguiente = inicio;
                inicio.Anterior = inicio.Anterior.Anterior;
                return eliminado;
            }
            
        }

        public Base EliminarInicio()
        {
            if(inicio == null)
            {
                return null;
            }
            else if(inicio.Siguiente == inicio && inicio.Anterior == inicio)
            {
                Base eliminado = inicio;
                inicio = null;
                return eliminado;
            }
            {
                Base eliminado = inicio;
                inicio.Anterior.Siguiente = inicio.Siguiente;
                inicio.Siguiente.Anterior = inicio.Anterior;
                inicio = inicio.Siguiente;
                return eliminado;
            }
        }

        public string Listar()
        {
            string lista = "";
            Base b = inicio;
            if(inicio != null)
            {
                lista += b.ToString();
                b = b.Siguiente;
            }

            while (b != inicio)
            {
                lista += b.ToString();
                b = b.Siguiente;
            }
            return lista;
        }
    }
}
