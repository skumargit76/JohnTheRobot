using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnTheRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        //Implimentation of Humanoid class
        interface IHumanoid
        {
            string Skill { get; set; }
        }
        //Humanoid
        class Humanoid : IHumanoid
        {
            public string Skill { get; set; }         
            public Humanoid(IHumanoid Obj)
            {
                Skill = Obj.Skill;
            }
            public Humanoid()
            {
                Skill = "No skill is defined";
            }
            public string ShowSkill()
            {
                return Skill;
            }
        }
        //dancing
        class Dancing : IHumanoid
        {
            public string Skill { get; set; }
            public Dancing()
            {
                Skill = "Dancing";
            }
        }
        //cooking
        class Cooking : IHumanoid
        {
            public string Skill { get; set; }
            public Cooking()
            {
                Skill = "Cooking";
            }
        }

    }
}
