using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_PQueue
{
    internal class Emergency_Room
    {


        private PriorityQueue<string, int> pQueue;
        int count = 0;
        private string _name;

        public Emergency_Room()
        {
            pQueue = new PriorityQueue<string, int>();
          
        }

        public void addPatient(string name, int priority) //enqueue method
        {
            pQueue.Enqueue(name, priority);
            count = pQueue.Count;
        }

        public string testFiFo() //dequeue and testor method
        {
            _name = pQueue.Dequeue();
            return _name;
        }

        public string[] patientList()
        {
            string[] patientList = new string[pQueue.Count];
            int count = pQueue.Count;
            for (int i = 0; i < count; i++)
            {
               
                testFiFo();
                patientList[i] = _name;
                
            }
            foreach (string patient in patientList)
            {
                int i = 1;
                _name = patient;
                addPatient(_name, i);
                i++;
                count = pQueue.Count;
              
            }
            
            //Console.WriteLine("\n this counts the final pQueue to verify 5 elements went back in => " + count + " <= yep!\n");
            
            return patientList;
        }
      
      







    }

}
