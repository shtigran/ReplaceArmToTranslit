using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReplaceArmText;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "Բարև Հայեր ջան, 1000 բարի, ինչպես եք?";
      Console.WriteLine(str.ReplaceArmText());
      
      Console.ReadKey();

    }
  }
}
