using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class TataCar
    {
        
           Iengine engine;
           public TataCar(Iengine engine)
           {
            this.engine = engine;
           }
            public void Drive()
            {

                engine.Start();
            }
            public void Halt()
            {

                engine.Stop();
            }

    }
    
       
}

