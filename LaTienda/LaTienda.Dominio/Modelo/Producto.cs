using System;
using System.Collections.Generic;
using System.Text;

namespace LaTienda.Dominio.Modelo
{
    class Producto
    {
        private double precio = 0, margen = 0, neto = 0, iva=0 ;
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double MargenGanancia { get; set; }
        public double PorcentajeIva { get; set; }
        public double NetoGravado
        {
            get => neto;
            set
            {
                neto = Costo + Costo * MargenGanancia;
            }
        }
       
        public double IVA
        {
            get => iva;
            set
            {
                iva = NetoGravado * PorcentajeIva;
            }
        }
        public double PrecioFinal
        {
            get => precio;
            set
            {
                precio = NetoGravado + IVA;
            }
        }


        //Extenciones
        public TallaRopa TallaRopa { get; set; }
        public Color Color { get; set; }
        public Rubro Rubro { get; set; }
        public int TallaCalzado { get; set; }




    }
}
