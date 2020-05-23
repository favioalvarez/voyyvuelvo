using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    abstract class Vehiculo
    {
        private Motor _motor;
        
        


        protected Vehiculo(string idMotor, TipoMotor tipoMotor, int cilindrada )
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);
        }

        internal Motor Motor { get => _motor; set => _motor = value; }
    }
}
