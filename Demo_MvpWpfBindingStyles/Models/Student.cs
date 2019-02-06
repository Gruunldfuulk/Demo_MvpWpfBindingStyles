using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MvpWpfBindingStyles.Models
{
    public class Student
    {
        private string _lastName;
        private string _firstname;
        private int _age;


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


    }
}
