using PrototypePattern.Abstract;

namespace PrototypePattern.Manager;

public class PrototypeManager
{
    private Dictionary<string, Prototype> _prototypes = new Dictionary<string, Prototype>();

    public Prototype this[string key]
    {
        get => _prototypes[key];
        set => _prototypes.Add(key, value);
    }
}
