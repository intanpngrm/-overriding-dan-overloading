using System;

namespace GameOverrideDemo
{
    public class PhysicalSkill : Skill
    {
        private float critRate;

        public PhysicalSkill()
        {
            critRate = 0.1f;
            Console.WriteLine("----> Konstruktor default PhysicalSKill<----");
        }

        public PhysicalSkill(float critRate, string name, float power, float cost)
            : base(name, power, cost)
        {
            Console.WriteLine("----> Konstruktor berparamenter PhysicalSkill<----");
            this.critRate = critRate;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[PhyiucalSkill.CalculateDamage] Mwnghitung damage fisik dengan critical hit...");
            float damage = basePower * (1 + critRate);
            return damage;
        }

        public float CalculateDamage(bool isBackstab)
        {
            Console.WriteLine($"[PhysicallSkill.CalculateDamage] Menghitung damage fisik dengan backstab: {isBackstab}");
            float damage = basePower * (1 + critRate);
            if (isBackstab)
                damage *= 1.5f;
            return damage;
        }

        public override void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("CRIT RATE    : " + (critRate * 100) + "%");
            Console.WriteLine("===========================");
        }
    }
}