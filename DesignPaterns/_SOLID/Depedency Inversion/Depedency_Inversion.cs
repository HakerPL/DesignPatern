using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns._SOLID.Depedency_Inversion
{
    /*
     * Depedency Inversion
     * Hight-level modules should not depend upon lol-level ones, use abstractions (interfaces)
     */


    public class Depedency_Inversion
    {
        //WRONG!!!
        public Depedency_Inversion(RelationshipsWrong relationships)
        {
            // send low level cod to highe level code iw WRONG!!
            // we cant change RelationshipsWrong store data without change all other code
        }

        // GOOD
        public Depedency_Inversion(IRelationshipBrowser relationships)
        {
            // now we are depend from interface not on class
        }

        public void Run()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mery" };

            var relationships = new RelationshipsWrong();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
        }
    }
}
