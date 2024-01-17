// See https://aka.ms/new-console-template for more information

// Initialise the stack
StackManager stack = new StackManager(new StackItem("don't know"));

Console.WriteLine(stack.Peek());

stack.Push(new StackItem("Hello, World!"));

Console.WriteLine(stack.Peek());

stack.Push(new StackItem("This is a nice stack."));

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());