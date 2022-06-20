using Newtonsoft.Json;
using System;

namespace Domain.Solicitacoes.Model
{
    public class SolicitacaoModel
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Mes { get; set; }
        public string Processo_numero { get; set; }
        public string Solicitacao_data { get; set; }
        public string Solicitacao_hora { get; set; }
        public string Solicitacao_descricao { get; set; }
        public string Solicitacao_regional { get; set; }
        public string Solicitacao_bairro { get; set; }
        public string Solicitacao_localidade { get; set; }
        public string Solicitacao_endereco { get; set; }
        public string Solicitacao_roteiro { get; set; }
        public string Rpa_codigo { get; set; }
        public string Rpa_nome { get; set; }
        public string Solicitacao_microrregiao { get; set; }
        public string Solicitacao_plantao { get; set; }
        public string Processo_situacao { get; set; }
        public string Processo_tipo { get; set; }
        public string Processo_origem { get; set; }

        [JsonProperty("processo_solicitacao_Colocacao de Lonas Plasticas")]
        public int ProcessoSolicitacaoColocacaoDeLonasPlasticas { get; set; }
        public int Processo_solicitacao_Vistoria { get; set; }
        public string EndUnico { get; set; }
        public DateTime Datetime { get; set; }
        public DateTime Month { get; set; }
        public string MesAno { get; set; }
    }
}
