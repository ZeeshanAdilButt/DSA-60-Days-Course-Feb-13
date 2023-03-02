public class Person {
    public int Id { get; set; }
    public Person Next { get; set; }
    
    public Person(int id) {
        Id = id;
        Next = null;
    }
}

public static int CountPeopleInLine(Person head) {
    
    // base case: if the current node is null, return 0 (end of list)
    if (head == null) {
        return 0;
    }
    
    // recursive case: count the number of people in the rest of the list and add 1
    return 1 + CountPeopleInLine(head.Next);
}