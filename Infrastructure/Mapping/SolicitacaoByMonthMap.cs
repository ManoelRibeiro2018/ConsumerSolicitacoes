using Domain.Solicitacoes.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Solicitacoes.Mapping
{
    public class SolicitacaoByMonthMap : IEntityTypeConfiguration<SolicitacaoByMonthViewModel>
    {
        public void Configure(EntityTypeBuilder<SolicitacaoByMonthViewModel> builder)
        {
            builder.HasNoKey();

            builder.Property(e => e.Mes)
                .HasColumnName("mes");

            builder.Property(e => e.Qtd)
                .HasColumnName("Qtd");

            builder.ToView("Vw_ConsultByMonth");
        }
    }
}
