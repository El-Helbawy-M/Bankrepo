using static System.Console;
using ClientFile;
using NewAccountFile;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        public static List<Client> list = new List<Client>();
        static void Main(string[] args)
        {
            for(int x = 0 ; x < 4 ; x ++){list.Add(new Client("Mohammed","Elmahala",(1000 + x * 2).ToString(),x));}
            Write("\t\tThe Operations\n"+
            "\n* for creating new account enter (1) .\n"+
            "\n* for operations on your account enter (2) .\n"+
            "\n* for making new VISA enter (3) .\n"+
            "\n* for Bank Loan enter (4) .\n" + "\n=================================================================================\n"+"Chose your operati: "
            );
            int op = int.Parse(ReadLine());
            switch (op)
            {
                case 1: NewAccount.fillData(); break;
                case 2:   break;
                case 3:   break;
                case 4:   break;
                default:   break; 
            }
        }
    }
}
