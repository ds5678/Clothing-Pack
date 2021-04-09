using ModSettings;

namespace ClothingPack
{
    internal class ClothingPackSettings : JsonModSettings
    {
        [Section("Spawn Settings")]
        [Name("Pilgram / Very High Loot Custom")]
        [Description("The percent probability of finding a modded spawn from the Clothing Pack on this game mode. Setting to zero disables them on this game mode.")]
        [Slider(0f, 100f, 101)]
        public float pilgramSpawnProbability = 35f;

        [Name("Voyager / High Loot Custom")]
        [Description("The percent probability of finding a modded spawn from the Clothing Pack on this game mode. Setting to zero disables them on this game mode.")]
        [Slider(0f, 100f, 101)]
        public float voyagerSpawnProbability = 21f;

        [Name("Stalker / Medium Loot Custom")]
        [Description("The percent probability of finding a modded spawn from the Clothing Pack on this game mode. Setting to zero disables them on this game mode.")]
        [Slider(0f, 100f, 101)]
        public float stalkerSpawnProbability = 14f;

        [Name("Interloper / Low Loot Custom")]
        [Description("The percent probability of finding a modded spawn from the Clothing Pack on this game mode. Setting to zero disables them on this game mode.")]
        [Slider(0f, 100f, 101)]
        public float interloperSpawnProbability = 7f;

        [Name("Wintermute")]
        [Description("The percent probability of finding a modded spawn from the Clothing Pack on this game mode. Setting to zero disables them on this game mode.")]
        [Slider(0f, 100f, 101)]
        public float storySpawnProbability = 35f;

        [Name("Challenges")]
        [Description("The percent probability of finding a modded spawn from the Clothing Pack on this game mode. Setting to zero disables them on this game mode.")]
        [Slider(0f, 100f, 101)]
        public float challengeSpawnProbability = 21f;
    }
    internal static class Settings
    {
        internal static ClothingPackSettings options;
        internal static void OnLoad()
        {
            options = new ClothingPackSettings();
            options.AddToModSettings("Clothing Pack");
        }
    }
}
