using System.Globalization;
using Course.Entities;

namespace Course {

    class Program {

        static void Main(string[]args) {

            List<Produtos> lista = new List<Produtos>();

            Console.Write("Digite a quantidade de produtos: ");
            int? product_qt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= product_qt; i++) {

                Console.WriteLine($"Produto {i}: ");
                Console.Write("Comum, usado ou importado? [C, U, I]: ");
                string? product_type = Console.ReadLine().ToLower();

                Console.Write("Nome: ");
                string? name = Console.ReadLine();

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (product_type == "u"){
                    Console.Write("Digite a data de fabricação: [DD/MM/AAAA] ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutosUsados(name, price, data));

                } else if (product_type == "i"){
                    Console.WriteLine("Digite a taxa de alfângeda");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutosImportados(name, price, taxaAlfandega));

                } else {
                    lista.Add(new Produtos(name, price));

                }

            }

            Console.WriteLine("Preços: ");

            foreach (Produtos produto in lista){

                Console.WriteLine(produto);

            }


        }

    }

}