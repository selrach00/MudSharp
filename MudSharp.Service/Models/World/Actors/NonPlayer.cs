using MudSharp.Service.Models.World.Actors;
using MudSharp.Service.Models.World.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Service.Models.World.Actors
{
    /// <summary>
    /// Class describing a non-player character (NPC).
    /// </summary>
    public class NonPlayer
    {
        public int Id { get; set; }

        public Guid InstanceId { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public List<Item> Inventory { get; set; }
    }
}
