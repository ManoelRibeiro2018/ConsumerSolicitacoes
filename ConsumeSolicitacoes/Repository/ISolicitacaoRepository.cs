using ConsumeSolicitacoes.Dto;
using ConsumeSolicitacoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Repository
{
    public interface ISolicitacaoRepository
    {
        public Task SaveAsync(SolicitacaoModel solicitacaoModel);
        public Task<List<SolicitacaoModel>> GetAllAsync();
        public Task<List<SolicitacaoModel>> GetByLastTwelveMoth();
        public Task<List<SolicitacaoViewModel>> GetBydistrictMoreAffected();
        public Task<List<SocilitacaoByYearViewModel>> GetByConsultByYear();

    }
}
