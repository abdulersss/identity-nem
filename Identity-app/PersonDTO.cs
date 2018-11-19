using System;
using System.Collections.Generic;
using System.Text;

namespace Identity_app
{
    class PersonDTO
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public AddressDTO CompleteAddress;
        public ParentDTO Father;
        public ParentDTO Mother;
        public string Religion;
        public string Nationality;
        public DateTime DateOfBirth; //
        public char Gender; // M or F

        public PersonDTO(string fname, string midname, string lname, AddressDTO address, ParentDTO father, ParentDTO mother, string religion, string nationality, DateTime dob, char gender)
        {
            FirstName = fname;
            MiddleName = midname;
            LastName = lname;
            CompleteAddress = address;
            Father = father;
            Mother = mother;
            Religion = religion;
            Nationality = nationality;

        }
    }
}
