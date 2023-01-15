using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class program5
    {
        //public static void Main(string[] args)
        //{


        //    Fighter f1 = new Fighter("Lew", 10, 2);
        //    Fighter f2 = new Fighter("Harry", 5, 4);

        //    static  string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        //    {
        //        string Res=string.Empty;
        //        string Attacker = fighter1.Name == firstAttacker ? fighter1.Name : fighter2.Name;
        //        while(fighter1.Health>0 || fighter2.Health>0)
        //        {
        //            if (Attacker == fighter2.Name)
        //            {
        //                fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
        //                if (fighter1.Health <= 0)
        //                {
        //                    Res = fighter2.Name;
        //                    break;
        //                }

        //            }
        //            else if (Attacker == fighter1.Name)
        //            {
        //                fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
        //                if(fighter2.Health<=0)
        //                {
        //                    Res = fighter1.Name;
        //                    break;
        //                }
        //            }
        //            Attacker=Attacker==fighter1.Name?fighter2.Name:fighter1.Name;
                    
        //        }


        //        return Res;
               
        //    }
        //   Console.WriteLine( declareWinner(f1, f2, "Lew"));

        //}
    }
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}
