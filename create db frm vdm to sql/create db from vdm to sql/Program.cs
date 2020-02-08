using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Suriya sasi = new Suriya();
            var res = sasi.Employees;
            foreach (var a in res) 
            {

            }

        }
    }
}
