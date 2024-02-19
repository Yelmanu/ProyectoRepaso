using ProyectoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRepaso.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void validarCliente(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("CLIENTES NO VALIDADOS");
            List<ClienteDto> listaAuxiliar = new List<ClienteDto>();

            foreach (ClienteDto cliente in listaClientes)
            {
                if (cliente.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    Console.WriteLine("DNI: " + cliente.DniCliente);
                    Console.WriteLine("NOMBRE: " + cliente.NombreCompletoCliente);
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    listaAuxiliar.Add(cliente);
                }

            }

            if (listaAuxiliar.Count > 0)
            {
                Console.WriteLine("Indica el dni del cliente a validar: ");
                string dniClienteAValidar = Console.ReadLine();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (cliente.DniCliente.Equals(dniClienteAValidar))
                    {
                        cliente.EsValidado = true;
                        Console.WriteLine("El cliente con dni " + dniClienteAValidar + " ha sido validado");
                    }
                }
            }


        }

        public void borrarCliente(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("BORRAR CLIENTE");
            if (listaClientes.Count > 0)
            {
                Console.WriteLine("Indica el dni del cliente a borrar: ");
                string dniClienteABorrar = Console.ReadLine();
                ClienteDto clienteAuxiliar = new ClienteDto();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (cliente.DniCliente.Equals(dniClienteABorrar))
                    {
                        clienteAuxiliar = cliente;
                    }
                }

                listaClientes.Remove(clienteAuxiliar);
                Console.WriteLine("El cliente con dni " + dniClienteABorrar + " ha sido borrado");

            }

        }

        public void mostrarClientes(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("MOSTRAR CLIENTES");
            foreach (ClienteDto cliente in listaClientes)
            {
                Console.WriteLine("%%%%%%%%%%");
                Console.WriteLine("DNI: " + cliente.DniCliente);
                Console.WriteLine("NOMBRE: " + cliente.Apellido1Cliente + " " +
                    cliente.Apellido2Cliente + ", " + cliente.NombreCliente);
                string sn;
                if (cliente.EsValidado == true)
                {
                    sn = "si";
                }
                else
                {
                    sn = "no";
                }
                Console.WriteLine("ESTADO VALIDACIÓN: " + sn);
                Console.WriteLine("%%%%%%%%%%");

            }
        }
    }
}
