namespace CodeQualityDemo;

public class CoverageDemo
{
    public string MethodReturningAString(bool doIt)
    {
        string result = "Bla";

        if (doIt)
        {
            result += " da";
        }

        return result;
    }
}