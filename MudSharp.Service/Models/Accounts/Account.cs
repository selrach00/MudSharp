using System;
using System.Collections.Generic;
using System.Text;

namespace MudSharp.Service.Models.Accounts
{
    public class Account : IEntity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public Guid InstanceId { get; set; }
    }
}
