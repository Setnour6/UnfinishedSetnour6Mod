using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x02000010 RID: 16
	public class TutorialSwordLevel8 : ModItem
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000034D2 File Offset: 0x000016D2
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tutorial Sword Level 8");
			base.Tooltip.SetDefault("[c/FBFF00:THERE'S A LEVEL 8??? WHAT?!?!? ]\n[c/533359:Can only be acquired by cheating. ]\n[c/334A59:Rest in peace, existance. ]");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000034F4 File Offset: 0x000016F4
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(48, 48, 50));
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003578 File Offset: 0x00001778
		public override void SetDefaults()
		{
			base.item.damage = 100000000;
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

		// Token: 0x0600003A RID: 58 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel8()
		{
		}
	}
}
