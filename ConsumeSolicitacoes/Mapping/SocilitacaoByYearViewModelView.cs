using ConsumeSolicitacoes.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeSolicitacoes.Mapping
{
    public class SocilitacaoByYearViewModelView : IEntityTypeConfiguration<SocilitacaoByYearViewModel>
    {
        public void Configure(EntityTypeBuilder<SocilitacaoByYearViewModel> builder)
        {
            builder.HasNoKey();

            builder.Property(e => e.Ano)
                .HasColumnName("Ano");

            builder.Property(e => e.Qtd)
                .HasColumnName("Qtd");

            builder.ToView("Vw_ConsultByYear");
        }
    }
}
