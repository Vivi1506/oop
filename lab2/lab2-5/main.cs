using System;

namespace lab2_5
{
    class main
    {
        static void Main(string[] args)
        {
            User me = new User("28.01.2006");
            me.age = 22;
            me.login = "BorMax";
            me.firstName = "Max";
            me.secondName = "Nicheparenko";
            me.ShowAllInfo();

        }
    }
}
