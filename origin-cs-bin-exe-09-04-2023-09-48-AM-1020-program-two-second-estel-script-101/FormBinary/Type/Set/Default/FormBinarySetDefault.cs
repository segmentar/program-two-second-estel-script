using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class FormBinary
    {
        public static IList<FormBinary> FormBinaryDefaultSet(String[] fileArray)
        {
            ICollection<FormBinary> collectionResult = default;

            collectionResult = new Collection<FormBinary>();

            foreach (String file in fileArray)
            {
                FormBinary formBinary;

                formBinary = MakeFormBinaryDefaultSurface(file);

                collectionResult.Add(formBinary);

                continue;
            }

            return new List<FormBinary>(collectionResult);
        }
    }
}
