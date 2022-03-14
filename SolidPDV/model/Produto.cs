namespace SolidPDV{
    internal class Produto
    {       
        private string codBarra;
        private string descricao;
        private decimal precoCusto;
        private decimal precoVenda;
        private int qtdEstoque;
        private int qtdMinima;
        public Produto(){
        }
        public Produto(string codBarra,string descricao, decimal precoCusto, decimal precoVenda,
            int qtdEstoque, int qtdMinima)
        {
            this.descricao = descricao;
            this.codBarra = codBarra;
            this.precoCusto = precoCusto;
            this.precoVenda = precoVenda;
            this.qtdEstoque = qtdEstoque;
            this.qtdMinima = qtdMinima;
        }      

        public string getCodBarra()
        {
            return this.codBarra;
        }
        public void setCodBarra(string codBarra)
        {
            this.codBarra = codBarra;
        }

        public decimal getPrecoCusto()
        {
            return this.precoCusto;
        }
        public void setPrecoCusto(decimal precoCusto)
        {
            this.precoCusto = precoCusto;
        }
        public decimal getPrecoVenda()
        {
            return this.precoVenda;
        }
        public void setPrecoVenda(decimal precoVenda)
        {
            this.precoVenda = precoVenda;
        }

        public decimal getEstoque()
        {
            return this.qtdEstoque;
        }
        public void setEstoque(int qtdEstoque)
        {
            this.qtdEstoque = qtdEstoque;
        }

        public decimal getQtdMinima()
        {
            return this.qtdMinima;
        }
        public void setQtdMinima(int qtdMinima)
        {
            this.qtdMinima = qtdMinima;
        }

        public string getDescricao()
        {
            return this.descricao;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao; ;
        }

    }
}
