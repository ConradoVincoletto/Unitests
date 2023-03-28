using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ClienteBusiness
    {
        public int CalcularIdade(ClienteDTO clienteDTO)
        {
            return DateTime.Now.Year - clienteDTO.DataNascimento.Year;
        }
    }
}
