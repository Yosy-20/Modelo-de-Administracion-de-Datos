using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Entidad
{
   public class Capitulo
    {
        public int idCapitulo { get; set; }
        public string Nombre { get; set; }
        public int idLibro { get; set; }

        public string NombreLibro { get; set; }
        public Capitulo() { }

        public Capitulo (int _idCapitulo, string _Nombre, int _idLibro, string _NombreLibro)
        {
            this.idLibro = _idLibro;
            this.Nombre = _Nombre;
            this.idLibro = _idLibro;
            this.NombreLibro = _NombreLibro;

        }


    }
}
