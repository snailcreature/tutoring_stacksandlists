using System;

class StackItem
{
    private string Data;

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
}