using System;
using System.Collections;

namespace vehiculo_RC_prueba1
{
    class Program
    {
        /* ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
          
            
            usuario y contraseña
          
          usuario =admin
          contraseña = 1234



         ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
         */

         
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        public static void Main(string[] args)
        {
            ArrayList _AutoNuevo = new ArrayList();
            

            string usuario;
            string contraseña;
            
            
            // login 
            Console.WriteLine("ingrese su nombre de usuario");
            usuario = Console.ReadLine();

            Console.WriteLine("ingrese su contraseña");
            contraseña = Console.ReadLine();

            while (usuario != "admin" && contraseña != "1234")
            {
                Console.WriteLine("ingrese su nombre de usuario");
                usuario = Console.ReadLine();

                Console.WriteLine("ingrese su contraseña");
                contraseña = Console.ReadLine();
            }

            //menu principal
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("bienvenidos, elija una opcion");
                    Console.WriteLine("1. ingresar automovil");
                    Console.WriteLine("2. listar automovil");
                    Console.WriteLine("3. salir del sistema");
                    int opcion;
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("ingrese el numero de motor");
                                string idMotor = Console.ReadLine();


                                Console.WriteLine("ingrese el tipo de motor");
                                Console.WriteLine("1. cuatro tiempos");
                                Console.WriteLine("2. dos tiempos");

                                TipoMotor tipoMotor = Console.ReadLine() == "2" ?
                                    TipoMotor.DOS_TIEMPOS : TipoMotor.CUATRO_TIEMPOS;

                                Console.WriteLine("ingrese la cilindrada");
                                int cilindrada = int.Parse(Console.ReadLine());


                                Console.WriteLine("ingrese la marca: ");
                                string marca = Console.ReadLine();

                                Console.WriteLine("ingrese el año: ");
                                int ano = int.Parse(Console.ReadLine());

                                Console.WriteLine("ingrese el kilometraje: ");
                                int kilometraje = int.Parse(Console.ReadLine());

                                Automovil automovil = new Automovil(idMotor, tipoMotor, cilindrada, marca, ano, kilometraje);
                                _AutoNuevo.Add(automovil);
                                Console.WriteLine("¡se agrego correctamente!");
                                break;
                            case 2:
                            if (_AutoNuevo.Count > 0)
                                foreach (Automovil tmpautomovil in _AutoNuevo)
                                {
                                    Console.WriteLine("ID del motor: " + tmpautomovil.Motor.Id);
                                    Console.WriteLine("Tipo del motor: " + tmpautomovil.Motor.TipoMotor);
                                    Console.WriteLine("Cilindrada: " + tmpautomovil.Motor.Cilindrada);
                                    Console.WriteLine("Estado del motor: " + tmpautomovil.Motor.Estado+ "%");
                                    Console.WriteLine("Marca: " + tmpautomovil.Marca);
                                    Console.WriteLine("Año: " + tmpautomovil.Ano);
                                    Console.WriteLine("Kilometraje: " + tmpautomovil.Kilometraje);
                                    Console.WriteLine("______________________________________________");
                                    Console.WriteLine(string.Empty);
                                }
                            else
                                Console.WriteLine("No hay motocicletas registradas.");
                            Console.WriteLine("* Presione cualquier tecla para continuar *");
                            Console.ReadLine();
                            break;
                            case 3:
                                Console.WriteLine("adios!");
                                Environment.Exit(0);
                                break;

                            default:
                            Console.WriteLine("opcion invalida");
                                break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida ");
                        Console.WriteLine("presione una tecla");
                        Console.ReadLine();

                    }
                }
            
        }
    }
}
