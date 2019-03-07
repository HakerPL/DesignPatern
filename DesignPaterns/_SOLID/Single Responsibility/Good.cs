using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPaterns._SOLID.Single_Responsibility
{
    /*
     * Single Responsibility
     * Class should only have one reson to change
     * (Separation of concerns)
     * class is responsible for one thing and has one reason to change.
     */

    public class JournalGood
    {
        private readonly List<string> _entries = new List<string>();

        private static int _counter = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_counter}: {text}");
            return _counter;
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }
    }

    public class PersistanceSave
    {
        public void SaveToFile(JournalGood jj, string fileName, bool overWrite = false)
        {
            if(overWrite || !File.Exists(fileName))
                File.WriteAllText(fileName, jj.ToString());
        }
    }

    public class PersistanceLoad
    {
        public JournalGood Load(string fileName)
        {
            string loadText = File.ReadAllText(fileName);

            JournalGood jj = new JournalGood();

            foreach (string text in loadText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None))
            {
                jj.AddEntry(text);
            }

            return jj;
        }
    }
}
