using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static Modul8_103022300023.BankConfig;

namespace Modul8_103022300023
{
    public class BankConfig
    {
        public BankConfig() { }
        public string lang { get; set; }
        public List<string> methods { get; set; }
        public Transfer transfer { get; set; }
        public Confirmation confirmation { get; set; }
        public class Transfer { 

            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }
        public class Confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
        }


    }

     
}
