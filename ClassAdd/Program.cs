using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UserInfo
    {
        public string Name, Family, Adress;
        public byte Age;

        public void writeInConsoleInfo(string name, string family, string adress, byte age)
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nМестонахождение: {2}\nВозраст: {3}\n", name, family, adress, age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInfo myInfo = new UserInfo();

            myInfo.Name = "Pupa";
            myInfo.Family = "Za";
            myInfo.Adress = "SPB";
            myInfo.Age = 2;

            UserInfo myGirlFriendInfo = new UserInfo();

            myGirlFriendInfo.Name = "Lupa";
            myGirlFriendInfo.Family = "Za";
            myGirlFriendInfo.Adress = "SPB";
            myGirlFriendInfo.Age = 3;

            myInfo.writeInConsoleInfo(myInfo.Name, myInfo.Family, myInfo.Adress, myInfo.Age);
            myGirlFriendInfo.writeInConsoleInfo(myGirlFriendInfo.Name, myGirlFriendInfo.Family, myGirlFriendInfo.Adress, myGirlFriendInfo.Age);

            Console.ReadLine();
        }
    }

}
