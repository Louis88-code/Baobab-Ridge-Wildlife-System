using System;
using System.Collections.Generic;
using System.Text;

namespace BaobabRidgeWildlifeSystem
{
    public static class AnimalClassifier
    {
        // status labels
        public const string StatusCritical = "Critical";
        public const string StatusSerious = "Serious";
        public const string StatusStable = "Stable";
        public const string StatusRecovering = "Recovering";
        public const string StatusReleaseReady = "Release-Ready";

        // housing unit labels
        public const string HousingIntensiveCare = "Intensive Care Unit";
        public const string HousingHighDependency = "High-Dependency Ward";
        public const string HousingRecoveryWard = "Recovery Ward";
        public const string HousingOutdoor = "Outdoor Enclosure";
        public const string HousingPreRelease = "Pre-Release Camp";

        // classifies a recovery score
        public static (string Status, string HousingUnit) Classify(int recoveryScore)
        {
            if (recoveryScore < 0 || recoveryScore > 100)
                throw new ArgumentOutOfRangeException(nameof(recoveryScore),recoveryScore, "Recovery score must be between 0 and 100.");

            if (recoveryScore < 20) return (StatusCritical, HousingIntensiveCare);
            if (recoveryScore < 40) return (StatusSerious, HousingHighDependency);
            if (recoveryScore < 60) return (StatusStable, HousingRecoveryWard);
            if (recoveryScore < 80) return (StatusRecovering, HousingOutdoor);
            return (StatusReleaseReady, HousingPreRelease);
        }
    }
}
