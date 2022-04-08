using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    //we can store any subclass reference into a base class variable and the behavior won’t change which is the goal of LSP
    //base class and child class relationships i.e. inheritance relationships, then, if we can successfully replace the object/instance of a
    //parent class with an object/instance of the child class, without affecting the behavior of the base class instance,
    //then it is said to be in Liskov Substitution Principle

    //For example, a father is a teacher whereas his son is a doctor. So here, in this case, the son can’t
    //simply replace his father even though both belong to the same family

    //By implementing the LSP, we are keeping our functionality intact and still having our subclasses act
    //as a substitute to a base class
    //Also, we encourage the code reusability by implementing the LCP and having better project maintenance as well.

    //When a child Class cannot perform the same actions as its parent Class, this can cause bugs.
    public class LisKovSubstitution
    {
    }
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
