﻿using MudSharp.Data.Models.World.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Data.Models.World.Actors
{
    public class Player : IEntity
    {
        public int Id { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public Guid InstanceId { get; set; }

        public List<Item> Inventory { get; set; }
    }
}
