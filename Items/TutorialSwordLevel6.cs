﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000E RID: 14
	public class TutorialSwordLevel6 : ModItem
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000322A File Offset: 0x0000142A
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Tutorial Sword Level 6");
			// base.Tooltip.SetDefault("[c/533359:Can only be acquired by cheating. ]\n[c/334A59:Hand-by-hand, this is the one of the best weapons to ever exist in Terraria... without anything extra. ]\n[c/400000:``Dear opponents, you gon' die`` ]");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000324C File Offset: 0x0000144C
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(30, 30, 112));
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000032D0 File Offset: 0x000014D0
		public override void SetDefaults()
		{
			base.Item.damage = 1000000;
			base.Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			base.Item.width = 4;
			base.Item.height = 4;
			base.Item.useTime = 2;
			base.Item.useAnimation = 2;
			base.Item.useStyle = 1;
			base.Item.knockBack = 20f;
			base.Item.value = 10000000;
			base.Item.rare = 17;
			base.Item.UseSound = SoundID.Item1;
			base.Item.autoReuse = true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel6()
		{
		}
	}
}
