using ModComponentMapper;

namespace ClothingPack
{
    public class SkiGogglesImplementation
    {
        void OnPutOn()
        {
            BrightnessChanger.Brightness = BrightnessChanger.GetDefault() * 0.25f;
        }

        void OnTakeOff()
        {
            BrightnessChanger.Reset();
        }
    }
}