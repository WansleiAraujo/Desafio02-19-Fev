Console.WriteLine("Calcular o melhor consumo de combustível");

Console.WriteLine("Informe o valor do Álcool: R$ ");
double alcool = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor da Gasolina: R$ ");
double gasolina = double.Parse(Console.ReadLine());

double abastecimentoIdeal = alcool / gasolina;
string resultado = abastecimentoIdeal.ToString("N2");

if (double.Parse(resultado) > 0.65)
{
    Console.WriteLine("É aconselhável abastecer com Álcool: " + abastecimentoIdeal.ToString("N3"));
    if (double.Parse(resultado) == 0.72)
        Console.WriteLine("Neste caso também economizará ao abastecer com álcool");
}
else
    Console.WriteLine("É aconselhável abastecer com Gasolina: " + abastecimentoIdeal.ToString("N3"));