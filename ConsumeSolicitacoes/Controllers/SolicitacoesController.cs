using ConsumeSolicitacoes.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.IO;
using ConsumeSolicitacoes.Service;
using ConsumeSolicitacoes.Acl;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Controllers
{
    [Route("api/[controller]")]
    public class SolicitacoesController : ControllerBase
    {
        private readonly ISolicitacaoService _solicitacaoService;
        private readonly ISolicitacaoAcl _solicitacaoAcl;
        public SolicitacoesController(ISolicitacaoService solicitacaoService,
            ISolicitacaoAcl solicitacaoAcl)
        {
            _solicitacaoService = solicitacaoService;
            _solicitacaoAcl = solicitacaoAcl;
        }

        [HttpPost]
        public async Task<IActionResult> Insert()
        {
            var result = await _solicitacaoAcl.GetSolicitacaoModelsAcl();
            await _solicitacaoService.InsertAsync(result);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var solicitacoes = await _solicitacaoService.GetAllAsync();
            return Ok(solicitacoes);
        }

        [HttpGet("GetByLastTwelveMoth")]
        public async Task<IActionResult> GetByLastTwelveMoth()
        {
            var result = await _solicitacaoService.GetByLastTwelveMoth();
            return Ok(result);
        }

        [HttpGet("GetBydistrictMoreAffected")]
        public async Task<IActionResult> GetBydistrictMoreAffected()
        {
            var result = await _solicitacaoService.GetBydistrictMoreAffected();
            return Ok(result);
        }

        [HttpGet("GetByConsultByYear")]
        public async Task<IActionResult> GetByConsultByYear()
        {
            var result = await _solicitacaoService.GetByConsultByYear();
            return Ok(result);
        }
    }
}
