using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Model
{
    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public TileTypes TileType { get; set; }
        private List<Prop> _contents;
        private World _world;

        public Tile(World w, int x, int y, int z)
        {
            _world = w;
            _contents = new List<Prop>();
        }

        public List<Prop> GetContents()
        {
            return this._contents;
        }
    }

}
