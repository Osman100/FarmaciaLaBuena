using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class Cliente
    {
        private string idCliente;
        private string nombreCliente;
        private string correoElectronico;
        private string numeroTelefonico;

        public Cliente()
        {

        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
    }
}
