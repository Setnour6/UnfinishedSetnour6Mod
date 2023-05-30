using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000F RID: 15
	public class TutorialSwordLevel7 : ModItem
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0000337E File Offset: 0x0000157E
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tutorial Sword Level 7");
			base.Tooltip.SetDefault("[c/533359:Can only be acquired by cheating. ]\n[c/334A59:Definetely one of, if not, the best weapon in terraria... that doesn't shoot projectiles. ]\n[c/303000:Rely on the weapon, for it is an eternal creation that looks unconvincing to many.]");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000033A0 File Offset: 0x000015A0
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

		// Token: 0x06000035 RID: 53 RVA: 0x00003424 File Offset: 0x00001624
		public override void SetDefaults()
		{
			base.item.damage = 10000000;
			base.item.melee = true;
			base.item.width = 4;
			base.item.height = 4;
			base.item.useTime = 1;
			base.item.useAnimation = 1;
			base.item.useStyle = 1;
			base.item.knockBack = 20f;
			base.item.value = 10000000;
			base.item.rare = 17;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel7()
		{
		}
	}
}
