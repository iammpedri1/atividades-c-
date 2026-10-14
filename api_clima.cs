using System.Net.Http;
using System.Text.Json;

var client = new HttpClient();

var url = "https://api.hgbrasil.com/weather?city_name=Belo Horizonte,MG&key=b3148cb6";

var response = await client.GetStringAsync(url);

var json = JsonDocument.Parse(response);

var resultado = json.RootElement.GetProperty("results");

Console.WriteLine(resultado.GetProperty("city_name"));
Console.WriteLine(resultado.GetProperty("temp"));
Console.WriteLine(resultado.GetProperty("description"));