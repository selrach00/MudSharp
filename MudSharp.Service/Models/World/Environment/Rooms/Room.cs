﻿using MudSharp.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Service.Models.World.Environment.Rooms
{
    /// <summary>
    /// Class describing a world room.
    /// </summary>
    public class Room : IEntity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public Guid InstanceId { get; set; }
    }
}
