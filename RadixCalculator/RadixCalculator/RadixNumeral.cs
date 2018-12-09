using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace RadixCalculator
{
	public partial class MixedRadixSystem
	{
		public class RadixNumeral
		{
			#region Members

			public BigInteger Base { get; private set; }
			public BigInteger Value { get; private set; }
			public BigInteger Exponent { get; private set; }
			private Dictionary<BigInteger, string> SymbolDictionary { get; set; }
			public string SymbolicValue { get { return (SymbolDictionary.Count == 0) ? Value.ToString() : SymbolDictionary[Value]; } }

			public RadixNumeral Next
			{
				get
				{
					if (_moreSignifigantNumeral == null) { return RadixNumeral.Empty; }
					else { return _moreSignifigantNumeral; }
				}
				set
				{
					if (_moreSignifigantNumeral == null) { _moreSignifigantNumeral = value == null ? RadixNumeral.Empty : value; }
					else { throw new FieldAccessException("Value may only be set once."); }
				}
			}
			private RadixNumeral _moreSignifigantNumeral = null;

			public RadixNumeral Previous
			{
				get
				{
					if (_lessSignifigantNumeral == null) { return RadixNumeral.Empty; }
					else { return _lessSignifigantNumeral; }
				}
				set
				{
					if (_lessSignifigantNumeral == null) { _lessSignifigantNumeral = value == null ? RadixNumeral.Empty : value; }
					else { throw new FieldAccessException("Value may only be set once."); }
				}
			}
			private RadixNumeral _lessSignifigantNumeral = null;

			#endregion // Members
			
			#region Constructors

			public static readonly RadixNumeral Empty = new RadixNumeral(-1, -1);

			public RadixNumeral(BigInteger RadixBase, BigInteger PlaceValue)
			{
				SymbolDictionary = new Dictionary<BigInteger, string>();
				this.Exponent = PlaceValue;
				this.Base = RadixBase;
			}

			public RadixNumeral(BigInteger RadixBase, BigInteger PlaceValue, Dictionary<BigInteger, string> symbolDictionary)
				: this(RadixBase, PlaceValue)
			{
				this.SymbolDictionary = symbolDictionary;
			}

			#endregion // Constructors
			
			#region Methods

			public void Zero()
			{
				Value = 0;
			}

			public void Increment()
			{
				if (this.Base != -1)
				{
					Increment(1);
				}
			}

			public static Dictionary<BigInteger, string> GenerateSymbolDictionary(BigInteger RadixBase)
			{
				BigInteger counter = 0;
				Dictionary<BigInteger, string> result = new Dictionary<BigInteger, string>();
				while (counter < RadixBase)
				{
					result.Add(counter, counter.ToString());
					counter++;
				}
				return result;
			}

			public void Increment(BigInteger DecimalValue)
			{
				if (DecimalValue < 0)
				{
					throw new ArgumentOutOfRangeException("DecimalValue", "Value must be a positive number.");
				}
				else if (DecimalValue == 0)
				{
					return;
				}
				else
				{
					BigInteger newValue = (Value + DecimalValue);
					if (newValue >= this.Base)
					{
						if (Next == RadixNumeral.Empty)
						{
							//Digits.Add(new RadixNumeral(this.Base));
							//throw new OverflowException("The value has exceeded what can be expressed with number system. The AddValue procedure may have been partially completed and therefore the state may be corrupt (The Value may not correctly reflect the result of the previous operation). It is recommended that the application be restarted.");
							Value = newValue;
							return;
						}

						BigInteger remainder = new BigInteger();

						BigInteger quotient = BigInteger.DivRem(newValue, Base, out remainder);

						Value = remainder;
						Next.Increment(quotient);
					}
					else if (newValue < this.Base)
					{
						Value = newValue;
					}
				}
			}

			#endregion // Methods
			
			#region Comparison Operators

			public static bool operator <(RadixNumeral a, RadixNumeral b)
			{
				if (a.Base != b.Base) { throw new ArithmeticException("The RadixNumeral on both sides of the comparison operator must have the same Base."); }
				return a.Value < b.Value;
			}

			public static bool operator >(RadixNumeral a, RadixNumeral b)
			{
				if (a.Base != b.Base) { throw new ArithmeticException("The RadixNumeral on both sides of the comparison operator must have the same Base."); }
				return a.Value > b.Value;
			}

			public static bool operator ==(RadixNumeral a, RadixNumeral b)
			{

				if (RadixNumeral.ReferenceEquals(a, null))
				{
					return RadixNumeral.ReferenceEquals(b, null);
				}

				return a.Equals(b);
			}

			public static bool operator !=(RadixNumeral a, RadixNumeral b)
			{
				return !(a == b);
			}

			#endregion // Comparison Operators
			
			#region Overrides

			public override string ToString()
			{
				return string.Format("{0}[{1}]", Value.ToString().PadLeft(Base.ToString().Length), this.Base);
			}

			public override bool Equals(object obj)
			{
				if (obj == null)
				{
					return false;
				}
				else if (object.ReferenceEquals(this, obj))
				{
					return true;
				}
				else if (obj is RadixNumeral)
				{
					RadixNumeral radNum = (RadixNumeral)obj;
					return (
								this.Base == radNum.Base
								&&
								this.Value == radNum.Base
								&&
								RadixNumeral.GetHashString(this) == RadixNumeral.GetHashString(radNum)
							);
				}
				else
				{
					return false;
				}
			}

			private static string GetHashString(RadixNumeral radNum)
			{
				//int counter = 0;
				//string symbolString = "{EMPTY}";
				//if (radNum.SymbolDictionary.Count > 0)
				//{
				//	symbolString = string.Join(",", radNum.SymbolDictionary.Values.Select(v => string.Format("{0}:{1}", counter++, v)));
				//}
				string result = string.Format("{0}[{1}]:{2}", radNum.Value, radNum.Base, radNum.SymbolicValue);//, symbolString, radNum.SymbolDictionary.Count);
				return result;
			}

			public override int GetHashCode()
			{
				unchecked
				{
					BigInteger hash = this.Value ^ this.Base ^ RadixNumeral.GetHashString(this).GetHashCode();
					if (hash > int.MaxValue)
					{
						hash = hash % int.MaxValue;
					}
					return (int)hash;
				}
			}

			#endregion // Overrides
		}
	}
}
