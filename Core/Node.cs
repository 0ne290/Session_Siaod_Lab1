namespace Core;

internal class Node<TValue>
{
    public required TValue Value { get; init; }
    
    public Node<TValue>? Next { get; set; }
}