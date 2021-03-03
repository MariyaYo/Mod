using System.Collections.Generic;

namespace Test2
{
	internal class Utils
	{
        private static List<string> TRUE_VALUES = new List<string> { "true", "x", "1" };

        public static bool isValueTrue(string valueToCheck)
        {
            return valueToCheck != null && TRUE_VALUES.Contains(valueToCheck.ToLower());
        }
    }
}