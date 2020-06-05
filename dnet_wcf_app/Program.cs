using dnet_wcf_app.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnet_wcf_app 
{
    class Program 
    {
        static void Main(string[] args)
        {
            FaksServisClient klijent = new FaksServisClient();
            klijent.NoviStudent("marko", 1, 2);
            klijent.NoviStudent("karlo", 2, 3);
            klijent.NoviStudent("darko", 3, 1);
            
            var nova = klijent.ListaStudenata().ToList();

            foreach (Student k in nova)
            {
                Console.Write(k.Ime);
            }
            Console.Write("dgkhntgnh");


        }
    }
}
