using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame.Memento
{
    //like in pattern Memento this class
    //in "Caretracker" role
    public class StatsCare 
    {
        //save our game states
        //in game, load from .xml stack of saves is empty
        private readonly Stack<CurrentState> Saves = new Stack<CurrentState>();

        public void Save(Unit unit1, Unit unit2, StringBuilder log) => Saves.Push(new CurrentState(unit1, unit2, log));

        public void Save(CurrentState currentState) => Saves.Push(currentState);

        public CurrentState Load() => Saves.Peek();

        public CurrentState Load(int back)
        {
            for (int i = 0; i < back; i++)
            {
                if(Saves.Count > 1)
                Saves.Pop();
            }
            return Saves.Peek();
        }

        public void ClearStack() => Saves.Clear();
    }
}
