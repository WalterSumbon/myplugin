using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;

namespace TestPlugin
{
    [ApiVersion(2, 1)]
    public class TestPlugin : TerrariaPlugin
    {
        public override string Name => "myplugin";
        public override string Author => "ZenithX";
        public override string Description => "Server plugin for USTC Terraria TShock server";
        public override Version Version => new Version(1, 0, 0, 0);

        // Initializes a new instance of the TestPlugin class.
        // This is where you set the plugin's order and perfrom other constructor logic
        public TestPlugin(Main game) : base(game)
        {

        }

        // Handles plugin initialization. 
        // Fired when the server is started and the plugin is being loaded.
        // You may register hooks, perform loading procedures etc here.
        public override void Initialize()
        {

        }

        // Handles plugin disposal logic.
        // *Supposed* to fire when the server shuts down.
        // You should deregister hooks and free all resources here.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }
    }
}