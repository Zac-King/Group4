using UnityEngine;
using System.Collections;

namespace EquipmentTypes
{
    public enum Equipment
    {
        e_Weapon,
        e_Shield,
        e_Armour,
        e_Throw,
        e_Rune,
    }

    // Sorted by weapon classes
    public enum WeaponTypes
    {
        e_Mace, e_Hammer,                                   // 1-handed blunt weapons
        e_ShortBow, e_LongBow, e_CrossBow,                  // Ranged weapons
        e_Axe, e_Dagger, e_ShortSword, e_LongSword,         // 1-handed edged weapons
        e_2Hand, e_BattleAxe, e_WarHammer,                  // 2-handed great weapons
    }

    // Sorted by defence strength (low-high)
    public enum ShieldTypes
    {
        e_Wood,
        e_Round,
        e_Square,
        e_Heater,
        e_Tower,
        e_Battle,
    }

    // Sorted by defence strength (low-high)
    public enum ArmourTypes
    {
        e_Cloth,
        e_Leather,
        e_ChainMail,
        e_FullPlate,
        e_BattleArmour,
        e_DragonScale,
    }

    public enum ThrowTypes
    {
        e_Knife,
        e_Potion,
    }

    public enum RuneTypes
    {
        e_Fire, e_Earth, e_Water, e_Air,                    // 4 basic elements
        e_Explosian, e_Ice, e_Toxic, e_Lightning,           // Sub-elements
        e_Attack, e_Dexterity, e_Defence, e_Speed,          // Boost weapons stats by a % amount
        e_EPIC,                                             // Rarest rune type. Combines all other effects + self-healing into 1 rune
    }
}