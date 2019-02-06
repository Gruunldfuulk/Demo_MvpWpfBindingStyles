using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_MvpWpfBindingStyles.Models;

namespace Demo_MvpWpfBindingStyles.Presenters
{
    public class MainWindowPresenters
    {
        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { _selectedStudent = value; }
        }

        public MainWindowPresenters()
        {
            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            _selectedStudent = new Student()
            {
                LastName = "Juhasz",
                FirstName = "Alex",
                Age = 31
            };
        }
    }
}
