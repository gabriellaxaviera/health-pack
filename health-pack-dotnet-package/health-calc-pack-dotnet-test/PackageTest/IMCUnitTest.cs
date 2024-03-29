using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace health_calc_pack_dotnet_test.PackageTest
{
    [TestClass]
    public class IMCUnitTest
    {
        [Fact]
        [TestMethod]
        public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 1.67;
            double Weight = 86;
            double ExpectedIMC = 30.84;

            //Act
            var result = imc.Calculate(Height, Weight);

            //Asserts
            Assert.AreEqual(ExpectedIMC, result);
        }

        [Fact]
        [TestMethod]
        public void ValidaDadosIMC_QuandoDadosInvalidos_EntaoRetornaFalso()
        {
            //Arrange
            IIMC imc = new IMC();
            double altura = 10.0;
            double peso = 400.0;

            //Act
            var result = imc.IsValidData(altura, peso);

            //Asserts
            Assert.IsFalse(result);
        }

        [Theory]
        [InlineData(17, Constants.MAGREZA)]
        [InlineData(24, Constants.NORMAL)]
        [InlineData(26, Constants.SOBREPESO)]
        [InlineData(30.55, Constants.OBESIDADE)]
        [InlineData(42, Constants.OBESIDADE_GRAVE)]
        [TestMethod]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao(double valorIMC, string classificacao)
        {
            //Arrange
            IIMC imc = new IMC();

            //Act
            string resultado = imc.GetIMCCategory(valorIMC);

            //Asserts
            Assert.AreEqual(classificacao, resultado);
        }
    }
}