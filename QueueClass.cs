using System;

namespace BankingCashCounter
{
    public class QueueClass
    {
        Node head = null;

        public void Enqueue(int data)   
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            // System.Console.WriteLine(node.data+" inserted in the Queue");
            System.Console.WriteLine(node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                return;
            }
            while (temp != null)
            {
                System.Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                return;
            }
            else
            {
                while (this.head != null)
                {
                    head.next.next = null;
                }
                head.next = head;
            }
        }
    }
}