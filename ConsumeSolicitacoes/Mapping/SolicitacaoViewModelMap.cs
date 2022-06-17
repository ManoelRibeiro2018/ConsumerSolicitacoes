using ConsumeSolicitacoes.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Mapping
{
    public class SolicitacaoViewModelMap : IEntityTypeConfiguration<SolicitacaoViewModel>
    {
        public void Configure(EntityTypeBuilder<SolicitacaoViewModel> builder)
        {
            builder.HasNoKey();

            builder.Property(e => e.Qtd)
                .HasColumnName("Qtd");

            builder.Property(e => e.Solicitacao_bairro)
                .HasColumnName("SolicitacaoBairro");

            builder.ToView("Vw_ConsultBydistrictMoreAffected");
        }
    }
}
