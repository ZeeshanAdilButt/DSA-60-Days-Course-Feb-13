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

class car{

    public int Id { get; set; }
    public string Name
     { get; set; }
}




public class LinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;
    int Count;

    public LinkedList()
    {
        head = null;
    }

  
    public void AddCenter(T data)
    {
        Node<T> newnode = new Node<T>(data);

        // old 
        last.next = newnode;

        last = newnode;






        //base
        if (head == null)
        {
            head = node;
        }
        else
        {
            int temp = Count  /2;

  


            Node<T> current = head;

  while( temp !=0){
         current = current.Next;

         temp --;
    }
          

            current.Next = node;
        }

         Count++;
    }


    
    public void AddCenter(T data, int index ) // 6
    {
        Node<T> newnode = new Node<T>(data);

        // old 
        last.next = newnode;

        last = newnode;






        //base
        if (head == null)
        {
            head = node;
        }
        else
        {
            int temp = Count  /2;

  


            Node<T> current = head;

  while( index !=0 && current != null){
         current = current.Next;

         index --;
    }
          

            current.Next = node;
        }

         Count++;
    }

    public void AddFirst(T data)
    {
        Node<T> node = new Node<T>(data);

       //var temp = head; // old head // second node

        node.Next = head; // null

        head = node;

        Count++;
  
    }

    public void AddLast(T data)
    {
        Node<T> newnode = new Node<T>(data);

        // old 
        last.next = newnode;

        last = newnode;



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

         Count++;
    }


    public void Remove(T data, int occurence) // 3
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
                occurence --;
                // return;
            }

            current = current.Next;
        }

         Count--;
    }
}
