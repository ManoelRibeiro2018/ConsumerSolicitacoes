using ConsumeSolicitacoes.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeSolicitacoes.Configuration
{
    public class SolicitacaoMap : IEntityTypeConfiguration<SolicitacaoModel>
    {
        public void Configure(EntityTypeBuilder<SolicitacaoModel> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Ano)
                .HasColumnName("Ano");

            // Solcitações
            builder.Property(e => e.Solicitacao_localidade)
                .HasColumnName("SolicitacaoLocalidade");

            builder.Property(e => e.Solicitacao_plantao)
              .HasColumnName("SolicitacaoPlantao");

            builder.Property(e => e.Solicitacao_bairro)
              .HasColumnName("SolicitacaoBairro");

            builder.Property(e => e.Solicitacao_data)
              .HasColumnName("SolicitacaoData");

            builder.Property(e => e.Solicitacao_descricao)
              .HasColumnName("SolicitacaoDescricao");

            builder.Property(e => e.Solicitacao_endereco)
              .HasColumnName("SolicitacaoEndereco");

            builder.Property(e => e.Solicitacao_hora)
              .HasColumnName("SolicitacaoHora");

            builder.Property(e => e.Solicitacao_localidade)
              .HasColumnName("SolicitacaoLocalidade");


            builder.Property(e => e.Solicitacao_plantao)
              .HasColumnName("SolicitacaoPlantao");

            builder.Property(e => e.Solicitacao_regional)
              .HasColumnName("SolicitacaoRegional");

            builder.Property(e => e.Solicitacao_roteiro)
              .HasColumnName("SolicitacaoRoteiro");

            builder.Property(e => e.Solicitacao_microrregiao)
              .HasColumnName("SolicitacaoMicrorregiao");

            builder.Property(e => e.Mes)
                .HasColumnName("Mes");


            builder.Property(e => e.EndUnico)
                .HasColumnName("EndUnico");

            // Processos
            builder.Property(e => e.Processo_solicitacao_Vistoria)
              .HasColumnName("ProcessoSolicitacaoVistoria");

            builder.Property(e => e.Processo_origem)
              .HasColumnName("ProcessoOrigem");

            builder.Property(e => e.Processo_numero)
                .HasColumnName("ProcessoNumero");

            builder.Property(e => e.Processo_situacao)
                .HasColumnName("ProcessoSituacao");

            builder.Property(e => e.Processo_tipo)
                .HasColumnName("ProcessoTipo");

            builder.Property(e => e.ProcessoSolicitacaoColocacaoDeLonasPlasticas)
                .HasColumnName("ProcessoSolicitacaoColocacaoDeLonasPlasticas");         

            builder.Property(e => e.Rpa_codigo)
                .HasColumnName("RpaCodigo");

            builder.Property(e => e.Rpa_nome)
                .HasColumnName("RpaNome");

            //TODO  - analisar esses  ampos
            builder.Property(e => e.MesAno)
                .HasColumnName("MesAno");
            builder.Property(e => e.Datetime)
                .HasColumnName("datetime");

            builder.Property(e => e.Month)
                .HasColumnName("month");

            builder.ToTable("SOLICITACAO");

        }
    }
}
