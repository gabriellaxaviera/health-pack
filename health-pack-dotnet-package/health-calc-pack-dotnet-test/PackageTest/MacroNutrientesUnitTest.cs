using health_calc_pack_dotnet.Model;
using health_calc_pack_dotnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using health_calc_pack_dotnet.Enum;

namespace health_calc_pack_dotnet_test.PackageTest
{
    [TestClass]
    public class MacroNutrientesUnitTest
    {
        [Theory]
        [InlineData(ObjetivoFisico.PerderPeso, 231, 231, 308)]
        [InlineData(ObjetivoFisico.ManterPeso, 308, 154, 308)]
        [InlineData(ObjetivoFisico.GanharPeso, 308, 77, 154)]
        [TestMethod]
        public void CalculaMacroNutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisico ObjetivoFisico,
            double carboidratos, double gorduras, double proteinas)
        {
            //Arrange
            MacroNutrientes macroNutrientes = new MacroNutrientes();
            double Peso = 77;
            var Expected = new MacroNutrientesModel()
            {
                Carboidratos = carboidratos,
                Gorduras = gorduras,
                Proteinas = proteinas,
            };

            var result = macroNutrientes.CalcularMacroNutrientes(ObjetivoFisico, Peso);


            Assert.Equals(Expected, result);
        }
    }
}