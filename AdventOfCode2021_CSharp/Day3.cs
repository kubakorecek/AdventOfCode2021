using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021_CSharp
{
    public class Day3 : ILoader
    {
        public struct SubmarineData
        {
            public double gammaRate;
            public double epsilonRate;
            public double consumption;
        }

        public struct LifeData
        {
            public double CO2;
            public double O2;
            public double support;
        }

        public string FileContent { get; }
        public List<string> Binaries { get; set; }

        private List<string> Temp { get; set; }

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
            long b;
            Binaries = FileContent.Split("\r\n").ToList();
            b = Convert.ToInt64(Binaries[0], 2);

            return true;
        }

        public SubmarineData Consumptions()
        {
            SubmarineData submarineData = new SubmarineData();
            int size = Binaries.First().Length;
            int[] counter = new int[size];
            Array.Fill(counter, 0);

            foreach (string str in Binaries)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1') { counter[i] += 1; }
                }

            }

            StringBuilder theMostCommonBits = new StringBuilder("", size);
            StringBuilder theLeastCommonBits = new StringBuilder("", size);
            for (int i = 0; i < counter.Length; i++)
            {

                if (counter[i] > Binaries.Count / 2)
                {
                    theMostCommonBits.Append('1');
                    theLeastCommonBits.Append('0');
                }
                else
                {
                    theMostCommonBits.Append('0');
                    theLeastCommonBits.Append('1');
                }
            }
            submarineData.epsilonRate = Day3.BinaryToDecimal(theLeastCommonBits.ToString());
            submarineData.gammaRate = Day3.BinaryToDecimal(theMostCommonBits.ToString());

            submarineData.consumption = submarineData.gammaRate * submarineData.epsilonRate;
            return submarineData;
        }

        private List<string> _SeparateLists(List<string> data,  int pos = 0, Type t = Type.CO2)
        {
            if(data.Count == 1) { return data; }

            if (data.Count == 2) 
            { 
                return (t == Type.CO2) ? data.Where(x => x[pos] == '0').ToList() : data.Where(x => x[pos] == '1').ToList();
            }

            if (pos > data.First().Length - 1)
            {
                throw new ArgumentException($"Parameter is too big" +
                    $" par:{pos} > size:{data.First().Length}", nameof(pos));
            }
            else if (pos < 0)
            {
                throw new ArgumentException($"Parameter is too small" +
                    $" par:{pos} size:{data.First().Length}", nameof(pos));
            }
            var ch1 = '1';
            var ch2 = '0';

            if (data.Where(x => x[pos] == ch2).Count() > data.Where(x => x[pos] == ch1).Count())
            {
                if (t == Type.CO2) 
                {
                    return data.Where(x => x[pos] == ch1).ToList();
                }else 
                {
                    return data.Where(x => x[pos] == ch2).ToList();
                }
                
            } else
            {
                if (t == Type.CO2)
                {
                    return data.Where(x => x[pos] == ch2).ToList();
                }
                else
                {
                    return data.Where(x => x[pos] == ch1).ToList();
                }
            }
            


        }

        public LifeData LifeSupport()
        {
            // First division 

            LifeData res = new LifeData();
            Temp = _SeparateLists(Binaries, 0, Type.CO2);


            // CO2
            int i = 1;
            while (i < Binaries.First().Length)
            {
                Temp = _SeparateLists(Temp, i, Type.CO2);
                if (Temp.Count() == 1)
                {
                    break;
                }
                i++;
            }

            res.CO2 = BinaryToDecimal(Temp.First());

            i = 1;
            Temp = _SeparateLists(Binaries, 0, Type.OXYGEN_RATING);
            while (i < Binaries.First().Length)
            {
                Temp = _SeparateLists(Temp, i, Type.OXYGEN_RATING);
                if (Temp.Count() == 1)
                {
                    break;
                }
                i++;
            }
            res.O2 = BinaryToDecimal(Temp.First());
            res.support = res.CO2 * res.O2;

            return res;
            //
        }

        public List<string> TheLeastCommon(List<string> data, int pos = -1)
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

        public static double BinaryToDecimal(string v)
        {
            var counter = 0;
            var length = v.Length;
            var decimalValue = 0.0;
            foreach (var c in v)
            {
                decimalValue += c == '1' ? Math.Pow(2, length - counter - 1) : 0;
                counter++;
            }
            return decimalValue;
        }
    }
}
