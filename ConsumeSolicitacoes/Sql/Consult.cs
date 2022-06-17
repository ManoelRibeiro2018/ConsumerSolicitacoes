using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Sql
{
    public class Consult
    {
        public static string ConsultTeste =>
            "SELECT SolicitacaoBairro, Count(*) as 'Qtd' FROM SOLICITACAO GROUP BY SolicitacaoBairro HAVING Count(*) > 1";
    }
}
