using System;
using System.Drawing;

namespace mage
{
    public abstract class RoomAction : Action
    {
        public abstract Rectangle AffectedRegion { get; }

    }
}
