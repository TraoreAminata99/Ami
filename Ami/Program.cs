using System;

namespace Ami
{

    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();


            Console.WriteLine("Hello World!");



            //declaration de tableau

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            //var names = new string[3]
            //{
            // "jack","john","mary"
            //};


            // demo des strings

            var firstName = "Mosh";

            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("MY NAME IS {0} {1}", firstName, lastName);
            //string.Format permet de recupéré les valeur des differents variable
            //string permet de recupéré la variable

            var names = new string[3] { "john", "jack", "Mary" };
            var formattedNames = string.Join(";", names);


            var text = @"Hi John
            look into the following paths
            c://folder1//folder2/
            c://folder3//folder4";
            Console.WriteLine(text);


            //demo type et valeur

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]:{0}, array2[0]:{1}", array1[2], array2[1]));


           Voiture rang = new Voiture();
            rang.Couleur = "Rose";
            rang.Marque = "Rang-rover";
            rang.Nombrepneu = " 4 roues";
            rang.Demarer();
            rang.Freiner();





            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }


        }






    }
   

            public  class Voiture
            {
                public string Couleur;
                public string Marque;
                public string Nombrepneu;
                

                public void Demarer()
                {
                    Console.WriteLine("La voiture de couleur" + " " + Couleur +" demare");
                   
                }

                public void Freiner()
                {
                    Console.WriteLine("La voiture de marque" + " " + Marque+ " Freine");

                }


                public void Roule()
                {
                    Console.WriteLine("La voiture avec " + " " + Nombrepneu + " Roule");

                }


            }


      


 

}
