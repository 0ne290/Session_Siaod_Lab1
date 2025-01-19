namespace Core;

public class Queue<TValue>
{
    public bool IsEmpty() => _head == null;
    
    public TValue Peek()
    {
        if (_head == null)
            throw new Exception("Queue is empty.");
        
        return _head.Value;
    }

    public void Enqueue(TValue value)
    {
        var newNode = new Node<TValue> { Value = value };
        
        if (_tail == null)
        {
            _tail = newNode;
            _head = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }
    }
    
    public TValue Dequeue()
    {
        if (_head == null)
            throw new Exception("Queue is empty.");

        var oldHead = _head;
        _head = _head.Next;

        if (_head == null)
            _tail = null;

        return oldHead.Value;
    }
    
    private Node<TValue>? _head;
    
    private Node<TValue>? _tail;
}