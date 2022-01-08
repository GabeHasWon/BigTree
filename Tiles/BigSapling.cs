using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace BigTree.Tiles
{
    class BigSapling : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = false;
            Main.tileSolid[Type] = false;

            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 16 };
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.RandomStyleRange = 2;
            TileObjectData.newTile.StyleHorizontal = false;
            TileObjectData.newTile.Origin = new Point16(0, 0);
            TileObjectData.addTile(Type);

            ModTranslation n = CreateMapEntryName();
            n.SetDefault("Sapling");
            AddMapEntry(new Microsoft.Xna.Framework.Color(163, 116, 81), n);

            dustType = DustID.Dirt;
            soundType = SoundID.Dig;
        }

        public override void RandomUpdate(int i, int j)
        {
            if (Main.rand.Next(8) == 0)
            {
                int xOff = 0; //Adjusts so the tree always spawns aligned with this tile -->
                int yOff = 0;
                if (Framing.GetTileSafely(i, j).frameX == 0)
                    xOff++;
                if (Framing.GetTileSafely(i, j).frameY == 0)
                    yOff++; //<--
                WorldGen.KillTile(i + xOff, j + yOff - 1, false, false, true); //Grows a tree after removing the sapling
                BigTree_Purity.Spawn(i + xOff - 1, j + yOff, Main.rand.Next(26, 47), null, true, 14, true); //Spawns tree
            }
        }
    }
}
