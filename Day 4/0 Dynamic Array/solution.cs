


public class DynamicArray<T>
{
    private T[] data;
    private int size;
    public int sizeFactor;

    public DynamicArray(int sizeFactor)
    {
        data = new T[10];
        size = 0;

        if(sizeFactor < 1.5){
                return NotSyupportedExcetopn();
        }

        sizeFactor  = sizeFactor;
    }


    public int Length
    {
        get { return size; }
    }

    public T this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }

    public void Add(T item)
    {
        if (size == data.Length)
        {
            Resize(sizeFactor * data.Length);
        }
        
        data[size] = item;

        size++;
    }

    private void Resize(int capacity)
    {
        T[] newData = new T[capacity];
        for (int i = 0; i < size; i++)
        {
            newData[i] = data[i];
        }
        data = newData;
    }
}
