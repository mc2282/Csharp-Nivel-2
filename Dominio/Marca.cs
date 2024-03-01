using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{        
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Marca(int aIdMarca, string aDescripcion)
        {
            Id = aIdMarca;
            Descripcion = aDescripcion;
        }
        public Marca() 
        { 
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}

