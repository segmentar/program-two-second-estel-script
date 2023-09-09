using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramFileSet(String[] directoryArray, String extension)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String directory in directoryArray)
            {
                var array = Directory.GetFiles(directory);

                foreach (String file in array)
                {
                    var period = Convert.ToChar(46);

                    var left = Path.GetExtension(file).Trim(period);

                    var right = extension.Trim(period);

                    Boolean didExtensionMatch;

                    didExtensionMatch = (left == right) is true;

                    if (didExtensionMatch is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    collectionResult.Add(file);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        } 
    }
}
