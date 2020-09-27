using ClientFile;
using Bank_System;
using static System.Console;

namespace NewAccountFile{

    public class NewAccount {
        static string name , adress , password ;
        public static void fillData(){
            Write("\n\n\t\tData Form\n\n"+"* Enter your name : ");  name = ReadLine();
            Write("\n\n* Enter your adress : ");    adress = ReadLine();
            Write("\n\n* Enter the password : ");   password = ReadLine();
            createNewAccount();
        }

        static void createNewAccount() => Program.list.Add(new Client(name, adress, password, Program.list.Count));

    }


}