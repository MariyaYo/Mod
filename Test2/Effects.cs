
using System.Collections.Generic;

namespace Test2
{
    public static class Effects
    {

        public struct EffectInfo
        {
            public readonly string effectName;
            public readonly EffectCategory effectCategory;
            public readonly string effectId;
            public readonly bool isEnabled;
            public readonly EffectLengthType effectLenghtType;


            public EffectInfo(string effectName, EffectCategory effectCategory, string effectId, EffectLengthType effectLenghtType, bool isEnabled = true)
            {
                this.effectName = effectName;
                this.effectCategory = effectCategory;
                this.effectId = effectId;
                this.isEnabled = isEnabled;
                this.effectLenghtType = effectLenghtType;
            }
        }


        public enum EffectCategory
        {
            PLAYER,
            ENEMIES,
            BOSSES,
            MISC,
            META
        }

        public enum EffectLengthType
        {
            TIMED_LONG,
            TIMED_NORMAL,
            TIMED_SHORT,
            INSTANT
        }


        public enum EffectType
        {
            EFFECT_PLAYER_CURSE_PLAYER,
            EFFECT_PLAYER_POSION_PLAYER,
            EFFECT_PLAYER_FROSTBITE_PLAYER,
            EFFECT_PLAYER_BLEED_PLAYER,
            EFFECT_PLAYER_TOXIC_PLAYER,
            EFFECT_PLAYER_HOLLOW,
            EFFECT_PLAYER_REVERSE_HOLLOW,
            EFFECT_PLAYER_DISABLE_JUPING,
            EFFECT_PLAYER_DISABLE_RUN,
            EFFECT_PLAYER_DISABLE_ROLL,
            EFFECT_PLAYER_DISABLE_W_ANS_S_KEYS,
            EFFECT_PLAYER_I_AM_BROKE,
            EFFECT_PLAYER_I_AM_RICH,
            EFFECT_PLAYER_SPAWN_A_FRIEND,
            EFFECT_PLAYER_APPLY_CHARCOAL_PINE_RESIN,
            EFFECT_PLAYER_APPLY_ROTTEN_PINE_RESIN,
            EFFECT_PLAYER_APPLY_GOLD_PINE_RESIN,
            EFFECT_ENEMIES_DIE_FROM_ONE_HIT,
            EFFECT_ENEMIES_KILL_PLAYER_WITH_ONE_HIT,
            EFFECT_ENEMIES_DOUBLE_ENEMIES,
            EFFECT_ENEMIES_DIE,
            EFFECT_BOSSES_SPAWN_GUNDYR,
            EFFECT_MISC_FOGGY_WEATHER,
            EFFECT_MISC_ROLL_CREDITS,
            EFFECT_MISC_GRAY_FILETER,
            EFFECT_META_TIMER_SPEED_X2,
            EFFECT_META_TIMER_SPEED_X5,
            EFFECT_META_TIMER_SPEED_X0_5,
            EFFECT_META_EFFECT_DURATION_X2,
            EFFECT_META_EFFECT_DURATION_X0_5,
            EFFECT_META_HIDE_UI
        }

