#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Subclassing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog butch = new Rottweiler("Butch") as Dog;
            Dog mac = new Spaniel("Mac", "yips") as Dog;

            butch.Bark();
            mac.Bark();
            butch.DoYourThing();
            mac.DoYourThing();

            Console.ReadLine();
        }
    }


    class Dog
    {
        protected string _name;
        protected string _sound;

        protected  Dog(string name)
        {
            _name = name;
            _sound = "barks";
        }
        protected Dog(string name, string sound)
        {
            _name = name;
            _sound = sound;
        }

        public void Bark()
        {
            Console.WriteLine("{0} {1} at you", _name, _sound);
        }

        public virtual void DoYourThing()
        {

        }

    }

    class Rottweiler : Dog
    {

        public Rottweiler(string name) : base(name) { }
        public Rottweiler(string name, string sound) : base(name, sound ) { }

        public override void DoYourThing()
        {
            Console.WriteLine("{0} snarls at you, in a very menacing fashion!", _name);
        }

    }

    class Spaniel : Dog
    {

        public Spaniel(string name) : base (name ) { }
        public Spaniel(string name, string sound) : base( name, sound ) { }

        public override void DoYourThing()
        {
            Console.WriteLine("{0} drools all over you, then licks you into submission!", _name);
        }

    }
}
