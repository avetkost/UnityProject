using System;

public class List<T>
{
    private T[] _items; // tarrery pahelu zangvac 
    private int _count; // elementneri qanaky 

    public int Count => _count; // elementneri qanaky stanal
    public int Capacity => _items.Length; // taroxutyuny stanal

    public List(int capacity = 4) // taroxutyan construktor 
    {
        _items = new T[capacity == 0 ? 4 : capacity]; // masiv trvac taroxutyamb
    }

    public void Add(T item) 
    {
        if (_count == _items.Length) // liqy linelu jamanak krknapatkel
        {
            T[] newArray = new T[_count * 2];
            Array.Copy(_items, newArray, _count);
            _items = newArray;
        }
        _items[_count] = item; // elementy qcum enq cucali mech 
        _count++; // mecacnum enq elementneri qanaky 
    }

    public bool Remove(T item) 
    {
        int index = Array.IndexOf(_items, item);
        if (index >= 0)
        {
            return RemoveAt(index); // stugum enq ete datark chi jnjum enq 
        }
        return false; // myus depqum datark a false 
    }

    public bool RemoveAt(int index) // indeqsov jnjel
    {
        if (index >= _count || index < 0) // sahmanic ancav false 
        {
            return false;
        }
        for (int i = index; i < _count - 1; i++) // mek hatov dzax jnjeluc heto
        {
            _items[i] = _items[i + 1];
        }
        _count--; // hanum enq elementneri tivy
        return true; 
    }

    public void AddRange(int from, List<T> list) // indexsic sksac avelacnel
    {
        if (from > _count || from < 0) // sahmanic ancnelu depqum 
        {
            return;
        }
        while (_count + list.Count > _items.Length) // stugel ete tex chka avelacnel
        {
            T[] newArray = new T[_count * 2];
            Array.Copy(_items, newArray, _count);
            _items = newArray;
        }
        for (int i = _count - 1; i >= from; i--) // avelacraci  chapov depi aj tanel
        {
            _items[i + list.Count] = _items[i];
        }
        for (int i = 0; i < list.Count; i++) // norery qcum enq cucaki mech
        {
            _items[from + i] = list[i];
        }
        _count += list.Count; 
    }

    protected T this[int i]
    {
        get { throw new NotImplementedException(); }
    }

    public bool RemoveRange(int from, int to) 
    {
        if (from > _count || from < 0 || to > _count || to < 0 || from > to) 
        {
            return false;
        }
        for (int i = from; i < _count - (to - from + 1); i++) // elementneri chapov depi dzax
        {
            _items[i] = _items[i + to - from + 1];
        }
        _count -= to - from + 1; 
        return true; 
    }

    public void Clear() 
    {
        _count = 0; // elementneri qanaky sarqum 0
    }
}
