
namespace GHA2.Service;

public class CalcService : ICalcService
{
    public int Add(int num1, int num2) => num1 + num2;

    public int Subtract(int v1, int v2)
    {
        return v1 - v2;
    }

    // Write me division and multiplication methods 
    public int Multiply(int v1, int v2)
    {
        return v1 * v2;
    }

    // Write division method
    public int Divide(int v1, int v2)
    {
        return v1 / v2;
    }
}
