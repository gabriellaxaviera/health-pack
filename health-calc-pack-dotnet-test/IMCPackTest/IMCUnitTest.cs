using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace health_calc_pack_dotnet_test.PackLibrary;

public class IMCUnitTest
{
    [Fact]
    public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
    {
        //Arrange
        IIMC imc = new IMC();
        double Height = 1.73;
        double Weight = 72;
        double ExpectedIMC = 24.06;

        //Act
        var result = imc.Calc(Weight, Height);

        //Asserts
        Assert.Equals(ExpectedIMC, result);
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
        Assert.IsFalse(result);
    }

    [Theory]
    [InlineData(17, "MAGREZA")]
    [InlineData(24, "NORMAL")]
    [InlineData(26, "SOBREPESO")]
    [InlineData(30.55, "OBESIDADE")]
    [InlineData(42, "OBESIDADE_GRAVE")]
    public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao(double valorIMC, string classificacao)
    {
        //Arrange
        IIMC imc = new IMC();

        //Act
        string resultado = imc.GetIMCCategory(valorIMC);

        //Asserts
        Assert.Equals(classificacao, resultado);
    }

}
