using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    class Node 
    { 
        // each node consist of the information part and link to the next node
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List 
    {
        Node START;
        public List() 
        {
            START = null;
        }
        public void addNote() // add a note in the list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            // if the node to be inserted is the first node
            if (START == null || rollNo <= START.rollNumber)
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                Node previous, current;
                previous = START;
                current = START;

                while ((current != null) && (rollNo >= current.rollNumber))
                {
                    if (rollNo == current.rollNumber)
                    {
                        Console.WriteLine();
                        return;
                    }

                    previous.next = current;
                    previous.next = newnode;
                }
                newnode.next = current;
                previous.next = newnode;

            }

            
        }
        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if(Search(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if(current == START)
                START = START.next;
            return true;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while ((current != null)&&(rollNo != current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void Traverse()
        {
            if (ListEmpty())
                Console.WriteLine("\nThe records in the list are: ");
            else
            {
                Console.WriteLine("\nThe records in the list are: ");
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + " "
                        + currentNode.name + "\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
