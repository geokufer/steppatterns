using System;

namespace FightGame
{
    #region Basic class of unit
    public class Unit
    {
        public static readonly double DEFMax = 9d;

        public string Name { get; set; }
        public double HP { get; set; }
        public int STR { get; set; }
        public int DEF { get; set; }
        public double DEFcoefficient { get; set; }
        public AttackFist attackFistFirst;
        public AttackFist attackFistSecond;

        bool isAttack = true;

        public void SetDEFcoefficient()
        {
            DEFcoefficient = DEF * 0.1 * DEFMax;
            DEFcoefficient -= Math.Truncate(DEFcoefficient);
            DEFcoefficient = Math.Round(DEFcoefficient, 1);
        }

        public void SetAttack()
        {
            attackFistFirst = new AttackFist(STR);
            attackFistSecond = new AttackFist(STR);
        }

        public void Deffence() => isAttack = false;

        public double TakePunch(double punch)
        {
            double damage = 0d;
            double? DEFcoefficientSave = null;
            if (!isAttack && (DEFcoefficient * 10 < 9))
            {
                DEFcoefficientSave = DEFcoefficient;
                DEFcoefficient = 1 * 0.1;
            }
            damage = punch * DEFcoefficient;
            HP -= damage;
            HP = Math.Round(HP, 1);
            if (DEFcoefficientSave != null)
            {
                DEFcoefficient = (double)DEFcoefficientSave;
                isAttack = true;
            }
            return damage;
        }
    }

    /// <summary>
    /// Basic class for attack
    /// </summary>
    public class AttackFist
    {
        public string name = "Fist Attack!";
        public int STR { get; set; }
        public AttackFist(int _STR) => STR = _STR;
        public virtual double Attack() => STR * 0.1;
    }
    #endregion
}

