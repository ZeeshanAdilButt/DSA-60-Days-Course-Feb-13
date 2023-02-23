# DSA-60-Days-Course-Feb-13


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

### findin memory address

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



