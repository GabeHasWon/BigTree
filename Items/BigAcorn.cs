using BigTree.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BigTree.Items
{
    class BigAcorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Don't ask how this works. It just works.'");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.maxStack = 999;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 6;
            item.value = Item.buyPrice(0, 0, 0, 5);
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.createTile = ModContent.TileType<BigSapling>();
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Acorn, 4);
            r.AddIngredient(ItemID.Wood, 2);
            r.AddIngredient(ItemID.Gel, 1);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
