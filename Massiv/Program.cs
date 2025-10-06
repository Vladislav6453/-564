

using System.Net.Http.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Введите длину массива:");
int length = int.Parse(Console.ReadLine());
int[] Massiv = new int[length];
for(int i = 0; i < Massiv.Length; i++)
{
    Console.Write($"Введите число номер {i+1}:");
    Massiv[i] = int.Parse(Console.ReadLine());
}
Console.Write("Введите число k:");
int k = int.Parse(Console.ReadLine());
HttpClient client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5186/api/");
var result = await client.PostAsJsonAsync($"Massiv/ComplexValue3/{k}", Massiv);
var data = await result.Content.ReadFromJsonAsync<int>();
Console.WriteLine(data);


















Console.ReadLine();