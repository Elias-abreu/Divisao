﻿
try
{
    Console.WriteLine("Informe o primeiro valor!");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor!");
    int b = int.Parse(Console.ReadLine());
    int result = a / b;
    Console.WriteLine("O resultado é :"+result);

}catch(Exception ex)
{
    Console.WriteLine("Algo de errado não está certo!");
}

