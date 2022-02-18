using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        // Sobrecargas do método Registrar -> dois ou mais métodos de mesmo nome,
        // mas que recebem argumentos de tipos diferentes.
        //public void Registrar(Diretor diretor)
        //{
        //    _totalBonificacao += diretor.GetBonificacao();
        //}

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
