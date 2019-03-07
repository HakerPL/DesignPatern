using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPaterns._SOLID.Single_Responsibility
{
    public class JournalWrong
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

        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }

        public static JournalWrong Load(string fileName)
        {
            string loadText = File.ReadAllText(fileName);

            JournalWrong jj = new JournalWrong();

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
