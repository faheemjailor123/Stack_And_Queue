class Queue {
    QNode front, rear;
 
    public Queue()
    {
        this.front = this.rear = null;
    }
    public void enqueue(int key)
    {

        QNode temp = new QNode(key);
        if (this.rear == null) {
            this.front = this.rear = temp;
            return;
        }

        this.rear.next = temp;
        this.rear = temp;
    }
 

    public void dequeue()
    {
        if (this.front == null)
            return;
 
        QNode temp = this.front;
        this.front = this.front.next;
        
        if (this.front == null)
            this.rear = null;
    }
}
 
public class Test {
    public static void Main(String[] args)
    {
        Queue q = new Queue();
        q.enqueue(70);
        q.enqueue(30);
        q.enqueue(56);
        q.dequeue();
        q.dequeue();
        q.enqueue(70);
        q.enqueue(30);
        q.enqueue(56);
        q.dequeue();
        Console.WriteLine("Queue Front : " + q.front.key);
        Console.WriteLine("Queue Rear : " + q.rear.key);
    }
}
 
