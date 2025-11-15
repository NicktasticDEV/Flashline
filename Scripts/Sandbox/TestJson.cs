using Flashline.Data.TextureAtlas;
using Newtonsoft.Json;
using UnityEngine;

namespace Flashline.Sandbox
{
    public class TestJson : MonoBehaviour
    {
        public TextAsset jsonFile;
        public AnimateAtlas animateAtlas;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            animateAtlas = JsonConvert.DeserializeObject<AnimateAtlas>(jsonFile.text);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}