using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class FormBinary
    {
        public static IList<Tuple<String, Int32, String, String, Object>> FormBinaryGlobalLineTupleSet(FormBinary formBinary)
        {
            ICollection<Tuple<String, Int32, String, String, Object>> collectionResult = default;

            collectionResult = new Collection<Tuple<String, Int32, String, String, Object>>();

            String[] stringArray;

            stringArray = ForgeGlobalLineTuple(formBinary.Data).Item2;

            foreach (String stringItem in stringArray)
            {
                var split = stringItem.Split();

                Boolean hasLength;

                hasLength = (split.Length == 6) is true;

                if (hasLength is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var second = split[1];

                var third = split[2];

                var fourth = split[3];

                var fifth = split[4];

                var sixth = split[5];

                String component;

                var dash = Convert.ToChar(45);

                var split_ORDINAL = third.Split(new String[] { dash.ToString() }, StringSplitOptions.None);

                var last = split_ORDINAL[split_ORDINAL.Length - 1];

                Int32 integer;

                integer = Int32.Parse(last);

                Int32 ordinal;

                String type, name;

                Object value;

                ordinal = integer;

                component = second;

                type = fourth;

                var colon = Convert.ToChar(58);

                var format = fifth.TrimEnd(colon);

                name = format;

                value = sixth;

                Tuple<String, Int32, String, String, Object> tuple;

                tuple = new Tuple<String, Int32, String, String, Object>(component, ordinal, type, name, value);

                collectionResult.Add(tuple);

                continue;
            }

            return new List<Tuple<String, Int32, String, String, Object>>(collectionResult);
        }
    }
}
