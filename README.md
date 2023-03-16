# DSA-60-Days-Course-Feb-13

A repo for my 60 days course for my DSA students to teach them basic to intermediate Data Structures and Complete 80+ Leetcode problems.


## Mathemetics Basics:

### modulo

modulo operator (%) returns the remainder of a division operation. For example, the expression 26 % 5 would return 1, because 26 divided by 5 is 5 with a remainder of 1.

So in your example, 5 modulo 26 would also return 5, because 5 cannot be divided by 26 evenly, and the remainder is 5. Therefore, the expression 5 % 26 would evaluate to 5.


## Computer Architecture and Memory

### Padding

Padding, also known as alignment, is the insertion of extra bytes of memory between data elements in a data structure in order to satisfy the alignment requirements of the CPU architecture. CPU architectures have different alignment requirements, which specify how data must be stored in memory so that it can be accessed efficiently by the CPU.

For example, on a 32-bit architecture, 32-bit integers must be aligned on a 4-byte boundary, while on a 64-bit architecture, 64-bit integers must be aligned on an 8-byte boundary. If data is not properly aligned, it can cause performance issues or even result in a crash.

Consider the following struct in C++:


struct Example {
    char c;
    int i;
    double d;
};

Assuming a 64-bit architecture where int is 4 bytes and double is 8 bytes, the size of this struct would be 24 bytes (1 byte for char + 3 bytes of padding, 4 bytes for int, and 8 bytes for double). This is because the int member must be aligned on a 4-byte boundary, so there are 3 bytes of padding added after the char member to achieve this alignment.

Padding can also occur within arrays and structures of arrays. For example, if we have an array of 32-bit integers, and we want to access the second element of the array, we need to start at an address that is a multiple of 4 bytes. If the first element is not properly aligned, the CPU may have to read two memory accesses to retrieve the data, which can cause a performance penalty.

Padding is usually inserted automatically by the compiler or runtime system, so it is typically not something that developers need to worry about in most high-level programming languages. However, it is important to be aware of padding and alignment requirements when working with low-level programming languages or when optimizing performance-critical code.

### Finding memory address

Python:

x = 42
print(id(x))  # prints something like 140597269098400

C#;

int x = 42;
IntPtr address = Marshal.AllocHGlobal(Marshal.SizeOf(x));

Marshal.StructureToPtr(x, address, false);
Console.WriteLine(address);


c++

int x = 42;
int* address = &x;
cout << address << endl;

Javascript:
let x = { foo: 42 };
console.log(Object.prototype.toString.call(x));

## Data structures internals

### Hash functions

The djb2 function is a simple hash function that was created by Dan Bernstein. It takes a string as input and produces a hash value as output. The hash value is a 32-bit unsigned integer that is used to identify the string.

Here's the implementation of the djb2 function in Python:

def djb2(string):
    hash_value = 5381
    for char in string:
        hash_value = ((hash_value << 5) + hash_value) + ord(char)
    return hash_value & 0xFFFFFFFF


Let's break down how this function works:

The function takes a string as input.

It initializes a hash value to 5381.

It loops through each character in the string and updates the hash value based on the ASCII value of the character. Specifically, it performs the following operation:

hash_value = ((hash_value << 5) + hash_value) + ord(char)

This operation left-shifts the hash value by 5 bits (multiplies by 32), adds the original hash value to it, and adds the ASCII value of the current character to it.

Finally, the function returns the hash value modulo 2^32, which ensures that the hash value is a 32-bit unsigned integer.

Here's an example of how to use the djb2 function:

>>> string = "hello, world!"
>>> hash_value = djb2(string)
>>> print(hash_value)
1540932062

C++:

#include <iostream>
#include <string>

unsigned long djb2(std::string str) {
    unsigned long hash = 5381;
    int c;

    for (char& c : str) {
        hash = ((hash << 5) + hash) + c;
    }

    return hash;
}

int main() {
    std::string string = "hello, world!";
    unsigned long hash_value = djb2(string);
    std::cout << hash_value << std::endl;
    return 0;
}


JS:

function djb2(str) {
    let hash = 5381;

    for (let i = 0; i < str.length; i++) {
        hash = ((hash << 5) + hash) + str.charCodeAt(i);
    }

    return hash;
}

let string = "hello, world!";
let hash_value = djb2(string);
console.log(hash_value);

C#:

using System;

class Program
{
    static uint djb2(string str)
    {
        uint hash = 5381;

        foreach (char c in str)
        {
            hash = ((hash << 5) + hash) + c;
        }

        return hash;
    }

    static void Main(string[] args)
    {
        string str = "hello, world!";
        uint hash_value = djb2(str);
        Console.WriteLine(hash_value);
    }
}


### Hashing Collision Solutions

1. Open addressing: In open addressing, when a collision occurs, the algorithm searches for the next available slot in the hash table and places the item there. The slots are searched in a fixed sequence, which can be either linear or quadratic. This technique is called "open addressing" because it does not require the use of a separate data structure to store collided items. However, as the table fills up, the number of collisions can increase significantly, which can negatively impact performance.

1.1 Linear probing: In linear probing, when a collision occurs, the algorithm searches for the next available slot in the hash table by probing the slots one by one until it finds an empty slot. The slots are probed in a linear sequence, which means that the algorithm checks the next slot after the current slot until it finds an empty slot. This technique is easy to implement and can have good cache performance, but it can suffer from clustering, where items tend to cluster together in certain parts of the table.


1.2 Double hashing: In double hashing, when a collision occurs, the algorithm uses a secondary hash function to calculate an offset value that is added to the original hash index to find the next available slot. The offset value is calculated using a different hash function than the primary hash function, which helps to reduce clustering and improve performance. However, finding a good secondary hash function can be difficult, and the technique can still suffer from clustering if the hash functions are poorly chosen.

