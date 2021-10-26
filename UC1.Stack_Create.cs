using System;
 
public class StackUsingLinkedlist
{
    private class Node
    {
        public int data;
        
        public Node link;            // reference variable Node type
    }
    Node top;                         // create global top reference variable
     
    public StackUsingLinkedlist()
    {
        this.top = null;
    }
 
    public void push(int x)
    {
       
        Node temp = new Node();         // create new node temp and allocate memory
 
        if (temp == null)
        {
            Console.Write("Heap Overflow");
            return;
        }
        temp.data = x;
        temp.link = top;
        top = temp;
    }

    public bool isEmpty()
    {
        return top == null;
    }
    public int peek()
    {
        if (!isEmpty())
        {
            return top.data;
        }
        else
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
    }

    public void pop() // remove at the beginning
    {
        // check for stack underflow
        if (top == null)
        {
            Console.Write("Stack Underflow");
            return;
        }

        top = (top).link;
    }
 
    public void display()
    {
        if (top == null)
        {
            Console.Write("Stack Underflow");
            return;
        }
        else
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write("{0}->", temp.data);
                temp = temp.link;
            }
        }
    }
}
 

public class String
{
    public static void Main(String[] args)
    {
        
        StackUsingLinkedlist obj = new StackUsingLinkedlist();
         
        
        obj.push(70);
        obj.push(30);
        obj.push(56);
        obj.display();
 
        Console.Write("\nTop element is {0}\n", obj.peek());
        obj.pop();
        obj.pop();
        obj.display();
 
        Console.Write("\nTop element is {0}\n", obj.peek());
    }
}
