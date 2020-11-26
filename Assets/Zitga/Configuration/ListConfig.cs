using System.Collections.Generic;

public abstract class ListConfig<T> : IConfig where T : IConfig, new()
{
    /// <summary>
    /// 
    /// </summary>
    private List<T> list;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<T> GetAll()
    {
        return list;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public T Get(int index)
    {
        if (index < list.Count)
        {
            return list[index];
        }

        return default;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    public virtual void Load(object content)
    {
        Load((List<string[]>)content);    
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    void Load(List<string[]> content)
    {
        list = new List<T>();
        foreach (var row in content)
        {
            var item = new T();
            
            item.Load(row);
            
            list.Add(item);
        }
    }
}
