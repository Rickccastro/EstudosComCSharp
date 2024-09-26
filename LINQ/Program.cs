namespace LINQ;

internal class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = CarregarListaPessoas();


        /*Pessoas com 2 irmãos para baixo*/
        IEnumerable<Pessoa> pessoasComMaisDeUmIrmao = from pessoa in pessoas where pessoa.QuantidadeIrmaos <= 2 select pessoa;
        var filtradasPessoas = pessoas.Where(pessoa => pessoa.QuantidadeIrmaos <= 2);

        foreach (var pessoaFiltrada in filtradasPessoas)
        {
            Console.WriteLine($"Nome: {pessoaFiltrada.Nome}, Quantidade de Irmãos: {pessoaFiltrada.QuantidadeIrmaos}");
        }

        foreach (var pessoa in pessoasComMaisDeUmIrmao)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Quantidade de Irmãos: {pessoa.QuantidadeIrmaos}");
        }

        /*Nome e idade de todas as pessoas maiores de idade */
        var pessoasMaioresDeIdade = from pessoa in pessoas where pessoa.Idade > 18 orderby pessoa.Nome ascending select new { pessoa.Nome, pessoa.Idade };
        var pessoasMaioresDeIdade2 = pessoas.Where(pessoas => pessoas.Idade > 18).OrderBy(pessoas => pessoas.Nome).Select(pessoas => new { pessoas.Nome, pessoas.Idade });


        foreach (var pessoaMaiorIdade in pessoasMaioresDeIdade)
        {
            Console.WriteLine("Maior de idade " + pessoaMaiorIdade.Nome, pessoaMaiorIdade.Idade);
        }

    }

    static List<Pessoa> CarregarListaPessoas()
    {
        List<Pessoa> pessoa = new List<Pessoa>();

        pessoa.Add(new Pessoa
        {
            Nome = "Ricardo",
            Idade = 21,
            QuantidadeIrmaos = 1,
        });

        pessoa.Add(new Pessoa
        {
            Nome = "João",
            Idade = 21,
            QuantidadeIrmaos = 2,
        });

        pessoa.Add(new Pessoa
        {
            Nome = "Maria",
            Idade = 21,
            QuantidadeIrmaos = 6,
        });

        return pessoa;
    }

    class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int QuantidadeIrmaos { get; set; }
    }


}
