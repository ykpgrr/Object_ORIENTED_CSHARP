using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Yakup Görür 040130052
//Istanbul Technical University Electronic and Communication Engineering
//https://github.com/ykpgrr
//https://tr.linkedin.com/in/ykpgrr


namespace Final_Calismasi_midterm_tekrar_q2
{
    class Tip
    {
        public string Name;
        public string Surname;
        public string Telno;
        public Tip(string name, string surname, string telno)
        {
            Name = name;
            Surname = surname;
            Telno = telno;
        }
        internal string Serialize()
        {
            return string.Format("{0} {1} {2} ", Name, Surname, Telno);
        }
    }
}
