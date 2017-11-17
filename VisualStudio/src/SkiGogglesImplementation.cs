using ModComponentMapper;

namespace ClothingPack
{
    public class SkiGogglesImplementation
    {
        void OnPutOn()
        {
            GammaChanger.SetGamma(2f);
        }

        void OnTakeOff()
        {
            GammaChanger.ResetGamma();
        }
    }
}