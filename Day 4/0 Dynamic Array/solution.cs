public class DynamicArray<T>
{
    private T[] data;
    private int size;

    public DynamicArray()
    {
        data = new T[1];
        size = 0;
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
            Resize(2 * data.Length);
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
