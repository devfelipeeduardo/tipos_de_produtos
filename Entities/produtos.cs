

using System.Reflection.Metadata.Ecma335;

namespace Course.Entities {

    public class Produtos {

        public string Name {get; set;}
        public double Price {get; set;}

        public Produtos () { }

        public Produtos(string name, double price){
            Name = name;
            Price = price;
        }

        public override string ToString(){

            return $"{Name}, R$ {Price}";

        }
    }
}