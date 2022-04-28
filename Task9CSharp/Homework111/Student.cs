using System;
using System.Collections.Generic;
using System.Text;

namespace Homework111
{
      class Student
    {

        public string _fName;
        public string Fullname
        {
            get => _fName;
            
                set
                {
                    while (!CheckFullname(value))
                    {
                        Console.WriteLine("Ad Soyadinizi Duzgun Daxil Etin:");
                        value = Console.ReadLine();

                    }
                    _fName = value; 
                }
        }

        public static bool CheckFullname(string fName)
        {
            return fName.Split(' ').Length >= 2;
        }

        private string _grNo;
        public string GroupNo
        {
            get => _grNo;
            
            set
                {
                    while (!CheckGroupNo(value))
                        {
                            Console.WriteLine("Qrup nomresini duzgun daxil edin");
                                value = Console.ReadLine(); 
                        }
                        _grNo = value;
                }
        }

        
        public static bool CheckGroupNo(string grNo)
        {
            if (grNo.Length == 4 && char.IsUpper(grNo[0]))
            {
                for (int i = 1; i < grNo.Length; i++)
                {
                    if (!char.IsDigit(grNo[i])) 
                        return false;
                }
                return true;

            } 
            return false;
                
        }


        public int Age { get; set; }

        public Student(string grNo, string fName,int age)
        {
            _grNo = grNo;
            _fName = fName; 
            Age = age; 
        }
        public Student()
        {
            Console.WriteLine("Xosh Gelmisiniz");
            
        }
        




    }
}
