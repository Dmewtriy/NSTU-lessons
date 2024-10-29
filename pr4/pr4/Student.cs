using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    public class Student
    {
        private string lastName;
        private string firstName;
        private string patronymic;
        private string dateOfBirth;
        private int rate;
        private string group;

        public Student()
        {
            lastName = "Иванов";
            firstName = "Иван";
            patronymic = "Иванович";
            dateOfBirth = new DateTime(1900, 1, 1).ToShortDateString();
            rate = 1;
            group = "A-1";
        }

        public Student(string lastName, string firstName, string patronymic, DateTime dateOfBirth, int rate, string group)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth.ToShortDateString();
            Rate = rate;
            Group = group;
        }

        public Student(string lastName, string firstName, string patronymic, string dateOfBirth, int rate, string group)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Rate = rate;
            Group = group;
            DateOfBirth = DateTime.TryParse(dateOfBirth, out DateTime date) ? date.ToShortDateString() : new DateTime(1900, 1, 1).ToShortDateString();
        }

        public override string ToString()
        {
            return $"Студент {Rate} курса группы {Group} {LastName} {FirstName} {Patronymic} родился {dateOfBirth}";
        }

        public string LastName 
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    lastName = "Иванов";
                }
            }

            get
            {
                return lastName;
            }
        }

        public string FirstName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                else
                {
                    firstName = "Иван";
                }
            }

            get
            {
                return firstName;
            }
        }
        public string Patronymic
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    patronymic = value;
                }
                else
                {
                    patronymic = "Иванович";
                }
            }

            get
            {
                return patronymic;
            }
        }

        public string DateOfBirth
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    dateOfBirth = value;
                }
                else
                {
                    dateOfBirth = new DateTime(1900, 1, 1).ToShortDateString();
                }
            }

            get
            {
                return dateOfBirth;
            }
        }

        public DateTime DateOfBirthToDate
        {
            get
            {
                DateTime.TryParseExact(dateOfBirth, "dd.MM.yyyy", DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, out DateTime date);
                return date;
            }
        }

        public int Rate
        {
            set
            {
                if(value > 0 && value < 6)
                {
                    rate = value;
                }
                else 
                {
                    rate = 1;
                }
            }

            get 
            { 
                return rate;
            }
        }

        public string Group
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    group = value;
                }
                else
                {
                    group = "A-1";
                }
            }

            get
            {
                return group;
            }
        }
    }
}
