using System;

// Class for holding data in the stack
class StackItem
{
    // Data to hold
    private string Data;

    // The item below this on the stack
    private StackItem NextInStack = null;

    public StackItem(string newData)
    {
        Data = newData;
    }

    public string GetData()
    {
        return Data;
    }

    public StackItem GetStack()
    {
        return NextInStack;
    }

    public void SetStack(StackItem next)
    {
        NextInStack = next;
    }
}