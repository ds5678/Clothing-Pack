using MelonLoader;

namespace ClothingPack
{
    internal class ClothingPackMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            Settings.OnLoad();
            SpawnProbabilities.AddToModComponent();
        }
    }
}
