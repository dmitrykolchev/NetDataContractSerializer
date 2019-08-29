using System.Collections.Generic;

namespace Compat.Runtime.Serialization
{
    public sealed class ExtensionDataObject
    {
        internal ExtensionDataObject()
        {
        }

        internal IList<ExtensionDataMember> Members { get; set; }
    }
}
