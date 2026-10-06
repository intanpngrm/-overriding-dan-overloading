using System;

namespace GameOverrideDemo
{
    public class MagicSkill : Skill
    {
        private string? elemenType;

        public MagicSkill()
        {
            elemenType = "Normal";
            Console.WriteLine("----> Konstruktor default MgicSkill <----");
        }

        public MagicSkill(string elemenType, string name, float power, float cost)
            : base(name, power,cost)
        {
            Console.WriteLine("----> Konstruktor berparamenter MagicSkill <----");
            this.elemenType = elemenType;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[MagicSkill.CalculateDamage]Menghitung damage sihir dengan elemen...");

            float damage = basePower;
            if(elemenType == "Fire")
            {
                damage *= 1.5f;
                Console.WriteLine("[MagicSkill] Bonus elemen Fire! Damage x1.5");
            }
            return damage;
        }

        public  override void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("ELEMEN TYPE : " + elemenType);
            Console.WriteLine("======================");
        }
    }
}