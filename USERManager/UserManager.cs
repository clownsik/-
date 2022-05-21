using System;
using System.Text.RegularExpressions;

namespace USERManager
{
    public class USERManager
    {     
        public bool Add(string login, string phone, string email, string password, string number, string seria)
        {
            string patPhone = @"^\+?\d{1,3}?[-.]?\(?(?:\d{2,3})\)?[-.]?\d\d\d[-.]?\d\d\d\d$";
            string patEmail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

            if (login.Length < 5)
            {
                throw new Exception("Логин должен быть больше 5 символов!");
            }

            if (!Regex.IsMatch(phone, patPhone, RegexOptions.IgnoreCase))
            {
                throw new Exception("Неправильный телефон!");
            }

            if (!Regex.IsMatch(email, patEmail, RegexOptions.IgnoreCase))
            {
                throw new Exception("Неправильная почта!");
            }

            if (number.Length < 6 || number.Length > 6)
            {
                throw new Exception("6 цирф для номера паспорта!");
            }

            if (seria.Length < 4 || seria.Length > 4)
            {
                throw new Exception("4 цирфы для серии паспорта!");
            }

            if (!Regex.IsMatch(password, @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*?$", RegexOptions.IgnoreCase))
            {
                throw new Exception("Пример пароля: Gabou12!");
            }

            return true;
        }
    }
}
