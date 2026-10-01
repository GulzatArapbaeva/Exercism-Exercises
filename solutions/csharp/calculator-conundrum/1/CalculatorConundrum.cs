using System;
public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        switch(operation)
        {
            case "+":
                int result = operand1 + operand2;
                return $"{operand1} + {operand2} = {result.ToString()}";
            case "*":
                int result1 = operand1 * operand2;
                return $"{operand1} * {operand2} = {result1.ToString()}";
            case "/":
                if(operand2 == 0)
                    return "Division by zero is not allowed.";
                
                int result2 = operand1 / operand2;
                return $"{operand1} / {operand2} = {result2.ToString()}";
            case "":
                throw new ArgumentException("The string is empty");
            case null:
                throw new ArgumentNullException("The string is null");
            default:
                throw new ArgumentOutOfRangeException("Please provide correct operation symbol.");
        }
        throw new NotImplementedException("Please implement the SimpleCalculator.Calculate() method");
        
    }
}
