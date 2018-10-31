namespace FightGame
{
    public class CreateUnit
    {
        #region Create unit. Pattern: Builder
        abstract public class UnitBuilder
        {
            public Unit unit { get; set; }
            public void CreateUnit() => unit = new Unit();
            public Unit GetUnit() => unit;
            public abstract void SetUnitClass();
        }

        public class UnitMageBuilder : UnitBuilder
        {
            public UnitMageBuilder() => CreateUnit();
            public override void SetUnitClass()
            {
                unit.Name = "Mage";
                unit.HP = 80d;
                unit.STR = 35;
                unit.DEF = 5;
                unit.SetDEFcoefficient();
                unit.SetAttack();
                unit.attackFistFirst = new FireBall(unit.STR);
                unit.attackFistSecond = new WindStorm(unit.STR);
            }
            
        }

        public class UnitKnightBuilder : UnitBuilder
        {
            public UnitKnightBuilder() => CreateUnit();
            public override void SetUnitClass()
            {
                unit.Name = "Knight";
                unit.HP = 200d;
                unit.STR = 10;
                unit.DEF = 2;
                unit.SetDEFcoefficient();
                unit.SetAttack();
                unit.attackFistFirst = new SwordHit(unit.STR);
                unit.attackFistSecond = new ComboSword(unit.STR);
            }
        }

        public class UnitArcherBuilder : UnitBuilder
        {
            public UnitArcherBuilder() => CreateUnit();
            public override void SetUnitClass()
            {
                unit.Name = "Archer";
                unit.HP = 120d;
                unit.STR = 25;
                unit.DEF = 4;
                unit.SetDEFcoefficient();
                unit.SetAttack();
                unit.attackFistFirst = new EagleEye(unit.STR);
                unit.attackFistSecond = new BullsEye(unit.STR);
            }
        }

        public class UnitHalberdierBuilder : UnitBuilder
        {
            public UnitHalberdierBuilder() => CreateUnit();
            public override void SetUnitClass()
            {
                unit.Name = "Halberdier";
                unit.HP = 150d;
                unit.STR = 15;
                unit.DEF = 3;
                unit.SetDEFcoefficient();
                unit.SetAttack();
                unit.attackFistFirst = new RoundAttack(unit.STR);
                unit.attackFistSecond = new Lumberjack(unit.STR);
            }
        }

        public class UnitMaternity
        {
            private readonly UnitBuilder unit;
            public UnitMaternity(UnitBuilder unitBuilder)=>unit = unitBuilder;
            public void UnitCreate() => unit.SetUnitClass();
            public Unit GetUnit() => unit.GetUnit();
        }
        #endregion
                     
        #region Here we decorated basic function of attack Pattern: decorator

        /// <summary>
        /// Атака для мага
        /// </summary>
        public class FireBall : AttackFist
        {
            public FireBall(int _STR) : base(_STR) {
                name = "FireBall";
            }
            public override double Attack()
            {
                return base.Attack()+STR*0.4;
            }
        }

        public class WindStorm : AttackFist
        {
            public WindStorm(int _STR) : base(_STR)
            {
                name = "WindStrorm";
            }

            public override double Attack()
            {
                return base.Attack()+STR*0.6;
            }
        }
        /// <summary>
        /// Атака для рыцаря
        /// </summary>
        public class SwordHit : AttackFist
        {
            public SwordHit(int _STR) : base(_STR)
            {
                name = "SwordHit";
            }
            public override double Attack()
            {
                return base.Attack() + STR * 0.4;
            }
        }

        public class ComboSword : AttackFist
        {
            public ComboSword(int _STR) : base(_STR)
            {
                name = "ComboSword";
            }

            public override double Attack()
            {
                return base.Attack() + STR * 0.6;
            }
        }
        /// <summary>
        /// Атака для лучника
        /// </summary>
        public class EagleEye : AttackFist
        {
            public EagleEye(int _STR) : base(_STR)
            {
                name = "EagleEye";
            }

            public override double Attack()
            {
                return base.Attack() + STR * 0.4;
            }
        }

        public class BullsEye : AttackFist
        {
            public BullsEye(int _STR) : base(_STR)
            {
                name = "BullsEye";
            }

            public override double Attack()
            {
                return base.Attack() + STR * 0.6;
            }
        }
        /// <summary>
        /// Атака для алебардиста
        /// </summary>
        public class RoundAttack : AttackFist
        {
            public RoundAttack(int _STR) : base(_STR)
            {
                name = "RoundAttack";
            }
            public override double Attack()
            {
                return base.Attack() + STR * 0.4;
            }

        }
        public class Lumberjack : AttackFist
        {
            public Lumberjack(int _STR) : base(_STR)
            {
                name = "Lumberjack";
            }

            public override double Attack()
            {
                return base.Attack() + STR * 0.6;
            }
        }
        #endregion
    }
}
