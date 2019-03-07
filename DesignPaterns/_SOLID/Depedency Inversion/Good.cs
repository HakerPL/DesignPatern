using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPaterns._SOLID.Depedency_Inversion
{
    // Low-level code
    public class RelationshipsGood : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindOfChildrenOf(string name)
        {
            foreach (var r in _relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent))
                yield return r.Item3;
        }
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindOfChildrenOf(string name);
    }
}
