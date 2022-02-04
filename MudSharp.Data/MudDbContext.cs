﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MudSharp.Data.Models.Accounts;
using MudSharp.Data.Models.World.Actors;
using MudSharp.Data.Models.World.Environment.Rooms;
using MudSharp.Data.Models.World.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MudSharp.Data
{
    /// <summary>
    /// Database context for all persisted objects in MudSharp.
    /// </summary>
    public class MudDbContext : DbContext
    {
        public MudDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetSection("DbConnectionString").Value;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        #region Players
        /// <summary>
        /// Player accounts.
        /// </summary>
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Player characters.
        /// </summary>
        public DbSet<Player> Players { get; set; }

        #endregion

        #region World
        public DbSet<Actor> Actors { get; set; }
        /// <summary>
        /// All the items in the world.
        /// </summary>
        public DbSet<Item> Items { get; set; }

        /// <summary>
        /// Non-player characters (NPCs).
        /// </summary>
        public DbSet<NonPlayer> NPCs { get; set; }

        /// <summary>
        /// All the rooms in the world.
        /// </summary>
        public DbSet<Room> Rooms { get; set; }

        #endregion
    }
}
