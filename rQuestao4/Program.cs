/*Valores faturamentos já definidos*/
var faturamentoSp = 67836.43;
var faturamentoRJ = 36678.66;
var faturamentoMG = 29229.88;
var faturamentoES = 27165.48;
var faturamentoOutros = 19849.53;
double total = faturamentoSp + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

/*Chamando o método*/
CalcPercent(faturamentoSp, total);
CalcPercent(faturamentoRJ, total);
CalcPercent(faturamentoMG, total);
CalcPercent(faturamentoES, total);
CalcPercent(faturamentoOutros, total);

/*Método de calculo percentual*/
void CalcPercent(double faturamento, double fatTotal)
{     
   var result = faturamento * 100 / fatTotal;
   Console.WriteLine($"{((int)result)}%");
}
