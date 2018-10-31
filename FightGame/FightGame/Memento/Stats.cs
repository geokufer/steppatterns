using System;

namespace FightGame.Memento
{
    //basic class of unit states by the game
    public class Stats
    {
        public string Name { get;private set; }
        public double HP { get; private set; }
        public int STR { get; private set; }
        public int DEF { get; private set; }

        public Stats(Unit unit) => SetStats(unit);

        public void SetStats(Unit unit)
        {
            Name = unit.Name ?? throw new ArgumentNullException(nameof(unit));
            HP =   unit.HP;
            STR =  unit.STR;
            DEF =  unit.DEF;
        }

        public void GetStats(Unit unit)
        {
            unit.Name = Name;
            unit.HP = HP;
            unit.STR= STR;
            unit.DEF= DEF;
        }
    }
}
