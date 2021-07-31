namespace ClothingPack
{
    public class SkiGogglesImplementation
    {
        void OnPutOn()
        {
            //BrightnessChanger.Brightness = BrightnessChanger.GetDefault() * 0.25f;
            BrightnessChanger.darknessMultiplier = 4;
        }

        void OnTakeOff()
        {
            //BrightnessChanger.Reset();
            BrightnessChanger.darknessMultiplier = 1;
        }
    }
}