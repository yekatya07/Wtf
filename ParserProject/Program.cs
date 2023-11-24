using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using DBLiv;

namespace ParserProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();
            db.Add(1, "message", "name");
        }
    }
}
