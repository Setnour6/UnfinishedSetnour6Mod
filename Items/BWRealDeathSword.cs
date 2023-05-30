using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x02000006 RID: 6
	public class BWRealDeathSword : ModItem
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002162 File Offset: 0x00000362
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("The Black and White Sword");
			base.Tooltip.SetDefault("[c/000000:I've had enough of this... ]\n[c/000000:Goodbye. ]\n[c/533359:Can only be acquired by cheating. ]\n[c/910000:This can possibly break the game. ]");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002184 File Offset: 0x00000384
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(0, 0, 0));
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002204 File Offset: 0x00000404
		public override void SetDefaults()
		{
			base.item.damage = 1000000000;
			base.item.melee = true;
			base.item.width = 20;
			base.item.height = 20;
			base.item.useTime = 20;
			base.item.useAnimation = 20;
			base.item.useStyle = 1;
			base.item.knockBack = 20f;
			base.item.value = 10000000;
			base.item.rare = 17;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022B6 File Offset: 0x000004B6
		public BWRealDeathSword()
		{
		}
	}
}
