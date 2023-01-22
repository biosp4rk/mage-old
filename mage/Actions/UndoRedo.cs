using System;

namespace mage
{
    public class UndoRedo
    {
        public DropOutStack<Action> UndoStack { get { return undoStack; } }
        public DropOutStack<Action> RedoStack { get { return redoStack; } }
        public bool CanUndo { get { return undoStack.Count > 0; } }
        public bool CanRedo { get { return redoStack.Count > 0; } }

        // fields
        private DropOutStack<Action> undoStack;
        private DropOutStack<Action> redoStack;

        // constructor
        public UndoRedo()
        {
            undoStack = new DropOutStack<Action>();
            redoStack = new DropOutStack<Action>();
        }

        public void Do(Action a, Room room)
        {
            a.Do(room);
            redoStack.Clear();
            if (undoStack.Count != 0 && a.combine)
            {
                if (!undoStack.Peek().TryCombine(a))
                {
                    undoStack.Push(a);
                }
            }
            else
            {
                undoStack.Push(a);
            }
        }

        public Action Undo(Room room)
        {
            Action a = undoStack.Pop();
            a.Undo(room);
            redoStack.Push(a);
            return a;
        }

        public Action Redo(Room room)
        {
            Action a = redoStack.Pop();
            a.Do(room);
            undoStack.Push(a);
            return a;
        }

        public void FinalizePreviousAction()
        {
            if (undoStack.Count > 0)
            {
                undoStack.Peek().combine = false;
            }
        }

    }
}
