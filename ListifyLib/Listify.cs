using System.Collections;

namespace ListifyLib;
public class Listify : IList<int>
{
    private IEnumerable<int> list;

    public Listify(int begin, int end)
    {
        list = Sequence(begin, end);
    }

    private static IEnumerable<int> Sequence(int begin, int end)
    {
        for (int i = begin; i <= end; ++i)
        {
            yield return i;
        }
    }

    public int this[int index] { get => list.ElementAt(index); set => throw new NotImplementedException(); }

    public int Count => list.Count();

    public bool IsReadOnly => true;

    public void Add(int item)
    {
        list.Append(item);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(int item)
    {
        return list.Contains(item);
    }

    public void CopyTo(int[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<int> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    public int IndexOf(int item)
    {
        int i = 0;
        foreach(int e in list)
        {
            if (e == item)
            {
                return i;
            }
            i++;
        }
        return -1;
    }

    public void Insert(int index, int item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }
}
