using System;

namespace Entities.Models
{

    public class NotaFiscalItens : EntityBase
    {
        public long NteId { get; set; }

        public long FilialId { get; set; }

        public long? ProId { get; set; }

        public string Nomeproduto { get; set; }

        public decimal? Precounitario { get; set; }

        public decimal? Quantidade { get; set; }

        public decimal? Totalprodutos { get; set; }

        public decimal? Valoricms { get; set; }

        public decimal? Aliquotaicms { get; set; }

        public decimal? Precocusto { get; set; }

        public decimal? Desconto { get; set; }

        public decimal? Codigoencerrante { get; set; }

        public DateTime? Dtultalt { get; set; }

        public string Dataehoraultenvio { get; set; }

        public string Statusenvio { get; set; }

        public decimal? Precounitariooriginal { get; set; }

        public decimal? Pontostroca { get; set; }

        public decimal? Numerocombo { get; set; }

        public long? OpfId { get; set; }

        public string Situacaotributaria { get; set; }

        public decimal? Percbaseicms { get; set; }

        public string Codigosticms { get; set; }

        public string Codigostpis { get; set; }

        public string Codigostcofins { get; set; }

        public decimal? Precounitariobaseparadesconto { get; set; }

        public decimal? AbaId { get; set; }

        public decimal? FunId { get; set; }

        public string Servico { get; set; }

        public decimal? Aliquotaissqn { get; set; }

        public string Sigla { get; set; }

        public long? ProcomboId { get; set; }

        public string NtrId { get; set; }

        public virtual NotaFiscalEmitida NotaFiscalEmitida { get; set; }
    }
}