using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class Vendedor
    {
        private int idVendedor;
        private string nombreVendedor;
        private string estadoLaboral;
        private double salario;

        public Vendedor()
        {

        }

        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string NombreVendedor { get => nombreVendedor; set => nombreVendedor = value; }
        public string EstadoLaboral { get => estadoLaboral; set => estadoLaboral = value; }
        public double Salario { get => salario; set => salario = value; }

        public void AgregarVendedor()
        {

        }

        public void ModificarVendedor()
        {

        }

        public void EliminarVendedor()
        {

        }

        public void BuscarVendedor()
        {

        }
    }
}
