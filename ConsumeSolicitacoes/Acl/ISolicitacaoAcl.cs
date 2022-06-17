using ConsumeSolicitacoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Acl
{
    public interface ISolicitacaoAcl
    {
        public Task<List<SolicitacaoModel>> GetSolicitacaoModelsAcl();
    }
}
