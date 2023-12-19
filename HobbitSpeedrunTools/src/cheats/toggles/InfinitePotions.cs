﻿using Memory;

namespace HobbitSpeedrunTools
{
    public class InfinitePotions : ToggleCheat
    {
        public override string Name { get; set; } = "Infinite Potions";
        public override string ShortName { get; set; } = "IP";
        public override string ShortcutName { get; set; } = "infinite_potions";

        public InfinitePotions(Mem _mem)
        {
            mem = _mem;
        }

        public override void OnTick()
        {
            if (Enabled)
            {
                mem?.WriteMemory(MemoryAddresses.healthPotions, "float", "99");
                mem?.WriteMemory(MemoryAddresses.antidotes, "float", "99");
            }
        }
    }
}
