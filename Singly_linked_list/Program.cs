using System;
using System.Collections.Generic;
using System.Linq;
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
            if(START == null || rollNo <= START.rollNumber)
            {
                if((START != null) &&(rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                
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
