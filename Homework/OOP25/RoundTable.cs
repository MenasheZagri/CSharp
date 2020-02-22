using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class RoundTable<T> : IEnumerable<T> 

    {
    private List<T> entities = new List<T>();

    public void Add(T entity)
    {
        entities.Add(entity);
    }


    public void InsertAt(int index, T entity)
    {
        entities.Insert(index, entity);
    }

    public void RemoveAt(int index)
    {
        //Zero based remove at index / remove from list
        entities.RemoveAt(index % entities.Count);
    }

    public void Clear()
    {
        entities.Clear();
    }

    public void Sort()
    {
        entities.Sort();
    }

    /*
    public List<T> GetRounded(int value)
    {

    }
    */
    

    public T this[int index]
    {
        get
        {
            if (entities.Count == 0)
            {
                return default(T);

            }

            return entities[index % entities.Count];
        }
    }

    /*
    public T this[string fieldName]
    {
        get
        {
            if (entities.Count == 0)
            {
                return default T;
            }

            foreach (T entity in entities)
            {
                if (entity.Name == fieldName)
                    return entity;
            }
        }
    }
    */

    public IEnumerator<T> GetEnumerator()
    {
        return entities.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return entities.GetEnumerator();
    }


    }
}
