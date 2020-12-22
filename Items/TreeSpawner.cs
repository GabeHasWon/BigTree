using BigTree.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BigTree.Items
{
	public class TreeSpawner : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Spawns a tree at cursor.");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override bool UseItem(Player player)
        {
            BigTree_Purity.Spawn((int)(Main.MouseWorld.X / 16f), (int)(Main.MouseWorld.Y / 16f), Main.rand.Next(18, 56), null, false, 8, true);
            return true;
        }
	}
}