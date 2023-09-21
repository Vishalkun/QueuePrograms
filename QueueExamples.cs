using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueuePrograms
{
    internal class QueueExamples
    {
        Node front;
        Node rear;
        public void enqueData(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                rear = node;
                front = rear;

            }
            else
            {
                rear.Next = node;
                rear = rear.Next;

            }
            Console.WriteLine("{0} is inserted into queue", node.data);

        }

        public void DisplayData()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }
            }
        }

        }
    }
