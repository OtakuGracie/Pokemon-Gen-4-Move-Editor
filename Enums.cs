

namespace PokemonHGSSMoveEditor
{
    public enum Target
    {
        FOE_OR_ALLY = 0,
        OTHER = 1,
        RANDOM = 2,
        ALL_FOES = 4,
        OTHERS = 8,
        SELF = 16,
        SELF_AND_ALLY = 32,
        ALL = 64,
        FOE_SIDE = 128,
        ALLY = 256,
        SELF_OR_ALLY = 512,
        ANY_FOE = 1024
    }

    public enum Category
    {
        PHYSICAL,
        SPECIAL,
        STATUS
    }

    public enum ContestCondition
    {
        COOL,
        BEAUTIFUL,
        CUTE,
        SMART,
        TOUGH
    }

    public enum MoveDataType
    {
        EFFECT,
        POWER,
        ACCURACY,
        PP,
        EFFECTCHANCE,
        PRIORITY,
        CONTESTEFFECT
    }

    
}
