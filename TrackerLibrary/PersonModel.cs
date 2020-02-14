using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Represents the last name of the person.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Represents the email of the person.
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// Represents the mobile phone number of the person.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
