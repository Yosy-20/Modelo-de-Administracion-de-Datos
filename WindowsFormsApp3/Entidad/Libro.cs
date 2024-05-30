using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Entidad
{
   public class Libro
    {
        public int idLibro { get; set; }
        public string Nombre { get; set; }
        public string idTestamento { get; set; }

        public string NombreTestamento { get; set; }
        public Libro() { }

        public Libro( int _idLibro, string _Nombre, string _idTestameto, string _NombreTestamento ) {

            this.idLibro = _idLibro;
            this.Nombre = _Nombre;
            this.idTestamento = _idTestameto;
            this.NombreTestamento = _NombreTestamento;
        }

    }
}
