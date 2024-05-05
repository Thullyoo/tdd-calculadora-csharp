namespace Calculadoratestes;
using Calculadora.Services;

public class CalculadoraImpTests
{
    private CalculadoraImp _calc;

    public CalculadoraImpTests()
    {
        this._calc = new CalculadoraImp();
    }

    [Fact]
    public void Test1()
    {
        int num1 = 56;
        int num2 = 10;

        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }
}