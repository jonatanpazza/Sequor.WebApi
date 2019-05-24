namespace Sequor.WebMvc
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextModel : DbContext
    {
        public ContextModel()
            : base("name=ContextModel")
        {
        }

        public virtual DbSet<WSQOLACIONAMENTOAVALIACAOSTATUS> WSQOLACIONAMENTOAVALIACAOSTATUS { get; set; }
        public virtual DbSet<WSQOLACIONAMENTOAVALIACAOSTATUSTIPO> WSQOLACIONAMENTOAVALIACAOSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLATRIBUTO> WSQOLATRIBUTO { get; set; }
        public virtual DbSet<WSQOLCARGA> WSQOLCARGA { get; set; }
        public virtual DbSet<WSQOLCARGAHIST> WSQOLCARGAHIST { get; set; }
        public virtual DbSet<WSQOLCENTROCUSTO> WSQOLCENTROCUSTO { get; set; }
        public virtual DbSet<WSQOLCENTROCUSTOTEMP> WSQOLCENTROCUSTOTEMP { get; set; }
        public virtual DbSet<WSQOLCLIENTE> WSQOLCLIENTE { get; set; }
        public virtual DbSet<WSQOLCLIENTECIDADEESTADO> WSQOLCLIENTECIDADEESTADO { get; set; }
        public virtual DbSet<WSQOLCLIENTEGRUPOVENDAS> WSQOLCLIENTEGRUPOVENDAS { get; set; }
        public virtual DbSet<WSQOLCODBLOQUEIOESTOQUEITEM> WSQOLCODBLOQUEIOESTOQUEITEM { get; set; }
        public virtual DbSet<WSQOLCOMPONENTEMEDICAO> WSQOLCOMPONENTEMEDICAO { get; set; }
        public virtual DbSet<WSQOLDOCUMENTOINSPECAO> WSQOLDOCUMENTOINSPECAO { get; set; }
        public virtual DbSet<WSQOLENDERECO> WSQOLENDERECO { get; set; }
        public virtual DbSet<WSQOLESPICKINGSCHEDULINGDEF> WSQOLESPICKINGSCHEDULINGDEF { get; set; }
        public virtual DbSet<WSQOLESPICKINGSCHEDULINGDEFHIST> WSQOLESPICKINGSCHEDULINGDEFHIST { get; set; }
        public virtual DbSet<WSQOLESTOQUEATUAL> WSQOLESTOQUEATUAL { get; set; }
        public virtual DbSet<WSQOLESTOQUEMOV> WSQOLESTOQUEMOV { get; set; }
        public virtual DbSet<WSQOLESTOQUEMOVAUXILIARREGRAS> WSQOLESTOQUEMOVAUXILIARREGRAS { get; set; }
        public virtual DbSet<WSQOLESTOQUEMOVAUXILIARSERVICOCONFIG> WSQOLESTOQUEMOVAUXILIARSERVICOCONFIG { get; set; }
        public virtual DbSet<WSQOLESTOQUEMOVAUXILIARSTATUS> WSQOLESTOQUEMOVAUXILIARSTATUS { get; set; }
        public virtual DbSet<WSQOLESTOQUEMOVAUXILIARSTATUSTIPO> WSQOLESTOQUEMOVAUXILIARSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLESTOQUEMOVERP> WSQOLESTOQUEMOVERP { get; set; }
        public virtual DbSet<WSQOLESTOQUESTATUS> WSQOLESTOQUESTATUS { get; set; }
        public virtual DbSet<WSQOLETIQUETASVOLUMESPA> WSQOLETIQUETASVOLUMESPA { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCHAVE> WSQOLEXPEDICAOCHAVE { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCHAVEHIST> WSQOLEXPEDICAOCHAVEHIST { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCHAVELOCALENTREGA> WSQOLEXPEDICAOCHAVELOCALENTREGA { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCHAVELOCALENTREGAHIST> WSQOLEXPEDICAOCHAVELOCALENTREGAHIST { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCHAVEUSUARIO> WSQOLEXPEDICAOCHAVEUSUARIO { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCHAVEUSUARIOHIST> WSQOLEXPEDICAOCHAVEUSUARIOHIST { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOCOMPONENTEGERACAO> WSQOLEXPEDICAOCOMPONENTEGERACAO { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOESTOQUEORDEMVENDALES> WSQOLEXPEDICAOESTOQUEORDEMVENDALES { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP> WSQOLEXPEDICAOESTOQUEORDEMVENDASAP { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOPLANEJAMENTOLESTIPO> WSQOLEXPEDICAOPLANEJAMENTOLESTIPO { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOTIPO> WSQOLEXPEDICAOTIPO { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOVOLUME> WSQOLEXPEDICAOVOLUME { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOVOLUMESTATUSTIPO> WSQOLEXPEDICAOVOLUMESTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLEXPREMESSA> WSQOLEXPREMESSA { get; set; }
        public virtual DbSet<WSQOLEXPREMESSADPCHAVEPICKING> WSQOLEXPREMESSADPCHAVEPICKING { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAHIST> WSQOLEXPREMESSAHIST { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENS> WSQOLEXPREMESSAITENS { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSHIST> WSQOLEXPREMESSAITENSHIST { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST> WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO> WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSNRSERIEHIST> WSQOLEXPREMESSAITENSNRSERIEHIST { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO> WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSSTATUSTIPO> WSQOLEXPREMESSAITENSSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAMOTIVOS> WSQOLEXPREMESSAMOTIVOS { get; set; }
        public virtual DbSet<WSQOLEXPREMESSASTATUSTIPO> WSQOLEXPREMESSASTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLFORNECEDORES> WSQOLFORNECEDORES { get; set; }
        public virtual DbSet<WSQOLFORNECEDORESTIPO> WSQOLFORNECEDORESTIPO { get; set; }
        public virtual DbSet<WSQOLFORNECEDORPRODUTO> WSQOLFORNECEDORPRODUTO { get; set; }
        public virtual DbSet<WSQOLHELPHTML> WSQOLHELPHTML { get; set; }
        public virtual DbSet<WSQOLIMAGEMINSPECAO> WSQOLIMAGEMINSPECAO { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEM> WSQOLINHAMONTAGEM { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEMAGRUPAMENTO> WSQOLINHAMONTAGEMAGRUPAMENTO { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEMAGRUPAMENTOHEADER> WSQOLINHAMONTAGEMAGRUPAMENTOHEADER { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEMGRUPO> WSQOLINHAMONTAGEMGRUPO { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEMREGRAS> WSQOLINHAMONTAGEMREGRAS { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEMTIPOESTACAO> WSQOLINHAMONTAGEMTIPOESTACAO { get; set; }
        public virtual DbSet<WSQOLINVENTARIO> WSQOLINVENTARIO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOAUDITORIA> WSQOLINVENTARIOAUDITORIA { get; set; }
        public virtual DbSet<WSQOLINVENTARIOAUDITORIATIPO> WSQOLINVENTARIOAUDITORIATIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCHAVE> WSQOLINVENTARIOCHAVE { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCHAVEEQUIPE> WSQOLINVENTARIOCHAVEEQUIPE { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCHAVEFILTROS> WSQOLINVENTARIOCHAVEFILTROS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCHAVELOCAL> WSQOLINVENTARIOCHAVELOCAL { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGEM> WSQOLINVENTARIOCONTAGEM { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGEMHIST> WSQOLINVENTARIOCONTAGEMHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGEMSTATUSTIPO> WSQOLINVENTARIOCONTAGEMSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGENSASSINCRONAS> WSQOLINVENTARIOCONTAGENSASSINCRONAS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGENSASSINCRONASHIST> WSQOLINVENTARIOCONTAGENSASSINCRONASHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUS> WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUSTIPO> WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIODEFINICOES> WSQOLINVENTARIODEFINICOES { get; set; }
        public virtual DbSet<WSQOLINVENTARIODEPOSITOCFG> WSQOLINVENTARIODEPOSITOCFG { get; set; }
        public virtual DbSet<WSQOLINVENTARIOEQUIPE> WSQOLINVENTARIOEQUIPE { get; set; }
        public virtual DbSet<WSQOLINVENTARIOEQUIPEUSUARIO> WSQOLINVENTARIOEQUIPEUSUARIO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOESTOQUE> WSQOLINVENTARIOESTOQUE { get; set; }
        public virtual DbSet<WSQOLINVENTARIOESTOQUEHIST> WSQOLINVENTARIOESTOQUEHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOESTOQUESTATUS> WSQOLINVENTARIOESTOQUESTATUS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOESTOQUESTATUSTIPO> WSQOLINVENTARIOESTOQUESTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOESTRATEGIAINCLUSAOPRODUTOS> WSQOLINVENTARIOESTRATEGIAINCLUSAOPRODUTOS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOHIST> WSQOLINVENTARIOHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOITENS> WSQOLINVENTARIOITENS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOITENSHIST> WSQOLINVENTARIOITENSHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOITENSSTATUS> WSQOLINVENTARIOITENSSTATUS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOITENSSTATUSTIPO> WSQOLINVENTARIOITENSSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOLOCAISTAREFA> WSQOLINVENTARIOLOCAISTAREFA { get; set; }
        public virtual DbSet<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS> WSQOLINVENTARIOLOCAISTAREFAPRODUTOS { get; set; }
        public virtual DbSet<WSQOLINVENTARIORASTREABILIDADE> WSQOLINVENTARIORASTREABILIDADE { get; set; }
        public virtual DbSet<WSQOLINVENTARIOSTATUS> WSQOLINVENTARIOSTATUS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOSTATUSTIPO> WSQOLINVENTARIOSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFAPDFHIST> WSQOLINVENTARIOTAREFAPDFHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFAS> WSQOLINVENTARIOTAREFAS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFASDETALHES> WSQOLINVENTARIOTAREFASDETALHES { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFASHIST> WSQOLINVENTARIOTAREFASHIST { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFASSTATUS> WSQOLINVENTARIOTAREFASSTATUS { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFASSTATUSTIPO> WSQOLINVENTARIOTAREFASSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTAREFASTIPO> WSQOLINVENTARIOTAREFASTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTIPO> WSQOLINVENTARIOTIPO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTIPOBLOQUEIOEDICAO> WSQOLINVENTARIOTIPOBLOQUEIOEDICAO { get; set; }
        public virtual DbSet<WSQOLKANBANACIONAMENTO> WSQOLKANBANACIONAMENTO { get; set; }
        public virtual DbSet<WSQOLKANBANACIONAMENTOHIST> WSQOLKANBANACIONAMENTOHIST { get; set; }
        public virtual DbSet<WSQOLKANBANACIONAMENTOSTATUS> WSQOLKANBANACIONAMENTOSTATUS { get; set; }
        public virtual DbSet<WSQOLKANBANACIONAMENTOSTATUSTIPO> WSQOLKANBANACIONAMENTOSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLKANBANACIONAMENTOTIPO> WSQOLKANBANACIONAMENTOTIPO { get; set; }
        public virtual DbSet<WSQOLKANBANATUAL> WSQOLKANBANATUAL { get; set; }
        public virtual DbSet<WSQOLKANBANCLIENTES> WSQOLKANBANCLIENTES { get; set; }
        public virtual DbSet<WSQOLKANBANCLIENTESGRUPO> WSQOLKANBANCLIENTESGRUPO { get; set; }
        public virtual DbSet<WSQOLKANBANCLIENTESGRUPOHIST> WSQOLKANBANCLIENTESGRUPOHIST { get; set; }
        public virtual DbSet<WSQOLKANBANCLIENTESHIST> WSQOLKANBANCLIENTESHIST { get; set; }
        public virtual DbSet<WSQOLKANBANDEF> WSQOLKANBANDEF { get; set; }
        public virtual DbSet<WSQOLKANBANDEFINICOES> WSQOLKANBANDEFINICOES { get; set; }
        public virtual DbSet<WSQOLKANBANDEFINICOESHIST> WSQOLKANBANDEFINICOESHIST { get; set; }
        public virtual DbSet<WSQOLKANBANESTRATEGIAGERACAOTIPO> WSQOLKANBANESTRATEGIAGERACAOTIPO { get; set; }
        public virtual DbSet<WSQOLKANBANIDENTIFICACAO> WSQOLKANBANIDENTIFICACAO { get; set; }
        public virtual DbSet<WSQOLKANBANIDENTIFICACAOPICKING> WSQOLKANBANIDENTIFICACAOPICKING { get; set; }
        public virtual DbSet<WSQOLKANBANMOV> WSQOLKANBANMOV { get; set; }
        public virtual DbSet<WSQOLKANBANSEMDEF> WSQOLKANBANSEMDEF { get; set; }
        public virtual DbSet<WSQOLKANBANSTATUS> WSQOLKANBANSTATUS { get; set; }
        public virtual DbSet<WSQOLKANBANVERIFICAOPABERTATIPO> WSQOLKANBANVERIFICAOPABERTATIPO { get; set; }
        public virtual DbSet<WSQOLLOCAIS> WSQOLLOCAIS { get; set; }
        public virtual DbSet<WSQOLLOCAISCONTROLECODIGO> WSQOLLOCAISCONTROLECODIGO { get; set; }
        public virtual DbSet<WSQOLLOCAISPRODUTOS> WSQOLLOCAISPRODUTOS { get; set; }
        public virtual DbSet<WSQOLLOCAISREGISTROAUXILIARTIPO> WSQOLLOCAISREGISTROAUXILIARTIPO { get; set; }
        public virtual DbSet<WSQOLLOCAISRESTRICOES> WSQOLLOCAISRESTRICOES { get; set; }
        public virtual DbSet<WSQOLLOCAISRESTRICOESPARAMS> WSQOLLOCAISRESTRICOESPARAMS { get; set; }
        public virtual DbSet<WSQOLLOCAISROTAS> WSQOLLOCAISROTAS { get; set; }
        public virtual DbSet<WSQOLLOCAISTAMANHOS> WSQOLLOCAISTAMANHOS { get; set; }
        public virtual DbSet<WSQOLLOCAISTIPOINTEGRACAOERP> WSQOLLOCAISTIPOINTEGRACAOERP { get; set; }
        public virtual DbSet<WSQOLLOCALMOV> WSQOLLOCALMOV { get; set; }
        public virtual DbSet<WSQOLMODULOS> WSQOLMODULOS { get; set; }
        public virtual DbSet<WSQOLMOTORISTAS> WSQOLMOTORISTAS { get; set; }
        public virtual DbSet<WSQOLNF> WSQOLNF { get; set; }
        public virtual DbSet<WSQOLNFITENS> WSQOLNFITENS { get; set; }
        public virtual DbSet<WSQOLNFSTATUS> WSQOLNFSTATUS { get; set; }
        public virtual DbSet<WSQOLOGCONEXAO> WSQOLOGCONEXAO { get; set; }
        public virtual DbSet<WSQOLOGEVENTOS> WSQOLOGEVENTOS { get; set; }
        public virtual DbSet<WSQOLOGINHIST> WSQOLOGINHIST { get; set; }
        public virtual DbSet<WSQOLOGINS> WSQOLOGINS { get; set; }
        public virtual DbSet<WSQOLOGINSPERFIS> WSQOLOGINSPERFIS { get; set; }
        public virtual DbSet<WSQOLOGINSREGRAS> WSQOLOGINSREGRAS { get; set; }
        public virtual DbSet<WSQOLOGINSTIPOUSUARIO> WSQOLOGINSTIPOUSUARIO { get; set; }
        public virtual DbSet<WSQOLPCP2PECACOMPONENTE> WSQOLPCP2PECACOMPONENTE { get; set; }
        public virtual DbSet<WSQOLPCP2PECACOMPONENTEHIST> WSQOLPCP2PECACOMPONENTEHIST { get; set; }
        public virtual DbSet<WSQOLPCP2PECACOMPONENTETIPO> WSQOLPCP2PECACOMPONENTETIPO { get; set; }
        public virtual DbSet<WSQOLPEDIDO> WSQOLPEDIDO { get; set; }
        public virtual DbSet<WSQOLPEDIDOCATEGORIACUSTOS> WSQOLPEDIDOCATEGORIACUSTOS { get; set; }
        public virtual DbSet<WSQOLPEDIDOITENS> WSQOLPEDIDOITENS { get; set; }
        public virtual DbSet<WSQOLPEDIDOMOVIMENTACAO> WSQOLPEDIDOMOVIMENTACAO { get; set; }
        public virtual DbSet<WSQOLPEDIDONF> WSQOLPEDIDONF { get; set; }
        public virtual DbSet<WSQOLPEDIDOTIPO> WSQOLPEDIDOTIPO { get; set; }
        public virtual DbSet<WSQOLPEDIDOTIPOITEM> WSQOLPEDIDOTIPOITEM { get; set; }
        public virtual DbSet<WSQOLPICKINGAUXILIAR> WSQOLPICKINGAUXILIAR { get; set; }
        public virtual DbSet<WSQOLPICKINGAUXILIARHIST> WSQOLPICKINGAUXILIARHIST { get; set; }
        public virtual DbSet<WSQOLPICKINGAUXILIARREGRAS> WSQOLPICKINGAUXILIARREGRAS { get; set; }
        public virtual DbSet<WSQOLPICKINGAUXILIARSTATUS> WSQOLPICKINGAUXILIARSTATUS { get; set; }
        public virtual DbSet<WSQOLPICKINGBAIXACGI> WSQOLPICKINGBAIXACGI { get; set; }
        public virtual DbSet<WSQOLPICKINGCHAVE> WSQOLPICKINGCHAVE { get; set; }
        public virtual DbSet<WSQOLPICKINGCHAVEBLOQUSUARIO> WSQOLPICKINGCHAVEBLOQUSUARIO { get; set; }
        public virtual DbSet<WSQOLPICKINGCHAVECGI> WSQOLPICKINGCHAVECGI { get; set; }
        public virtual DbSet<WSQOLPICKINGCHAVEFINALIZACAOTIPO> WSQOLPICKINGCHAVEFINALIZACAOTIPO { get; set; }
        public virtual DbSet<WSQOLPICKINGCHAVETIPOAPONT> WSQOLPICKINGCHAVETIPOAPONT { get; set; }
        public virtual DbSet<WSQOLPICKINGCHAVEUSUARIO> WSQOLPICKINGCHAVEUSUARIO { get; set; }
        public virtual DbSet<WSQOLPICKINGGRUPO> WSQOLPICKINGGRUPO { get; set; }
        public virtual DbSet<WSQOLPICKINGGRUPOKIT> WSQOLPICKINGGRUPOKIT { get; set; }
        public virtual DbSet<WSQOLPICKINGKITUSUARIO> WSQOLPICKINGKITUSUARIO { get; set; }
        public virtual DbSet<WSQOLPICKINGMOV> WSQOLPICKINGMOV { get; set; }
        public virtual DbSet<WSQOLPICKINGMOVITENS> WSQOLPICKINGMOVITENS { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQ> WSQOLPICKINGSEQ { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQHIST> WSQOLPICKINGSEQHIST { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITEMEMBALAGEM> WSQOLPICKINGSEQITEMEMBALAGEM { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES> WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITENS> WSQOLPICKINGSEQITENS { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITENSSTATUS> WSQOLPICKINGSEQITENSSTATUS { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQORIGEM> WSQOLPICKINGSEQORIGEM { get; set; }
        public virtual DbSet<WSQOLPLANOFREQUENCIA> WSQOLPLANOFREQUENCIA { get; set; }
        public virtual DbSet<WSQOLQLCDEFVINCULO> WSQOLQLCDEFVINCULO { get; set; }
        public virtual DbSet<WSQOLQLCDEFVINCULOPARAMS> WSQOLQLCDEFVINCULOPARAMS { get; set; }
        public virtual DbSet<WSQOLQLCDISPOSITIVOMEDICAO> WSQOLQLCDISPOSITIVOMEDICAO { get; set; }
        public virtual DbSet<WSQOLQLCESTRATEGIA> WSQOLQLCESTRATEGIA { get; set; }
        public virtual DbSet<WSQOLQLCFOTO> WSQOLQLCFOTO { get; set; }
        public virtual DbSet<WSQOLQLCFOTOITENS> WSQOLQLCFOTOITENS { get; set; }
        public virtual DbSet<WSQOLQLCITEMVALIDACAO> WSQOLQLCITEMVALIDACAO { get; set; }
        public virtual DbSet<WSQOLQLCMODULO> WSQOLQLCMODULO { get; set; }
        public virtual DbSet<WSQOLQLCNBRDEF> WSQOLQLCNBRDEF { get; set; }
        public virtual DbSet<WSQOLQLCNBRDEFCODIGOLITERAL> WSQOLQLCNBRDEFCODIGOLITERAL { get; set; }
        public virtual DbSet<WSQOLQLCNBRDEFOLD> WSQOLQLCNBRDEFOLD { get; set; }
        public virtual DbSet<WSQOLQLCNBRDEFREGIMEATENUADO> WSQOLQLCNBRDEFREGIMEATENUADO { get; set; }
        public virtual DbSet<WSQOLQLCNBRHISTSISTEMACOMUTACAO> WSQOLQLCNBRHISTSISTEMACOMUTACAO { get; set; }
        public virtual DbSet<WSQOLQLCOPCOESATRIBUTO> WSQOLQLCOPCOESATRIBUTO { get; set; }
        public virtual DbSet<WSQOLQLCPLANO> WSQOLQLCPLANO { get; set; }
        public virtual DbSet<WSQOLQLCPLANOITEM> WSQOLQLCPLANOITEM { get; set; }
        public virtual DbSet<WSQOLQLCRASTREABILIDADE> WSQOLQLCRASTREABILIDADE { get; set; }
        public virtual DbSet<WSQOLQLCSEGREGADONBR> WSQOLQLCSEGREGADONBR { get; set; }
        public virtual DbSet<WSQOLQLCSEGREGADOS> WSQOLQLCSEGREGADOS { get; set; }
        public virtual DbSet<WSQOLQLCTIPOFOTO> WSQOLQLCTIPOFOTO { get; set; }
        public virtual DbSet<WSQOLQLCTIPOITEM> WSQOLQLCTIPOITEM { get; set; }
        public virtual DbSet<WSQOLQLCVALIDACAO> WSQOLQLCVALIDACAO { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOCODIGORESERVADO> WSQOLRECEBIMENTOCODIGORESERVADO { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOCONTAGENS> WSQOLRECEBIMENTOCONTAGENS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOCONTAGENSHIST> WSQOLRECEBIMENTOCONTAGENSHIST { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTODIVERGENCIA> WSQOLRECEBIMENTODIVERGENCIA { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTODIVERGENCIAACEITE> WSQOLRECEBIMENTODIVERGENCIAACEITE { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTODIVERGENCIAITENS> WSQOLRECEBIMENTODIVERGENCIAITENS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTODIVERGENCIAITENSACAO> WSQOLRECEBIMENTODIVERGENCIAITENSACAO { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTODIVERGENCIATIPO> WSQOLRECEBIMENTODIVERGENCIATIPO { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOERP> WSQOLRECEBIMENTOERP { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOERPHIST> WSQOLRECEBIMENTOERPHIST { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOERPITENS> WSQOLRECEBIMENTOERPITENS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOERPITENSHIST> WSQOLRECEBIMENTOERPITENSHIST { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOERPITENSSTATUS> WSQOLRECEBIMENTOERPITENSSTATUS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOERPSTATUS> WSQOLRECEBIMENTOERPSTATUS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOFOLHAROSTO> WSQOLRECEBIMENTOFOLHAROSTO { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOFOLHAROSTOHIST> WSQOLRECEBIMENTOFOLHAROSTOHIST { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOFOLHAROSTOSTATUS> WSQOLRECEBIMENTOFOLHAROSTOSTATUS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOLOCAISVINCULO> WSQOLRECEBIMENTOLOCAISVINCULO { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOPORTARIA> WSQOLRECEBIMENTOPORTARIA { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOVOLUMES> WSQOLRECEBIMENTOVOLUMES { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOVOLUMESHIST> WSQOLRECEBIMENTOVOLUMESHIST { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOVOLUMESITENS> WSQOLRECEBIMENTOVOLUMESITENS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOVOLUMESITENSHIST> WSQOLRECEBIMENTOVOLUMESITENSHIST { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOVOLUMESSTATUS> WSQOLRECEBIMENTOVOLUMESSTATUS { get; set; }
        public virtual DbSet<WSQOLREQUISICOES> WSQOLREQUISICOES { get; set; }
        public virtual DbSet<WSQOLREQUISICOESFLUXO> WSQOLREQUISICOESFLUXO { get; set; }
        public virtual DbSet<WSQOLREQUISICOESITENS> WSQOLREQUISICOESITENS { get; set; }
        public virtual DbSet<WSQOLREQUISICOESTIPOENTREGA> WSQOLREQUISICOESTIPOENTREGA { get; set; }
        public virtual DbSet<WSQOLREQUISICOESTIPOITEM> WSQOLREQUISICOESTIPOITEM { get; set; }
        public virtual DbSet<WSQOLREQUISICOESTIPOORIGEM> WSQOLREQUISICOESTIPOORIGEM { get; set; }
        public virtual DbSet<WSQOLRESERVA> WSQOLRESERVA { get; set; }
        public virtual DbSet<WSQOLRESERVADPCHAVEPICKING> WSQOLRESERVADPCHAVEPICKING { get; set; }
        public virtual DbSet<WSQOLRESERVAITENS> WSQOLRESERVAITENS { get; set; }
        public virtual DbSet<WSQOLRESTRICAOENDERECO> WSQOLRESTRICAOENDERECO { get; set; }
        public virtual DbSet<WSQOLRESTRICOESDEF> WSQOLRESTRICOESDEF { get; set; }
        public virtual DbSet<WSQOLSPEDIDOVENDACGI> WSQOLSPEDIDOVENDACGI { get; set; }
        public virtual DbSet<WSQOLSPEDIDOVENDAITENSCGI> WSQOLSPEDIDOVENDAITENSCGI { get; set; }
        public virtual DbSet<WSQOLSTATUSLOCAL> WSQOLSTATUSLOCAL { get; set; }
        public virtual DbSet<WSQOLTIPOLOCAL> WSQOLTIPOLOCAL { get; set; }
        public virtual DbSet<WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG> WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG { get; set; }
        public virtual DbSet<WSQOLTIPORECIPIENTE> WSQOLTIPORECIPIENTE { get; set; }
        public virtual DbSet<WSQOLTRANSFERENCIAESTOQUEBAIXA> WSQOLTRANSFERENCIAESTOQUEBAIXA { get; set; }
        public virtual DbSet<WSQOLUNIDADES> WSQOLUNIDADES { get; set; }
        public virtual DbSet<WSQOLUNIDADESCONVERSAO> WSQOLUNIDADESCONVERSAO { get; set; }
        public virtual DbSet<WSQOLUNIDADESMEDIDA> WSQOLUNIDADESMEDIDA { get; set; }
        public virtual DbSet<WSQOLUNIDADESNEGOCIO> WSQOLUNIDADESNEGOCIO { get; set; }
        public virtual DbSet<WSQOLVEICULOSTRANSPORTE> WSQOLVEICULOSTRANSPORTE { get; set; }
        public virtual DbSet<WSQOLVINCULOCARGARECEBIMENTO> WSQOLVINCULOCARGARECEBIMENTO { get; set; }
        public virtual DbSet<WSQOLVINCULOFOLHAROSTORECEBIMENTOERPITEM> WSQOLVINCULOFOLHAROSTORECEBIMENTOERPITEM { get; set; }
        public virtual DbSet<WSQOLCARGASTATUS> WSQOLCARGASTATUS { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOITEMREMESSAVOLUME> WSQOLEXPEDICAOITEMREMESSAVOLUME { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOVOLUMEHIST> WSQOLEXPEDICAOVOLUMEHIST { get; set; }
        public virtual DbSet<WSQOLEXPEDICAOVOLUMETIPO> WSQOLEXPEDICAOVOLUMETIPO { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSNRSERIE> WSQOLEXPREMESSAITENSNRSERIE { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSNRSERIECOMPONENTE> WSQOLEXPREMESSAITENSNRSERIECOMPONENTE { get; set; }
        public virtual DbSet<WSQOLEXPREMESSAITENSSITUACAOTIPO> WSQOLEXPREMESSAITENSSITUACAOTIPO { get; set; }
        public virtual DbSet<WSQOLIMPRESSORASLOCAIS> WSQOLIMPRESSORASLOCAIS { get; set; }
        public virtual DbSet<WSQOLINHAMONTAGEM_DEPARA> WSQOLINHAMONTAGEM_DEPARA { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCODIGOVALIDO> WSQOLINVENTARIOCODIGOVALIDO { get; set; }
        public virtual DbSet<WSQOLINVENTARIOCONTAGEMSTATUS> WSQOLINVENTARIOCONTAGEMSTATUS { get; set; }
        public virtual DbSet<WSQOLINVENTARIODEPOSITOCFGNOTALLOWED> WSQOLINVENTARIODEPOSITOCFGNOTALLOWED { get; set; }
        public virtual DbSet<WSQOLINVENTARIOITENSERP> WSQOLINVENTARIOITENSERP { get; set; }
        public virtual DbSet<WSQOLINVENTARIOTIPOESTOQUE> WSQOLINVENTARIOTIPOESTOQUE { get; set; }
        public virtual DbSet<WSQOLLOCALMOVSTATUSTIPO> WSQOLLOCALMOVSTATUSTIPO { get; set; }
        public virtual DbSet<WSQOLMODULOSREGRAS> WSQOLMODULOSREGRAS { get; set; }
        public virtual DbSet<WSQOLNFVOLUMES> WSQOLNFVOLUMES { get; set; }
        public virtual DbSet<WSQOLOGPROCEDURE> WSQOLOGPROCEDURE { get; set; }
        public virtual DbSet<WSQOLPARAMPICKINGSEQOP> WSQOLPARAMPICKINGSEQOP { get; set; }
        public virtual DbSet<WSQOLPEDIDOSTATUS> WSQOLPEDIDOSTATUS { get; set; }
        public virtual DbSet<WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP> WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP { get; set; }
        public virtual DbSet<WSQOLPICKINGRESTRICAOQTDMAX> WSQOLPICKINGRESTRICAOQTDMAX { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST> WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITEMEMBALAGEMHIST> WSQOLPICKINGSEQITEMEMBALAGEMHIST { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITEMSERIAIS> WSQOLPICKINGSEQITEMSERIAIS { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQITEMSTATUS> WSQOLPICKINGSEQITEMSTATUS { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQPRIORIDADEATIPO> WSQOLPICKINGSEQPRIORIDADEATIPO { get; set; }
        public virtual DbSet<WSQOLPICKINGSEQSTATUS> WSQOLPICKINGSEQSTATUS { get; set; }
        public virtual DbSet<WSQOLPICKINGSTATUS> WSQOLPICKINGSTATUS { get; set; }
        public virtual DbSet<WSQOLPRERECEBIMENTOVOLUMES> WSQOLPRERECEBIMENTOVOLUMES { get; set; }
        public virtual DbSet<WSQOLQLCTIPOVALIDACAOPLANO> WSQOLQLCTIPOVALIDACAOPLANO { get; set; }
        public virtual DbSet<WSQOLRCBSEQUENCIADIARIA> WSQOLRCBSEQUENCIADIARIA { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOCONTAGEMSTATUS> WSQOLRECEBIMENTOCONTAGEMSTATUS { get; set; }
        public virtual DbSet<WSQOLRECEBIMENTOVOLUMESITENSSTATUS> WSQOLRECEBIMENTOVOLUMESITENSSTATUS { get; set; }
        public virtual DbSet<WSQOLREQUISICOESCODIGOVALIDO> WSQOLREQUISICOESCODIGOVALIDO { get; set; }
        public virtual DbSet<WSQOLREQUISICOESFLUXOSTATUS> WSQOLREQUISICOESFLUXOSTATUS { get; set; }
        public virtual DbSet<WSQOLREQUISICOESSTATUS> WSQOLREQUISICOESSTATUS { get; set; }
        public virtual DbSet<WSQOLRESERVADIAGRAMAREDE> WSQOLRESERVADIAGRAMAREDE { get; set; }
        public virtual DbSet<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS> WSQOLSSTOREMOVDEBITOCOMPONENTESERROS { get; set; }
        public virtual DbSet<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS_STATUS> WSQOLSSTOREMOVDEBITOCOMPONENTESERROS_STATUS { get; set; }
        public virtual DbSet<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO> WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WSQOLACIONAMENTOAVALIACAOSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLACIONAMENTOAVALIACAOSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLATRIBUTO>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCARGA>()
                .Property(e => e.USUARIO_CRIACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCARGA>()
                .Property(e => e.TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCARGA>()
                .Property(e => e.PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCARGAHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCENTROCUSTO>()
                .Property(e => e.UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCENTROCUSTO>()
                .Property(e => e.CODIGO_CCT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCENTROCUSTO>()
                .Property(e => e.DESCRICAO_CCT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCENTROCUSTOTEMP>()
                .Property(e => e.UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCENTROCUSTOTEMP>()
                .Property(e => e.CODIGO_CCT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCENTROCUSTOTEMP>()
                .Property(e => e.DESCRICAO_CCT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CODIGO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.NOME_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.GRUPO_CONTAS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CODIGO_CLIENTE_ANTIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ENDERECO_EMISSOR_ORDEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ENDERECO_RECEB_MERCADORIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ENDERECO_RECEB_FATURA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CNPJ_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.NOME_VENDEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.TIPO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.ESTADO)
                .IsFixedLength();

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.PAIS_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.RUA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.COD_IDIOMA_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTE>()
                .Property(e => e.DESC_COD_IDIOMA_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTECIDADEESTADO>()
                .Property(e => e.CODIGO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTECIDADEESTADO>()
                .Property(e => e.REGIAO)
                .IsFixedLength();

            modelBuilder.Entity<WSQOLCLIENTECIDADEESTADO>()
                .Property(e => e.LOCAL)
                .IsFixedLength();

            modelBuilder.Entity<WSQOLCLIENTEGRUPOVENDAS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCLIENTEGRUPOVENDAS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCODBLOQUEIOESTOQUEITEM>()
                .Property(e => e.DESC_BLOQUEIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCODBLOQUEIOESTOQUEITEM>()
                .Property(e => e.MENSAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCODBLOQUEIOESTOQUEITEM>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCODBLOQUEIOESTOQUEITEM>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCODBLOQUEIOESTOQUEITEM>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCODBLOQUEIOESTOQUEITEM>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCOMPONENTEMEDICAO>()
                .Property(e => e.COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLDOCUMENTOINSPECAO>()
                .Property(e => e.DOC_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLENDERECO>()
                .Property(e => e.RUA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLENDERECO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLENDERECO>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLENDERECO>()
                .Property(e => e.PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEF>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEF>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEF>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEF>()
                .Property(e => e.USUARIO_ULTIMA_ALTERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEF>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEFHIST>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEFHIST>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEFHIST>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEFHIST>()
                .Property(e => e.USUARIO_ULTIMA_ALTERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESPICKINGSCHEDULINGDEFHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.MENSAGEM_STATUS_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEATUAL>()
                .Property(e => e.LOCAL_ORIGEM_MOV)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.QUANTIDADE_LANCADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.QUANTIDADE_ATUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.MENSAGEM_STATUS_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.ORIGEM_LANCAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.INFO_ORIGEM_LANCAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.INFO_ORIGEM_LANCAMENTO_2)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.VERSAO_MODULO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.LOCAL_ORIGEM_MOV)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.DOC_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOV>()
                .Property(e => e.LOCAL_ORIGEM_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARREGRAS>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARREGRAS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARREGRAS>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARREGRAS>()
                .Property(e => e.ATRIBUTO_EX)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARSTATUS>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARSTATUS>()
                .Property(e => e.OS_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVAUXILIARSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.ACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.TIPO_MOVIMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.STATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.LOCAL_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.TRANSACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.CENTRO_CUSTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.ORDEM_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.ORDEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.SALDO_ESTOQUE_ANTERIOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.LOCAL_LES)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.LOTE_CONTROLE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.ITEM_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.NUMERO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.ITEM_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.NUMERO_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.DOC_MAT_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUEMOVERP>()
                .Property(e => e.NUM_DOC_REF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLESTOQUESTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLETIQUETASVOLUMESPA>()
                .Property(e => e.CODIGO_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLETIQUETASVOLUMESPA>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLETIQUETASVOLUMESPA>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLETIQUETASVOLUMESPA>()
                .Property(e => e.DESCRICAO_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLETIQUETASVOLUMESPA>()
                .Property(e => e.PESO_EMBALAGEM_KG)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVE>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVE>()
                .Property(e => e.TIPO_EXPEDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVE>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEHIST>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEHIST>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEHIST>()
                .Property(e => e.TIPO_EXPEDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEHIST>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVELOCALENTREGA>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVELOCALENTREGAHIST>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVELOCALENTREGAHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVELOCALENTREGAHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEUSUARIO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEUSUARIOHIST>()
                .Property(e => e.ID_CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEUSUARIOHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEUSUARIOHIST>()
                .Property(e => e.USUARIO_ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCHAVEUSUARIOHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCOMPONENTEGERACAO>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCOMPONENTEGERACAO>()
                .Property(e => e.COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCOMPONENTEGERACAO>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCOMPONENTEGERACAO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOCOMPONENTEGERACAO>()
                .Property(e => e.NUMERO_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.LOCAL_ORIGEM_MOV)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.ORDEM_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.ITEM_ORDEM_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDALES>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP>()
                .Property(e => e.ORDEM_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP>()
                .Property(e => e.ITEM_ORDEM_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOESTOQUEORDEMVENDASAP>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOPLANEJAMENTOLESTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOTIPO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.CODIGO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.CODIGO_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.TIPO_EXPEDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.PESO_TOTAL_CALCULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.PESO_TOTAL_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.CHAVE_EXPEDICAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.DOC_TRANSPORTE_AUX_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.TAM_CAMINHAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.DETALHE_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUME>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMESTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMESTATUSTIPO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMESTATUSTIPO>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMESTATUSTIPO>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMESTATUSTIPO>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.CODIGO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.LOCAL_EXPEDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.CODIGO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.CODIGO_TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.CODIGO_MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.STATUS_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.GRUPO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.DOCUMENTO_FATURAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.NUM_DOCUMENTO_TRANSPORTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.CHAVE_EXPEDICAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.LOCAL_ENTREGA_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.TAM_CAMINHAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.DETALHE_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.STATUS_GLOBAL_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.DESC_STATUS_GLOBAL_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.VOLUME_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.PESO_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.UNIDADE_PESO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSA>()
                .Property(e => e.STATUS_ENVIO_ERP_CHAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSADPCHAVEPICKING>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSADPCHAVEPICKING>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSADPCHAVEPICKING>()
                .Property(e => e.CODIGO_MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSADPCHAVEPICKING>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSADPCHAVEPICKING>()
                .Property(e => e.CODIGO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSADPCHAVEPICKING>()
                .Property(e => e.DATA_PROCESSO_REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.CODIGO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.LOCAL_EXPEDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.CODIGO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.CODIGO_TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.CODIGO_MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.STATUS_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.GRUPO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.DOCUMENTO_FATURAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.NUM_DOCUMENTO_TRANSPORTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.CHAVE_EXPEDICAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.LOCAL_ENTREGA_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.TAM_CAMINHAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.DETALHE_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.STATUS_GLOBAL_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.DESC_STATUS_GLOBAL_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.VOLUME_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.PESO_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.UNIDADE_PESO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.LOCAL_DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.CODIGO_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.ITEM_CODIGO_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.NUMERO_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.ITEM_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.QUANTIDADE_PICKING)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.DOCUMENTO_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.CATEGORIA_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.DESC_CATEGORIA_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.NR_ORDEM_V)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.NR_ITEM_ORDEM_V)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.PESO_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.UNIDADE_PESO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENS>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.LOCAL_DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.CODIGO_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.ITEM_CODIGO_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.NUMERO_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.ITEM_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.QUANTIDADE_PICKING)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.DOCUMENTO_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.CATEGORIA_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.DESC_CATEGORIA_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.NR_ORDEM_V)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.NR_ITEM_ORDEM_V)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.PESO_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.UNIDADE_PESO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST>()
                .Property(e => e.NR_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST>()
                .Property(e => e.CODIGO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST>()
                .Property(e => e.DESCRICAO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTEHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTESTATUSTIPO>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIEHIST>()
                .Property(e => e.NR_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIEHIST>()
                .Property(e => e.CODIGO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIEHIST>()
                .Property(e => e.ITEM_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIEHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIEHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIESTATUSTIPO>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSTATUSTIPO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSTATUSTIPO>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSTATUSTIPO>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSTATUSTIPO>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAMOTIVOS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAMOTIVOS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAMOTIVOS>()
                .Property(e => e.PRIORIDADE_A_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSASTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSASTATUSTIPO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSASTATUSTIPO>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSASTATUSTIPO>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSASTATUSTIPO>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.NOME_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.TIPO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.SITE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORES>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORESTIPO>()
                .Property(e => e.TIPO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORESTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORPRODUTO>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLFORNECEDORPRODUTO>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLHELPHTML>()
                .Property(e => e.ID_HELP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLHELPHTML>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLHELPHTML>()
                .Property(e => e.HTML_HELP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLIMAGEMINSPECAO>()
                .Property(e => e.IMAGEM_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM>()
                .Property(e => e.DESCRICAO_LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM>()
                .Property(e => e.DESCRICAO_ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM>()
                .Property(e => e.ESQUEMA_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMAGRUPAMENTO>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMAGRUPAMENTO>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMAGRUPAMENTOHEADER>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMAGRUPAMENTOHEADER>()
                .Property(e => e.DESCRICAO_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMGRUPO>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMGRUPO>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMREGRAS>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMREGRAS>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMREGRAS>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMREGRAS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINHAMONTAGEMREGRAS>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMREGRAS>()
                .Property(e => e.ATRIBUTO_EX)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEMTIPOESTACAO>()
                .Property(e => e.TIPO_ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.EXERCICIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.CENTRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.STATUS_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIO>()
                .Property(e => e.STATUS_BAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.UNIDADE_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.NUMERO_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIA>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIATIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOAUDITORIATIPO>()
                .Property(e => e.DESCRICAO_EXTENDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVE>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVE>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVEEQUIPE>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVEEQUIPE>()
                .Property(e => e.CODIGO_EQUIPE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVEFILTROS>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVEFILTROS>()
                .Property(e => e.LOCAL_FILTRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVELOCAL>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCHAVELOCAL>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEM>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEM>()
                .Property(e => e.UNIDADE_MEDIDA_CONTADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEM>()
                .Property(e => e.QUANTIDADE_INFORMADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEM>()
                .Property(e => e.UNIDADE_MEDIDA_INFORMADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEM>()
                .Property(e => e.FATOR_CONVERSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEMHIST>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEMHIST>()
                .Property(e => e.STATUS_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEMHIST>()
                .Property(e => e.STATUS_MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEMSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.UNIDADE_MEDIDA_CONTADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.QUANTIDADE_INFORMADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.UNIDADE_MEDIDA_INFORMADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.FATOR_CONVERSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONAS>()
                .Property(e => e.LOCAL_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASHIST>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASHIST>()
                .Property(e => e.STATUS_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASHIST>()
                .Property(e => e.STATUS_MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASHIST>()
                .Property(e => e.STATUS_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUS>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIODEFINICOES>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIODEFINICOES>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIODEFINICOES>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIODEPOSITOCFG>()
                .Property(e => e.CHAVE_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOEQUIPE>()
                .Property(e => e.CODIGO_EQUIPE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOEQUIPE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOEQUIPEUSUARIO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOEQUIPEUSUARIO>()
                .Property(e => e.CODIGO_EQUIPE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.UNIDADE_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.NUMERO_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUE>()
                .Property(e => e.QTD_ESTOQUE_ATUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.UNIDADE_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.NUMERO_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.QUANTIDADE_CONTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.QTD_ESTOQUE_ATUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.STATUS_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUEHIST>()
                .Property(e => e.STATUS_MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUESTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUESTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTOQUESTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTRATEGIAINCLUSAOPRODUTOS>()
                .Property(e => e.STORED_PROCEDURE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOESTRATEGIAINCLUSAOPRODUTOS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.EXERCICIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.CENTRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.STATUS_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.STATUS_BAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.STATUS_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOHIST>()
                .Property(e => e.STATUS_MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.ITEM_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.DOC_RECONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.ESTOQUE_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.CONTAGEM_ZERO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.CONTADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.CONTAGEM_APROVADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.RECONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.ITEM_ELIMINADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.ORDEM_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENS>()
                .Property(e => e.PRIORIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.ITEM_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.DOC_RECONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.ESTOQUE_ESPECIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.CONTAGEM_ZERO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.CONTADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.CONTAGEM_APROVADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.RECONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.ITEM_ELIMINADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.STATUS_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSHIST>()
                .Property(e => e.STATUS_MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFA>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS>()
                .Property(e => e.CODIGO_TAREFA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS>()
                .Property(e => e.UNIDADE_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS>()
                .Property(e => e.RECONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS>()
                .Property(e => e.TIPO_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOLOCAISTAREFAPRODUTOS>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIORASTREABILIDADE>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIORASTREABILIDADE>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIORASTREABILIDADE>()
                .Property(e => e.NUMERO_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIORASTREABILIDADE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIORASTREABILIDADE>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAPDFHIST>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAPDFHIST>()
                .Property(e => e.USER_MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.UNIDADE_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFAS>()
                .Property(e => e.ESTRATEGIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASDETALHES>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASDETALHES>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASDETALHES>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.NUMERO_INVENTARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.UNIDADE_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.ESTRATEGIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.STATUS_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.STATUS_MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASHIST>()
                .Property(e => e.STATUS_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASSTATUS>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASSTATUS>()
                .Property(e => e.LOCAL_CONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTAREFASTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTIPOBLOQUEIOEDICAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CODIGO_RASTREABILIDADE_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CODIGO_LOCAL_FLUTUANTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CODIGO_LOCAL_CONSUMO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.QTD_MAX_ABASTECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.QTD_LOTE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.PERCENTUAL_REPOSICAO_CRITICA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.PERCENTUAL_REPOSICAO_URGENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTO>()
                .Property(e => e.PERCENTUAL_DEMANDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CODIGO_LOCAL_FLUTUANTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CODIGO_LOCAL_CONSUMO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.QTD_MAX_ABASTECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.QTD_LOTE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.PERCENTUAL_REPOSICAO_CRITICA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.PERCENTUAL_REPOSICAO_URGENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.PERCENTUAL_DEMANDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOHIST>()
                .Property(e => e.OS_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOSTATUS>()
                .Property(e => e.PERCENTUAL_DEMANDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOSTATUS>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOSTATUS>()
                .Property(e => e.OS_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANACIONAMENTOTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANATUAL>()
                .Property(e => e.CODIGO_CARTAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANATUAL>()
                .Property(e => e.LOCAL_RECIPIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANATUAL>()
                .Property(e => e.LOCAL_ALOCACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANATUAL>()
                .Property(e => e.QUANTIDADE_ATUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANATUAL>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTES>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTES>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPO>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPOHIST>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPOHIST>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPOHIST>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPOHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPOHIST>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESGRUPOHIST>()
                .Property(e => e.OS_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESHIST>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESHIST>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESHIST>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESHIST>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANCLIENTESHIST>()
                .Property(e => e.OS_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.LOCAL_CONSUMO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.QTD_DEMANDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.QTD_REPOSICAO_MINIMA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.QTD_REPOSICAO_CRITICA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.QTD_MAXIMA_RECIPIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.TEMPO_MEDIO_ABASTECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.TEMPO_MEDIO_CONSUMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.TEMPO_LIMITE_ABASTECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.SUGESTAO_UTILIZADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEF>()
                .Property(e => e.CENTRO_TRABALHO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.CODIGO_LOCAL_CONSUMO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.QTD_MAX_ABASTECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.QTD_LOTE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.PERCENTUAL_REPOSICAO_CRITICA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.PERCENTUAL_REPOSICAO_URGENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.PERCENTUAL_DEMANDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.QTD_MAQUINAS_DIMENSIONAMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.PERIODO_DIAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.QTD_MAX_RECIPIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOES>()
                .Property(e => e.GRUPO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.CODIGO_LOCAL_CONSUMO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.QTD_MAX_ABASTECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.QTD_LOTE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.PERCENTUAL_REPOSICAO_CRITICA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.PERCENTUAL_REPOSICAO_URGENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.PERCENTUAL_DEMANDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.QTD_MAQUINAS_DIMENSIONAMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.PERIODO_DIAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.MACHINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.OS_USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.LISTAGEM_FILTRO_CRITERIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.QTD_MAX_RECIPIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.NOME_ARQUIVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANDEFINICOESHIST>()
                .Property(e => e.GRUPO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANESTRATEGIAGERACAOTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.ID_)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.PRIORIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.REFUGO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.BASE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.BASE_ISO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.STATUS_COMPONENT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.ORIGEM_MATERIALPCP2)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.KANBAN_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.LOCAL_TRABALHO_ORDEM_PROD)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANIDENTIFICACAO>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANMOV>()
                .Property(e => e.CODIGO_CARTAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANMOV>()
                .Property(e => e.LOCAL_RECIPIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANMOV>()
                .Property(e => e.LOCAL_ALOCACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANMOV>()
                .Property(e => e.QUANTIDADE_ATUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLKANBANMOV>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANSEMDEF>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANSEMDEF>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANSEMDEF>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANSEMDEF>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLKANBANVERIFICAOPABERTATIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.LOCAL_FISICO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.GIS_LONGITUDE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.GIS_LATITUDE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.GIS_ALTITUDE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.LOCAL_INTEGRACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.CENTRO_CUSTOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.QTD_LOTE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAIS>()
                .Property(e => e.TAMANHO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISCONTROLECODIGO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISPRODUTOS>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISPRODUTOS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISPRODUTOS>()
                .Property(e => e.ESTOQUE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISPRODUTOS>()
                .Property(e => e.QUANTIDADE_REPOSICAO_CRITICA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISPRODUTOS>()
                .Property(e => e.QUANTIDADE_REPOSICAO_MINIMA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISREGISTROAUXILIARTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOES>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOES>()
                .Property(e => e.CODIGO_RESTRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOESPARAMS>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOESPARAMS>()
                .Property(e => e.CODIGO_RESTRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOESPARAMS>()
                .Property(e => e.CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOESPARAMS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISRESTRICOESPARAMS>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISROTAS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISROTAS>()
                .Property(e => e.LOCAL_FISICO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISROTAS>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISROTAS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISTAMANHOS>()
                .Property(e => e.TAMANHO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCAISTAMANHOS>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISTAMANHOS>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISTAMANHOS>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLLOCAISTIPOINTEGRACAOERP>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCALMOV>()
                .Property(e => e.CODIGO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCALMOV>()
                .Property(e => e.CODIGO_LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCALMOV>()
                .Property(e => e.USUARIO_GERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCALMOV>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMODULOS>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMODULOS>()
                .Property(e => e.SUBMODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.NOME_MOTORISTA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.RG_MOTORISTA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.CPF_MOTORISTA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMOTORISTAS>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.CHAVE_NF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.NATUREZA_OP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.CPF_CNPJ_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.NOME_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.CNPJ_TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.NOME_TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.PLACA_TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.QTD_VOLUMES)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.ESPECIE_VOLUMES)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.PESO_LIQUIDO_VOLUMES)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.PESO_BRUTO_VOLUMES)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.PEDIDO_COMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNF>()
                .Property(e => e.CNPJ_DESTINATARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.DESCRICAO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.INFORMACAO_ADICIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.QUANTIDADE_VINCULADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.UNIDADE_ORIGINAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFITENS>()
                .Property(e => e.QUANTIDADE_ORIGINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGCONEXAO>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGCONEXAO>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGCONEXAO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGEVENTOS>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGEVENTOS>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGEVENTOS>()
                .Property(e => e.EVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGEVENTOS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.USUARIO_ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.NOME_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINHIST>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINS>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINS>()
                .Property(e => e.NOME_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINS>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINS>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSPERFIS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSPERFIS>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSREGRAS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSREGRAS>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSREGRAS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLOGINSREGRAS>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSREGRAS>()
                .Property(e => e.ATRIBUTO_EX)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGINSTIPOUSUARIO>()
                .Property(e => e.TIPO_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTE>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTE>()
                .Property(e => e.DESCRICAO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTEHIST>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTEHIST>()
                .Property(e => e.DESCRICAO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTEHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTEHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPCP2PECACOMPONENTETIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.CODIGO_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.TIPO_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.CODIGO_COMPRADOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.NOME_COMPRADOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.CONTATO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.MOEDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDO>()
                .Property(e => e.USUARIO_CRIACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOCATEGORIACUSTOS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOCATEGORIACUSTOS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.QUANTIDADE_RECEBIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.FATOR_VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.CATEGORIA_CUSTOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.CODIGO_INTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.QUANTIDADE_VINCULADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.TIPO_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.REMESSA_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.CENTRO_CUSTOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.PEDIDO_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOITENS>()
                .Property(e => e.TIPO_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.CODIGO_INTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.QUANTIDADE_RECEBIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.CODIGO_JUSTIFICATIVA_VARIACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOMOVIMENTACAO>()
                .Property(e => e.OBS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.QUANTIDADE_RECEBIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.JUSTIFICATIVA_VARIACAO_NF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.OBS_VARIACAO_NF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.CODIGO_JUSTIFICATIVA_VARIACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.OBS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.CODIGO_PECA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDONF>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOTIPO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOTIPO>()
                .Property(e => e.PRIORIDADE_A_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOTIPOITEM>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOTIPOITEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.USUARIO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.PRIORIDADE_A)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.PRIORIDADE_B)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.PRIORIDADE_C)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.VERSAO_TABLET_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.DESCRICAO_LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.DOC_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.QUANTIDADE_PAGO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.CODIGO_LEITURA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.CODIGO_RASTREABILIDADE_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.ID_ITEM_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIAR>()
                .Property(e => e.STATUS_ENVIO_ERP_CHAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.USUARIO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.PRIORIDADE_A)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.PRIORIDADE_B)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.PRIORIDADE_C)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.VERSAO_TABLET_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.DESCRICAO_LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.DOC_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.QUANTIDADE_PAGO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.CODIGO_LEITURA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.ID_ITEM_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.STATUS_ENVIO_ERP_CHAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.USUARIO_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.MESSAGE_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.REGRA_REGRAS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.VALOR_REGRAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.ATRIBUTO_REGRAS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARHIST>()
                .Property(e => e.ATRIBUTO_EX_REGRAS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARREGRAS>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARREGRAS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARREGRAS>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARREGRAS>()
                .Property(e => e.ATRIBUTO_EX)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGAUXILIARSTATUS>()
                .Property(e => e.MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGBAIXACGI>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGBAIXACGI>()
                .Property(e => e.MENSAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.ESQUEMA_CALENDARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.CHAVE_GERACAO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.MODULO_QUALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.FORNECEDOR_QUALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.PROCEDURE_VALIDA_LOCAL_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVE>()
                .Property(e => e.LOCAL_ALOCACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVEBLOQUSUARIO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVECGI>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVEFINALIZACAOTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVEFINALIZACAOTIPO>()
                .Property(e => e.DESCRICAO_EXTENDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVETIPOAPONT>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVEUSUARIO>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGCHAVEUSUARIO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPO>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPO>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPOKIT>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPOKIT>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPOKIT>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGGRUPOKIT>()
                .Property(e => e.GRUPO_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGKITUSUARIO>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGKITUSUARIO>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGKITUSUARIO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOV>()
                .Property(e => e.USUARIO_PAGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOV>()
                .Property(e => e.VERSAO_TABLET_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOV>()
                .Property(e => e.PRIORIDADE_A)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOV>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOV>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOV>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.QUANTIDADE_PAGO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.QUANTIDADE_FALTANTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.LOCAL_DEBITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.LOCAL_CREDITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.VERSAO_TABLET_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.LOCAL_DEBITO_CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.LOCAL_CREDITO_CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGMOVITENS>()
                .Property(e => e.QUANTIDADE_ENTREGUE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.USUARIO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.PRIORIDADE_A)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.PRIORIDADE_B)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.PRIORIDADE_C)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.VERSAO_TABLET_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.DESCRICAO_LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.DOC_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQ>()
                .Property(e => e.GRUPO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.KIT)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.USUARIO_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.PRIORIDADE_A)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.PRIORIDADE_B)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQHIST>()
                .Property(e => e.PRIORIDADE_C)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.PESO_TOTAL_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.PESO_TOTAL_CALCULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEM>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.PESO_TOTAL_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.PESO_TOTAL_CALCULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.CODIGO_RASTREABILIDADE_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.QUANTIDADE_PAGO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.CODIGO_LEITURA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.ID_ITEM_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITENS>()
                .Property(e => e.QUANTIDADE_FALTANTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITENSSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQORIGEM>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQORIGEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPLANOFREQUENCIA>()
                .Property(e => e.DESCRICAO_PLANO_FREQUENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPLANOFREQUENCIA>()
                .Property(e => e.CONDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULO>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULO>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULO>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULO>()
                .Property(e => e.PLANO_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULO>()
                .Property(e => e.ESTRATEGIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULOPARAMS>()
                .Property(e => e.PARAMETRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDEFVINCULOPARAMS>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCDEFVINCULOPARAMS>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCDISPOSITIVOMEDICAO>()
                .Property(e => e.DISPOSITIVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCESTRATEGIA>()
                .Property(e => e.ESTRATEGIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCESTRATEGIA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCESTRATEGIA>()
                .Property(e => e.TEMPLATE_SEGREGACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCESTRATEGIA>()
                .Property(e => e.TEMPLATE_GRAVACAO_DADOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCFOTO>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCFOTO>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCFOTO>()
                .Property(e => e.JUSTIFICATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCFOTO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCMODULO>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCMODULO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEF>()
                .Property(e => e.CODIGO_LITERAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEF>()
                .Property(e => e.NQA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCNBRDEF>()
                .Property(e => e.REGIME_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEF>()
                .Property(e => e.TIPO_AMOSTRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEFCODIGOLITERAL>()
                .Property(e => e.NIVEL_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEFCODIGOLITERAL>()
                .Property(e => e.CODIGO_LITERAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEFOLD>()
                .Property(e => e.CODIGO_LITERAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEFOLD>()
                .Property(e => e.NQA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCNBRDEFOLD>()
                .Property(e => e.REGIME_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEFOLD>()
                .Property(e => e.TIPO_AMOSTRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRDEFREGIMEATENUADO>()
                .Property(e => e.NQA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCNBRHISTSISTEMACOMUTACAO>()
                .Property(e => e.REGIME_INSPECAO_ANTIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRHISTSISTEMACOMUTACAO>()
                .Property(e => e.REGIME_INSPECAO_NOVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCNBRHISTSISTEMACOMUTACAO>()
                .Property(e => e.DESCRICAO_MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCOPCOESATRIBUTO>()
                .Property(e => e.ESQUEMA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCOPCOESATRIBUTO>()
                .Property(e => e.OPCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANO>()
                .Property(e => e.PLANO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANO>()
                .Property(e => e.DESCRICAO_PLANO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANO>()
                .Property(e => e.SCOPE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.DISPOSITIVO_COLETA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.CODIGO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.LIMITE_INFERIOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.LIMITE_SUPERIOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.NOMINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.GED_VIRTUAL_FOLDER)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .Property(e => e.OPCOES_ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCPLANOITEM>()
                .HasMany(e => e.WSQOLQLCITEMVALIDACAO)
                .WithRequired(e => e.WSQOLQLCPLANOITEM)
                .HasForeignKey(e => e.ID_ITEM);

            modelBuilder.Entity<WSQOLQLCRASTREABILIDADE>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCRASTREABILIDADE>()
                .Property(e => e.REGRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCRASTREABILIDADE>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCRASTREABILIDADE>()
                .Property(e => e.ATRIBUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCRASTREABILIDADE>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADONBR>()
                .Property(e => e.NIVEL_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADONBR>()
                .Property(e => e.NQA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCSEGREGADONBR>()
                .Property(e => e.REGIME_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADONBR>()
                .Property(e => e.TIPO_AMOSTRA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADONBR>()
                .Property(e => e.CODIGO_LITERAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADONBR>()
                .Property(e => e.TAMANHO_LOTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCSEGREGADOS>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADOS>()
                .Property(e => e.QUANTIDADE_AMOSTRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCSEGREGADOS>()
                .Property(e => e.USUARIO_SEGREGACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADOS>()
                .Property(e => e.USUARIO_INSPECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCSEGREGADOS>()
                .Property(e => e.QUANTIDADE_AMOSTRA_OK)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCSEGREGADOS>()
                .Property(e => e.QUANTIDADE_AMOSTRA_NOK)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLQLCTIPOFOTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCTIPOITEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCTIPOITEM>()
                .Property(e => e.CAMPO_1)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCTIPOITEM>()
                .Property(e => e.CAMPO_2)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCTIPOITEM>()
                .Property(e => e.CAMPO_3)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCVALIDACAO>()
                .Property(e => e.ESQUEMA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCVALIDACAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCVALIDACAO>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCODIGORESERVADO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.QUANTIDADE_CONTAGEM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.TIPO_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.QUANTIDADE_ESPERADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENS>()
                .Property(e => e.CATEGORIA_CUSTOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGENSHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIA>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIA>()
                .Property(e => e.SETOR_LANCAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIA>()
                .Property(e => e.SETOR_ENVIADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIA>()
                .Property(e => e.USUARIO_LANCAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIA>()
                .Property(e => e.WORKFLOW_UTILIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIA>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.NOTADEVOLUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.FATORGERADOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.EMBALAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.CODFORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.NUMERONF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAACEITE>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.USUARIO_CONFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.USUARIO_LANCAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.QUANTIDADE_RECEBIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.QUANTIDADE_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENS>()
                .Property(e => e.QUANTIDADE_RECEBIDA_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIAITENSACAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTODIVERGENCIATIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERP>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERP>()
                .Property(e => e.DIRECAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.ITEM_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.CODIGO_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.COMPRADOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.SNUMERO_NF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.CENTRO_CUSTOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.REQUISITANTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.ITEM_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.CATEGORIA_CUSTOS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENS>()
                .Property(e => e.TIPO_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENSHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPITENSSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOERPSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.LOCAL_CONFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.MOTORISTA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTO>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTOHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTOHIST>()
                .Property(e => e.VERSION_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOFOLHAROSTOSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOLOCAISVINCULO>()
                .Property(e => e.LOCAL_CONFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOLOCAISVINCULO>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOPORTARIA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.CODIGO_RECEBIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.LOCAL_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.TIPO_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.CATEGORIA_CUSTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.NF)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMES>()
                .Property(e => e.REQUISITANTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMESHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMESITENS>()
                .Property(e => e.QUANTIDADE_VINCULADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMESITENSHIST>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMESSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.CODIGO_REQUISICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.CHAVE_PICKING)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.USUARIO_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.ORIGEM_REQUISICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.SETOR_APROVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.LINHA_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.ESTACAO_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOES>()
                .Property(e => e.USUARIO_LIBERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESFLUXO>()
                .Property(e => e.CODIGO_REQUISICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESFLUXO>()
                .Property(e => e.SETOR_LANCAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESFLUXO>()
                .Property(e => e.SETOR_ENVIADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESFLUXO>()
                .Property(e => e.WORKFLOW_UTILIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESFLUXO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESITENS>()
                .Property(e => e.CODIGO_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLREQUISICOESITENS>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESITENS>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESTIPOENTREGA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESTIPOITEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESTIPOITEM>()
                .Property(e => e.ICONE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESTIPOORIGEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVA>()
                .Property(e => e.CODIGO_RESERVA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVA>()
                .Property(e => e.USUARIO_RESERVA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADPCHAVEPICKING>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADPCHAVEPICKING>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADPCHAVEPICKING>()
                .Property(e => e.TIPO_MOVIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADPCHAVEPICKING>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADPCHAVEPICKING>()
                .Property(e => e.NR_RESERVA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.LOCAL_RETIRADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.TIPO_MOVIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.RECEBEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.CCUSTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.PONTO_DESCARGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVAITENS>()
                .Property(e => e.TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICAOENDERECO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.CODIGO_RESTRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.DESCRICAO_LONGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.PROCEDURE_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.PROCEDURE_SUGESTAO_ALOCACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.PROCEDURE_SUGESTAO_RETIRADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.PESO_SUGESTAO_ALOCACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLRESTRICOESDEF>()
                .Property(e => e.PESO_SUGESTAO_RETIRADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.SERIE_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.CODIGO_FUNCIONARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.NOME_TRANSPORTADORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.NOME_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.NOME_CIDADE_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.NOME_VENDEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDACGI>()
                .Property(e => e.NOME_REGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDAITENSCGI>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDAITENSCGI>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDAITENSCGI>()
                .Property(e => e.VALOR_UNITARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSPEDIDOVENDAITENSCGI>()
                .Property(e => e.QUANTIDADE_AUTORIZADA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSTATUSLOCAL>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPOLOCAL>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG>()
                .Property(e => e.TIPO_MOVIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG>()
                .Property(e => e.DEPOSITO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.PESO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTIPORECIPIENTE>()
                .Property(e => e.PESO_RECIPIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLTRANSFERENCIAESTOQUEBAIXA>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTRANSFERENCIAESTOQUEBAIXA>()
                .Property(e => e.LOCAL_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTRANSFERENCIAESTOQUEBAIXA>()
                .Property(e => e.LOCAL_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTRANSFERENCIAESTOQUEBAIXA>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLTRANSFERENCIAESTOQUEBAIXA>()
                .Property(e => e.MENSAGEM_ERRO_ERP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADES>()
                .Property(e => e.CODIGO_UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADES>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESCONVERSAO>()
                .Property(e => e.UNIDADE_FROM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESCONVERSAO>()
                .Property(e => e.UNIDADE_TO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESCONVERSAO>()
                .Property(e => e.FATOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLUNIDADESCONVERSAO>()
                .Property(e => e.TOLERANCIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLUNIDADESCONVERSAO>()
                .Property(e => e.OFFSET)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLUNIDADESMEDIDA>()
                .Property(e => e.COD_UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESMEDIDA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESMEDIDA>()
                .Property(e => e.TOLERANCIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLUNIDADESNEGOCIO>()
                .Property(e => e.UNIDADE_NEGOCIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESNEGOCIO>()
                .Property(e => e.DESCRICAO_UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESNEGOCIO>()
                .Property(e => e.LOCAL_INTEGRACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLUNIDADESNEGOCIO>()
                .Property(e => e.DESCRICAO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLVEICULOSTRANSPORTE>()
                .Property(e => e.CODIGO_VEICULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLVEICULOSTRANSPORTE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLCARGASTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOITEMREMESSAVOLUME>()
                .Property(e => e.ITEM_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.CODIGO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.CODIGO_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.TIPO_EXPEDICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.PESO_TOTAL_CALCULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.PESO_TOTAL_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.CHAVE_EXPEDICAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.DOC_TRANSPORTE_AUX_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.TAM_CAMINHAO_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.DETALHE_PLANEJAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMEHIST>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMETIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPEDICAOVOLUMETIPO>()
                .Property(e => e.DESCRICAO_EXTENDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIE>()
                .Property(e => e.NR_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIE>()
                .Property(e => e.CODIGO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIE>()
                .Property(e => e.ITEM_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIE>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTE>()
                .Property(e => e.NR_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTE>()
                .Property(e => e.CODIGO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTE>()
                .Property(e => e.DESCRICAO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTE>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSNRSERIECOMPONENTE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSITUACAOTIPO>()
                .Property(e => e.SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLEXPREMESSAITENSSITUACAOTIPO>()
                .Property(e => e.DESC_SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLIMPRESSORASLOCAIS>()
                .Property(e => e.IMPRESSORA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLIMPRESSORASLOCAIS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM_DEPARA>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM_DEPARA>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM_DEPARA>()
                .Property(e => e.LINHA_MONTAGEM_DEPARA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINHAMONTAGEM_DEPARA>()
                .Property(e => e.ESTACAO_DEPARA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEMSTATUS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOCONTAGEMSTATUS>()
                .Property(e => e.MSG_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSERP>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSERP>()
                .Property(e => e.UNIDADE_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSERP>()
                .Property(e => e.RECONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOITENSERP>()
                .Property(e => e.TIPO_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLINVENTARIOTIPOESTOQUE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLLOCALMOVSTATUSTIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMODULOSREGRAS>()
                .Property(e => e.CODIGO_EXCECAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMODULOSREGRAS>()
                .Property(e => e.VALOR_VARCHAR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLMODULOSREGRAS>()
                .Property(e => e.VALOR_NUMERIC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFVOLUMES>()
                .Property(e => e.ESPECIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLNFVOLUMES>()
                .Property(e => e.PESO_LIQUIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFVOLUMES>()
                .Property(e => e.PESO_BRUTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLNFVOLUMES>()
                .Property(e => e.ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGPROCEDURE>()
                .Property(e => e.CALLER)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLOGPROCEDURE>()
                .Property(e => e.LOG_MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPARAMPICKINGSEQOP>()
                .Property(e => e.CENTRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPARAMPICKINGSEQOP>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPEDIDOSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP>()
                .Property(e => e.CENTRO_TRABALHO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGPARAMETROSSEQUENCIAMENTOOP>()
                .Property(e => e.DOC_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.PESO_TOTAL_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.PESO_TOTAL_CALCULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.CODIGO_RASTREABILIDADE_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOESHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.PESO_TOTAL_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.PESO_TOTAL_CALCULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMEMBALAGEMHIST>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMSERIAIS>()
                .Property(e => e.SERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMSERIAIS>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLPICKINGSEQITEMSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQPRIORIDADEATIPO>()
                .Property(e => e.PRIORIDADE_A)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQPRIORIDADEATIPO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQPRIORIDADEATIPO>()
                .Property(e => e.COR_HEXA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQPRIORIDADEATIPO>()
                .Property(e => e.LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQPRIORIDADEATIPO>()
                .Property(e => e.COR_ITEM_SELECIONADO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSEQSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPICKINGSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPRERECEBIMENTOVOLUMES>()
                .Property(e => e.CODIGO_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPRERECEBIMENTOVOLUMES>()
                .Property(e => e.ESPECIE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLPRERECEBIMENTOVOLUMES>()
                .Property(e => e.NUMERO_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLQLCTIPOVALIDACAOPLANO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOCONTAGEMSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRECEBIMENTOVOLUMESITENSSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESFLUXOSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLREQUISICOESSTATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.DIAGRAMA_REDE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.RESERVA)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.USUARIO_ULTIMA_MOVIMENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.ELEMENTO_PEP)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.CODIGO_LOTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLRESERVADIAGRAMAREDE>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.CODIGO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.QUANTIDADE_FALTANTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.QUANTIDADE_PRODUZIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.TIPO_MOVIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.LOCAL_DEBITO_PADRAO_LES)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.LOCAL_FILTRO_DEBITO_LES)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.CODIGO_RESTRICAO_MOV)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.LOCAL_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.ACAO)
                .IsFixedLength();

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROS_STATUS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.ORDEM_PRODUCAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.LINHA_MONTAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.ESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.CODIGO_COMPONENTE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.TIPO_MOVIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.LOCAL_DEBITO_PADRAO_LES)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.LOCAL_FILTRO_DEBITO_LES)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.CODIGO_RESTRICAO_MOV)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.LOCAL_ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.CODIGO_RASTREABILIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.ACAO)
                .IsFixedLength();

            modelBuilder.Entity<WSQOLSSTOREMOVDEBITOCOMPONENTESERROSPASSIVO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);
        }
    }
}
