using System;
using Terraria;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.NPCs
{
	// Token: 0x02000005 RID: 5
	public class ModGlobalNPC : GlobalNPC
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000209C File Offset: 0x0000029C
		public override void OnKill(NPC npc)
		{
			int type = npc.type;
			if (type != 68)
			{
				if (type != 398)
				{
					return;
				}
				if (Main.rand.Next(0) == 0)
				{
					Item.NewItem(npc.GetSource_Loot(), npc.position, npc.width, npc.height, base.Mod.Find<ModItem>("StaticalEssence").Type, 1, false, 0, false, false);
				}
			}
			else if (Main.rand.Next(0) == 0)
			{
				Item.NewItem(npc.GetSource_Loot(), npc.position, npc.width, npc.height, base.Mod.Find<ModItem>("StaticalEssence").Type, 1, false, 0, false, false);
				return;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000215A File Offset: 0x0000035A
		public ModGlobalNPC()
		{
		}
	}
}
