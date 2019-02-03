using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ETGItemCards
{
    public class ETGSettings
    {
        private const string filepath = "Mods/ETGItemCards.xml";

        private static ETGSettings instance;
        private static ETGSettings Instance
        {
            get
            {
                if(instance == null)
                    instance = LoadFromFile();
                return instance;
            }
        }

        private ETGSettings()
        {

        }

        private static ETGSettings LoadFromFile()
        {
            FileStream fs = null;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(ETGSettings));
                fs = File.Open(filepath, FileMode.Open);
                ETGSettings output = (ETGSettings)ser.Deserialize(fs);
                return output;
            }
            catch
            {
                return new ETGSettings();
            }
            finally
            {
                if(fs != null)
                    fs.Close();
            }
        }

        public static void Save()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(ETGSettings));
                FileStream fs = File.Create(filepath);
                ser.Serialize(fs, Instance);
                fs.Close();
            }
            catch
            {

            }
        }

        [XmlIgnore]
        private ItemCardFormat currentFormat;

        [XmlAttribute]
        public string format = ItemCardFormat.LITE;

        public static ItemCardFormat CurrentFormat
        {
            get
            {
                if(Instance.currentFormat == null)
                    Instance.currentFormat = new ItemCardFormat(Instance.format);
                return Instance.currentFormat;
            }
        }

        public static void SetCurrentFormat(ItemCardFormat format)
        {
            Instance.currentFormat = format;
            Instance.format = format.format;
            Save();
        }
    }
}