        public static readonly Dictionary<EffectType, EffectInfo> EffectsMap = new Dictionary<EffectType, EffectInfo>()
        {
            {EffectType.EFFECT_PLAYER_CURSE_PLAYER, new EffectInfo("Curse me", EffectCategory.PLAYER, "player_curse", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_POSION_PLAYER, new EffectInfo("Poison me", EffectCategory.PLAYER, "player_poison", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_FROSTBITE_PLAYER, new EffectInfo("Frostbite me", EffectCategory.PLAYER, "player_frostbite", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_BLEED_PLAYER, new EffectInfo("Bleed me", EffectCategory.PLAYER, "player_bleed", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_TOXIC_PLAYER, new EffectInfo("Toxic me", EffectCategory.PLAYER, "player_toxic", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_HOLLOW, new EffectInfo("Hollow me", EffectCategory.PLAYER, "player_hollow", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_REVERSE_HOLLOW, new EffectInfo("Human me?", EffectCategory.PLAYER, "player_reverse_hollow", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_DISABLE_JUPING, new EffectInfo("Jumping is hard", EffectCategory.PLAYER, "player_disable_jump", EffectLengthType.TIMED_SHORT)},
            {EffectType.EFFECT_PLAYER_DISABLE_RUN, new EffectInfo("No Sprint", EffectCategory.PLAYER,"player_disable_run", EffectLengthType.TIMED_SHORT)},
            {EffectType.EFFECT_PLAYER_DISABLE_ROLL, new EffectInfo("We can't roll", EffectCategory.PLAYER, "player_disable_roll",EffectLengthType.TIMED_SHORT)},
            {EffectType.EFFECT_PLAYER_DISABLE_W_ANS_S_KEYS, new EffectInfo("Can't go back or forward", EffectCategory.PLAYER, "player_reverse_hollow", EffectLengthType.TIMED_SHORT)},
            {EffectType.EFFECT_PLAYER_I_AM_BROKE, new EffectInfo("I'm broke", EffectCategory.PLAYER, "player_broke", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_I_AM_RICH, new EffectInfo("Money Rain", EffectCategory.PLAYER, "player_rich", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_SPAWN_A_FRIEND, new EffectInfo("Spawn a friend", EffectCategory.PLAYER, "player_spawn_friend", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_APPLY_CHARCOAL_PINE_RESIN, new EffectInfo("Charcoal pine", EffectCategory.PLAYER, "player_charcoal_pine", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_APPLY_ROTTEN_PINE_RESIN, new EffectInfo("Rotten pine", EffectCategory.PLAYER, "player_rotten_pine", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_PLAYER_APPLY_GOLD_PINE_RESIN, new EffectInfo("Gold pine", EffectCategory.PLAYER, "[layer_gold_pine", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_ENEMIES_DIE_FROM_ONE_HIT, new EffectInfo("One punch man", EffectCategory.ENEMIES, "enemies_everuthing_dies_from_one_hit", EffectLengthType.TIMED_LONG)},
            {EffectType.EFFECT_ENEMIES_KILL_PLAYER_WITH_ONE_HIT, new EffectInfo("One hit KO", EffectCategory.ENEMIES, "enemies_one_hit_ko", EffectLengthType.TIMED_LONG)},
            {EffectType.EFFECT_ENEMIES_DOUBLE_ENEMIES, new EffectInfo("We replicate at a rapid speed", EffectCategory.ENEMIES, "enemies_double_enemies", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_ENEMIES_DIE, new EffectInfo("Kill everithing", EffectCategory.ENEMIES, "enemies_kill_everithing", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_BOSSES_SPAWN_GUNDYR, new EffectInfo("Spawn Gundyr", EffectCategory.BOSSES, "boss_spawn_gundyr", EffectLengthType.INSTANT)},
            {EffectType.EFFECT_MISC_FOGGY_WEATHER, new EffectInfo("Foggy weather", EffectCategory.MISC, "misc_forry_weather", EffectLengthType.TIMED_LONG)},
            {EffectType.EFFECT_MISC_ROLL_CREDITS, new EffectInfo("Roll credits", EffectCategory.MISC, "misc_roll_credits", EffectLengthType.TIMED_NORMAL)},
            {EffectType.EFFECT_MISC_GRAY_FILETER, new EffectInfo("Gray filter", EffectCategory.MISC, "misc_gray_filter", EffectLengthType.TIMED_LONG)},
            {EffectType.EFFECT_META_TIMER_SPEED_X0_5, new EffectInfo("0.5x Timer Speed", EffectCategory.META, "meta_timerspeed_0_5x", EffectLengthType.TIMED_NORMAL)},
            {EffectType.EFFECT_META_TIMER_SPEED_X2, new EffectInfo("2x Timer Speed", EffectCategory.META, "meta_timerspeed_2x", EffectLengthType.TIMED_NORMAL)},
            {EffectType.EFFECT_META_TIMER_SPEED_X5, new EffectInfo("5x Timer Speed", EffectCategory.META, "meta_timerspeed_5x", EffectLengthType.TIMED_NORMAL)},
            {EffectType.EFFECT_META_EFFECT_DURATION_X2, new EffectInfo("2x Effect Duration", EffectCategory.META, "meta_effect_duration_2x", EffectLengthType.TIMED_NORMAL)},
            {EffectType.EFFECT_META_EFFECT_DURATION_X0_5, new EffectInfo("0.5x Effect Duration", EffectCategory.META, "meta_effect_duration_0_5x", EffectLengthType.TIMED_NORMAL)},
            {EffectType.EFFECT_META_HIDE_UI, new EffectInfo("What's Happening??", EffectCategory.META, "meta_hide_chaos_ui", EffectLengthType.TIMED_NORMAL)}
        };

    }
}