//Pastrana Garnica Anael Alejandro (226Z0188)
//13-feb-2024

using System.Drawing;
int numero;

Console.WriteLine("Dame un numero: ");
numero = int.Parse(Console.ReadLine());


if(numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}