using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Entidad
{
    public class Testamento
    {
    
        public string Nombre { get; set; }
        public Testamento() { }
        public Testamento( string _Nombre)
        {
            
            this.Nombre = _Nombre;
           
        }

    }
}
