﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {
        //Insert part
        //Add Value in LinkedList Node....
        public Node head; //Empty node To point
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head; //Stroing last Data In temp Variable...
                while(temp.Next != null) 
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} Linked List",node.data);
        }

        //Reverse Data From ....
        public void AddInReverse( int data)
        {
            Node node = new Node(data);


        }

       
    }
}
