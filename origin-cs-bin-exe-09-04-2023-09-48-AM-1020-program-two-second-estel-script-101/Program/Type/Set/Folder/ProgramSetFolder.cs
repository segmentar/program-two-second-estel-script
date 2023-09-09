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
        internal static IList<String> ProgramFolderSet(String directory)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String directoryItem in Directory.GetDirectories(directory))
            {
                collectionResult.Add(directoryItem);

                var list = new List<String>(ProgramFolderSet(directoryItem));

                foreach (var item_DIRECTORY in list)
                {
                    collectionResult.Add(item_DIRECTORY);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        } 
    }
}
