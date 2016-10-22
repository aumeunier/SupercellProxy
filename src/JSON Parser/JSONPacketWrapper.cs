﻿using System.Collections.Generic;

namespace SupercellProxy.JSON_Parser
{
    internal class JSONPacketWrapper
    {
        /// <summary>
        ///     The ID of the Packet ex. 10100, 10101
        /// </summary>
        public int PacketID { get; set; }

        /// <summary>
        ///     The Name of the Packet
        /// </summary>
        public string PacketName { get; set; }

        /// <summary>
        ///     Determines if this Packet should get Logged
        /// </summary>
        public bool ShouldLog { get; set; }

        /// <summary>
        ///     Determines if this Packet should get Exported
        /// </summary>
        public bool ShouldExport { get; set; }

        /// <summary>
        ///     The Fields of the Packet
        /// </summary>
        public List<JSONPacketField> Fields { get; set; }
    }
}