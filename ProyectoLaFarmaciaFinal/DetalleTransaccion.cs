using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class DetalleTransaccion
    {
        private int idDetalle;
        private int idTransaccion;
        private int idProducto;
        private int cantidadProducto;
        private double subtotal; 

        public DetalleTransaccion()
        {
        }

        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int IdTransaccion { get => idTransaccion; set => idTransaccion = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }

        public void calcularSubtotal()
        {
            throw new NotImplementedException();
        }

    }


}
