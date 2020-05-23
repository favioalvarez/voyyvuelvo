using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private int _ano;
        private int _kilometraje;

        public Automovil(string idmotor, TipoMotor tipoMotor, int cilindrada,
            string marca, int ano, int kilometraje) : base (idmotor, tipoMotor, cilindrada)
        
        {
            Marca = marca;
            Ano = ano;
            Kilometraje = kilometraje;
            
        }
       

        public string Marca { get => _marca; set => _marca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}
