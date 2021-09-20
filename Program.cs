using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //strig interpolation
            Console.WriteLine($"Oled {userAge} aastat vana.");


        }
    }
}
