using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000B RID: 11
	public class TutorialSwordLevel3 : ModItem
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000029CD File Offset: 0x00000BCD
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tutorial Sword Level 3");
			base.Tooltip.SetDefault("A Seriously deadly testing sword that your enemies should avoid. ]\n[c/AB706F:Killing Time! ]\n[c/395933:--I'm terrible at trying to make this weapon fire projectiles, so I need lessons-- ]");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000029F0 File Offset: 0x00000BF0
		public override void SetDefaults()
		{
			base.item.damage = 1000;
			base.item.melee = true;
			base.item.width = 100;
			base.item.height = 100;
			base.item.useTime = 14;
			base.item.useAnimation = 14;
			base.item.useStyle = 1;
			base.item.knockBack = 8f;
			base.item.value = 100000;
			base.item.rare = 12;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
			base.item.useTurn = true;
			base.item.shoot = base.mod.ProjectileType("TutorialSwordLevel4Projectile");
			base.item.shootSpeed = 10f;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002ADC File Offset: 0x00000CDC
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 1f;
			float rotation = MathHelper.ToRadians(1f);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 30f;
			int i = 0;
			while ((float)i < numberProjectiles)
			{
				Vector2 perturbedSpeed = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(-rotation, rotation, (float)i / (numberProjectiles - 1f)), default(Vector2)) * 0.5f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI, 0f, 0f);
				i++;
			}
			return false;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(3467, 50);
			modRecipe.AddIngredient(3458, 25);
			modRecipe.AddIngredient(base.mod.GetItem("TutorialSwordLevel2"), 1);
			modRecipe.AddTile(412);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel3()
		{
		}
	}
}
