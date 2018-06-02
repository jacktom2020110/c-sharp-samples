using System;

namespace SingleClass
{
    class User
    {
        // 1.私有化构造方式，目的：防止用户通过new来多次实例化对象
        private User() { }

        // 2. 提供一个私有的静态的当前类对象
        private static User _instance = new User();

        // 3. 提供一个public 权限的方法，返回一个当前类的对象
        public static User CurrentUser()
        {
            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User u1 = User.CurrentUser();
            User u2 = User.CurrentUser();

            Console.WriteLine(u1 == u2);

            Console.ReadLine();
        }
    }
}
