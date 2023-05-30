using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Drops
{
	// Token: 0x02000013 RID: 19
	public class StaticalEssence : ModItem
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003984 File Offset: 0x00001B84
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Statical Essence");
			base.Tooltip.SetDefault("'The essence of glitchy, yet static things'");
			ItemID.Sets.ItemNoGravity[base.item.type] = true;
			Main.RegisterItemAnimation(base.item.type, new DrawAnimationVertical(3, 13));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000039DC File Offset: 0x00001BDC
		public override void SetDefaults()
		{
			base.item.width = 20;
			base.item.height = 20;
			base.item.maxStack = 999;
			base.item.value = 1000;
			base.item.rare = -1;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003A30 File Offset: 0x00001C30
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(170, 160, 170));
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022B6 File Offset: 0x000004B6
		public StaticalEssence()
		{
		}
	}
}
