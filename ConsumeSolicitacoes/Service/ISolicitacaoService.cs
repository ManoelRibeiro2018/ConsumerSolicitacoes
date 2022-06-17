using ConsumeSolicitacoes.Dto;
using ConsumeSolicitacoes.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Service
{
    public interface ISolicitacaoService
    {
        public Task InsertAsync(List<SolicitacaoModel> solicitacaoModels);
        public Task<List<SolicitacaoModel>> GetAllAsync();
        public Task<List<SolicitacaoModel>> GetByLastTwelveMoth();
        public Task<List<SolicitacaoViewModel>> GetBydistrictMoreAffected();
        public Task<List<SocilitacaoByYearViewModel>> GetByConsultByYear();
    }
}
