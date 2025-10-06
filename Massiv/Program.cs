

using System.Net.Http.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

//1
//Console.Write("Введите длину массива:");
//int length = int.Parse(Console.ReadLine());
//int[] Massiv = new int[length];
//for(int i = 0; i < Massiv.Length; i++)
//{
//    Console.Write($"Введите число номер {i+1}:");
//    Massiv[i] = int.Parse(Console.ReadLine());
//}
//Console.Write("Введите число k:");
//int k = int.Parse(Console.ReadLine());
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:5186/api/");
//var result = await client.PostAsJsonAsync($"Massiv/ComplexValue3/{k}", Massiv);
//var data = await result.Content.ReadFromJsonAsync<int>();
//Console.WriteLine(data);

//2
//Console.Write("Введите длину массива:");
//int length = int.Parse(Console.ReadLine());
//int[] Massiv = new int[length];
//for (int i = 0; i < Massiv.Length; i++)
//{
//    Console.Write($"Введите число номер {i + 1}:");
//    Massiv[i] = int.Parse(Console.ReadLine());
//}
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:5186/api/");
//var result = await client.PostAsJsonAsync($"Massiv/ComplexValue4", Massiv);
//var data = await result.Content.ReadFromJsonAsync<int[]>();
//Console.WriteLine($"Длина массива, состоящего из индексов нулей равна:{data.Length}.");
//foreach (int i in data)
//{
//    Console.WriteLine(data[i]);
//}
//Console.ReadLine();

//3
//Console.Write("Введите длину массива:");
//int length = int.Parse(Console.ReadLine());
//int[] Massiv = new int[length];
//for (int i = 0; i < Massiv.Length; i++)
//{
//    Console.Write($"Введите число номер {i + 1}:");
//    Massiv[i] = int.Parse(Console.ReadLine());
//}
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:5186/api/");
//var result = await client.PostAsJsonAsync($"Massiv/ComplexValue5", Massiv);
//var data = await result.Content.ReadFromJsonAsync<bool>();
//if (data)
//    Console.WriteLine("Первое число отрицательно.");
//else
//    Console.WriteLine("Первое число положительно.");

//4
//Console.Write("Введите длину массива:");
//int length = int.Parse(Console.ReadLine());
//int[] Massiv = new int[length];
//for (int i = 0; i < Massiv.Length; i++)
//{
//    Console.Write($"Введите число номер {i + 1}:");
//    Massiv[i] = int.Parse(Console.ReadLine());
//}
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:5186/api/");
//var result = await client.PostAsJsonAsync($"Massiv/ComplexValue6", Massiv);
//var data = await result.Content.ReadFromJsonAsync<bool>();
//if (data)
//    Console.WriteLine("Массив возрастающий.");
//else
//    Console.WriteLine("Массив не возрастающий.");


//5
//Console.Write("Введите длину массива:");
//int length = int.Parse(Console.ReadLine());
//int[] Massiv = new int[length];
//for (int i = 0; i < Massiv.Length; i++)
//{
//    Console.Write($"Введите число номер {i + 1}:");
//    Massiv[i] = int.Parse(Console.ReadLine());
//}
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:5186/api/");
//var result = await client.PostAsJsonAsync($"Massiv/ComplexValue7", Massiv);
//var data = await result.Content.ReadFromJsonAsync<int[]>();
//Console.WriteLine($"Длина массива, состоящего из четных чисел:{data.Length}.");
//for(int i = 0; i < data.Length; i++)
//{
//    Console.WriteLine(data[i]);
//}

//6
//Console.Write("Введите длину массива:");
//int length = int.Parse(Console.ReadLine());
//int[] Massiv = new int[length];
//for (int i = 0; i < Massiv.Length; i++)
//{
//    Console.Write($"Введите число номер {i + 1}:");
//    Massiv[i] = int.Parse(Console.ReadLine());
//}
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:5186/api/");
//var result = await client.PostAsJsonAsync($"Massiv/ComplexValue8", Massiv);
//var data = await result.Content.ReadFromJsonAsync<int>();
//Console.WriteLine($"И это число равно: {data}.");


//7
Console.Write("Введите длину массива:");
int length = int.Parse(Console.ReadLine());
int[] Massiv = new int[length];
for (int i = 0; i < Massiv.Length; i++)
{
    Console.Write($"Введите число номер {i + 1}:");
    Massiv[i] = int.Parse(Console.ReadLine());
}
Console.Write("Введите то самое число:");
int k = int.Parse(Console.ReadLine());
HttpClient client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5186/api/");
var result = await client.PostAsJsonAsync($"Massiv/ComplexValue9/{k}", Massiv);
var data = await result.Content.ReadFromJsonAsync<int>();
Console.WriteLine($"И это число равно: {data}.");



Console.ReadLine();