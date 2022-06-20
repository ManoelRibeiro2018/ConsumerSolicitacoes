using Domain.Solicitacoes.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Solicitacoes.Mapping
{
    public class SocilitacaoByYearViewMap : IEntityTypeConfiguration<SocilitacaoByYearViewModel>
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
