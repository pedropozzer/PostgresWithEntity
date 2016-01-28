using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Dao.Mapping;
using Entities.Models;

namespace Dao.MappingModels
{
    public class ClienteMap : IMap
    {
        public void Mapping(DbModelBuilder modelBuilder)
        {
            //Cliente
            modelBuilder.Entity<Clientes>().ToTable("clientes", "public");

            //Cliente Id
            modelBuilder.Entity<Clientes>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Clientes>().Property(c => c.Id).HasColumnName("cli_id");
            modelBuilder.Entity<Clientes>().HasKey(c => c.Id);

            modelBuilder.Entity<Clientes>().Property(c => c.MstId).HasColumnName("cli_mst_id");

            modelBuilder.Entity<Clientes>().Property(c => c.EstIdcobranca).HasColumnName("cli_est_id_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.CidIdcobranca).HasColumnName("cli_cid_id_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.BaiIdcobranca).HasColumnName("cli_bai_id_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.EstId).HasColumnName("cli_est_id");

            modelBuilder.Entity<Clientes>().Property(c => c.CidId).HasColumnName("cli_cid_id");

            modelBuilder.Entity<Clientes>().Property(c => c.BaiId).HasColumnName("cli_bai_id");

            modelBuilder.Entity<Clientes>().Property(c => c.Razaosocial).HasColumnName("cli_razaosocial");

            modelBuilder.Entity<Clientes>().Property(c => c.Tipopessoa).HasColumnName("cli_tipopessoa");

            modelBuilder.Entity<Clientes>().Property(c => c.Suspenso).HasColumnName("cli_suspenso");

            modelBuilder.Entity<Clientes>().Property(c => c.Motivosuspenso).HasColumnName("cli_motivosuspenso");

            modelBuilder.Entity<Clientes>().Property(c => c.Nomepai).HasColumnName("cli_nomepai");

            modelBuilder.Entity<Clientes>().Property(c => c.Nomemae).HasColumnName("cli_nomemae");

            modelBuilder.Entity<Clientes>().Property(c => c.Nascimento).HasColumnName("cli_nascimento");

            modelBuilder.Entity<Clientes>().Property(c => c.Logradouro).HasColumnName("cli_logradouro");

            modelBuilder.Entity<Clientes>().Property(c => c.Numero).HasColumnName("cli_numero");

            modelBuilder.Entity<Clientes>().Property(c => c.Complemento).HasColumnName("cli_complemento");

            modelBuilder.Entity<Clientes>().Property(c => c.Cep).HasColumnName("cli_cep");

            modelBuilder.Entity<Clientes>().Property(c => c.Email).HasColumnName("cli_email");

            modelBuilder.Entity<Clientes>().Property(c => c.Identidade).HasColumnName("cli_identidade");

            modelBuilder.Entity<Clientes>().Property(c => c.Cpf).HasColumnName("cli_cpf");

            modelBuilder.Entity<Clientes>().Property(c => c.Cnpj).HasColumnName("cli_cnpj");

            modelBuilder.Entity<Clientes>().Property(c => c.Ie).HasColumnName("cli_ie");

            modelBuilder.Entity<Clientes>().Property(c => c.Limitecredito).HasColumnName("cli_limitecredito");

            modelBuilder.Entity<Clientes>().Property(c => c.Mediakm).HasColumnName("cli_mediakm");

            modelBuilder.Entity<Clientes>().Property(c => c.Dataabertura).HasColumnName("cli_dataabertura");

            modelBuilder.Entity<Clientes>().Property(c => c.Observacao).HasColumnName("cli_observacao");

            modelBuilder.Entity<Clientes>().Property(c => c.Ativo).HasColumnName("cli_ativo");

            modelBuilder.Entity<Clientes>().Property(c => c.Bonus).HasColumnName("cli_bonus");

            modelBuilder.Entity<Clientes>().Property(c => c.Obrigaplaca).HasColumnName("cli_obrigaplaca");

            modelBuilder.Entity<Clientes>().Property(c => c.Obrigaleituraobs).HasColumnName("cli_obrigaleituraobs");

            modelBuilder.Entity<Clientes>().Property(c => c.Logradourocobranca).HasColumnName("cli_logradouro_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.Numerocobranca).HasColumnName("cli_numero_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.Cepcobranca).HasColumnName("cli_cep_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.Complementocobranca).HasColumnName("cli_complemento_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.Ramoatividade).HasColumnName("cli_ramoatividade");

            modelBuilder.Entity<Clientes>().Property(c => c.Contatocob).HasColumnName("cli_contatocob");

            modelBuilder.Entity<Clientes>().Property(c => c.Fonecontatocob).HasColumnName("cli_fonecontatocob");

            modelBuilder.Entity<Clientes>().Property(c => c.Cargocontatocob).HasColumnName("cli_cargocontatocob");

            modelBuilder.Entity<Clientes>().Property(c => c.Utilizaprecosespeciais).HasColumnName("cli_utilizaprecosespeciais");

            modelBuilder.Entity<Clientes>().Property(c => c.Cortesias).HasColumnName("cli_cortesias");

            modelBuilder.Entity<Clientes>().Property(c => c.Exigeordemabastec).HasColumnName("cli_exigeordemabastec");

            modelBuilder.Entity<Clientes>().Property(c => c.Diacobranca).HasColumnName("cli_diacobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.FunId).HasColumnName("cli_fun_id");

            modelBuilder.Entity<Clientes>().Property(c => c.Suframa).HasColumnName("cli_suframa");

            modelBuilder.Entity<Clientes>().Property(c => c.Aliquotaicms).HasColumnName("cli_aliquotaicms");

            modelBuilder.Entity<Clientes>().Property(c => c.CatId).HasColumnName("cli_cat_id");

            modelBuilder.Entity<Clientes>().Property(c => c.PrsId).HasColumnName("cli_prs_id");

            modelBuilder.Entity<Clientes>().Property(c => c.Diasparavencimento).HasColumnName("cli_diasparavencimento");

            modelBuilder.Entity<Clientes>().Property(c => c.Somentevista).HasColumnName("cli_somentevista");

            modelBuilder.Entity<Clientes>().Property(c => c.Utilizacartao).HasColumnName("cli_utilizacartao");

            modelBuilder.Entity<Clientes>().Property(c => c.Utilizacartaodoposto).HasColumnName("cli_utilizacartaodoposto");

            modelBuilder.Entity<Clientes>().Property(c => c.Separarfaturaporassociado).HasColumnName("cli_separarfaturaporassociado");

            modelBuilder.Entity<Clientes>().Property(c => c.Ordemabastecimento).HasColumnName("cli_ordemabastecimento");

            modelBuilder.Entity<Clientes>().Property(c => c.Obsfatura).HasColumnName("cli_obsfatura");

            modelBuilder.Entity<Clientes>().Property(c => c.Informacoes).HasColumnName("cli_informacoes");

            modelBuilder.Entity<Clientes>().Property(c => c.Emitirnotaref).HasColumnName("cli_emitirnotaref");

            modelBuilder.Entity<Clientes>().Property(c => c.CobId).HasColumnName("cli_cob_id");

            modelBuilder.Entity<Clientes>().Property(c => c.TipId).HasColumnName("cli_tip_id");

            modelBuilder.Entity<Clientes>().Property(c => c.Cobranca).HasColumnName("cli_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.FilialIdpreferencia).HasColumnName("cli_fil_id_preferencia");

            modelBuilder.Entity<Clientes>().Property(c => c.Limitecreditomensal).HasColumnName("cli_limitecreditomensal");

            modelBuilder.Entity<Clientes>().Property(c => c.Emitirnotarefmensal).HasColumnName("cli_emitirnotarefmensal");

            modelBuilder.Entity<Clientes>().Property(c => c.Obrigaobs).HasColumnName("cli_obrigaobs");

            modelBuilder.Entity<Clientes>().Property(c => c.Percdescontonafatura).HasColumnName("cli_percdescontonafatura");

            modelBuilder.Entity<Clientes>().Property(c => c.Saldopontos).HasColumnName("cli_saldopontos");

            modelBuilder.Entity<Clientes>().Property(c => c.Saldotabela1).HasColumnName("cli_saldotabela1");

            modelBuilder.Entity<Clientes>().Property(c => c.Saldotabela2).HasColumnName("cli_saldotabela2");

            modelBuilder.Entity<Clientes>().Property(c => c.Diasparaatrasocupom).HasColumnName("cli_diasparaatrasocupom");

            modelBuilder.Entity<Clientes>().Property(c => c.Diasparaatrasofatura).HasColumnName("cli_diasparaatrasofatura");

            modelBuilder.Entity<Clientes>().Property(c => c.Qtdviasaprazo).HasColumnName("cli_qtdviasaprazo");

            modelBuilder.Entity<Clientes>().Property(c => c.Emailcontato).HasColumnName("cli_emailcontato");

            modelBuilder.Entity<Clientes>().Property(c => c.Identificadordigital).HasColumnName("cli_identificadordigital");

            modelBuilder.Entity<Clientes>().Property(c => c.Fantasia).HasColumnName("cli_fantasia");

            modelBuilder.Entity<Clientes>().Property(c => c.Limitecreditoporlitragem).HasColumnName("cli_limitecreditoporlitragem");

            modelBuilder.Entity<Clientes>().Property(c => c.Enviardanfeautomaticamente).HasColumnName("cli_enviardanfeautomaticamente");

            modelBuilder.Entity<Clientes>().Property(c => c.Dtultalt).HasColumnName("cli_dtultalt");

            modelBuilder.Entity<Clientes>().Property(c => c.Bloqueiachequedevolvido).HasColumnName("cli_bloqueiachequedevolvido");

            modelBuilder.Entity<Clientes>().Property(c => c.PaiId).HasColumnName("cli_pai_id");

            modelBuilder.Entity<Clientes>().Property(c => c.PaiIdcobranca).HasColumnName("cli_pai_id_cobranca");

            modelBuilder.Entity<Clientes>().Property(c => c.Produtor).HasColumnName("cli_produtor");

            modelBuilder.Entity<Clientes>().Property(c => c.Obrigaidentificacaodigitalvendaaprazo).HasColumnName("cli_obrigaidentificacaodigitalvendaaprazo");

            modelBuilder.Entity<Clientes>().Property(c => c.Exigirportalautor).HasColumnName("cli_exigirportalautor");

            modelBuilder.Entity<Clientes>().Property(c => c.Protestar).HasColumnName("cli_protestar");

            modelBuilder.Entity<Clientes>().Property(c => c.Obrigaidentificacaoporcartao).HasColumnName("cli_obrigaidentificacaoporcartao");

            modelBuilder.Entity<Clientes>().Property(c => c.Mensagemaposemitircupom).HasColumnName("cli_mensagemaposemitircupom");

            modelBuilder.Entity<Clientes>().Property(c => c.Inscricaomunicipal).HasColumnName("cli_inscricaomunicipal");

            modelBuilder.Entity<Clientes>().Property(c => c.Agregarobservacoesnanota).HasColumnName("cli_agregarobservacoesnanota");

            modelBuilder.Entity<Clientes>().Property(c => c.Diasparaprotesto).HasColumnName("cli_diasparaprotesto");

            modelBuilder.Entity<Clientes>().Property(c => c.Percentualjurosboleto).HasColumnName("cli_percentualjurosboleto");

            modelBuilder.Entity<Clientes>().Property(c => c.Percentualdescontoboleto).HasColumnName("cli_percentualdescontoboleto"); 
        }
    }
}
