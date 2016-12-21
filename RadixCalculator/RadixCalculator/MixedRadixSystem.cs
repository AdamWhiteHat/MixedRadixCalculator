/*
 *
 * Developed by Adam Rakaska
 *  http://csharpcodewhisperer.blogspot.com
 *    http://arakaska.wix.com/intelligentsoftware
 *
 *
 * Made using SharpDevelop
 *
 * 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Text;


namespace RadixCalculator
{
    public partial class MixedRadixSystem
    {
        #region Members

        public List<RadixNumeral> Digits { get; private set; }
        public List<long> RadixValue { get { return Digits.Select(d => d.Value).ToList(); } }
        public readonly List<long> BaseRadices;
        public bool LeftToRight { get; set; }

        public static string BaseStringSeparator = ":";
        public static string BaseStringSpacer = string.Format(" {0} ", BaseStringSeparator);

        public BigInteger DecimalValue
        {
            get
            {
                checked
                {
                    int counter = 0;
                    BigInteger result = 0;
                    foreach (RadixNumeral radix in Digits)
                    {
                        BigInteger placeValue = BigInteger.Pow(radix.Base, counter);                        
                        result += BigInteger.Multiply(placeValue, radix.Value);

                        counter++;
                    }
                    return result;
                }
            }            
        }

        #endregion

        #region Constructors

        public MixedRadixSystem(int Base, int Precision)
            : this(Enumerable.Repeat<long>(Base, Precision).ToList())
        { }

        public MixedRadixSystem(List<long> NumberSystemDefinition, bool LeftToRight = false)
            : this(ConvertListToRadixNumeralList(NumberSystemDefinition), LeftToRight)
        { }

        public MixedRadixSystem(int Base, int Precision, Dictionary<long, string> SymbolDictionary)
            : this(NumeralSystemDefinition: Enumerable.Repeat<long>(Base, Precision).ToList(), SymbolDictionary: SymbolDictionary, LeftToRight: false)
        { }

        public MixedRadixSystem(List<long> NumeralSystemDefinition, Dictionary<long, string> SymbolDictionary, bool LeftToRight = false)
            : this(ConvertListToRadixNumeralList(NumeralSystemDefinition, SymbolDictionary), LeftToRight)
        { }

        public MixedRadixSystem(List<RadixNumeral> NumberSystem, bool LeftToRight = false)
        {
            Digits = NumberSystem;

            if (Digits.Count > 0)
            {
                this.LeftToRight = LeftToRight;
                BaseRadices = Digits.Select(d => d.Base).ToList();
                Zero();
            }
        }

        public MixedRadixSystem(string NumberSystemString, bool LeftToRight)
        {
            if (string.IsNullOrWhiteSpace(NumberSystemString))
            {
                throw new ArgumentNullException("NumberSystemString", "Argument NumberSystemString cannot be null or empty.");
            }
            this.LeftToRight = LeftToRight;

            string selectedNumberSystem = NumberSystemString.Replace("Base ", "");
            if (selectedNumberSystem.Contains(BaseStringSeparator))
            {
                List<string> baseArray = new List<string>(selectedNumberSystem.Split(new string[] { BaseStringSeparator }, StringSplitOptions.RemoveEmptyEntries));
                List<long> baseDefinition = baseArray.Select(s => long.Parse(s)).ToList();
                BaseRadices = baseDefinition;
                Digits = ConvertListToRadixNumeralList(baseDefinition);
            }
            else
            {
                long baseNumber = 0;
                if (!long.TryParse(selectedNumberSystem, out baseNumber))
                {
                    throw new Exception(string.Format("Cannot parse base \"{0}\".", selectedNumberSystem));
                }

                int digits = 10;
                double logBase = Math.Log(long.MaxValue, baseNumber);
                if(logBase < 10)
                {
                    digits = (int)logBase;
                }

                Digits = ConvertListToRadixNumeralList(Enumerable.Repeat(baseNumber, digits).ToList());
            }
            
            if (Digits.Count < 1)
            {
                throw new Exception(string.Format("Failed to construct object; NumberSystemString should contain the numbering system's bases, separated by \"{0}\".", BaseStringSeparator));
            }

            BaseRadices = Digits.Select(d => d.Base).ToList();
            Zero();
        }

        private static List<RadixNumeral> ConvertListToRadixNumeralList(List<long> NumeralSystemDefinition)
        {
            return ConvertListToRadixNumeralList(NumeralSystemDefinition: NumeralSystemDefinition, SymbolDictionary: null);
        }

        private static List<RadixNumeral> ConvertListToRadixNumeralList(List<long> NumeralSystemDefinition, Dictionary<long, string> SymbolDictionary)
        {
            return ConvertListToRadixNumeralList(NumeralSystemDefinition, SymbolDictionary == null ? null : Enumerable.Repeat(SymbolDictionary, NumeralSystemDefinition.Count).ToList());
        }

        private static List<RadixNumeral> ConvertListToRadixNumeralList(List<long> NumeralSystemDefinition, List<Dictionary<long, string>> SymbolDictionaryList)
        {
            if (NumeralSystemDefinition == null)
            {
                throw new ArgumentNullException("NumberSystemDefinition");
            }
            if (NumeralSystemDefinition.Count < 1)
            {
                throw new ArgumentException("List cannot be empty.", "NumberSystemDefinition");
            }

            NumeralSystemDefinition.Add(-1);

            int index = 0;
            RadixNumeral rLast = RadixNumeral.Empty;
            List<RadixNumeral> result = new List<RadixNumeral>();
            foreach (long radixBase in NumeralSystemDefinition)
            {
                RadixNumeral radNew = RadixNumeral.Empty;

                if (radixBase != -1)
                {
                    if (SymbolDictionaryList == null)
                    {
                        radNew = new RadixNumeral(radixBase);
                    }
                    else
                    {
                        radNew = new RadixNumeral(radixBase, SymbolDictionaryList[index]);
                    }

                    if (rLast == RadixNumeral.Empty)
                    {
                        radNew.Previous = RadixNumeral.Empty;
                    }
                    else
                    {
                        rLast.Next = radNew;
                        radNew.Previous = rLast;

                        result.Add(rLast);
                    }

                    rLast = radNew;
                }
                else
                {
                    rLast.Next = RadixNumeral.Empty;
                    result.Add(rLast);
                    break;
                }

                index += 1;
            }

            if (result.Count > 0)
            {
                return result;
            }
            else
            {
                throw new Exception("result.Count < 1");
            }
        }

        #endregion

        public void Zero()
        {
            foreach (RadixNumeral digit in Digits)
            {
                digit.Zero();
            }
        }

        public void Increment()
        {
            Digits[0].Increment();
            //if (Digits[index].RadixValue >= BaseRadices[index] - 1) { if ((BaseRadices.Count() - 1) > (index + 1))
            //	{ throw new OverflowException("Current value exceeded what can be expressed with the current mixed radix number system."); }
            //	Digits[index++].Zero(); Increment(); } else { DecimalValue++; Digits[index].Increment(); index = 0; }
        }

        public void AddDecimalValue(long Value)
        {
            Digits[0].AddDecimalValue(Value);
            //while (Value-- > 0) { Increment(); }
        }

        public string GetTabularFormat()
        {
            int counter = 0;
            List<string> paddedArray = RadixValue.Select(b => b.ToString().PadLeft(BaseRadices[counter++].ToString().Length)).ToList();
            return formatArrayString(paddedArray, BaseStringSpacer);
        }

        public string GetNumeralFormat()
        {
            IEnumerable<string> digitCollection = Digits.Select(d => d.ToString());
            return formatArrayString(digitCollection, " ");
        }

        public override string ToString()
        {
            return GetNumeralFormat();
        }

        private string formatArrayString<T>(IEnumerable<T> array, string separator)
        {
            return string.Join<T>(separator, LeftToRight ? array : array.Reverse());
        }
    }
}
