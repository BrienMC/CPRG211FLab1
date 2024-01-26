using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211_F_Lab_1
{
    public class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public Person(int id, string first, string last, string color, int personAge, bool working)
        {
            personId = id;
            firstName = first;
            lastName = last;
            favoriteColour = color;
            age = personAge;
            isWorking = working;
        }

        public virtual void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite color is {favoriteColour}");
        }

        public virtual void ChangeFavoriteColour()
        {
            this.favoriteColour = "White";
        }

        public virtual void GetAgeInTenYears()
        {
            Console.WriteLine($"{firstName} {lastName}'s Age in 10 years is: " + (age + 10));
        }

        public virtual void ToString()
        {
            Console.WriteLine($"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}");
        }

    }
}
