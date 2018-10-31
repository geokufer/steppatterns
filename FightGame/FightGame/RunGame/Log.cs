using System;
using System.Text;

namespace FightGame.RunGame
{
    public class Log
    {
        public StringBuilder LogText = new StringBuilder();

        public string Time() => DateTime.Now.ToShortTimeString();

        public void logSaveAttack(string name, double punch) => LogText.AppendLine(Time() + " " + name + " hit: " + punch + " points.");

        public void logSaveBlock(string name) => LogText.AppendLine(Time() + " " + name + " make block.");

        public void logWin(string name) => LogText.AppendLine(Time() + " " + name + " WIN!!!.\nGAME OVER!!!");

        public void logDRAW() => LogText.AppendLine(Time() + " DRAW!!!.\nGAME OVER!!!");
    }
}
