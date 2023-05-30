using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x02000009 RID: 9
	public class TutorialSword : ModItem
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000027C9 File Offset: 0x000009C9
		public override void SetStaticDefaults()
		{
			base.Tooltip.SetDefault("Literally a testing sword");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027DC File Offset: 0x000009DC
		public override void SetDefaults()
		{
			base.item.damage = 10;
			base.item.melee = true;
			base.item.width = 40;
			base.item.height = 40;
			base.item.useTime = 20;
			base.item.useAnimation = 20;
			base.item.useStyle = 1;
			base.item.knockBack = 4f;
			base.item.value = 1000;
			base.item.rare = 1;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
			base.item.useTurn = true;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002896 File Offset: 0x00000A96
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(2, 100);
			modRecipe.AddTile(18);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSword()
		{
		}
	}
}
