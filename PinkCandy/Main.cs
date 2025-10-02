using HarmonyLib;
using LabApi.Loader.Features.Plugins;
using System;

namespace PinkCandy
{
    public class Main : Plugin
    {
        public override string Name => "PinkCandy";
        public override string Description => "PinkCandy";
        public override string Author => "ui_2506";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredApiVersion => new Version(1, 1, 2);

        private Harmony harmony;

        public override void Enable()
        {
            harmony = new Harmony(Name);
            harmony.PatchAll();
        }

        public override void Disable()
        {
            harmony.UnpatchAll();
            harmony = null;
        }
    }
}
