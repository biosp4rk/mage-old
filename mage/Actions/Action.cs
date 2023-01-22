using System;

namespace mage
{
    public abstract class Action
    {
        public bool combine;

        public abstract void Do(Room room);

        public abstract void Undo(Room room);

        public virtual bool TryCombine(Action a)
        {
            return false;
        }

        public abstract string ActionText { get; }


    }
}
