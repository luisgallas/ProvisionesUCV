using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionesUCV
{
    internal class Pedidos
    {
        string codigo;
        string fecha;
        string estado;
        string descripcion;
        string usuario;
        string cantidad;
        public Pedidos(string codigo,string fecha, string estado, string descrpcion , string usuario, string cantidad)
        {
            this.codigo = codigo;   
            this.fecha = fecha;
            this.estado = estado;
            this.descripcion = descrpcion;
            this.usuario = usuario; 
            this.cantidad = cantidad;
        }
    }

}
