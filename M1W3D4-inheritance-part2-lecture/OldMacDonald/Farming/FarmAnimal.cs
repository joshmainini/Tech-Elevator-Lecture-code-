using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Farming
{
    public abstract class FarmAnimal : ISingable
    {
<<<<<<< HEAD
		public abstract string MakeSoundOnce(); //<-- mark this virtual so that subclasses override it

		public abstract string MakeSoundTwice(); //<-- the challenge though is what if subclasses dont override it
            
=======
        public abstract string MakeSoundOnce(); //<-- mark this virtual so that subclasses override it

        public abstract string MakeSoundTwice(); //<-- the challenge though is what if subclasses dont override it
      
>>>>>>> f724b8d02cfe31d508dfb52fef1bf2b5b7eb5433
    }
}
