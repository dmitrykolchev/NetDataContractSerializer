using System.Collections.Generic;

namespace Compat.Runtime.Serialization
{
    internal class ClassDataNode : DataNode<object>
    {
        private IList<ExtensionDataMember> _members;

        internal ClassDataNode()
        {
            dataType = Globals.TypeOfClassDataNode;
        }

        internal IList<ExtensionDataMember> Members
        {
            get => _members;
            set => _members = value;
        }

        public override void Clear()
        {
            base.Clear();
            _members = null;
        }
    }
}
