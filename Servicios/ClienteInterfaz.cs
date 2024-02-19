using ProyectoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRepaso.Servicios
{
    internal interface ClienteInterfaz
    {
        public void registroNuevoCliente(List<ClienteDto> listaClientes);

        public void accesoCliente(List<ClienteDto> listaClientes);
    }
}
