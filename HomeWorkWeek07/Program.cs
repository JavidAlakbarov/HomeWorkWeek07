using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkWeek07;


namespace HomeWorkWeek07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Task0701
            List<User> UserList = new List<User>();
            UserList.Add(new User("Javid", "Alakbarov", 25, "Azerbaijan"));
            UserList.Add(new User("Parviz", "Parvizyan", 26, "Greece"));
            UserList.Add(new User("Cristiano", "Ronaldo", 27, "Portugal"));
            UserList.Add(new User("Roberto", "Carlos", 7, "Brazil"));
            UserList.Add(new User("Pavel", "Pavluchenko", 19, "Russia"));
            UserList.Add(new User("Turan", "Arda", 28, "Turkey"));
            UserList.Add(new User("Hakan", "Shukur", 29, "Turkey"));
            UserList.Add(new User("Luis", "Nani", 9, "Vietnam"));
            UserList.Add(new User("Michael", "Owen", 17, "England"));
            UserList.Add(new User("Tony", "Kroose", 3, "Germany"));
            Console.WriteLine("Find all users that age is greater than 20 and print them as Name Surname Age Country :");
            List<User> list = UserList.Where(x => x.Age > 20).ToList();
            foreach (User user in list)
            {
                Console.WriteLine(user.Name + " " + user.Surname + " " + user.Age + " " + user.Country);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Remove all users that belongs to Turkey and Age is lower than 10 :");
            UserList.RemoveAll(x => x.Country == "Turkey");
            List<User> list1 = UserList.Where(x => x.Age > 10).ToList();
            foreach (User user in list1)
            {
                Console.WriteLine(user.Name + " " + user.Surname + " " + user.Age + " " + user.Country);
            }
            #endregion


            #region Task0702
            Console.WriteLine("---------------------------");
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
           
////Delegate MyDelegate tam eded parametri verilir ==> delegate cagiracag method automatik bu parametri idare edecek
////==> bu delegate boshlug evezine tam eded qaytarir. Method delegate vasitesi ile run edildikde kompilyator return parametrlerinide yoxlayir.
//// Method 3de yeni bir delegate type yaradirig bashqa method adi ile deyeri 10 ==> cagiralacag method her defe deyishir.
            #endregion
        }
    }
}
