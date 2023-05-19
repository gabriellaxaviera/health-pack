using health_calc_pack_dotnet.Model;
using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Strategy;

namespace health_calc_pack_dotnet_test.PackageTest
{
    public class MacroNutrientesUnitTest
    {
        [Theory]
        [InlineData(ObjetivoFisico.PerderPeso, 258, 258, 344)]
        [InlineData(ObjetivoFisico.ManterPeso, 344, 172, 344)]
        [InlineData(ObjetivoFisico.GanharPeso, 344, 86, 172)]
        public void CalculaMacroNutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisico ObjetivoFisico,
            double carboidratos, double gorduras, double proteinas)
        {
            //Arrange
            MacroNutrientes macroNutrientes = new MacroNutrientes();
            double Peso = 86;
            var Expected = new MacroNutrientesModel()
            {
                Carboidratos = carboidratos,
                Gorduras = gorduras,
                Proteinas = proteinas,
            };

            var result = macroNutrientes.CalculateMacroNutrientes(ObjetivoFisico, Peso);

            Assert.Equal(macroNutrientes.getResultForMacros(Expected), macroNutrientes.getResultForMacros(result));
        }

        [Theory]
        [InlineData(ObjetivoFisico.PerderPeso, 258, 258, 344)]
        [InlineData(ObjetivoFisico.ManterPeso, 344, 172, 344)]
        [InlineData(ObjetivoFisico.GanharPeso, 344, 86, 172)]
        public void CalculaMacroNutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientesStrategy(ObjetivoFisico ObjetivoFisico,
            double carboidratos, double gorduras, double proteinas)
        {
            //Arrange
            MacroNutrientesContext strategy = new MacroNutrientesContext();
            double Peso = 86;

            switch (ObjetivoFisico)
            {
                case ObjetivoFisico.GanharPeso:
                    strategy.SetStrategy(new GanharPesoStrategy());
                    break;
                case ObjetivoFisico.PerderPeso:
                    strategy.SetStrategy(new PerderPesoStrategy());
                    break;
                case ObjetivoFisico.ManterPeso:
                    strategy.SetStrategy(new ManterPesoStrategy());
                    break;
                default:
                    break;
            }


            MacroNutrientesModel Expected = new ()
            {
                Carboidratos = carboidratos,
                Gorduras = gorduras,
                Proteinas = proteinas,
            };

            var result = strategy.ExecuteStrategy(Peso);

            Assert.Equal(Expected.Proteinas, result.Proteinas);
            Assert.Equal(Expected.Gorduras, result.Gorduras);
            Assert.Equal(Expected.Carboidratos, result.Carboidratos);
        }
    }
}