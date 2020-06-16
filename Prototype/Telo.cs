using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    
    class Telo
    {
        int dlina;
        string name;

        public Telo(int dln, string nm)
        {
            dlina = dln;
            name = nm;
        }

        public int DLINA
        {
            get { return dlina; }
            set { dlina= value;}
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
    }

    // "System"

    abstract class System
    {
        private Telo SSS;

        // Constructor
        public System( Telo ddd)
        {
            SSS = ddd;
        }

        // Property
        public Telo SsS
        {
            get { return SSS; }
            set { SSS = value; }
        }

        public abstract System Clone();
    }

    // "ConcretePrototype1"

    class ConcretePrototype1 : System
    {
        // Constructor
        public ConcretePrototype1(Telo ddd)
            : base(ddd)
        {
        }

        public override System Clone()
        {
            // Shallow copy
            return (System)this.MemberwiseClone();
        }
    }

    // "ConcretePrototype2"

    class ConcretePrototype2 : System
    {
        // Constructor
        public ConcretePrototype2(Telo ddd)
            : base(ddd)
        {
        }

        public override System Clone()
        {
            // Deep copy
           
            return new ConcretePrototype2( new Telo(SsS.DLINA, SsS.NAME));
        }
    }
}
