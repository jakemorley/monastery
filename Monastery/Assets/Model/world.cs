using UnityEngine;
using System.Collections;


namespace Assets.Model
{
    public class World
    {
        private const int _height = 480;
        private const int _width = 640;
        private const int _levels = 1;
        private const int _worldSize = _width * _height * _levels;
        private Tile[] _tiles;

        public World()
        {
            _tiles = new Tile[_worldSize];
            var tilesInitilized = this.Initialize();
        }

        private int Initialize()
        {
            int tileCount = 0;
            for(int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    for (int k = 0; k < +_levels; k++)
                    {
                        var theTile = new Tile(this, i, j, k);
                        tileCount++;
                    }
                }                
            }
            Debug.Log("World created with " + tileCount + " tiles");
            return tileCount;
        }
    }
}