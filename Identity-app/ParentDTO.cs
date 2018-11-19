using System;
using System.Collections.Generic;
using System.Text;

namespace Identity_app
{
    class ParentDTO
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string Religion;
        public string Nationality;
        public string Occupation;

        public ParentDTO(string fname, string midname, string lname, string religion, string nationality, string occupation)
        {
            FirstName = fname;
            MiddleName = midname;
            LastName = lname;
            Religion = religion;
            Nationality = nationality;
            Occupation = occupation;
        }
    }
}
