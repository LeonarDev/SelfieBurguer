namespace SelfieBurguer.Domain.Entities
{
    public class Compra : Base
    {
        public virtual IList<Produto> Produtos { get; set; } = new List<Produto>();
        public virtual double ValorTotal { get; set; } = 0;

        protected Compra() { }

        public Compra(Produto produto)
        {
            SetProduto(produto);
            SetValorTotal();
        }

        public virtual void SetProduto(Produto produto) => Produtos.Add(produto);

        public virtual void SetValorTotal()
        {
            foreach (Produto produto in Produtos)
            {
                ValorTotal += produto.Preco;
            }
        }
    }
}
