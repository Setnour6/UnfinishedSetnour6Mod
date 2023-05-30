using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000C RID: 12
	public class TutorialSwordLevel4 : ModItem
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002C01 File Offset: 0x00000E01
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tutorial Sword Level 4");
			base.Tooltip.SetDefault("A seriously deadly testing sword that is so powerful against many things! ]\n[c/334A59:Relying on the sword itself is a good option, since no projectiles will be launched from the sword...]\n[c/395933:--I'm terrible at trying to make this weapon fire projectiles, so I need lessons-- ]\n[c/395933:--Hopefully I get this right...-- ]");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C24 File Offset: 0x00000E24
		public override void SetDefaults()
		{
			base.item.damage = 10000;
			base.item.melee = true;
			base.item.width = 4;
			base.item.height = 4;
			base.item.useTime = 8;
			base.item.useAnimation = 10;
			base.item.useStyle = 1;
			base.item.knockBack = 10f;
			base.item.value = 1000000;
			base.item.rare = 12;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
			base.item.useTurn = true;
			base.item.shoot = base.mod.ProjectileType("TutorialSwordLevel4Projectile");
			base.item.shootSpeed = 40f;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D0C File Offset: 0x00000F0C
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2f;
			float rotation = MathHelper.ToRadians(2f);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 40f;
			int i = 0;
			while ((float)i < numberProjectiles)
			{
				Vector2 perturbedSpeed = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(-rotation, rotation, (float)i / (numberProjectiles - 1f)), default(Vector2)) * 0.6f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI, 0f, 0f);
				i++;
			}
			return false;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(179, 121, 121));
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E54 File Offset: 0x00001054
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(base.mod);
			recipe.AddIngredient(3467, 250);
			recipe.AddIngredient(3458, 100);
			recipe.AddIngredient(base.mod.GetItem("TutorialSwordLevel3"), 1);
			recipe.AddIngredient(3530, 10);
			if (ModLoader.GetMod("CalamityMod") != null)
			{
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("CoreofCalamity"), 50);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("GalacticaSingularity"), 100);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("UnholyEssence"), 100);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm"), 20);
			}
			if (ModLoader.GetMod("ThoriumMod") != null)
			{
				recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("InfernoEssence"), 10);
			}
			if (ModLoader.GetMod("JoostMod") != null)
			{
				recipe.AddIngredient(ModLoader.GetMod("JoostMod").ItemType("Gilameshset"), 1);
			}
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel4()
		{
		}
	}
}
