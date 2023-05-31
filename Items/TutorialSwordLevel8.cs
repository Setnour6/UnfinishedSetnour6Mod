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
			// base.DisplayName.SetDefault("Tutorial Sword Level 8");
			// base.Tooltip.SetDefault("[c/FBFF00:THERE'S A LEVEL 8??? WHAT?!?!? ]\n[c/533359:Can only be acquired by cheating. ]\n[c/334A59:Rest in peace, existance. ]");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000034F4 File Offset: 0x000016F4
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(48, 48, 50));
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003578 File Offset: 0x00001778
		public override void SetDefaults()
		{
			base.Item.damage = 100000000;
			base.Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			base.Item.width = 4;
			base.Item.height = 4;
			base.Item.useTime = 0;
			base.Item.useAnimation = 0;
			base.Item.useStyle = 1;
			base.Item.knockBack = 20f;
			base.Item.value = 10000000;
			base.Item.rare = 17;
			base.Item.UseSound = SoundID.Item1;
			base.Item.autoReuse = true;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel8()
		{
		}
	}
}
