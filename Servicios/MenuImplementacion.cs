using ProyectoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRepaso.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        List<ClienteDto> listaClientes = new List<ClienteDto>();
        public int mostrarMenuPrincipalYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Versión empleado");
            Console.WriteLine("2. Versión cliente");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public void accederVersionEmpleado()
        {
            string rutaFichero = @"C:\\Users\\csi22-mdiarro\\Desktop\\Programacion\\ProyectoRepaso\\log-ddMMyy.txt";           
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            int opcionEmpleado;
            opcionEmpleado = mostrarMenuEmpleadoYSeleccion();

            switch (opcionEmpleado)
            {
                case 0:
                    break;
                case 1:
                    ei.validarCliente(listaClientes);
                    using(StreamWriter sw = new StreamWriter(rutaFichero, true))
                    {
                        sw.WriteLine("Validar Cliente - " + DateTime.Now.ToString("dd-MM-yy"));
                    }                   
                    break;
                case 2:
                    ei.borrarCliente(listaClientes);
                    using(StreamWriter sw = new StreamWriter(rutaFichero, true))
                    {
                        sw.WriteLine("Borrar Cliente - " + DateTime.Now.ToString("dd-MM-yy"));
                    }                    
                    break;
                case 3:
                    ei.mostrarClientes(listaClientes);
                    using(StreamWriter sw = new StreamWriter(rutaFichero, true))
                    {
                        sw.WriteLine("Mostrar clientes - " + DateTime.Now.ToString("dd-MM-yy"));
                    }                    
                    break;
                default:
                    Console.WriteLine("No ha seleccionado una opción aceptable vuelve al menú inicial.");
                    break;
            }
        }
        private int mostrarMenuEmpleadoYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Validar cliente");
            Console.WriteLine("2. Borrar cliente");
            Console.WriteLine("3. Mostrar clientes");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public void accederVersionCliente()
        {
            string rutaFichero = @"C:\\Users\\csi22-mdiarro\\Desktop\\Programacion\\ProyectoRepaso\\log-ddMMyy.txt";
            ClienteInterfaz ci = new ClienteImplementacion();

            int opcionCliente;
            opcionCliente = mostrarMenuClienteYSeleccion();

            switch (opcionCliente)
            {
                case 0:
                    break;
                case 1:
                    ci.registroNuevoCliente(listaClientes);
                    using(StreamWriter sw = new StreamWriter(rutaFichero, true))
                    {
                        sw.WriteLine("Registro nuevo cliente - " + DateTime.Now.ToString("dd-MM-yy"));
                    }
                    break;
                case 2:
                    ci.accesoCliente(listaClientes);
                    using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                    {
                        sw.WriteLine("Acceso cliente (login) - " + DateTime.Now.ToString("dd-MM-yy"));
                    }
                        break;
                default:
                    Console.WriteLine("No ha seleccionado una opción aceptable vuelve al menú inicial.");
                    break;
            }
        }
        private int mostrarMenuClienteYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Registro cliente");
            Console.WriteLine("2. Acceso cliente (login)");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
