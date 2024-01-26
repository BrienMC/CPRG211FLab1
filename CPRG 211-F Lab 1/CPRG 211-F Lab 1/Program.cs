using System.Linq.Expressions;

namespace CPRG_211_F_Lab_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            gina.DisplayPersonInfo();
            mike.ToString();
            ian.ChangeFavoriteColour();
            ian.DisplayPersonInfo();
            mary.GetAgeInTenYears();

            Relation ginaAndMary = new Relation(gina, mary, "Sister");
            ginaAndMary.ShowRelationShip();

            Relation ianAndMike = new Relation(ian, mike, "Brother");
            ianAndMike.ShowRelationShip();

            List<Person> people = new List<Person>();
            people.Add(ian);
            people.Add(mike);
            people.Add(gina);
            people.Add(mary);

            double ageTotal = 0;

            for (int i = 0; i < people.Count; i++)
            {          
                ageTotal += people[i].age;
            }

            int youngestAge = int.MaxValue;
            string youngestPerson = people[0].firstName;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].age < youngestAge) {
                    youngestAge = people[i].age;
                    youngestPerson = people[i].firstName;
                }
            }

            int oldestAge = int.MinValue;
            string oldestPerson = people[0].firstName;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].age > oldestAge)
                {
                    oldestAge = people[i].age;
                    oldestPerson = people[i].firstName;
                }
            }

            Console.WriteLine("Average age is: " + (ageTotal / people.Count));
            Console.WriteLine("The youngest person is: " + youngestPerson);
            Console.WriteLine("The oldest person is: " + oldestPerson);

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].firstName.Substring(0,1) == "M")
                {
                    people[i].ToString();
                }
            }
            
            for (int i = 0;i < people.Count; i++)
            {
                if (people[i].favoriteColour == "Blue")
                {
                    people[i].ToString();
                }
            }

        }
    }
}
