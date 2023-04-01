// See https://aka.ms/new-console-template for more information
Console.Write("Especie: ");
string Especie = Console.ReadLine()!;

Console.Write("Raça: ");
string Raca = Console.ReadLine()!;

Console.Write("Apelido: ");
string Apelido = Console.ReadLine()!;

Console.Write(" Idade");
string Idade = Console.ReadLine()!;

Console.Write("Pelagem/Cor: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.WriteLine("+=========================================================+");
Console.Write("|               ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("       Pet Hotel");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                          |");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("|   ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(" Espécie");
Console.ForegroundColor = ConsoleColor.Red;

Console.Write(Especie.Trim().PadLeft(8,  '.'));

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("         |");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("   Raça");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write( Raca.Trim().PadLeft(8,   '.'));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("             |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("");
Console.Write("+=========================================================+");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" ");
Console.Write("|  ");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("  Apelido");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write( Apelido.Trim().PadLeft(9,  '.'));

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("        |");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("   Idade");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write( Idade.Trim().PadLeft(2,  '.'));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("                  |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("");
Console.Write("+=========================================================+");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" ");
Console.Write("|  ");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("             Pelagem/Cor");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write( pelagemCor.Trim().PadLeft(8,  '.'));

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("                       |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("");
Console.Write("+=========================================================+");