using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class Producto
    {
        private int idProducto;
        private int idProveedor;
        private int idCategoria;
        private string nombreProducto;
        private double precioProducto;

        public Producto()
        {

        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }

        public void AgregarProducto()
        {

        }

        public void ModificarProducto()
        {

        }

        public void EliminarProducto()
        {

        }

        public void BuscarProducto()
        {

        }


    }
}
