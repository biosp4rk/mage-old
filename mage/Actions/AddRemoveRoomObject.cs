using System;
using System.Drawing;

namespace mage
{
    public class AddRemoveRoomObject : RoomAction
    {
        private enum ActionType { Add, Remove };

        // fields
        private RoomObject obj;
        private int objNum;
        private ActionType actionType;

        // constructor (add)
        public AddRemoveRoomObject(Room room, Type type, Point pos)
        {
            actionType = ActionType.Add;
            combine = false;

            if (type == typeof(Enemy))
            {
                obj = new Enemy();
                objNum = room.enemyList.Count;
            }
            else if (type == typeof(Door))
            {
                obj = DoorData.NewDoor(room.AreaID, room.RoomID);
                objNum = room.doorList.Count;
            }
            else if (type == typeof(Scroll))
            {
                obj = new Scroll();
                objNum = room.scrollList.Count * 6;
            }

            obj.Add(pos);
        }

        // constructor (remove)
        public AddRemoveRoomObject(RoomObject prevObj, int objNum)
        {
            actionType = ActionType.Remove;
            combine = false;
            this.objNum = objNum;
            this.obj = prevObj;
        }

        public override void Do(Room room)
        {
            bool add = (actionType == ActionType.Add);
            DoAction(room, add);
        }

        public override void Undo(Room room)
        {
            bool add = (actionType == ActionType.Remove);
            DoAction(room, add);
        }

        private void DoAction(Room room, bool add)
        {
            if (obj is Enemy)
            {
                if (add)
                {
                    room.enemyList.AddEnemy((Enemy)obj, objNum);
                    //room.enemyList.SetEnemyBounds((Enemy)obj);
                }
                else
                {
                    room.enemyList.RemoveEnemy(objNum);
                }
            }
            else if (obj is Door)
            {
                if (add)
                {
                    room.doorList.AddDoor((Door)obj, objNum);
                }
                else
                {
                    room.doorList.RemoveDoor(objNum);
                }
            }
            else if (obj is Scroll)
            {
                if (add)
                {
                    room.scrollList.AddScroll((Scroll)obj, objNum);
                }
                else
                {
                    room.scrollList.RemoveScroll(objNum);
                }
            }
        }

        public override Rectangle AffectedRegion
        {
            get { return obj.DrawingBounds; }
        }

        public override string ActionText
        {
            get
            {
                string text;
                //if (actionType == ActionType.Add) { text = "Add "; }
                //else { text = "Remove "; }
                
                //if (obj is Enemy) { return text + "sprite"; }
                //if (obj is Door) { return text + "door"; }
                //if (obj is Scroll) { return text + "scroll"; }
                if (actionType == ActionType.Add) { text = Properties.Resources.Action_AddText; }
                else { text = Properties.Resources.Action_RemoveText; }

                if (obj is Enemy) { return text + Properties.Resources.Action_SpriteText; }
                if (obj is Door) { return text + Properties.Resources.Action_DoorText; }
                if (obj is Scroll) { return text + Properties.Resources.Action_ScrollText; }
                return text;
            }
        }


    }
}
