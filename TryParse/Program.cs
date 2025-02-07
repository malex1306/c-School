

public static class CustomParser
{
    public static bool TryParseDouble(string input, out double result)
    {
        result = 0;
        if (string.IsNullOrEmpty(input)) return false;

        bool isNegative = input[0] == '-';
        int startIndex = isNegative ? 1 : 0;
        bool hasDecimalPoint = false;
        double value = 0, factor = 1;

        for (int i = startIndex; i < input.Length; i++)
        {
            char c = input[i];
            if (c == '.' && !hasDecimalPoint)
            {
                hasDecimalPoint = true;
                continue;
            }
            if (c < '0' || c > '9') return false;

            if (hasDecimalPoint)
            {
                factor /= 10;
                value += (c - '0') * factor;
            }
            else
            {
                value = value * 10 + (c - '0');
            }
        }

        result = isNegative ? -value : value;
        return true;
    }

    public static bool TryParseDecimal(string input, out decimal result)
    {
        if (TryParseDouble(input, out double doubleResult))
        {
            result = (decimal)doubleResult;
            return true;
        }
        result = 0;
        return false;
    }

    public static bool TryParseBool(string input, out bool result)
    {
        result = false;
        if (string.Equals(input, "true", StringComparison.OrdinalIgnoreCase))
        {
            result = true;
            return true;
        }
        if (string.Equals(input, "false", StringComparison.OrdinalIgnoreCase))
        {
            result = false;
            return true;
        }
        return false;
    }

    public static void Main()
    {
        if (TryParseDouble("123.45", out double doubleValue))
            Console.WriteLine("Parsed double: " + doubleValue);
        else
            Console.WriteLine("Invalid double");

        if (TryParseDecimal("678.90", out decimal decimalValue))
            Console.WriteLine("Parsed decimal: " + decimalValue);
        else
            Console.WriteLine("Invalid decimal");

        if (TryParseBool("true", out bool boolValue))
            Console.WriteLine("Parsed bool: " + boolValue);
        else
            Console.WriteLine("Invalid bool");
    }
}
