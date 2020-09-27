using static System.Console;
using System.Collections.Generic;
namespace ClientFile {

    
    public class Client {

        private string _name, _adress, _password;
        private int _Id, _balance = 5000;

        public int balance { get => _balance; set => _balance = balance; }
        public string password{get => _password; set => _password = password;}
        public Client (string name, string adress, string password, int Id) {
            this._name = name;
            this._Id = Id;
            this._adress = adress;
            this._password = password;
            WriteLine ("Your Id : " + Id);
        }


        void ShowBalanca () => WriteLine ("The Balanca : " + _balance);
        public static Client operator + (int amount, Client c) { c._balance += amount; return c; }
        public static Client operator - ( Client c , int amount) { c._balance -= amount; return c; }

    }

    
}