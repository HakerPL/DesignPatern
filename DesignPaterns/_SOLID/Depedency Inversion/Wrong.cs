using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Depedency_Inversion
{
    public enum Relationship
    {
        Parent, Child, Sibling
    }

    public class Person
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
    }

    // Low-level code
    public class RelationshipsWrong
    {
        private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        //WRONG!!!
        public List<(Person, Relationship, Person)> Relations => _relations;
    }
}
