using System;
using System.Drawing;

namespace mage
{
    public class EditRoomObject : RoomAction
    {
        private enum ActionType { Edit, Move };

        // fields
        private RoomObject obj;
        private ActionType actionType;
        private int objNum;
        private Rectangle region;

        // constructor (edit)
        public EditRoomObject(RoomObject newObj, int objNum, bool move)
        {
            if (move)
            {
                actionType = ActionType.Move;
                combine = true;
            }
            else
            {
                actionType = ActionType.Edit;
                combine = false;
            }
            this.objNum = objNum;
            this.obj = newObj;
        }

        public override void Do(Room room)
        {
            RoomObject prev = null;
            if (obj is Enemy)
            {
                Enemy curr = room.enemyList[objNum];
                prev = curr.Copy();
                curr.SetValue(obj);
                room.enemyList.Edited = true;
            }
            else if (obj is Door)
            {
                Door curr = room.doorList[objNum];
                prev = curr.Copy();
                curr.SetValue(obj);
                room.doorList.Edited = true;
            }
            else if (obj is Scroll)
            {
                Scroll curr = room.scrollList[objNum / 6];
                prev = curr.Copy();
                curr.SetValue(obj);
                room.scrollList.Edited = true;
            }

            region = Rectangle.Union(prev.DrawingBounds, obj.DrawingBounds);
            obj = prev;
        }

        public override void Undo(Room room)
        {
            Do(room);
        }

        public override Rectangle AffectedRegion
        {
            get
            {
                int x = (region.X / 16) * 16;
                int y = (region.Y / 16) * 16;
                int w = ((region.Width / 16) + 2) * 16;
                int h = ((region.Height / 16) + 2) * 16;
                return new Rectangle(x, y, w, h);
            }
        }

        public override string ActionText
        {
            get
            {
                string text;
                //if (actionType == ActionType.Edit) { text = "Edit "; }
                //else { text = "Move "; }
                
                //if (obj is Enemy) { return text + "sprite"; }
                //if (obj is Door) { return text + "door"; }
                //if (obj is Scroll) { return text + "scroll"; }
                if (actionType == ActionType.Edit) { text = Properties.Resources.Action_EditText; }
                else { text = Properties.Resources.Action_MoveText; }

                if (obj is Enemy) { return text + Properties.Resources.Action_SpriteText; }
                if (obj is Door) { return text + Properties.Resources.Action_DoorText; }
                if (obj is Scroll) { return text + Properties.Resources.Action_ScrollText; }
                return text;
            }
        }

        public override bool TryCombine(Action a)
        {
            EditRoomObject newer = a as EditRoomObject;
            if (newer != null && combine && this.actionType == ActionType.Move && 
                newer.actionType == ActionType.Move && this.objNum == newer.objNum)
            {
                return true;
            }
            return false;
        }


    }
}
