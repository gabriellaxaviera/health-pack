using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enum;

var imc = new IMC();

var result = imc.Calculate(1.67, 86.0);
var classificacao = imc.GetIMCCategory(result);

Console.WriteLine($"Seu IMC é: {result} e o resultado é: {classificacao}");

var macro = new MacroNutrientes();

var resultToPerderPeso = macro.getResultForMacros(macro.CalcularMacroNutrientes(ObjetivoFisico.PerderPeso, 86.0));
var resultToManterPeso = macro.getResultForMacros(macro.CalcularMacroNutrientes(ObjetivoFisico.ManterPeso, 86.0));
var resultToGanharPeso = macro.getResultForMacros(macro.CalcularMacroNutrientes(ObjetivoFisico.GanharPeso, 86.0));

Console.WriteLine($"Para ganhar peso seus macros são: {resultToGanharPeso} \n Para manter peso seus macros são: {resultToManterPeso} \n Para perder peso seus macros são: {resultToPerderPeso}");
