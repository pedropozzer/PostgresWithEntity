using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Entities.Models
{

    public class NotaFiscalEmitida : EntityBase
    {
        public long FilialId { get; set; }

        public long? Numero { get; set; }

        public string Serie { get; set; }

        public long? CliId { get; set; }

        public string Nomecliente { get; set; }

        public string Enderecocliente { get; set; }

        public string Complementocliente { get; set; }

        public string Cepcliente { get; set; }

        public string Fone { get; set; }

        public string Celular { get; set; }

        public string Clientecnpj { get; set; }

        public string Clienteie { get; set; }

        public long? BaiId { get; set; }

        public long? CidId { get; set; }

        public long? EstId { get; set; }

        public string Condicao { get; set; }

        public string Situacao { get; set; }

        public decimal? Desconto { get; set; }

        public string Emitiunota { get; set; }

        public string Placa { get; set; }

        public string Kilometragem { get; set; }

        public decimal? Juros { get; set; }

        public TimeSpan? Hora { get; set; }

        public DateTime? Emissao { get; set; }

        public TimeSpan? Horapagto { get; set; }

        public DateTime? Datapagamento { get; set; }

        public long? FunId { get; set; }

        public long? OpfId { get; set; }

        public long? CaxId { get; set; }

        public long? FunIdoperador { get; set; }

        public decimal? Mediakm { get; set; }

        public long? CaxIdrecebimento { get; set; }

        public string Observacao { get; set; }

        public string Motivocancelamento { get; set; }

        public long? FatId { get; set; }

        public string CliIdanterior { get; set; }

        public string Precoespecial { get; set; }

        public long? BanIdtipopagto { get; set; }

        public string Dataalteracao { get; set; }

        public decimal? Totalicms { get; set; }

        public decimal? Totalnota { get; set; }

        public decimal? Totalprodutos { get; set; }

        public string CpgId { get; set; }

        public string NfvId { get; set; }

        public string Numerocliente { get; set; }

        public string Serieequipto { get; set; }

        public long? Matriculaautorizado { get; set; }

        public string Nomeautorizado { get; set; }

        public string Frota { get; set; }

        public string Ordemcompra { get; set; }

        public DateTime? Dtultalt { get; set; }

        public long? FilialIdfatura { get; set; }

        public string FilialIdrecebimento { get; set; }

        public string Dataehoraultenvio { get; set; }

        public string Statusenvio { get; set; }

        public long? Nrocupomequipto { get; set; }

        public string FilialIdvinculada { get; set; }

        public long? CaxIdprincipal { get; set; }

        public long? BanId { get; set; }

        public string Transpnome { get; set; }

        public string Transpfrete { get; set; }

        public string Transpplaca { get; set; }

        public string Transpufplaca { get; set; }

        public string Transpendereco { get; set; }

        public string Transpmunicipio { get; set; }

        public string Transpuftransp { get; set; }

        public string Transpcpfcnpj { get; set; }

        public string Transpinscest { get; set; }

        public string Transpquantidade { get; set; }

        public string Transpespecie { get; set; }

        public string Transpmarca { get; set; }

        public string Transpnumero { get; set; }

        public string Transppesobruto { get; set; }

        public string Transppesoliquido { get; set; }

        public decimal? Pontos { get; set; }

        public string Baixadaincobravel { get; set; }

        public long? Quilometragemanterior { get; set; }

        public string Datasaida { get; set; }

        public string Horasaida { get; set; }

        public long? Ilha { get; set; }

        public decimal? Descontobaixa { get; set; }

        public long? PaiId { get; set; }

        public long? Backupdoidnegativoquandofoinecessario { get; set; }

        public string Bairrocliente { get; set; }

        public string Emailcliente { get; set; }

        public string NotaprodutorestId { get; set; }

        public string Notaprodutoranoemes { get; set; }

        public string Notaprodutorcnpj { get; set; }

        public string Notaprodutorcpf { get; set; }

        public string Notaprodutorie { get; set; }

        public string Notaprodutormodelo { get; set; }

        public string Notaprodutorserie { get; set; }

        public string Notaprodutornumero { get; set; }

        public decimal? Horimetro { get; set; }

        public string Mensagemimpostoncm { get; set; }

        public string Cpfnotafiscalgaucha { get; set; }

        public decimal? Mediahorimetro { get; set; }

        public string Documentofiscalreftipo { get; set; }

        public string Documentofiscalrefchavenfe { get; set; }

        public string Documentofiscalrefufemissor { get; set; }

        public string Documentofiscalrefanomesemissao { get; set; }

        public string Documentofiscalrefcnpjemissor { get; set; }

        public string Documentofiscalrefmodelo { get; set; }

        public string Documentofiscalrefserie { get; set; }

        public string Documentofiscalrefnumero { get; set; }

        public string Documentofiscalrefchavecte { get; set; }

        public string Documentofiscalrefnumeroecf { get; set; }

        public string Documentofiscalrefcoo { get; set; }

        public string Textoviatef { get; set; }

        public string Codigotransacaotef { get; set; }

        public string Cupomeletronico { get; set; }

        public string Cfeserie { get; set; }

        public string Cfenumero { get; set; }

        public string Notafiscalservicoeletronica { get; set; }

        public string Nesserie { get; set; }

        public string Nesnumero { get; set; }

        public virtual ICollection<NotaFiscalItens> NotaFiscalItens { get; set; }
    }
}