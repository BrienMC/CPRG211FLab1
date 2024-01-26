using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211_F_Lab_1
{
    public class Relation
    {
    
        public string person1;
        public string person2;
        public string RelationshipType;

        public Relation(Person p1, Person p2, string relationship)
        {
            person1 = p1.firstName;
            person2 = p2.firstName;
            RelationshipType = relationship;
        }

        public virtual void ShowRelationShip()
        {
            Console.WriteLine($"Relationship between {person1} and {person2} is: {RelationshipType}hood");
        }
    }
}
