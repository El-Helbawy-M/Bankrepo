using static System.Console;
using ClientFile;
using Bank_System;
namespace OperationsAccount{

    public class OA{
        public static void operationPanel(){
            bool check = true;int Id = 4;
            while(check){
                Write("\n\nID : "); Id = int.Parse(ReadLine()); 
                if(! Program.list.Contains(Program.list[Id])) continue;
                Write("Password : "); string password = ReadLine();
                check = (password != Program.list[Id].password) ?  true : false;
                WriteLine("wrong password !");
            }

            Write(""+
            "\n\n\t\tThe operations on the account\n\n" +
            "* for adding money enter (1).\n"+
            "\n* for withdraw money enter (2).\n"+
            "\n* for show balance enter (3).\n"+ 
            "\n===============================================================================\n"+
            "Chose the operation : "); int op = int.Parse(ReadLine());

            switch (op)
            {
                case 1: Write("enter the balance you want to add : "); int balance = int.Parse(ReadLine()); Program.list[Id] = balance + Program.list[Id]; break;
                case 2: Write("enter the balance you want to withdraw : "); int amount = int.Parse(ReadLine()); Program.list[Id] = Program.list[Id] - amount; break;
                case 3: Write("Your balance : " + Program.list[Id].balance); break;
                default:  break;
            }

            WriteLine("===============================================================================\n");
            
        }
    }
}