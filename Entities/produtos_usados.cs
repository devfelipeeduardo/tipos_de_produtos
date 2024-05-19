namespace Course.Entities {
    public class ProdutosUsados : Produtos {
        public DateTime DataFabricacao {get; set;}

        public ProdutosUsados (){
        }
        public ProdutosUsados (string name, double price, DateTime dataFabricacao)
        : base(name, price){

            DataFabricacao = dataFabricacao;

        }

        public override string ToString(){

            return $"{Name}, R$ {Price} Data: {DataFabricacao}";

        }

    }
}