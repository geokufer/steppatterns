using System;
using System.Text;
using System.Xml;

namespace FightGame.Memento
{
    //here we save(load) our game stats into .xml file
    public class XMLcontroller
    {
        #region Save into .xml file basic game stats
        public void Save(CurrentState currentState,string fileName)
        {
            XmlTextWriter writer = null;
            writer = new XmlTextWriter(fileName, Encoding.Unicode);
            writer.WriteStartDocument();
            writer.WriteStartElement("GameStats");
            WriteObjectsData(writer, currentState);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private static void WriteObjectsData(XmlTextWriter writer,CurrentState currentState)
        {
            writer.WriteStartElement("Unit1");
            writer.WriteAttributeString("Name", currentState.statsCareUnit1.Name);
            writer.WriteAttributeString("HP",   currentState.statsCareUnit1.HP.ToString());
            writer.WriteAttributeString("STR",  currentState.statsCareUnit1.STR.ToString());
            writer.WriteAttributeString("DEF",  currentState.statsCareUnit1.DEF.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Unit2");
            writer.WriteAttributeString("Name", currentState.statsCareUnit2.Name);
            writer.WriteAttributeString("HP", currentState.statsCareUnit2.HP.ToString());
            writer.WriteAttributeString("STR", currentState.statsCareUnit2.STR.ToString());
            writer.WriteAttributeString("DEF", currentState.statsCareUnit2.DEF.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("log");
            writer.WriteAttributeString("Log", currentState.logStatus.ToString());
        }
        #endregion

        #region Load from .xml file basic game stats
        public CurrentState Load(string fileName)
        {
            CurrentState currentState;
            Unit unit1 = new Unit();
            Unit unit2 = new Unit();
            StringBuilder stringbuilder = new StringBuilder();
            XmlTextReader reader = new XmlTextReader(fileName);
            try
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Unit1")
                        {
                            unit1.Name = reader.GetAttribute("Name");
                            unit1.HP = Convert.ToDouble(reader.GetAttribute("HP"));
                            unit1.STR = Convert.ToInt32(reader.GetAttribute("STR"));
                            unit1.DEF = Convert.ToInt32(reader.GetAttribute("DEF"));
                        }
                        if (reader.Name == "Unit2")
                        {
                            unit2.Name = reader.GetAttribute("Name");
                            unit2.HP = Convert.ToDouble(reader.GetAttribute("HP"));
                            unit2.STR = Convert.ToInt32(reader.GetAttribute("STR"));
                            unit2.DEF = Convert.ToInt32(reader.GetAttribute("DEF"));
                        }
                        if (reader.Name == "log")
                        {
                            stringbuilder.AppendFormat(reader.GetAttribute("Log"));
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }

            
            return currentState = new CurrentState(unit1,unit2, stringbuilder);
        }
        #endregion
    }
}
