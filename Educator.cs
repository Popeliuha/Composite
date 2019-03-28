using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Educator
    {
        private string name;
        private string post;
        private string groupNumber;
        public List<Educator> Subordinates { get; set; }

        public Educator(string name, string post, string groupNumber)
        {
            this.name = name;
            this.post = post;
            this.groupNumber = groupNumber;
            Subordinates = new List<Educator>();
        }

        public void AddToSubordinates(Educator educator)
        {
            Subordinates.Add(educator);
        }

        public void RemoveFromSubordinates(Educator educator)
        {
            Subordinates.Remove(educator);
        }

        public string ShowInfo()
        {
            return $"Educator's name is {name}, post is {post} and group number is {groupNumber}.";
        }
    }
}
