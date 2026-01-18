using UnityEngine;

namespace Flashline.ScriptableObjects
{
    [CreateAssetMenu(fileName = "TextureAtlas", menuName = "Flashline/Texture Atlas Pack")]
    public class TextureAtlas : ScriptableObject
    {
        // Animation.json
        // spritemap class[]
            // name
            // texture2D

        public TextAsset AnimationAtlas;
    }
}
