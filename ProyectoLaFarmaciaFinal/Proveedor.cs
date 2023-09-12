using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class Proveedor
    { 
        private int idProveedor;
        private string nombreProveedor;
        private string telefonoProveedor;

        public Proveedor()
        {

        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string TelefonoProveedor { get => telefonoProveedor; set => telefonoProveedor = value; }
    }
}
