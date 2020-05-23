using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    abstract class VehiculoComponentes 
    {
        private double _estado;
        
        protected VehiculoComponentes() 
        {
            _estado = 100.0;

        }

        public double Estado { get => _estado; set => _estado = value; }
    }
}
