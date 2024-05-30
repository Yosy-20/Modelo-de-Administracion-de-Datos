using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Entidad
{
    public class Versiculo
    {
        public int idVersiculo { get; set; }
        public string cita { get; set; }

        public string contenido { get; set; }
        public int idCapitulo { get; set; }

        public string NombreCapitulo { get; set; }
        public Versiculo() { }

        public Versiculo(int _idVersiculo, string _cita, string _contenido, int _idCapitulo, string _NombreCapitulo)
        {
            this.idVersiculo = _idVersiculo;
            this.cita =_cita;
            this.contenido = _contenido;
            this.idCapitulo = _idCapitulo;
            this.NombreCapitulo = _NombreCapitulo;

        }


    }
}
