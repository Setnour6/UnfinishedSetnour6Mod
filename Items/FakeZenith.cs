using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x02000008 RID: 8
	public class FakeZenith : ModItem
	{
		// Token: 0x06000012 RID: 18 RVA: 0x0000240E File Offset: 0x0000060E
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Zenith");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002420 File Offset: 0x00000620
		public override void SetDefaults()
		{
			base.item.CloneDefaults(757);
			base.item.shootSpeed *= 1.3f;
			base.item.shoot = base.mod.ProjectileType("FakeZenithProjectile");
			base.item.damage *= 2;
			base.item.rare = 10;
			base.item.useTime = 30;
			base.item.useAnimation = 30;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024AC File Offset: 0x000006AC
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float num72 = base.item.shootSpeed;
			int num73 = base.item.damage;
			float num74 = base.item.knockBack;
			num74 = player.GetWeaponKnockback(base.item, num74);
			player.itemTime = base.item.useTime;
			Vector2 vector2 = player.RotatedRelativePoint(player.MountedCenter, true);
			Utils.RotatedBy(Vector2.UnitX, (double)player.fullRotation, default(Vector2));
			float num75 = (float)Main.mouseX + Main.screenPosition.X - vector2.X;
			float num76 = (float)Main.mouseY + Main.screenPosition.Y - vector2.Y;
			if (player.gravDir == -1f)
			{
				num76 = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY - vector2.Y;
			}
			float num77 = (float)Math.Sqrt((double)(num75 * num75 + num76 * num76));
			if ((float.IsNaN(num75) && float.IsNaN(num76)) || (num75 == 0f && num76 == 0f))
			{
				num75 = (float)player.direction;
				num76 = 0f;
				num77 = num72;
			}
			else
			{
				num77 = num72 / num77;
			}
			num75 *= num77;
			num76 *= num77;
			int num78 = 4;
			if (Main.rand.Next(2) == 0)
			{
				num78++;
			}
			if (Main.rand.Next(4) == 0)
			{
				num78++;
			}
			if (Main.rand.Next(8) == 0)
			{
				num78++;
			}
			if (Main.rand.Next(16) == 0)
			{
				num78++;
			}
			for (int num79 = 0; num79 < num78; num79++)
			{
				int r = this.projectiles[Main.rand.Next(this.projectiles.Length)];
				float num80 = num75;
				float num81 = num76;
				float num82 = 0.05f * (float)num79;
				num80 += (float)Main.rand.Next(-35, 36) * num82;
				num81 += (float)Main.rand.Next(-35, 36) * num82;
				num77 = (float)Math.Sqrt((double)(num80 * num80 + num81 * num81));
				num77 = num72 / num77;
				num80 *= num77;
				num81 *= num77;
				float x = vector2.X;
				float y4 = vector2.Y;
				Projectile.NewProjectile(x, y4, num80, num81, r, num73, num74, Main.myPlayer, 0f, 0f);
			}
			return false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002704 File Offset: 0x00000904
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(757, 1);
			modRecipe.AddIngredient(3063, 1);
			modRecipe.AddIngredient(3065, 1);
			modRecipe.AddIngredient(2880, 1);
			modRecipe.AddIngredient(1826, 1);
			modRecipe.AddIngredient(3018, 1);
			modRecipe.AddIngredient(65, 1);
			modRecipe.AddIngredient(1123, 1);
			modRecipe.AddIngredient(989, 1);
			modRecipe.AddIngredient(3507, 1);
			modRecipe.AddTile(134);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000027A9 File Offset: 0x000009A9
		public FakeZenith()
		{
		}

		// Token: 0x04000001 RID: 1
		private int[] projectiles = new int[] { 173, 321, 9, 116, 181, 132, 483, 451, 503, 502 };
	}
}
