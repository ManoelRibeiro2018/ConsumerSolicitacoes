using Domain.Solicitacoes.Dto;
using Domain.Solicitacoes.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Solicitacoes.Repository
{
    public interface ISolicitacaoRepository
    {
        public Task SaveAsync(SolicitacaoModel solicitacaoModel);
        public Task<List<SolicitacaoModel>> GetAllAsync();
        public Task<List<SolicitacaoModel>> GetByLastTwelveMoth();
        public Task<List<SolicitacaoViewModel>> GetBydistrictMoreAffected();
        public Task<List<SocilitacaoByYearViewModel>> GetByConsultByYear();
        public Task<List<SolicitacaoByMonthViewModel>> GetByConsultMonth();

    }
}
