// -----------------------------------------------------------------------------
// <copyright file="StatusModule.cs" company="Zack Loveless">
//    Copyright (c) 2014 Zack Loveless. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------

namespace Status
{
    using Atlantis.Net.Irc;
    using Lantea.Common.Extensibility;
    using Lantea.Common.IO;

    [Module(ConfigBlock = "")]
    public class StatusModule : IModule
    {
        #region Implementation of IModule

        public void Dispose()
        {
            // TODO: Break down
        }

        public void Initialize(Block config, IrcClient client)
        {
            Rehash(config);

            // TODO: Initialize
        }

        public void Rehash(Block config)
        {
        }

        public string Author
        {
            get { return "Zack Loveless"; }
        }

        public string Description
        {
            get { return "Provides "; }
        }

        public string Name
        {
            get { return "Status"; }
        }

        public string Version
        {
            get { return "1.0"; }
        }

        #endregion
    }
}
