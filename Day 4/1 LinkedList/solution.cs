public class Node<T>
{
    public T Data;
    public Node<T> Next;
    
    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    public LinkedList()
    {
        head = null;
    }

    public void AddFirst(T data)
    {
        Node<T> node = new Node<T>(data);
        node.Next = head;
        head = node;
    }

    public void AddLast(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
        {
            head = node;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }
    }

    public void Remove(T data)
    {
        if (head == null)
        {
            return;
        }

        if (head.Data.Equals(data))
        {
            head = head.Next;
            return;
        }

        Node<T> current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }
}
