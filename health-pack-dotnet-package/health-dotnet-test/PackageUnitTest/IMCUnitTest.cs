using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Utils;

namespace health_calc_pack_dotnet_test.PackageTest
{
    public class IMCUnitTest
    {
        [Fact]
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
            Assert.Equal(ExpectedIMC, result);
        }

        [Fact]
        public void ValidaDadosIMC_QuandoDadosInvalidos_EntaoRetornaFalso()
        {
            //Arrange
            IIMC imc = new IMC();
            double altura = 10.0;
            double peso = 400.0;

            //Act
            var result = imc.IsValidData(altura, peso);

            //Asserts
            Assert.False(result);
        }

        [Theory]
        [InlineData(17, Constants.MAGREZA)]
        [InlineData(24, Constants.NORMAL)]
        [InlineData(26, Constants.SOBREPESO)]
        [InlineData(30.55, Constants.OBESIDADE)]
        [InlineData(42, Constants.OBESIDADE_GRAVE)]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao(double valorIMC, string classificacao)
        {
            //Arrange
            IIMC imc = new IMC();

            //Act
            string resultado = imc.GetIMCCategory(valorIMC);

            //Asserts
            Assert.Equal(classificacao, resultado);
        }
    }
}