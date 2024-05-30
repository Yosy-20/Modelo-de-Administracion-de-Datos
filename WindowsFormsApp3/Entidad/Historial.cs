using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Entidad
{
    public class Historial
    {
        public string Usuario { get; set; }

        public string palabra { get; set; }
        public DateTime Fecha { get; set; }


        public Historial() { }


        Historial(string _Usuario, string _palabra, DateTime _Fecha ) {

            this.Usuario = _Usuario;
            this.palabra = _palabra;
            this.Fecha = _Fecha;


        }

    }
}
