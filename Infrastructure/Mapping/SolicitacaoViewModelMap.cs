using Domain.Solicitacoes.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
