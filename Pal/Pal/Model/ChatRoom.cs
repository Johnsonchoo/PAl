﻿
using System;
using System.Collections.ObjectModel;

namespace Pal.Model
{
    public class ChatRoom
    {
        public string RoomID { get; set; }
        public string Image { get; set; }
        public string RoomTilte { get; set; }
        public bool IsDestruct { get; set; }

        public ChatRoom()
        {
            this.Image = "blank_profile_picture_640.png";
        }

        public ChatRoom(string roomID,string roomTilte,bool isDestruct)
        {
            RoomID = roomID;
            RoomTilte = roomTilte;
            this.Image = "blank_profile_picture_640.png";
            IsDestruct = isDestruct;
        }
    }
}
