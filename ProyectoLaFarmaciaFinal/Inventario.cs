using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class Inventario
    {
        private int idStock;
        private int idProducto;
        private int numeroExistencia;

        public Inventario()
        {

        }

        public int IdStock { get => idStock; set => idStock = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int NumeroExistencia { get => numeroExistencia; set => numeroExistencia = value; }

        public void agregarStock()
        {

        }   

        public void reducirStock()
        {

        }   

        public void mostrarStock()
        {

        }
    }
}
