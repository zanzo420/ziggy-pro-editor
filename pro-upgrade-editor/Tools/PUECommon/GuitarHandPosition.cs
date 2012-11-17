﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProUpgradeEditor.DataLayer;
using Sanford.Multimedia.Midi;

namespace ProUpgradeEditor.Common
{

    public class GuitarHandPosition : GuitarMessage
    {
        public GuitarHandPosition(GuitarTrack track, MidiEvent downEvent, MidiEvent upEvent)
            : base(track, downEvent, upEvent)
        {
        }

        public int NoteFretDown
        {
            get { return Data2 - 100; }
            set { Data2 = 100 + value; }
        }

        public override string ToString()
        {
            return "Fret: " + NoteFretDown.ToStringEx();
        }
    }
}
