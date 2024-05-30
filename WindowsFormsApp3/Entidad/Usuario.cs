using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Entidad
{
    public class Usuario
    {
        public int id { get; set; }
        public string Correo { get; set; }
        public string Contra { get; set; }
        public string Nombre { get; set; }
        public string NomUsua { get; set; }
        public DateTime FechaNam { get; set; }
        public int Estatus { get; set; }
        public string Genero { get; set; }
        public Usuario() { }

        public Usuario(int id, string _Correo, string _Contra, string _Nombre, DateTime _FechaNam, int _Estatus, string _Genero, string _NomUsua)
        {
            this.id = id;
            this.Correo = _Correo;
            this.Contra = _Contra;
            this.Nombre = _Nombre;
            this.NomUsua = _NomUsua;
            this.FechaNam = _FechaNam;
            this.Estatus = _Estatus;
            this.Genero = _Genero;
        }
    }
}
