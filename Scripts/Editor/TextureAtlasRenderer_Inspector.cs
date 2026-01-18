using Flashline.Components;
using UnityEditor;
using UnityEngine;


namespace Flashline.Editors
{
    //[CustomEditor(typeof(TextureAtlasRenderer))]
    public class TextureAtlasRenderer_Inspector : Editor
    {
        public override void OnInspectorGUI()
        {
            TextureAtlasRenderer textureAtlasRenderer = (TextureAtlasRenderer)target;

            // field for textureAtlas
            textureAtlasRenderer.textureAtlas = (Flashline.ScriptableObjects.TextureAtlas)EditorGUILayout.ObjectField("Texture Atlas", textureAtlasRenderer.textureAtlas, typeof(Flashline.ScriptableObjects.TextureAtlas), false);
            
        }
    }
}