﻿using ConsumeSolicitacoes.Context;
using ConsumeSolicitacoes.Dto;
using ConsumeSolicitacoes.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Repository
{
    public class SolicitacaoRepository : ISolicitacaoRepository
    {
        private readonly SolicitacaoDbContext _solicitacaoDbContext;

        public SolicitacaoRepository(SolicitacaoDbContext solicitacaoDbContext)
        {
            _solicitacaoDbContext = solicitacaoDbContext;
        }

        public async Task<List<SolicitacaoModel>> GetAllAsync()
        {
            return await _solicitacaoDbContext.SolicitacaoModels.ToListAsync();
        }

        public async Task<List<SocilitacaoByYearViewModel>> GetByConsultByYear()
        {
            return await _solicitacaoDbContext.SocilitacaoByYearViewModels.ToListAsync();
        }

        public Task<List<SolicitacaoViewModel>> GetBydistrictMoreAffected()
        {
            var result = _solicitacaoDbContext.SolicitacaoViews.ToListAsync();
            return result;
        }

        public async Task<List<SolicitacaoModel>> GetByLastTwelveMoth()
        {
            return await _solicitacaoDbContext.SolicitacaoModels.Where(e => e.Month >= DateTime.Now.AddYears(-2)).ToListAsync();
        }

        public async Task SaveAsync(SolicitacaoModel solicitacaoModel)
        {
            try
            {
                _solicitacaoDbContext.SolicitacaoModels.Add(solicitacaoModel);
                await _solicitacaoDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}