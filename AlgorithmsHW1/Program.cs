//1. Data Structures

//Create a list of integers and add 5 elements to it.

List<int> myList = new List<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
myList.Add(5);

Console.WriteLine(string.Join(", ", myList));  // Output: 1, 2, 3, 4, 5


//Create a dictionary with string keys and integer values, and add 5 key-value pairs to it.

Dictionary<string, int> myDict = new Dictionary<string, int>();
myDict.Add("one", 1);
myDict.Add("two", 2);
myDict.Add("three", 3);
myDict.Add("four", 4);
myDict.Add("five", 5);

foreach (var kvp in myDict)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}
// Output:
// Key: one, Value: 1
// Key: two, Value: 2
// Key: three, Value: 3
// Key: four, Value: 4
// Key: five, Value: 5

//Create a queue of integers and add 5 elements to it.

Queue<int> myQueue = new Queue<int>();
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);
myQueue.Enqueue(4);
myQueue.Enqueue(5);

foreach (var item in myQueue)
{
    Console.WriteLine(item);
}
// Output:
// 1
// 2
// 3
// 4
// 5

//Create a stack of integers and add 5 elements to it.

Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);

foreach (var item in myStack)
{
    Console.WriteLine(item);
}
// Output:
// 5
// 4
// 3
// 2
// 1

////////////////////////////////////////////////////////////////////////////

//2.Operations on Data Structures

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sumList = numbers.Sum();
        Console.WriteLine($"Sum of all elements in the list: {sumList}");

        // Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "A", 10 },
            { "B", 20 },
            { "C", 30 }
        };
        int sumDictionary = dictionary.Values.Sum();
        Console.WriteLine($"Sum of all values in the dictionary: {sumDictionary}");

        // Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        queue.Dequeue();
        queue.Dequeue();
        Console.WriteLine("Remaining elements in the queue: " + string.Join(", ", queue));

        // Stack
        Stack<string> stack = new Stack<string>();
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");
        stack.Pop();
        stack.Pop();
        Console.WriteLine("Remaining elements in the stack: " + string.Join(", ", stack));
    }
}


//////////////////////////////////////////////////////////////////////////////////////////////

//3.Additional Tasks

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample list of integers
        List<int> data = new List<int> { 1, 2, 3, 4, 5 };

        // 1. Print all elements of the list
        Console.WriteLine("Elements of the list:");
        foreach (int number in data)
        {
            Console.WriteLine(number);
        }

        // 2. From a three-digit number, print the largest digit
        int threeDigitNumber = 124;
        int largestDigit = threeDigitNumber.ToString().Select(c => c - '0').Max();
        Console.WriteLine("Largest digit in " + threeDigitNumber + ": " + largestDigit);

        // 3. From a three-digit number, print the smallest digit
        int smallestDigit = threeDigitNumber.ToString().Select(c => c - '0').Min();
        Console.WriteLine("Smallest digit in " + threeDigitNumber + ": " + smallestDigit);

        // 4. From an array, find all even values and print their sum
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int evenSum = array.Where(num => num % 2 == 0).Sum();
        Console.WriteLine("Sum of all even values in the array: " + evenSum);

        // 5. Calculate and print the average of all elements in the array
        double average = array.Average();
        Console.WriteLine("Average of all elements in the array: " + average);
    }
}



