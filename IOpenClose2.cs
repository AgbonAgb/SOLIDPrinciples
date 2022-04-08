using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public interface IOpenClose2
    {
        ////public double GetSalesDiscount(double amount, CustomerType custType)
        ////{//Challenge, we will have issues when additional InvoiceType is added, we should make this extensible
        ////    //so, create classes for each type and new addition can be added
        ////    double finalAmount = 0;
        ////    switch (custType)
        ////    {
        ////        case CustomerType.Gold:
        ////            finalAmount = amount - 100;
        ////            break;
        ////        case CustomerType.Silver:
        ////            finalAmount = amount - 50;
        ////            break;
        ////    }

        ////    return finalAmount;
        ////}
        ////public enum CustomerType
        ////{
        ////    Gold,
        ////    Silver
        ////};
        //////Solution
        //////Now, the OpenClose class is closed for modification.
        //////But it is open for the extension as it allows creating new classes deriving from
        //////the Invoice class which clearly follows the Open-Closed Principle in C#. 
        ////public virtual double GetSalesDiscount(double amount)
        ////{
        ////    //return amount - 10;
        ////    double finalAmount = amount;
        ////    return finalAmount;
        ////}

        double GetSalesDiscount(double amount);
    }
    //define concreat classes
    //Define each customer type that impliment its discount and overide the virtual base class
    public class GoldCustomers : IOpenClose2
    {
        public double GetSalesDiscount(double amount)
        {
            return (amount) - 50;
        }
    }
    public class SilverCustomers : IOpenClose2
    {
        public double GetSalesDiscount(double amount)
        {
            return (amount) - 40;
        }
    }
    public class PlatinumCustomers : IOpenClose2
    {
        public double GetSalesDiscount(double amount)
        {
            return (amount) - 30;
        }
    }
}
