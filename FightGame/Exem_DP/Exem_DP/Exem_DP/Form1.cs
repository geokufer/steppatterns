using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exem_DP {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            int rSize = richTextBox1.ClientSize.Height;
            for (int i = 15; i < rSize; i += 13) {
                richTextBox1.AppendText("\n");
            }
            
        }
        private bool Vis = true;
        Mage heroMage = new Mage();
        Shooter heroShooter = new Shooter();
        Warrior heroWarrior = new Warrior();
        //GameOriginator GO = new GameOriginator();

        private void ShowStatistic() {
            var ct = new Caretaker();
            richTextBox1.AppendText(Time() + ct.ShowStats() + "\n");
        }

        private string Time() {
            return DateTime.Now.ToShortTimeString();
        }

        private void buttonCreateHero_Click(object sender, EventArgs e) {
            buttonCreateHero.Visible = !Vis;
            labelNameHero.Visible = Vis;
            textBoxNameHero.Visible = Vis;
            labelClass.Visible = Vis;
            buttonClassMage.Visible = Vis;
            buttonClassShooter.Visible = Vis;
            buttonClassWarrior.Visible = Vis;
        }

        private void buttonClassMage_Click(object sender, EventArgs e) {
            if (textBoxNameHero.Text != "") {
                labelNameHero.Visible = !Vis;
                textBoxNameHero.Visible = !Vis;
                labelClass.Visible = !Vis;
                buttonClassMage.Visible = !Vis;
                buttonClassShooter.Visible = !Vis;
                buttonClassWarrior.Visible = !Vis;
                //GO.CreateHero('1');
                heroMage.SetName(textBoxNameHero.Text);
                richTextBox1.AppendText(Time() + heroMage.Say() + "\n");
                richTextBox1.ScrollToCaret();
                buttonFireball.Visible = Vis;
                buttonLighting.Visible = Vis;
            }
        }

        private void buttonClassShooter_Click(object sender, EventArgs e) {
            if (textBoxNameHero.Text != "") {
                labelNameHero.Visible = !Vis;
                textBoxNameHero.Visible = !Vis;
                labelClass.Visible = !Vis;
                buttonClassMage.Visible = !Vis;
                buttonClassShooter.Visible = !Vis;
                buttonClassWarrior.Visible = !Vis;
                //GO.CreateHero('2');
                heroShooter.Name = textBoxNameHero.Text;
                //richTextBox1.AppendText(Time() + heroShooter.Say() + "\n");
                richTextBox1.ScrollToCaret();
                buttonShotByAR.Visible = Vis;
            }
        }

        private void buttonClassWarrior_Click(object sender, EventArgs e) {
            if (textBoxNameHero.Text != "") {
                labelNameHero.Visible = !Vis;
                textBoxNameHero.Visible = !Vis;
                labelClass.Visible = !Vis;
                buttonClassMage.Visible = !Vis;
                buttonClassShooter.Visible = !Vis;
                buttonClassWarrior.Visible = !Vis;
                //GO.CreateHero('3');
                heroWarrior.Name = textBoxNameHero.Text;
                //richTextBox1.AppendText(Time() + heroWarrior.Say() + "\n");
                richTextBox1.ScrollToCaret();
                buttonHitSword.Visible = Vis;
            }
        }

        private void buttonFireball_Click(object sender, EventArgs e) {
            var fireball = new Fireball(heroMage);
            richTextBox1.AppendText(Time() + fireball.Say() + "\n");
            richTextBox1.ScrollToCaret();
            ShowStatistic();
        }

        private void buttonLighting_Click(object sender, EventArgs e) {
            var lighting = new Lighting(heroMage);
            richTextBox1.AppendText(Time() + lighting.Say() + "\n");
            richTextBox1.ScrollToCaret();
            ShowStatistic();
        }

        private void buttonShotByAR_Click(object sender, EventArgs e) {
            var AR = new AR(heroShooter);
            richTextBox1.AppendText(Time() + AR.Say() + "\n");
            richTextBox1.ScrollToCaret();
            ShowStatistic();
        }

        private void buttonHitSword_Click(object sender, EventArgs e) {
            var sword = new Sword(heroWarrior);
            richTextBox1.AppendText(Time() + sword.Say() + "\n");
            richTextBox1.ScrollToCaret();
            ShowStatistic();
        }
    }

    //  Save/Load

    class GameState {
        public double Health { get; }
        public int KilledMonsters { get; }

        public GameState(double health, int killedMonsters) {
            Health = health;
            KilledMonsters = killedMonsters;
        }

        public override string ToString() {
            return $" Health: {Health} Killed Monsters: {KilledMonsters}";
        }
    }

    class GameMemeto {
        private readonly GameState _gameState;

        public GameMemeto(GameState gameState) {
            _gameState = gameState;
        }

        public GameState getGameState() {
            return _gameState;
        }
    }

    class Caretaker {
        private readonly Stack<GameMemeto> _gameStates;
        private readonly GameOriginator _originator;
        private readonly char heroNumber = '1';
        public Caretaker() {
            _gameStates = new Stack<GameMemeto>();
            _originator = new GameOriginator(heroNumber);
        }

        public string ShowStats() {
            return _originator.Stats();
        }

        public void Save() {
            _gameStates.Push(_originator.Save());
        }

        public void Load() {
            _originator.Load(_gameStates.Peek());
        }
    }

    class GameOriginator {
        private GameState _gameState;


        public GameOriginator(char heroNumber) {
            switch (heroNumber) {
                case '1':
                    _gameState = new GameState(100, 0);
                    break;
                case '2':
                    _gameState = new GameState(150, 0);
                    break;
                case '3':
                    _gameState = new GameState(300, 0);
                    break;
            }
        }

        public string Stats() {
            return _gameState.ToString();
            //Random rng = new Random();
            //_gameState = new GameState(_gameState.Health * (rng.Next(0,10) / 10f), _gameState.KilledMonsters + 1);
        }

        public GameMemeto Save() {
            return new GameMemeto(_gameState);
        }

        public void Load(GameMemeto memeto) {
            _gameState = memeto.getGameState();
        }
    }


    //  Create Hero

    class Hero {
        public string Name { get; set; }
        public string Class { get; set; }
        public virtual string Say() {
            return $" Герой: {Name}, успішно створений.";
        }

    }

    abstract class HeroBuilder {
        protected Hero Hero { get; set; }

        public void CreateHero() {
            Hero = new Hero();
        }

        public Hero GetHero() {
            return Hero;
        }

        public abstract void SetValues();
    }

    class Mage: HeroBuilder{
        private string _name;

        public void SetName(string name ) {
            _name = name;
        }

        public Mage() {
            CreateHero();
        }

        public virtual string Say() {
            return $" Герой: {_name}, успішно створений.";
        }

        public override void SetValues() {
            Hero.Name = _name;
            Hero.Class = "Mage";
        }
    }

    class Shooter : Hero {
        public void setName(string name) {
            Name = name;
        }
    }

    class Warrior : Hero {
        public void setName(string name) {
            Name = name;
        }
    }

    class DecorateHero : Hero {
        protected Hero DecoratedHero { get; set; }

        public DecorateHero(Hero decoratedHero) {
            DecoratedHero = decoratedHero;
        }

        public override string Say() {
            return DecoratedHero.Say();
        }
    }

    class Fireball : DecorateHero {
        public Fireball(Mage decoratedHero) : base(decoratedHero) { }

        public override string Say() {
            return $" Лови фаєрболл!";
        }
    }

    class Lighting : DecorateHero {
        public Lighting(Mage decoratedHero) : base(decoratedHero) { }

        public override string Say() {
            return $" Як тобі молнія?";
        }
    }

    class AR : DecorateHero {
        public AR(Shooter decoratedHero) : base(decoratedHero) { }

        public override string Say() {
            return $" Один постріл - одне вбивство.";
        }
    }

    class Sword : DecorateHero {
        public Sword(Warrior decoratedHero) : base(decoratedHero) { }

        public override string Say() {
            return $" Просто удар мечем.";
        }
    }
}
