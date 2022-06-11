using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }
        public Family(List<Person> people)
        {
            People = people;
            
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            Person newPerson = this.people.Find(p => p.Age == this.people.Max(x => x.Age));
            return newPerson;
        }
    }
}