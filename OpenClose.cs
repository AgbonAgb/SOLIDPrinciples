using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    //1. Open for extension, meaning that the class’s behavior can be extended; and
    //2. Closed for modification, meaning that the source code is set and cannot be changed.
    //Classes should be open for extension, but closed for modification
    //This principle aims to extend a Class’s behaviour without changing the existing behaviour of that Class. This is to avoid causing bugs wherever the Class is being used.
    public class OpenClose
    {
        //this is mostly observed when using if statement of switch, it means any new option will 
        //force us to edit the code that has been running well. We should be able to extend the class using abstract
        //inheritance or reflection, virtual


        //this class method is not closed for modification, editing this method violate the Open-Close Principle of 
        public double GetSalesDiscount(double amount, CustomerType custType)
        {//Challenge, we will have issues when additional InvoiceType is added, we should make this extensible
            //so, create classes for each type and new addition can be added
            double finalAmount = 0;
            switch(custType)
            {
                case CustomerType.Gold:
                   finalAmount = amount - 100;
                    break;
                case CustomerType.Silver:
                    finalAmount = amount - 50;
                    break;
            }

            return finalAmount;
        }
        public enum CustomerType
        {
            Gold,
            Silver
        };
        //Solution
        //Now, the OpenClose class is closed for modification.
        //But it is open for the extension as it allows creating new classes deriving from
        //the Invoice class which clearly follows the Open-Closed Principle in C#. 
        public virtual double GetSalesDiscount(double amount)
        {
            //return amount - 10;
            double finalAmount = amount;
            return finalAmount;
        }
    }


    //Create Classes that inherit from the above and override


    //Define each customer type that impliment its discount and overide the virtual base class
    public class GoldCustomer : OpenClose
    {
        public override double GetSalesDiscount(double amount)
        {
            return base.GetSalesDiscount(amount) - 50;
        }
    }
    public class SilverCustomer : OpenClose
    {
        public override double GetSalesDiscount(double amount)
        {
            return base.GetSalesDiscount(amount) - 40;
        }
    }
    public class PlatinumCustomer : OpenClose
    {
        public override double GetSalesDiscount(double amount)
        {
            return base.GetSalesDiscount(amount) - 30;
        }
    }

}
