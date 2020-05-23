using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    enum Recubrimiento { fenol, hule, poliuretano }
    class Rueda : VehiculoComponentes
    {
        
        private int _Mayor = 180;
        private int _Menor=100;
        private Recubrimiento _recubrimiento;

        

        public Rueda(int mayor,int menor, Recubrimiento recubrimiento) :base()
        {
            _Mayor = mayor;
            _Menor = menor;

        }

        protected void Durometro()
        {
            Console.WriteLine(_Menor);
            Console.WriteLine(_Mayor);
        }

        public int Mayor { get => _Mayor; set => _Mayor = value; }
        public int Menor { get => _Menor; set => _Menor = value; }
        internal Recubrimiento Recubrimiento { get => _recubrimiento; set => _recubrimiento = value; }

    }
}
