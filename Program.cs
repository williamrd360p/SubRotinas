ExibirTitulo();

void ExibirTitulo()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("----------------------");
    Console.WriteLine("--- Par ou ímpar ---");
    Console.WriteLine ("------------------\n");
    Console.ResetColor();
}


Console.Write("Informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
bool ehPar = DefinirPar(numero);


bool DefinirPar(int numero)
{
    bool ehPar = numero % 2 == 0;
    return ehPar;
}


ExibirResultado();


void ExibirResultado()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"O número {numero} é  um número {(ehPar ? "Par" : "Ímpar")}");
    Console.ResetColor();
}
