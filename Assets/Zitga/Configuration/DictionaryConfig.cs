using System.Collections.Generic;

public abstract class DictionaryConfig<U, V> : IConfig
{
    private Dictionary<U, V> _dictionary;
    
    public virtual void Load()
    {
        _dictionary = new Dictionary<U, V>();
    }

    public void Load(object content)
    {
        throw new System.NotImplementedException();
    }

    public Dictionary<U, V> GetAll()
    {
        return _dictionary;
    }

    public V Get(U key)
    {
        if (_dictionary.ContainsKey(key))
        {
            return _dictionary[key];
        }

        return default;
    }
}