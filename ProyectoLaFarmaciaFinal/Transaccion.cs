using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLaFarmaciaFinal
{
    internal class Transaccion
    {
        private int idTransaccion;
        private int idCliente;
        private int idVendedor;
        private int idDetalle;
        private DateTime fechaTransaccion;
        private double total;

        public Transaccion() 
        { 

        }

        public int IdTransaccion { get => idTransaccion; set => idTransaccion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
        public double Total { get => total; set => total = value; }
    }

   
}
