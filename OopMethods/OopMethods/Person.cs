using System;
using System.Collections.Generic;
using System.Text;

namespace OopMethods
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName
        {
            get
            {
                return ($"{FirstName} {LastName}");
            }
        }
        public void SayHello(string introductionFormula)//nu trebuie neaparat return 
        {
            Console.Write($"{introductionFormula}{FullName}" );
              }

         public int GetAge() //trebuie sa am neaparat return 
        {
            return DateTime.Today.Year - DateOfBirth.Year;
        }
     }
}


    
   //instanta si static???
   //static ar fi daca toata masinile din luma ar avea acelasi mototr, acelasi obict motor
   //
