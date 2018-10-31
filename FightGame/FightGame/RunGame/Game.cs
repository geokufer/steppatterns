using System;
using FightGame.Memento;
using FightGame.RunGame;
using static FightGame.CreateUnit;

namespace FightGame
{
    //Main game procces
    public class Game
    {
        public Log log = new Log();

        public Game() {
            if (Player.Unit != null && Bot.Unit !=null)
            SaveStats();
        }

        #region XML load/save

        XMLcontroller XMLcontroller = new XMLcontroller();

        public void SaveToXml(string fileName)
        {
            XMLcontroller.Save(statsGameCare.Load(), fileName);
        }

        public void LoadFromXML(string fileName)
        {
            statsGameCare.ClearStack();
            statsGameCare.Save(XMLcontroller.Load(fileName));
            CreatePlayer(statsGameCare.Load().statsCareUnit1.Name);//create player unit
            CreateBot(statsGameCare.Load().statsCareUnit2.Name);
            statsGameCare.Load().GetStats(Player.Unit, Bot.Unit, log.LogText);
        }

        //prepare unit's for game
        public void CreateBot(string name)
        {
            BotSelect botSelect = new BotSelect();
            botSelect.SetBotWariorClass();
        }

        public void CreatePlayer(string name)
        {
            Player.Name = name;
            UnitMaternity unit;

            switch (name)
            {
                case "Archer":
                    unit = new UnitMaternity(new UnitArcherBuilder());
                    break;
                case "Halberdier":
                    unit = new UnitMaternity(new UnitHalberdierBuilder());
                    break;
                case "Knight":
                    unit = new UnitMaternity(new UnitKnightBuilder());
                    break;
                case "Mage":
                    unit = new UnitMaternity(new UnitMageBuilder());
                    break;
                default:
                    unit = new UnitMaternity(new UnitMageBuilder());
                    break;
            }
            unit.UnitCreate();
            Player.Unit = unit.GetUnit();
        }
        #endregion

        #region state of game
        public StatsCare statsGameCare = new StatsCare();

        public void SaveStats()
        {
            statsGameCare.Save(Player.Unit, Bot.Unit, log.LogText);
        }

        public void GetBack(int step) {
            log.LogText.Clear();
            statsGameCare.Load(step).GetStats(Player.Unit, Bot.Unit, log.LogText);
        }
        #endregion

        #region BATTLE
        public delegate double SomeAttack();
        public static bool GameRunning = false;
        Random random = new Random();

        public void AttackUser(SomeAttack someAttack)
        {
            SaveStats();
            double punch = Bot.Unit.TakePunch(someAttack());
            log.logSaveAttack(Player.Name, punch);
        }

        public void DefenceUser()
        {
            SaveStats();
            Player.Unit.Deffence();
            log.logSaveBlock(Player.Name);
        }
        
        public void BotTurn()
        {
            double punch = 0d;
            switch (random.Next(1,4))
            {
                case 1:
                    punch = Player.Unit.TakePunch(Bot.Unit.attackFistFirst.Attack());
                    log.logSaveAttack(Bot.Name,punch);
                    break;
                case 2:
                    punch = Player.Unit.TakePunch(Bot.Unit.attackFistSecond.Attack());
                    log.logSaveAttack(Bot.Name, punch);
                    break;
                case 3:
                    Bot.Unit.Deffence();
                    log.logSaveBlock(Bot.Name);
                    break;
            }
        }

        public bool isGameOver()
        {

            if (Bot.Unit.HP <= 0 && Player.Unit.HP <= 0)
            {
                log.logDRAW();
                Bot.Unit.HP = Player.Unit.HP = 0;
                return true;
            }
            else if(Player.Unit.HP <= 0)
            {
                Player.Unit.HP = 0;
                log.logWin(Bot.Name);
                return true;
            } 
            else if (Bot.Unit.HP <= 0)
            {
               Bot.Unit.HP = 0;
                log.logWin(Player.Name);
               return true;
            }
            else
                return false;
        }
        #endregion
    }
}