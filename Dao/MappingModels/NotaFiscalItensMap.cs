
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Dao.Mapping;
using Entities.Models;

namespace Dao.MappingModels
{
    public class NotaFiscalItensMap : IMap
    {
        public void Mapping(DbModelBuilder modelBuilder)
        {
            //NotaItem
            modelBuilder.Entity<NotaFiscalItens>().ToTable("notafiscalitens", "public");

            //NotaItem Id
            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Id).HasColumnName("nti_id");
            modelBuilder.Entity<NotaFiscalItens>().HasKey(c => new{c.Id, c.FilialId});

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.NteId).HasColumnName("nti_nte_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.ProId).HasColumnName("nti_pro_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Nomeproduto).HasColumnName("nti_nomeproduto");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Precounitario).HasColumnName("nti_precounitario");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Quantidade).HasColumnName("nti_quantidade");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Totalprodutos).HasColumnName("nti_totalprodutos");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Valoricms).HasColumnName("nti_valoricms");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Aliquotaicms).HasColumnName("nti_aliquotaicms");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Precocusto).HasColumnName("nti_precocusto");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Desconto).HasColumnName("nti_desconto");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Codigoencerrante).HasColumnName("nti_codigoencerrante");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Dtultalt).HasColumnName("nti_dtultalt");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.FilialId).HasColumnName("nti_fil_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Dataehoraultenvio).HasColumnName("nti_dataehoraultenvio");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Statusenvio).HasColumnName("nti_statusenvio");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Precounitariooriginal).HasColumnName("nti_precounitariooriginal");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Pontostroca).HasColumnName("nti_pontostroca");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Numerocombo).HasColumnName("nti_numerocombo");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.OpfId).HasColumnName("nti_opf_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Situacaotributaria).HasColumnName("nti_situacaotributaria");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Percbaseicms).HasColumnName("nti_percbaseicms");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Codigosticms).HasColumnName("nti_codigosticms");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Codigostpis).HasColumnName("nti_codigostpis");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Codigostcofins).HasColumnName("nti_codigostcofins");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Precounitariobaseparadesconto).HasColumnName("nti_precounitariobaseparadesconto");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.AbaId).HasColumnName("nti_aba_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.FunId).HasColumnName("nti_fun_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Servico).HasColumnName("nti_servico");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Aliquotaissqn).HasColumnName("nti_aliquotaissqn");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.Sigla).HasColumnName("nti_sigla");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.ProcomboId).HasColumnName("nti_pro_combo_id");

            modelBuilder.Entity<NotaFiscalItens>().Property(c => c.NtrId).HasColumnName("nti_ntr_id");

            modelBuilder.Entity<NotaFiscalItens>().HasRequired(b => b.NotaFiscalEmitida).WithMany(c => c.NotaFiscalItens).HasForeignKey(b => new { b.NteId, b.FilialId });
        }
    }
}