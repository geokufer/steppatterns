using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace FightGame
{
    public partial class BattleField : Form
    {
        NewCharacter unit = new NewCharacter(); //form for create char
        Game game = null;
        
        public BattleField()
        {
            InitializeComponent();
            label_nameChanged.Text = Player.Name ?? "Player";
            label2.Text = Bot.Name ?? "Bot";
            unit.InitializeStartBattle(fightStart);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           unit.ShowDialog();
        }

        private void RefreshScoreBoard()
        {
            //Player stats
            label_healthChanged.Text = Player.Unit.HP.ToString();
            label5_playerDEF.Text = Player.Unit.DEF.ToString();
            label5_playerSTR.Text = Player.Unit.STR.ToString();
            //Bot stats
            label1.Text = Bot.Unit.HP.ToString();
            label5_botDEF.Text = Bot.Unit.DEF.ToString();
            label5_botSTR.Text = Bot.Unit.STR.ToString();
            //log
            richTextBox1.Text = game.log.LogText.ToString();
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        public void SetButtonImages()
        {
            var collection = imageList_main.Images;
            switch (Player.Unit.Name)
            {
                case "Archer":
                    button_hit1.ImageList = imageList_Archer;
                    button_hit2.ImageList = imageList_Archer;
                    panel2.BackgroundImage = collection[0];
                    panel2.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "Halberdier":
                    button_hit1.ImageList = imageList_Halb;
                    button_hit2.ImageList = imageList_Halb;
                    panel2.BackgroundImage = collection[1];
                    panel2.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "Knight":
                    button_hit1.ImageList = imageList_Knight;
                    button_hit2.ImageList = imageList_Knight;
                    panel2.BackgroundImage = collection[2];
                    panel2.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "Mage":
                    button_hit1.ImageList = imageList_Mage;
                    button_hit2.ImageList = imageList_Mage;
                    panel2.BackgroundImage = collection[3];
                    panel2.BackgroundImageLayout = ImageLayout.Center;
                    break;
            }
            button_hit1.ImageIndex = 0;
            button_hit2.ImageIndex = 1;
        }

        private void button_hit1_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning && game != null)
            {
                game.AttackUser(Player.Unit.attackFistFirst.Attack);
                game.BotTurn();
                Game.GameRunning = !game.isGameOver();
                RefreshScoreBoard();
                if (game.isGameOver())
                    game = null;
            }
        }

        private void button_hit2_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning && game != null)
            {
                game.AttackUser(Player.Unit.attackFistSecond.Attack);
                game.BotTurn();
                Game.GameRunning = !game.isGameOver();
                RefreshScoreBoard();
                if (game.isGameOver())
                    game = null;
            }
        }

        private void button_block_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning && game!=null)
            {
                game.DefenceUser();
                game.BotTurn();
                Game.GameRunning = !game.isGameOver();
                RefreshScoreBoard();
                if (game.isGameOver())
                    game = null;
            }
        }

        public void fightStart()
        {

                Game.GameRunning = true;
                label_nameChanged.Text = Player.Name ?? "Player";
                label2.Text = Bot.Name ?? "Bot";
                button_hit1.Text = "      " + Player.Unit.attackFistFirst.name;
                button_hit2.Text = "      " + Player.Unit.attackFistSecond.name;
                game = new Game();
                RefreshScoreBoard();
                SetButtonImages();
          
        }
         
        //back for 1 step
        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning)
            {
                game.GetBack(1);
                RefreshScoreBoard();
            }
        }
        //back for 2 step
        private void stepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning)
            {
                game.GetBack(2);
                RefreshScoreBoard();
            }
        }
        //back for 3 step
        private void stepsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning)
            {
                game.GetBack(3);
                RefreshScoreBoard();
            }
        }
        //back for 4 step
        private void stepsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Game.GameRunning)
            {
                game.GetBack(4);
                RefreshScoreBoard();
            }
        }

        //Save to file
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) { 
                string path = saveFileDialog1.FileName;
                game.SaveToXml(path);
                MessageBox.Show("File saved","Save",MessageBoxButtons.OK);
            }
        }
        //Load from file
        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                game = new Game();
                game.LoadFromXML(path);
                Game.GameRunning = true;
                label_nameChanged.Text = Player.Name ?? "Player";
                label2.Text = Bot.Name ?? "Bot";
                button_hit1.Text = Player.Unit.attackFistFirst.name;
                button_hit2.Text = Player.Unit.attackFistSecond.name;
                MessageBox.Show("File loaded. Enjoy =)","Load",MessageBoxButtons.OK);
                RefreshScoreBoard();
                SetButtonImages();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fight game ver. 0.9\n" +
                            " IT Academy \"STEP\"\n" +
                            " student:George B.\n" +
                            "      10.2018 ",
                "About", MessageBoxButtons.OK);
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Play with 3 buttons after create\n" +
                "  new game or load old play",
                "Instruction", MessageBoxButtons.OK);
        }
    }
}
