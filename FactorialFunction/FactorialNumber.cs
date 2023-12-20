namespace FactorialFunction;

public class FactorialCalculator
{
    public static int ExecuteOperation(int variable)
    {
        if (variable < 0)
            return 0;

        if (variable == 0)
            return 1;

        return variable * ExecuteOperation(variable - 1);
    }
}