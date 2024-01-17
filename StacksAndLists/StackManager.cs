using System;

class StackManager
{
    private StackItem TopOfStack;

    public StackManager(StackItem firstItem) 
    {
        TopOfStack = firstItem;
    }

    public void Push(StackItem newTop)
    {
        // Link the current top of the stack to the new data
        newTop.SetStack(TopOfStack);
        // Make the new data the top of the stack
        TopOfStack = newTop;
    }

    public string Pop()
    {
        // Capture the current top of stack data
        string returnString = TopOfStack.GetData();
        // Tell the stack manager that the new top is the one below this top
        TopOfStack = TopOfStack.GetStack();
        // Return the captured data
        return returnString;
    }

    public string Peek()
    {
        return TopOfStack.GetData();
    }
}