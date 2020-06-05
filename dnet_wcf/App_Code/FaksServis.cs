using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IFaksServis
{
    List<Student> lista = new List<Student>();
    public List<Student> ListaStudenata()
    {
        return lista;
    }

    public void NoviStudent(string ime, int oib, int god_stud)
    {
        Student s = new Student();
        s.Ime = ime;
        s.OIB = oib;
        s.GodinaStudiranja = god_stud;
        lista.Add(s);
        
    }
}
