using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class User
    {
        public static bool Registration(string Login, string Password, string ConfirmPassword)
        {
            bool result = false;

            //Проверяем содержит ли Login пробелы и длина Login меньше 20
            if (Login.Length >= 20 || Login.Length == 0 || Login.Contains(' '))
            {
                throw new WrongLoginException("Некорректный Login : слишком длинный или содержит пробелы!");
            }
            else
            {
                //Проверяем содержит ли Password пробелы и длина Password меньше 20
                if (Password.Length >= 20 || Password.Contains(' '))
                {
                    throw new WrongPasswordException("Некорректный Password : слишком длинный или содержит пробелы!");
                }
                else
                {
                    //Проверяем содержит ли Password цифры
                    int iter = 0;
                    foreach (char c in Password)
                    {
                        if (char.IsNumber(c))
                        {
                            iter++;
                            break;
                        }
                    }

                    if(iter == 0)
                    {
                        throw new WrongPasswordException("Некорректный Password : Password должен содержать хотя бы одну цифру!");
                    }
                    else
                    {
                        //Проверяем Password и ConfirmPassword на равенство
                        if (Password == ConfirmPassword)
                        {
                            //Если все проверки пройдены, присваеваем в result true
                            result = true;
                        }
                        else
                        {
                            throw new WrongPasswordException("ConfirmPassword не равен Password!");
                        }
                    }
                }
            }

            return result;
        }
    }
}
