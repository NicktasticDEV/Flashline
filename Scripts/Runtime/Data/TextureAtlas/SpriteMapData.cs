using UnityEngine;
using System.Collections.Generic;

namespace Flashline.Data.TextureAtlas
{
    public class SpriteMap
    {
        public Atlas ATLAS { get; set; }
        public Meta meta { get; set; }
    }

    public class Atlas
    {
        public List<Sprite> SPRITES { get; set; }
    }

    public class Sprite
    {
        public SpriteData SPRITE { get; set; }
    }

    public class SpriteData
    {
        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public bool rotated { get; set; }
    }

    public class Size
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Meta
    {
        public string app { get; set; }
        public string version { get; set; }
        public string image { get; set; }
        public string format { get; set; }
        public Size size { get; set; }
        public string resolution { get; set; }
    }
}
