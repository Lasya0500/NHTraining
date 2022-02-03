using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************
Author : G V S S SRI LASYA
Purpose :  Create your own class and variables and initialize with 
some values.Print them using
for
foreach
lambda
linq query
*********************************************************************/


namespace Day8Project5
{
    class PoliceOfficer
    {

        public string name;
        public string designation;
        public int id;

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            
                //creating a PoliceOfficer list,initialising it 
                List<PoliceOfficer> policeOfficers = new List<PoliceOfficer>()
            {
                new  PoliceOfficer() { name = "Srinivas", designation = "DGP" , id  = 1},
                new  PoliceOfficer() { name = "Sravani", designation = "IG" ,id = 2},
                new  PoliceOfficer() { name = "Chandan", designation = "DIG", id = 3},
                new  PoliceOfficer() { name = "Varsha", designation = "SP", id = 4},
                new  PoliceOfficer(){  name = "Harshini",designation = "SP", id = 5}
            };


                //printing name and designation of officers whose id<=3 using for loop
                for (int i = 0; i < policeOfficers.Count; i++)
                {
                    if (policeOfficers[i].id <= 3)
                        Console.Write($"\nname : {policeOfficers[i].name}\t\tdesignation : {policeOfficers[i].designation}");

                }


                Console.WriteLine("\n\n");
            //printing name and designation of officers whose id<=3 using foreach
            foreach (var policeOfficer in policeOfficers)
                {
                    if (policeOfficer.id <= 3)
                        Console.Write($"\name : {policeOfficer.name}\t\tdesignation: {policeOfficer.designation}");
                }


                Console.WriteLine("\n\n");
            //printing name and designation of officers whose id<=3  using lambda expression
            policeOfficers.ToList().Where(policeOfficer => policeOfficer.id <= 3).ToList().ForEach(policeOfficer => Console.Write($"\nname : {policeOfficer.name}\t\tdesignation : {policeOfficer.designation}"));


                Console.WriteLine("\n\n");
            //printing name and designation of officers whose id<=3  using LINQ
            var result = from policeOfficer in policeOfficers
                         where policeOfficer.id <= 3
                         select policeOfficer;

                result.ToList().ForEach(policeOfficer => Console.Write($"\nname : {policeOfficer.name}\t\tdesignation : {policeOfficer.designation}"));

                Console.ReadLine();

            }

        }

    }
















