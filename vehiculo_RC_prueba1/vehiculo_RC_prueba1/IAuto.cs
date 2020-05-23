using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo_RC_prueba1
{
    interface IAuto
    {
        public void InsertarAutomovil(Automovil Automovil);
        public void ActualizarAutomovil(int id, Automovil Automovil);

        public Dictionary<int, Automovil> ObtenerAutomovil();
        
        public void EliminarAutomovil(int id);
    }
}
