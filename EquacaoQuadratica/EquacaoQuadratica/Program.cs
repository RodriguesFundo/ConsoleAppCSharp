using System;
using System.Globalization;

Console.WriteLine("Cálculo de Equação Quadrática!");
Console.WriteLine("\n------------------------------------------------------------\n\n");

try
{
    Console.Write("Insira o valor de a: ");
    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Insira o valor de b: ");
    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Insira o valor de c: ");
    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("\n");

    if (a.Equals(0))
        Console.WriteLine("O valor de 'a' não pode ser igual a 0");
    else
    {
        double delta = 0;
        Console.WriteLine("Equação: " + a + "X² + " + b + "X + " + c + " = 0");
        Console.WriteLine("delta = b² - 4.a.c");
        Console.WriteLine("delta = " + b + "² - 4." + a + "." + c);
        Console.WriteLine("delta = " + (b * b) + " - 4." + (a * c));
        Console.WriteLine("delta = " + (b * b) + " - 4 * " + (a * c));
        delta = (b * b) - (4 * a * c);
        Console.WriteLine("delta = " + delta.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("\n\n");

        if (delta < 0)
            Console.WriteLine("A equação não possui raízes");
        else if (delta.Equals(0))
        {
            Console.WriteLine("   (-b±√delta)");
            Console.WriteLine("X = ---------------");
            Console.WriteLine("        2.a      \n\n");

            Console.WriteLine("   (" + -b + "±√" + delta + ")");
            Console.WriteLine("X = ---------------");
            Console.WriteLine("      2." + a + "      \n\n");

            Console.WriteLine("   (" + -b + "±" + Math.Sqrt(delta) + ")");
            Console.WriteLine("X = ---------------");
            Console.WriteLine("      " + (2 * a) + "      \n\n");

            Console.WriteLine("X = " + ((-b + Math.Sqrt(delta)) / (2 * a)).ToString("F2", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("   (-b±√delta)");
            Console.WriteLine("X = ---------------");
            Console.WriteLine("        2.a      \n\n");

            Console.WriteLine("   (" + -b + "±√" + delta + ")");
            Console.WriteLine("X = ---------------");
            Console.WriteLine("      2." + a + "      \n\n");

            Console.WriteLine("   (" + -b + "±" + Math.Sqrt(delta) + ")");
            Console.WriteLine("X = ---------------");
            Console.WriteLine("      " + (2 * a) + "      \n\n");

            Console.WriteLine("X1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("X2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Insira um número válido");
}
