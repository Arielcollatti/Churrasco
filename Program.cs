Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" ---Calculadora para churrasco--- ");
Console.ResetColor();

Console.Write("Quantidade de adultos que consomem bebidas alcoólicas.......: ");

int adultosAlcool = int.Parse(Console.ReadLine()!);

Console.Write("Quantidade de adultos que não consomem bebidas alcoólicas...: ");

int adultosNaoAlcool = int.Parse(Console.ReadLine()!);

Console.Write("Quantidade de crianças......................................: ");

int crianças = int.Parse(Console.ReadLine()!);

int adultos = adultosNaoAlcool + adultosAlcool;
int pessoas = adultos + crianças;

double carne = (adultos * 0.4) + 0.2 * crianças;
double acompanhamentos = pessoas * 0.2;
double cerveja = adultosAlcool * 2;
double refrigerante = adultosNaoAlcool + crianças * 0.5;
double agua = pessoas * 0.4;

Console.WriteLine($"\nCarne................: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos........: {acompanhamentos:N1}kg"); 
Console.WriteLine($"Cerveja................: {cerveja:N1}L"); 
Console.WriteLine($"Refrigerante...........: {refrigerante:N1}L"); 
Console.WriteLine($"Água...................: {agua:N1}L");