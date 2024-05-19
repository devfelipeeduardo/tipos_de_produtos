namespace Course.Entities {
    public class ProdutosImportados : Produtos {
        public double TaxaAlfandega {get; set;}

        public ProdutosImportados (){
        }
        public ProdutosImportados (string name, double price, double taxaAlfandega)
        : base(name, price){

        TaxaAlfandega = taxaAlfandega; 

        }

        public override string ToString(){

            return $"{Name}, R$ {Price} TX: {TaxaAlfandega}";

        }
    }
}