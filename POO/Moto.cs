using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;

        public void ExibirDetalhesMoto()
        {
            ExibirDetalhes(); // Método herdado de veículo
            Console.WriteLine($"Partida elétrica: {TemPartidaEletrica}");
        }
    }
}