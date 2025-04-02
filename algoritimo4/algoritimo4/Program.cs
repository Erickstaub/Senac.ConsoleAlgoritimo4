// See https://aka.ms/new-console-template for more information
using System.Globalization;

    Console.WriteLine("Quanto vai gastar na reforma?");
    Console.WriteLine();

//largura da parede
    Console.WriteLine("Qual largura");
    Console.WriteLine();
    double largura;
        largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//comprimento da parede
    Console.WriteLine("Qual comprimento");
    Console.WriteLine();
    double comprimento;
        comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//arae da parede
    Console.WriteLine("Qual area");
    Console.WriteLine();
    double area;
        area = largura * comprimento ;
    Console.Write(area + "m²");
    Console.WriteLine();

//preco do m²
    Console.WriteLine("Quanto custa o m²");
    Console.WriteLine();
    double preco;
        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//todal do preço
    double total;
        total = area * preco ;
    Console.Write(total.ToString("F2") + "R$");