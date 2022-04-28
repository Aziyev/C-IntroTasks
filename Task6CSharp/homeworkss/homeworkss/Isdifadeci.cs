using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkss
{
    internal class Isdifadeci
    {
        string username;

        public string UserName
        {
            get { return username; }
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("Duzgun UserName Daxil Edin");
                    value = Console.ReadLine();
                }
                username = value;
            }

        }

        string password;

        public string Password
        {
            get { return password; }
            set
            {

                bool check = true;

                while (check)
                {
                    bool checkUperCase = false;

                    bool checkLowerCase = false;

                    bool checkDigit = false;

                    if (value.Length >= 8)
                    {
                        foreach (char item in value)
                        {
                            if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLowerCase = true;
                            }
                            else if (char.IsUpper(item))
                            {
                                checkUperCase = true;
                            }

                            if (checkDigit && checkUperCase && checkLowerCase)
                            {

                                password = value;

                                check = false;

                                break;
                            }
                        }
                    }

                    if (!checkDigit || !checkLowerCase || !checkUperCase)
                    {
                        Console.WriteLine("Password-u Duzgun Daxil Edin Uzunlugu minimum 8 olmalidir");

                        value = Console.ReadLine();
                    }
                }
            }
        }

        public Isdifadeci(string username)
        {
            username = username;
        }
    }

}