2. Chaining

Chaining is another technique for resolving collisions in hash tables. In chaining, instead of storing items directly in the hash table, we use a linked list to store all the items that hash to the same index. When a collision occurs, the algorithm simply adds the new item to the end of the linked list at the appropriate index.

The advantage of chaining is that it can handle a large number of collisions without degrading performance. The linked list provides a dynamic structure that can grow as needed to accommodate more items, without requiring any additional memory allocation. Additionally, because each slot in the table only needs to store a reference to the head of the linked list, the memory requirements for the hash table can be smaller than other techniques that require a slot for each item.

However, chaining can suffer from poor cache performance, because the items that hash to the same index may not be contiguous in memory. This can lead to a high number of cache misses and degrade performance. 


# Recursion

### Pros and Cons

#### Pros

- Bridges the gap between elegance and complexity
- Reduces the need for complex loops and auxiliary data structures
- Can reduce time complexity easily with memoization
- Works really well with recursive structures like tress and graphs

#### Cons
- Slowness due to CPU overhead
- Can lead to out of memory errors / stack overflow exceptions
- Can be unnecessarily complex if poorly constructed


# Sorting Algorithms

### Selection Sort:

Selection Sort is a simple sorting algorithm that works by iterating through an array, finding the smallest element in the unsorted portion of the array, and swapping it with the first element of the unsorted portion. The process is repeated until the entire array is sorted.

### Insertion Sort:

Insertion Sort is a simple sorting algorithm that works by iterating through an array, comparing each element to the elements that come before it, and inserting the element into its correct position in the array.

### Bubble Sort:

Bubble Sort is another simple sorting algorithm that works by repeatedly iterating through an array and swapping adjacent elements if they are in the wrong order.

### Merge Sort:

Merge Sort is a divide-and-conquer sorting algorithm that works by recursively dividing an array into halves, sorting each half, and then merging the two sorted halves back together.

### Quick Sort:

Quick Sort is a divide-and-conquer sorting algorithm that works by partitioning an array into two halves, one with elements smaller than a pivot element and one with elements larger than the pivot, and then recursively sorting each half.


# Mathemetical Techniques:

### why not do left + right / 2 ? what's the benefit for  left + (right - left) / 2 ? explain with example

The reason we use left + (right - left) / 2 instead of left + right / 2 is to avoid an integer overflow when computing the middle index.

Let's take the example:
arr = [1, 3, 4, 6, 7, 9, 11, 13]

Suppose we want to compute the middle index of the subarray defined by left = 0 and right = 7 using the expression left + right / 2.

In this case, left is 0 and right is 7, so the middle index is computed as:
mid = 0 + 7 / 2 = 3

This gives us the correct middle index, which is 3.

However, suppose we want to compute the middle index of a subarray with a very large left and right, such as:

left = 2147483640
right = 2147483647

If we use the expression left + right / 2, we get:
``` mid = 2147483640 + 2147483647 / 2 = 4294967283 ```

This result overflows the range of a 32-bit integer, which causes a runtime error in our program.

To avoid this problem, we can use the expression left + (right - left) / 2 instead. This expression is mathematically equivalent to left + right / 2, but it avoids the integer overflow problem.

In the same example, if we use the expression left + (right - left) / 2, we get:
``` mid = 2147483640 + (2147483647 - 2147483640) / 2 = 2147483643 ```

This result is within the range of a 32-bit integer, and gives us the correct middle index.

So, in summary, we use left + (right - left) / 2 instead of left + right / 2 to avoid an integer overflow when computing the middle index of a subarray with a large range of indices.

## computing related issues

Floating-point rounding errors are caused by the fact that computers store floating-point numbers using a fixed number of bits, and some decimal numbers cannot be represented exactly in binary. For example, the decimal number 0.1 cannot be represented exactly in binary, so when it is stored as a floating-point number, there will be a small rounding error.

for example: floating-point rounding errors can occur when calculating the logarithm of n and when rounding the result of the logarithm. The tolerance of 1e-10 is used to account for these errors by allowing for small differences between the exact result and the rounded result. If the difference between the two is less than 1e-10, the result is considered to be accurate enough and the function returns true.

1e-10 is scientific notation for a small decimal number: 1 multiplied by 10 raised to the power of -10. So 1e-10 is equivalent to 0.0000000001.

## Bitwise operator

The bitwise shift operators in C# are used to shift the bits of an integer value left or right. There are two types of shift operators:

Left Shift Operator (<<): This operator shifts the bits of the left-hand operand to the left by the number of positions specified by the right-hand operand. The leftmost bits are filled with zeros.

Right Shift Operator (>>): This operator shifts the bits of the left-hand operand to the right by the number of positions specified by the right-hand operand. The rightmost bits are filled with zeros for unsigned values and with the sign bit for signed values.

Here's an example of how to use the bitwise shift operators:

int x = 8;   // binary: 0000 1000

int y = x << 2;   // binary: 0010 0000, decimal: 32

int z = x >> 2;   // binary: 0000 0010, decimal: 2

In the above example, we first declare an integer variable x and initialize it with the value 8 (in binary: 0000 1000). We then use the left shift operator (<<) to shift the bits of x to the left by 2 positions, resulting in the value y of 32 (in binary: 0010 0000).

Next, we use the right shift operator (>>) to shift the bits of x to the right by 2 positions, resulting in the value z of 2 (in binary: 0000 0010).

Note that the bitwise shift operators can also be used with assignment operators, for example: x <<= 2; is equivalent to x = x << 2;.










