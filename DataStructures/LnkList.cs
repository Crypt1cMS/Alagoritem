namespace DataStructures;

public class LnkList
{
    private LnkListNode? _head;

    public LnkList() => _head = null;

    public LnkList(params int[] values)
    {
        foreach (var value in values) 
            Add(value);
    }

    // O(1)
    public void Prepend(int value)
    {
        if (_head == null)
        {
            _head = new LnkListNode(value);
            return;
        }

        _head = new LnkListNode(value, _head);
    }

    // O(n)
    public void Add(int value)
    {
        if (_head == null)
        {
            _head = new LnkListNode(value);
            return;
        }
        
        _head.Add(value);
    }

    public IEnumerable<int> ToArray() => 
        _head == null ? Array.Empty<int>() : _head.ToArray();
}