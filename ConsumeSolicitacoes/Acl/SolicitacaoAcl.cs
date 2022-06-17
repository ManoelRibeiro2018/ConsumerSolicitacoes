using ConsumeSolicitacoes.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Acl
{
    public class SolicitacaoAcl : ISolicitacaoAcl
    {
        public async Task<List<SolicitacaoModel>> GetSolicitacaoModelsAcl()
        {
            List<SolicitacaoModel> listSolicitacao = new List<SolicitacaoModel>(); 
            HttpClient client = new();
            var response = await client.GetAsync("http://60ef-35-245-221-211.ngrok.io/");
            var content = await response.Content.ReadAsStringAsync();

            var solicitacoes = JsonConvert.DeserializeObject<SolicitacaoModel[]>(content);
            for (int i = 0; i < solicitacoes.Length; i++)
            {
                listSolicitacao.Add(solicitacoes[i]);
            }

            return listSolicitacao;
        }

    }
}
