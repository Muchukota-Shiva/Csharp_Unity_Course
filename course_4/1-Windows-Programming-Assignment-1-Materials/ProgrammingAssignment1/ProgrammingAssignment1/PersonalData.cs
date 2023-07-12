using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        // declare your fields here
        string firstname = "";
        string middlename = "";
        string lastname = "";
        string streetaddress = "";
        string city = "";
        string state = "";
        string postalcode = "";
        string country = "";
        string phonenumber = "";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
                // delete code below and replace with correct code
                return firstname;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                // delete code below and replace with correct code
                return middlename;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                // delete code below and replace with correct code
                return lastname;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
                // delete code below and replace with correct code
                return streetaddress;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                // delete code below and replace with correct code
                return city;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                // delete code below and replace with correct code
                return state;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                // delete code below and replace with correct code
                return postalcode;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                // delete code below and replace with correct code
                return country;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                // delete code below and replace with correct code
                return phonenumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here
            StreamReader input = null;
            string filename = "ValidData.txt";
            
            try
            {
                //input = File.OpenText("D:/C#/coloradoc#course/Csharp_Unity_Course/course_4/1-Windows-Programming-Assignment-1-Materials/ProgrammingAssignment1/ProgrammingAssignment1/bin/Debug/net6.0/ValidData.txt");
                input = File.OpenText(filename);
                String tmp = input.ReadLine();
                List<String> value = new List<string>();
                int index = tmp.IndexOf(',');

                while (index != -1)
                {
                    value.Add(tmp.Substring(0, index));
                    tmp = tmp.Substring(index + 1);
                    index = tmp.IndexOf(',');
                    if (index == -1 && tmp != null)
                    {
                        value.Add(tmp);
                    }
                }

                if (value.Count > 0)
                {
                    firstname = value[0];
                    middlename = value[1];
                    lastname = value[2];
                    streetaddress = value[3];
                    city = value[4];
                    state = value[5];
                    postalcode = value[6];
                    country = value[7];
                    phonenumber = value[8];
                }
                else
                {
                    firstname = "";
                    middlename = "";
                    lastname = "";
                    streetaddress = "";
                    city = "";
                    state = "";
                    postalcode = "";
                    country = "";
                    phonenumber = "";
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                if(input!=null)
                {
                    input.Close();
                }
            }
            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data
        }

        #endregion
    }
}
