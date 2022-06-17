using ConsumeSolicitacoes.Dto;
using ConsumeSolicitacoes.Model;
using ConsumeSolicitacoes.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Service
{
    public class SolicitacaoService : ISolicitacaoService
    {
        private readonly ISolicitacaoRepository _solicitacaoRepository;
        public ILogger<SolicitacaoService> _logger { get; set; }
        public SolicitacaoService(ILogger<SolicitacaoService> logger,
            ISolicitacaoRepository solicitacaoRepository)
        {
            _logger = logger;
            _solicitacaoRepository = solicitacaoRepository;
        }
        public async Task<List<SolicitacaoModel>> GetAllAsync()
        {
            return await _solicitacaoRepository.GetAllAsync();
        }

        public async Task InsertAsync(List<SolicitacaoModel> solicitacaoModels)
        {
            _logger.LogInformation("Iniciando processo de tratamento");
            try
            {
                _logger.LogInformation("Dados tratados com sucesso");

                for (var solicitacao = 1; solicitacao < solicitacaoModels.Count; solicitacao++)
                {
                    _logger.LogInformation("Iniciando processo de inserção");
                    await _solicitacaoRepository.SaveAsync(solicitacaoModels[solicitacao]);
                    _logger.LogInformation("Inserção realizada com sucesso");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<List<SolicitacaoModel>> GetByLastTwelveMoth()
        {
            return await _solicitacaoRepository.GetByLastTwelveMoth();
        }

        public async Task<List<SolicitacaoViewModel>> GetBydistrictMoreAffected()
        {
            return await _solicitacaoRepository.GetBydistrictMoreAffected();
        }

        public Task<List<SocilitacaoByYearViewModel>> GetByConsultByYear()
        {
            return _solicitacaoRepository.GetByConsultByYear();
        }

        //public List<SolicitacaoModel> TratedBase(string path)
        //{
        //    try
        //    {
        //        var model =
        //              from linha in
        //             File.ReadAllLines(path)
        //              let clienteDados =
        //                linha.Split(';')

        //              select new SolicitacaoModel()
        //              {
        //                  Ano = clienteDados[0],
        //                  Mes = clienteDados[1],
        //                  ProcessoNumero = clienteDados[2],
        //                  SolicitacaoData = clienteDados[3],

        //                  SolicitacaoHora = clienteDados[4],
        //                  SolicitacaoDescricao = clienteDados[5],
        //                  SolicitacaoRegional = clienteDados[6],
        //                  SolicitacaoBairro = clienteDados[7],
        //                  SolicitacaoLocalidade = clienteDados[8],
        //                  SolicitacaoEndereco = clienteDados[9],
        //                  SolicitacaoRoteiro = clienteDados[10],
        //                  RpaCodigo = clienteDados[11],
        //                  RpaNome = clienteDados[12],
        //                  SolicitacaoMicrorregiao = clienteDados[13],
        //                  SolicitacaoPlantao = clienteDados[14],
        //                  ProcessoSituacao = clienteDados[15],
        //                  ProcessoTipo = clienteDados[16],
        //                  ProcessoOrigem = clienteDados[17],
        //                  ProcessoSolicitacao = clienteDados[18]

        //              };

        //        return model.ToList();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

    }
}
