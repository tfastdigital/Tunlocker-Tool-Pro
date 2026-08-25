using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace motoulocked;

public sealed class SymbolEnc
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__1_002D0
	{
		public Random _0024VB_0024Local_random;

		public _Closure_0024__1_002D0(_Closure_0024__1_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_random = arg0._0024VB_0024Local_random;
			}
		}

		[SpecialName]
		internal int _Lambda_0024__0(int x)
		{
			return _0024VB_0024Local_random.Next();
		}
	}

	public static string EncryptText(string val)
	{
		_Closure_0024__1_002D0 arg = default(_Closure_0024__1_002D0);
		_Closure_0024__1_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__1_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_random = new Random();
		int[] source = Enumerable.Range(0, val.Length).ToArray();
		source = source.OrderBy([SpecialName] (int x) => CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next()).ToArray();
		checked
		{
			char[] array = new char[val.Length - 1 + 1];
			int num = val.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = val[source[i]];
			}
			string arg2 = new string(array);
			string arg3 = string.Join("O", source);
			return $"{arg2}_{arg3}";
		}
	}

	public static string UnshuffleText(string shuffledText, int[] originalPositions)
	{
		checked
		{
			char[] array = new char[shuffledText.Length - 1 + 1];
			int num = shuffledText.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[originalPositions[i]] = shuffledText[i];
			}
			return new string(array);
		}
	}
}
