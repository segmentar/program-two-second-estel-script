using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] SafeArray(Object[] objectArray)
        {
            String[] arrayResult = default;

            var length = objectArray.Length;

            String[] stringArray;

            stringArray = new String[length];

            var indexer = 0;

            do
            {
                Boolean shouldStop;

                shouldStop = (indexer == length) is true;

                if (shouldStop is true)
                {
                    break;
                }
                else
                    "false".ToString();

                String stringItem;

                stringItem = objectArray[indexer].ToString();

                var reflect = SafeString(stringItem);

                stringArray[indexer] = reflect;

                indexer = indexer + 1;

                continue;

            } while (true);

            arrayResult = stringArray;

            return arrayResult;
        }

    }
}
