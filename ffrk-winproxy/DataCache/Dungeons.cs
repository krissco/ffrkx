﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.DataCache.Dungeons
{
    public struct Key
    {
        public uint DungeonId;
    }

    public class Data
    {
        public uint WorldId;
        public uint Series;
        public string Name;
        public byte Type;
        public ushort Difficulty;
    }
}
