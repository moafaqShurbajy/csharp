using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pro2111.Models
{
    public class Product
    {
        #region allProparty
        public string fullName { get; set; }
        public string fullAdress { get; set; }
        public string _fName { get; set; }
        public string _lName { get; set; }

        #endregion
        #region function
        public string getFullName (string fName,string lName ){
            fullName = fName + " " + lName;
            return fullName;
        }
        public string getFullName (string fName,string mName, string lName)
        {
            fullName = fName + " " +mName+" "+ lName;
            return fullName;

        }
        public string getFullName (){
            fullName = _fName + " " + _lName;
            return fullName;
        }
        public double Calc (double salary, double commession, double bonce, double overtimeByHour){
            double total ;
            double plusingSomething = salary + commession + bonce;
            double endSomthing = (plusingSomething * 0.16) - salary;
            double overTime = overtimeByHour * 6.5;
            total = endSomthing + overTime;
            return total;
        }
        #endregion
    }
}