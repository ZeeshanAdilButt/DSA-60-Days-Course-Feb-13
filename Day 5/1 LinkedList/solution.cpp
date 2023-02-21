#include <iostream>

class DynamicArray {
private:
    int *arr;
    int size;
    int capacity;
public:
    DynamicArray() {
        arr = new int[1];
        size = 0;
        capacity = 1;
    }

    void push_back(int num) {
        if (size == capacity) {
            
            int *temp = new int[2 * capacity];

            for (int i = 0; i < capacity; i++) {
                temp[i] = arr[i];
            }
            delete[] arr;
            capacity *= 2;
            arr = temp;
        }
        arr[size] = num;
        size++;
    }

    int get(int index) {
        if (index < 0 || index >= size) {
            throw "Invalid index";
        }
        return arr[index];
    }

    int getSize() {
        return size;
    }
};

int main() {
    DynamicArray myArray;
    myArray.push_back(1);
    myArray.push_back(2);
    myArray.push_back(3);
    myArray.push_back(4);
    myArray.push_back(5);

    for (int i = 0; i < myArray.getSize(); i++) {
        std::cout << myArray.get(i) << " ";
    }

    return 0;
}
