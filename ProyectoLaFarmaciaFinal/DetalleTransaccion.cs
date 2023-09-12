using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    public class DetalleTransaccion
    {
        private int idDetalle;
        private int idTransaccion;
        private int idProducto;
        private int cantidadProducto;
        private double subtotal;
        Producto producto1 = new Producto();

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
            this.subtotal = this.cantidadProducto * producto1.PrecioProducto;
        }

        public void AgregarDetalleTransaccion()
        {

        }



    }


}
