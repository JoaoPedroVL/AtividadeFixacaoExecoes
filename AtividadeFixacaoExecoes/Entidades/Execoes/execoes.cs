using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFixacaoExecoes.Entidades.Execoes
{
    internal class ExecaoPersonalizada : ApplicationException
    {
        public ExecaoPersonalizada(string mensagem) : base(mensagem)
        {

        }
    }
}
