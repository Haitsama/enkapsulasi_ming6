using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enkapsulasi
{
    internal class bank
    {
        //field
        private string nama;
        private string alamat;
        private int nomor_akun ;
        private double dompet;
        private int no_ref;

        public string Nama
        //properties
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public int NO_akun
        {
            get { return nomor_akun; }
            set { nomor_akun = value; }
        }

        public double Dompet
        {
            get { return dompet; }
            set { dompet = value; }
        }

        public int NO_REF
        {
            get { return no_ref; }
            set { no_ref = value; }
        }

        public void cetak()
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Alamat: " + alamat);
            Console.WriteLine("NO.Akun: " + nomor_akun);
            Console.WriteLine("Dompet: " + dompet);
        }

        public void cetak2()
        {
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Alamat: " + alamat);
            Console.WriteLine("NO.Akun: " + nomor_akun);
            Console.WriteLine("NO.ref: " + no_ref);
            Console.WriteLine("Dompet: " + dompet);
            
        }

        public void Deposit(double jumlah)
        {
            dompet += jumlah;
            Console.WriteLine("===================================================");
            Console.WriteLine("Deposit sebesar Rp." + jumlah + " telah berhasil !!");
            Console.WriteLine("===================================================");
        }

        public void Withdraw(double jumlah)
        {
            if (jumlah <= dompet)
            {
                dompet -= jumlah;
                Console.WriteLine("===================================================");
                Console.WriteLine("Withdraw sebesar Rp." + jumlah +" telah berhasil !!");
                Console.WriteLine("===================================================");
            }
            else
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("Saldo tidak cukup!");
                Console.WriteLine("===================================================");
            }
        }
        public void Transfer(double jumlah)
        {
            if (jumlah <= dompet)
            {
                dompet -= jumlah;
                Console.WriteLine("===================================================");
                Console.WriteLine("Transfer sebesar Rp." + jumlah + " telah berhasil !!");
                Console.WriteLine("===================================================");
            }
            else
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("Saldo tidak cukup!");
                Console.WriteLine("===================================================");
            }
        }



    }
}
