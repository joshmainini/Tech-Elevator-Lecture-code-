
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Farming
{
    public class Chicken : FarmAnimal
    {

        public override string MakeSoundOnce()
        {
            return "Cluck";
        }

<<<<<<< HEAD
		public override string MakeSoundTwice()
		{
			return "Cluck Cluck";
		}
=======
        public override string MakeSoundTwice()
        {
            return "Cluck Cluck";

        }
>>>>>>> f724b8d02cfe31d508dfb52fef1bf2b5b7eb5433

		public void LayEgg()
        {
            Console.WriteLine("Bakaw");
        }

    }
}
