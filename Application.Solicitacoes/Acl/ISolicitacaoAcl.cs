using Domain.Solicitacoes.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Solicitacoes
{
    public interface ISolicitacaoAcl
    {
        public Task<List<SolicitacaoModel>> GetSolicitacaoModelsAcl();
    }
}
