using EntrevistaTarget.Model;
using Newtonsoft.Json;

/*Acessando os dados Json*/
StreamReader r = new StreamReader("Data/dados.json");
string jsonString = r.ReadToEnd();
List<DataModel> m = JsonConvert.DeserializeObject<List<DataModel>>(jsonString);

/*Lendo o maior valor*/
var maiorValor = m.Select(x => x.Valor).Max();
Console.WriteLine($"O maior valor faturado é - {maiorValor}");

/*Lendo o menor valor, descondierando faturamento = 0*/
var menorValor = m.Where(x => x.Valor > 0).Select(x => x.Valor).Min();
   Console.WriteLine($"O menor valor faturado é - {menorValor}");

/*Lendo o valor médio mensal*/
var valorMediaMensal = m.Where(x => x.Valor > 0).Select(x => x.Valor).Average();

/*Contagem de dias de valor faturado maior que a média mensal*/
var superFaturamentos = m.Count(x => x.Valor > valorMediaMensal);
   Console.WriteLine($"Total de dias com valor maior que média mensal - {superFaturamentos}");