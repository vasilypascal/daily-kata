using System;

namespace DailyKata
{
    public class HaystackNeedleKata
    {
        public static string FindNeedle(object[] haystack)
        {
            if (haystack == null)
                throw new ArgumentNullException(nameof(haystack));

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] is string)
                {
                    if (haystack[i] == "needle")
                        return ("found the needle at position " + i);
                }
            }
            return "needle not found";
        }
    }
}
