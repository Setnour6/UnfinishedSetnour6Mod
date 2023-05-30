using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000A RID: 10
	public class TutorialSwordLevel2 : ModItem
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000028C1 File Offset: 0x00000AC1
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tutorial Sword Level 2");
			base.Tooltip.SetDefault("Literally a testing sword... up a level.");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000028E4 File Offset: 0x00000AE4
		public override void SetDefaults()
		{
			base.item.damage = 100;
			base.item.melee = true;
			base.item.width = 50;
			base.item.height = 50;
			base.item.useTime = 18;
			base.item.useAnimation = 18;
			base.item.useStyle = 1;
			base.item.knockBack = 5f;
			base.item.value = 10000;
			base.item.rare = 3;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
			base.item.useTurn = true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000299E File Offset: 0x00000B9E
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(706, 100);
			modRecipe.AddTile(16);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel2()
		{
		}
	}
}
