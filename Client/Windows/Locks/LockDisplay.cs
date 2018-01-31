﻿using System;

namespace LunaClient.Windows.Locks
{
    internal class VesselLockDisplay
    {
        public Guid VesselId { get; set; }
        public string VesselName { get; set; }
        public bool Selected { get; set; }

        public string ControlLockOwner { get; set; }
        public string UpdateLockOwner { get; set; }
        public string UnloadedUpdateLockOwner { get; set; }
    }
}
