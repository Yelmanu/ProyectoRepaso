using ProyectoRepaso.Servicios;

namespace ProyectoRepaso.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFichero = @"C:\\Users\\csi22-mdiarro\\Desktop\\Programacion\\ProyectoRepaso\\log-ddMMyy.txt";
            
            MenuInterfaz mi = new MenuImplementacion();

            int opcionPrincipal;
            bool cerrarPrincipal = false;

            do
            {
                Console.WriteLine("MENÚ INICIAL");
                using(StreamWriter sw = new StreamWriter(rutaFichero, true))
                {
                    sw.WriteLine("Acceso a menú principal - " + DateTime.Now.ToString("dd-MM-yy"));
                }             
                opcionPrincipal = mi.mostrarMenuPrincipalYSeleccion();
                switch (opcionPrincipal)
                {

                    case 0:
                        Console.WriteLine("Se cierra la aplicación");
                        cerrarPrincipal = true;
                        break;
                    case 1:
                        Console.WriteLine("VERSIÓN EMPLEADO");
                        mi.accederVersionEmpleado();
                        using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                        {
                            sw.WriteLine("Acceso a menú empleado - " + DateTime.Now.ToString("dd-MM-yy"));
                        }                                                  
                        break;
                    case 2:
                        Console.WriteLine("VERSIÓN CLIENTE");
                        mi.accederVersionCliente();
                        using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                        {
                            sw.WriteLine("Acceso a menú cliente - " + DateTime.Now.ToString("dd-MM-yy"));
                        }                       
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción aceptable");
                        break;
                }

            } while (!cerrarPrincipal);
            
        }
    }
}