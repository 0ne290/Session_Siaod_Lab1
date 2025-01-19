namespace Core;

public class Stack<TValue>
{
    public bool IsEmpty() => _head == null;
    
    public TValue Peek()
    {
        if (_head == null)
            throw new Exception("Stack is empty.");
        
        return _head.Value;
    }

    public void Push(TValue value) => _head = new Node<TValue> { Value = value, Next = _head };
    
    public TValue Pop()
    {
        if (_head == null)
            throw new Exception("Stack is empty.");

        var oldHead = _head;
        _head = _head.Next;

        return oldHead.Value;
    }
    
    private Node<TValue>? _head;
}