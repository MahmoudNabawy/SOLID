using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    //Let q(x) be a property provable about objects of x of type T. 
    //Then q(y) should be provable for objects y of type S where S is a subtype of T.

    // This example achieve Liskov Substitution
    class ContactSQLiteRepository : ContactRepository
    {
        public string findContactOrNull(string id)
        {
            return "this is :" + id;
        }
    }
}
