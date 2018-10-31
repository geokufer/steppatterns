using System;
using System.Windows.Forms;
using static FightGame.CreateUnit;

namespace FightGame
{
    public partial class NewCharacter : Form
    {
        public delegate void FightStart();
        FightStart fightStart = null;

        public NewCharacter()
        {
            InitializeComponent();
            maskedTextBox_nameCharacter.SelectionStart = 0;
        }

        public void InitializeStartBattle(FightStart _fightStart)=> fightStart = _fightStart;
        
        private void ClearForm()
        {
            maskedTextBox_nameCharacter.Clear();
            this.Hide();
        }

        public void CreateOponents()
        {
            Player.Name = maskedTextBox_nameCharacter.Text;
            UnitMaternity unit;

            #region cast bot char
            if (radioButton_archer.Checked)
            {
                unit = new UnitMaternity(new UnitArcherBuilder());
                radioButton_archer.Checked = false;
            }
            else if (radioButton_halberdier.Checked)
            {
                unit = new UnitMaternity(new UnitHalberdierBuilder());
                radioButton_halberdier.Checked = false;
            }
            else if (radioButton_knight.Checked)
            {
                unit = new UnitMaternity(new UnitKnightBuilder());
                radioButton_knight.Checked = false;
            }
            else
            {
                unit = new UnitMaternity(new UnitMageBuilder());
                radioButton_mage.Checked = false;
            }
            #endregion

            unit.UnitCreate();
            Player.Unit = unit.GetUnit();

            BotSelect botSelect = new BotSelect();
            botSelect.SetBotWariorClass();
        }

        private void button_newCharOK_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_nameCharacter.Text.Length == 0) {
                ClearForm();
                return;
            }
            CreateOponents();
            fightStart?.Invoke();
            ClearForm();
        }
    }
}