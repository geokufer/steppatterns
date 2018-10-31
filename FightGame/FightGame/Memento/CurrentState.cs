using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FightGame.Memento
{
    //this is "screenshot of game" states of units & log of game
    public class CurrentState
    {
        public Stats statsCareUnit1 { get; set; }
        public Stats statsCareUnit2 { get; set; }
        public StringBuilder logStatus { get; private set; }

        public CurrentState(Unit unit1, Unit unit2, StringBuilder log)
        {
            statsCareUnit1 = new Stats(unit1);
            statsCareUnit2 = new Stats(unit2);
            logStatus = new StringBuilder(log.ToString());
        }

        public void SaveStats(Unit unit1, Unit unit2, StringBuilder log)
        {
            statsCareUnit1.SetStats(unit1);
            statsCareUnit2.SetStats(unit2);
            logStatus = new StringBuilder(log.ToString());
        }

        public void GetStats(Unit unit1, Unit unit2, StringBuilder log)
        {
            statsCareUnit1.GetStats(unit1);
            statsCareUnit2.GetStats(unit2);
            log.AppendFormat(logStatus.ToString());
        }
    }
}
