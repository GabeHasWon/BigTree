using BigTree.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace BigTree
{
    class ModGlobalTile : GlobalTile
    {
        public override bool CanKillTile(int i, int j, int type, ref bool blockDamaged)
        {
            int[] requireGroundTypes = new int[] { TileType<BigTree_Purity>() }; //Makes tiles under big trees unable to be killed
            if (j > 0 && requireGroundTypes.Any(x => ActiveType(i, j - 1, x)) && SolidTile(i, j)) //Makes sure the position is also in-world
                return false;
            return true;
        }

        public bool ActiveType(int i, int j, int t) => Framing.GetTileSafely(i, j).active() && Framing.GetTileSafely(i, j).type == t; //Some helper methods
        public bool SolidTile(int i, int j) => Framing.GetTileSafely(i, j).active() && Main.tileSolid[Framing.GetTileSafely(i, j).type];
    }
}
