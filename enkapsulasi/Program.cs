using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace enkapsulasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bank bank = new bank();

            bank.Nama = "bank plecit";
            bank.Alamat = "sentalu sariharjo";
            bank.NO_akun = 34343432;
            bank.Dompet = 100000;
            Console.WriteLine("============================");
            bank.cetak();
            Console.WriteLine("============================");
            Console.ReadLine();
            bank.Transfer(50000);
            bank.NO_REF = 545347970;
            bank.cetak2();
            Console.ReadLine();
            bank.Deposit(50000);
            bank.cetak();
            Console.ReadLine();
            bank.Withdraw(50000);
            bank.cetak();
            Console.ReadLine();
            bank.Withdraw(150000);
            bank.cetak();
            Console.ReadLine();

        }
    }
}
