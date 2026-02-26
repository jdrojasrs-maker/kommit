// See https://aka.ms/new-console-template for more information
using technical_challenge;

Console.WriteLine("Kommit technical-challenge");

var list = new DoublyLinkedList();

Console.WriteLine("Original List");

list.InsertAtHead(10);
list.InsertAtHead(22);
list.InsertAtTail(31);
list.InsertAtTail(42);
list.InsertAtTail(43);
list.InsertAtTail(31);


list.PrintList();
Console.WriteLine("Delete 22");
list.DeleteNode(22);

Console.WriteLine("List after remove");
list.PrintList();

Console.WriteLine("Delete duplicate 31");
list.RemoveDuplicates();

Console.WriteLine("List after remove duplicates");
list.PrintList();


var index = list.Search(43);
// Considerando posiscion inicaial index 0
Console.WriteLine($"Index de 22: {index}");

list.CountNodes();
