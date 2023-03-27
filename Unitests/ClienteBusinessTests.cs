using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using DTOs;

namespace Unitests
{
    public class ClienteBusinessTests
    {
        [Test]
        public void CalcularIdade_DadosValidos_RetornaIdade()
        {
            //Arrange
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            ClienteDTO clienteDTO = new ClienteDTO { Nome = "Nome 1", DataNascimento = new DateTime(2010, 1, 1) };
            int expectedResult = 13;

            //Act
            int result = clienteBusiness.CalcularIdade(clienteDTO);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}
