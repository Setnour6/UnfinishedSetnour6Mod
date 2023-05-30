using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x02000007 RID: 7
	public class BWRealDeathSword2 : ModItem
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000022BE File Offset: 0x000004BE
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("The Almighty Black and White Sword");
			base.Tooltip.SetDefault("[c/000000:I've had enough of this... ]\n[c/000000:Goodbye. ]\n[c/533359:Can only be acquired by cheating. ]\n[c/910000:This can possibly break the game. ]");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022E0 File Offset: 0x000004E0
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

		// Token: 0x06000010 RID: 16 RVA: 0x00002360 File Offset: 0x00000560
		public override void SetDefaults()
		{
			base.item.damage = 2000000000;
			base.item.melee = true;
			base.item.width = 4;
			base.item.height = 4;
			base.item.useTime = 0;
			base.item.useAnimation = 0;
			base.item.useStyle = 1;
			base.item.knockBack = 20f;
			base.item.value = 10000000;
			base.item.rare = 17;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022B6 File Offset: 0x000004B6
		public BWRealDeathSword2()
		{
		}
	}
}
