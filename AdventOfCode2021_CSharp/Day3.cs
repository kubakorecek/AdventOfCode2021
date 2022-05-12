using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day3 : ILoader
    {
        public string FileContent { get; }
        public List<string> Binaries { get; set; }
        public Day3(string fileContent)
        {
            FileContent = fileContent;
        }

        public Day3(List<string> binaries)
        {
            Binaries = binaries;
        }

        public bool Load()
        {
            Binaries = FileContent.Split('\n').ToList();
            return true;
        }

        public List<string> theLeastCommon(List<string> data, int pos = -1)
        {
            if (pos < 0) { throw new ArgumentException("Parameter cannot be <0", nameof(pos)); }

            List<string> Data0 = new List<string>();
            List<string> Data1 = new List<string>();

            foreach (string str in data)
            {
                ;
                if (str[pos].Equals('0'))
                {
                    Data0.Add(str);
                }
                else
                {
                    Data1.Add(str);
                }
               ;

            }
            if (Data0.Count > Data1.Count)
            {
                return Data0;
            }

            return Data1;
        }
    }
}
