using ModComponentMapper;
using System;

namespace ClothingPack
{
    internal static class SpawnProbabilities
    {
        internal static void AddToModComponent()
        {
            SpawnTagManager.AddToTaggedFunctions("ClothingPack", new Func<DifficultyLevel, FirearmAvailability, GearSpawnInfo, float>(GetProbability));
        }
        private static float GetProbability(DifficultyLevel difficultyLevel, FirearmAvailability firearmAvailability, GearSpawnInfo gearSpawnInfo)
        {
            switch (difficultyLevel)
            {
                case DifficultyLevel.Pilgram:
                    return Settings.options.pilgramSpawnProbability;
                case DifficultyLevel.Voyager:
                    return Settings.options.voyagerSpawnProbability;
                case DifficultyLevel.Stalker:
                    return Settings.options.stalkerSpawnProbability;
                case DifficultyLevel.Interloper:
                    return Settings.options.interloperSpawnProbability;
                case DifficultyLevel.Challenge:
                    return Settings.options.challengeSpawnProbability;
                case DifficultyLevel.Storymode:
                    return Settings.options.storySpawnProbability;
                default:
                    return 0f;
            }
        }
    }
}
