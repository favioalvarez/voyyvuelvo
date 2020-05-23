using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    class Estanque : VehiculoComponentes
    {
        private int _capacidad;
        private int _litros;
        public Estanque()
        {

        }

        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public int Litros { get => _litros; set => _litros = value; }

        public void MitadCombustible()
        {
            if (_litros > 10.5 && _litros <= 50.0)
            {
                Console.WriteLine("estanque a la mitad: "+ _litros);
            }
            

        }

        public void BajoCombustible()
        {
            if (_litros <= 10.5) 
            {
                Console.WriteLine("combustible bajo: "+ _litros);
            }
           
        }
    }
}
