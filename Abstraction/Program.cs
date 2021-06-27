using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {


            TataCar _harrier = new TataCar(new VeriCoreEngine());
            _harrier.Drive();
            _harrier.Halt();
            TataCar _nexon = new TataCar(new MultiEngine());
            _nexon.Drive();
            _nexon.Halt();
            TataCar _hexa = new TataCar(new RevorTron());
            _hexa.Drive();
            _hexa.Halt();
        }
    }
    
}
