namespace LinkedListProblem
{
  public class LinkedListStack
  { 
     private Node top;
     public  LinkedListStack()
     {
       this.top = null;
     }
     internal void  push(int value)
     {
       Node node = new Node(value);
       if (this.pop == null)
       {
          node.next = null;
       }
       else
       {
          node.next = this.top;
       }
       this.top = node;
       console.WriteLine("{0} pushed  to stack ", value);
   }
   internal void Display()
   {
      Node temp = this.top;
      While (temp != null)
      {
        Console.Write(temp.data + " ");
        temp = temp.next;
      }
    }
    internal void peek()
    {
      if (this.top == null)
      {
        Console.WriteLine("Stack is empty");
        return;
      }
      Console.WriteLine("{0} is in the top of the stack", this.top.data);
      }
      internal void Display()
      {
         Node temp = this.top;
         While (temp !=null)
         {
            Console.Write(temp.data +" ");
            temp = temp.next;
          }
       }
       internal void Peek()
    {
       if(this.top == null)
       {
         Console.WriteLine("stack is empty");
         return;
        }
        Console.WriteLine("{0} is in the top of the stack", this.top.data);
     }
     internal void Pop()
     {
       if (this.top == null)
       {
         Console.WriteLine("Stack is empty,Deletion is not possible");
         return;
       }
       Console.WriteLine("value popped is {0}", this.top.data);
       this.top = this.top.next;
     }
     internal void IsEmpty()
     {
       While (this.top != null)
       {
       
         peek();
         pop();
       }
     }  
