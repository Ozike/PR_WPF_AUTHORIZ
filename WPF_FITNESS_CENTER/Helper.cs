using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_FITNESS_CENTER.Model;

namespace WPF_FITNESS_CENTER
{
    class Helper
    {
        private static Entities loginEntities;
        public static Entities GetContext()
        {
            if (loginEntities == null)
            {
                loginEntities = new Entities();
            }
            return loginEntities;
        }
        public string SearchUsers(string login, string password)
        {
            
            var users = loginEntities.Participant.Where(x => x.Login == login).FirstOrDefault();
            var users1 = loginEntities.Coach.Where(x => x.Login == login).FirstOrDefault();
            var users2 = loginEntities.Moderator.Where(x => x.Login == login).FirstOrDefault();
            var users3 = loginEntities.Organizator.Where(x => x.Login == login).FirstOrDefault();

            if (users == null && users1 == null && users2 == null && users3 == null)
            {
                return "Такого пользователя нет.";
            }
            else
            {
                if (users == null && users2 == null && users1 == null)
                {
                    if (users3.Password == password)
                    {
                        return "Вы авторизовались, как организатор";
                    }
                    else
                    {
                        return "Неправильно введён пароль.";
                    }
                }
                else if(users == null && users1 == null && users3 == null)
                {
                    if (users2.Password == password)
                    {
                        return "Вы авторизовались, как модератор";
                    }
                    else
                    {
                        return "Неправильно введён пароль.";
                    }
                }
                else if(users == null && users2 == null && users3 == null)
                {
                    if (users1.Password == password)
                    {
                        return "Вы авторизовались, как тренер";
                    }
                    else
                    {
                        return "Неправильно введён пароль.";
                    }
                }
                else if (users1 == null && users2 == null && users3 == null)
                {
                    if (users.Password == password)
                    {
                        return "Вы авторизовались, как участник";
                    }
                    else
                    {
                        return "Неправильно введён пароль.";
                    }
                }
                else
                {
                    return "Что-то пошло не так";
                }

            }
        }
    }
}
