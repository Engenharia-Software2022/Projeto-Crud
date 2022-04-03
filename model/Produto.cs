

namespace ProjetoDS.model
{
    public class Produto
    {
        public int id_produto { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }

        //Chave estrangeira da tabela de fornecedor
        public int fk_fornecedor { get; set; }

    }
}
