
namespace Flashline.Animate
{
    public class Animation 
    {
        public Element StageInstance;
        public Element CurInstance;
        public Data.TextureAtlas.Metadata Metadata;

        public bool Finished {get; private set;}
        public bool IsPlaying {get; private set;}
        
        public float FrameRate;
        public int CurFrame;
    }
}
