using System;
using static FightGame.CreateUnit;

namespace FightGame
{
    public static class Bot
    {
        public static string Name { get; set; }
        public static Unit Unit { get; set; }
    }

    //help us to make a bot unit
    public class BotSelect
    {
        public Random rand = new Random();
        public int GetRandomNumber() => rand.Next(1, 4);


        public void SetBotWariorClass(string NameOfClass = null)
        {
            UnitMaternity unit;

            int choice = 0;
            if(NameOfClass != null)
            {
                switch (NameOfClass)
                {
                    case "Archer":
                        choice = 1;
                        break;
                    case "Halberdier":
                        choice = 2;
                        break;
                    case "Knight":
                        choice = 3;
                        break;
                    case "Mage":
                        choice = 4;
                        break;
                    default:
                        choice = 1;
                        break;
                }
            }
            else
                choice = GetRandomNumber();

            switch (choice)
            {
                case 1:
                    unit = new UnitMaternity(new UnitArcherBuilder());
                    break;
                case 2:
                    unit = new UnitMaternity(new UnitHalberdierBuilder());
                    break;
                case 3:
                    unit = new UnitMaternity(new UnitKnightBuilder());
                    break;
                case 4:
                    unit = new UnitMaternity(new UnitMageBuilder());
                    break;
                default:
                    unit = new UnitMaternity(new UnitKnightBuilder());
                    break;
            }
            unit.UnitCreate();
            Bot.Unit = unit.GetUnit();
            Bot.Name = Bot.Unit.Name;
        }
        
    }

}
