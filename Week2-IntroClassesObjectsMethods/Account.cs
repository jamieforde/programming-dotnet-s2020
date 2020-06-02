using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Week2_IntroClassesObjectsMethods
{
    /// <summary>
    /// Represent an User Account
    /// </summary>
    public class Account
    {
        //private string name;

        //public void SetName(string enterName)
        //{
        //    name = enterName;
        //} 

        //public string GetName()
        //{
        //    return name;
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        if (value.Length > 0)
        //        {
        //            name = value;
        //        }
        //        else
        //        {
        //            throw new Exception("You need to enter some text");
        //        }
        //    }
        //}


        /// <summary>
        /// Constructor for Account class
        /// </summary>
        /// <param name="firstName">Represents the user first name</param>
        /// <param name="lastName"></param>
        public Account (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString() => $"{FirstName} {LastName}";
 
        


    }
}
