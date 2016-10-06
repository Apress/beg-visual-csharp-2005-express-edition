#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Properties
{
    public class Person
    {
        private string _surname;
        private string _forename;
 
        public void SetName(string surname, string forename)
        {
            _surname = surname;
            _forename = forename;
        }
        public string FullName
        {
            get
            {
                return _forename + " " + _surname;
            }
            set
            {
                string[] names = value.Split(new string[] { " " },
                        StringSplitOptions.RemoveEmptyEntries);
                _forename = names[0];
                _surname = names[names.Length - 1];

            }

        }


    }
}
