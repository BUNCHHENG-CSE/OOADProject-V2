namespace OOADPROV2.Utilities.Builder;

public class Validator<T>
{
    private readonly List<Func<T, (bool IsValid, string Message)>> _rules = new();

    public Validator<T> AddRule(Func<T, (bool, string)> rule)
    {
        _rules.Add(rule);
        return this;
    }

    public (bool IsValid, string ErrorMessage) Validate(T instance)
    {
        foreach (var rule in _rules)
        {
            var (isValid, message) = rule(instance);
            if (!isValid)
                return (false, message);
        }
        return (true, string.Empty);
    }
}
