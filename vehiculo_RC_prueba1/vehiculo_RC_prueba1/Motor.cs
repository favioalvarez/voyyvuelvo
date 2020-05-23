using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    enum TipoMotor 
    {
        DOS_TIEMPOS,CUATRO_TIEMPOS
    }

    class Motor : VehiculoComponentes
    {
        private string _id;
        private TipoMotor _tipoMotor;
        private int _cilindrada;
       


        public Motor(string id, TipoMotor tipoMotor, int cilindrada) : base()
        {
            Id = id;
            TipoMotor = tipoMotor;
            Cilindrada = cilindrada;
        }

        public string Id { get => _id; set => _id = value; }
        public int Cilindrada { get => _cilindrada; set => _cilindrada = value; }
        internal TipoMotor TipoMotor { get => _tipoMotor; set => _tipoMotor = value; }
    }
}
