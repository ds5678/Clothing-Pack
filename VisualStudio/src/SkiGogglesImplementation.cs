using ModComponentMapper;

namespace ClothingPack
{
    public class SkiGogglesImplementation
    {
        void OnPutOn()
        {
            GammaChanger.SetGamma(2.5f);
        }

        void OnTakeOff()
        {
            GammaChanger.ResetGamma();
        }
    }
}