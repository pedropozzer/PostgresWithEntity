
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Dao.Mapping;
using Entities.Models;

namespace Dao.MappingModels
{
    public class NotaFiscalEmitidaMap : IMap
    {
        public void Mapping(DbModelBuilder modelBuilder)
        {
            //Cliente
            modelBuilder.Entity<NotaFiscalEmitida>().ToTable("notafiscalemitida", "public");

            //Cliente Id
            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Id).HasColumnName("nte_id");
            modelBuilder.Entity<NotaFiscalEmitida>().HasKey(c => new {c.Id, c.FilialId});

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Id).HasColumnName("nte_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FilialId).HasColumnName("nte_fil_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Numero).HasColumnName("nte_numero");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Serie).HasColumnName("nte_serie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CliId).HasColumnName("nte_cli_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Nomecliente).HasColumnName("nte_nomecliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Enderecocliente).HasColumnName("nte_enderecocliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Complementocliente).HasColumnName("nte_complementocliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Cepcliente).HasColumnName("nte_cepcliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Fone).HasColumnName("nte_fone");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Celular).HasColumnName("nte_celular");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Clientecnpj).HasColumnName("nte_clientecnpj");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Clienteie).HasColumnName("nte_clienteie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.BaiId).HasColumnName("nte_bai_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CidId).HasColumnName("nte_cid_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.EstId).HasColumnName("nte_est_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Condicao).HasColumnName("nte_condicao");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Situacao).HasColumnName("nte_situacao");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Desconto).HasColumnName("nte_desconto");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Emitiunota).HasColumnName("nte_emitiunota");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Placa).HasColumnName("nte_placa");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Kilometragem).HasColumnName("nte_kilometragem");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Juros).HasColumnName("nte_juros");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Hora).HasColumnName("nte_hora");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Emissao).HasColumnName("nte_emissao");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Horapagto).HasColumnName("nte_horapagto");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Datapagamento).HasColumnName("nte_datapagamento");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FunId).HasColumnName("nte_fun_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.OpfId).HasColumnName("nte_opf_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CaxId).HasColumnName("nte_cax_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FunIdoperador).HasColumnName("nte_fun_id_operador");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Mediakm).HasColumnName("nte_mediakm");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CaxIdrecebimento).HasColumnName("nte_cax_id_recebimento");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Observacao).HasColumnName("nte_observacao");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Motivocancelamento).HasColumnName("nte_motivocancelamento");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FatId).HasColumnName("nte_fat_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CliIdanterior).HasColumnName("nte_cli_id_anterior");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Precoespecial).HasColumnName("nte_precoespecial");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.BanIdtipopagto).HasColumnName("nte_ban_id_tipopagto");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Dataalteracao).HasColumnName("nte_dataalteracao");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Totalicms).HasColumnName("nte_totalicms");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Totalnota).HasColumnName("nte_totalnota");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Totalprodutos).HasColumnName("nte_totalprodutos");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CpgId).HasColumnName("nte_cpg_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.NfvId).HasColumnName("nte_nfv_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Numerocliente).HasColumnName("nte_numerocliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Serieequipto).HasColumnName("nte_serieequipto");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Matriculaautorizado).HasColumnName("nte_matricula_autorizado");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Nomeautorizado).HasColumnName("nte_nome_autorizado");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Frota).HasColumnName("nte_frota");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Ordemcompra).HasColumnName("nte_ordemcompra");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Dtultalt).HasColumnName("nte_dtultalt");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FilialIdfatura).HasColumnName("nte_fil_id_fatura");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FilialIdrecebimento).HasColumnName("nte_fil_id_recebimento");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Dataehoraultenvio).HasColumnName("nte_dataehoraultenvio");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Statusenvio).HasColumnName("nte_statusenvio");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Nrocupomequipto).HasColumnName("nte_nrocupomequipto");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.FilialIdvinculada).HasColumnName("nte_fil_id_vinculada");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.CaxIdprincipal).HasColumnName("nte_cax_id_principal");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.BanId).HasColumnName("nte_ban_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpnome).HasColumnName("nte_transpnome");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpfrete).HasColumnName("nte_transpfrete");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpplaca).HasColumnName("nte_transpplaca");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpufplaca).HasColumnName("nte_transpufplaca");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpendereco).HasColumnName("nte_transpendereco");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpmunicipio).HasColumnName("nte_transpmunicipio");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpuftransp).HasColumnName("nte_transpuftransp");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpcpfcnpj).HasColumnName("nte_transpcpfcnpj");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpinscest).HasColumnName("nte_transpinscest");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpquantidade).HasColumnName("nte_transpquantidade");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpespecie).HasColumnName("nte_transpespecie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpmarca).HasColumnName("nte_transpmarca");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transpnumero).HasColumnName("nte_transpnumero");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transppesobruto).HasColumnName("nte_transppesobruto");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Transppesoliquido).HasColumnName("nte_transppesoliquido");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Pontos).HasColumnName("nte_pontos");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Baixadaincobravel).HasColumnName("nte_baixadaincobravel");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Quilometragemanterior).HasColumnName("nte_quilometragemanterior");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Datasaida).HasColumnName("nte_datasaida");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Horasaida).HasColumnName("nte_horasaida");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Ilha).HasColumnName("nte_ilha");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Descontobaixa).HasColumnName("nte_descontobaixa");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.PaiId).HasColumnName("nte_pai_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Backupdoidnegativoquandofoinecessario).HasColumnName("nte_backupdoidnegativoquandofoinecessario");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Bairrocliente).HasColumnName("nte_bairrocliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Emailcliente).HasColumnName("nte_emailcliente");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.NotaprodutorestId).HasColumnName("nte_notaprodutor_est_id");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutoranoemes).HasColumnName("nte_notaprodutoranoemes");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutorcnpj).HasColumnName("nte_notaprodutorcnpj");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutorcpf).HasColumnName("nte_notaprodutorcpf");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutorie).HasColumnName("nte_notaprodutorie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutormodelo).HasColumnName("nte_notaprodutormodelo");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutorserie).HasColumnName("nte_notaprodutorserie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notaprodutornumero).HasColumnName("nte_notaprodutornumero");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Horimetro).HasColumnName("nte_horimetro");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Mensagemimpostoncm).HasColumnName("nte_mensagemimpostoncm");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Cpfnotafiscalgaucha).HasColumnName("nte_cpfnotafiscalgaucha");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Mediahorimetro).HasColumnName("nte_mediahorimetro");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalreftipo).HasColumnName("nte_documentofiscalreftipo");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefchavenfe).HasColumnName("nte_documentofiscalrefchavenfe");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefufemissor).HasColumnName("nte_documentofiscalrefufemissor");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefanomesemissao).HasColumnName("nte_documentofiscalrefanomesemissao");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefcnpjemissor).HasColumnName("nte_documentofiscalrefcnpjemissor");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefmodelo).HasColumnName("nte_documentofiscalrefmodelo");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefserie).HasColumnName("nte_documentofiscalrefserie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefnumero).HasColumnName("nte_documentofiscalrefnumero");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefchavecte).HasColumnName("nte_documentofiscalrefchavecte");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefnumeroecf).HasColumnName("nte_documentofiscalrefnumeroecf");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Documentofiscalrefcoo).HasColumnName("nte_documentofiscalrefcoo");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Textoviatef).HasColumnName("nte_textoviatef");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Codigotransacaotef).HasColumnName("nte_codigotransacaotef");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Cupomeletronico).HasColumnName("nte_cupomeletronico");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Cfeserie).HasColumnName("nte_cfe_serie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Cfenumero).HasColumnName("nte_cfe_numero");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Notafiscalservicoeletronica).HasColumnName("nte_notafiscalservicoeletronica");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Nesserie).HasColumnName("nte_nes_serie");

            modelBuilder.Entity<NotaFiscalEmitida>().Property(c => c.Nesnumero).HasColumnName("nte_nes_numero");
        }
    }
}