using UnityEngine;
using System.Collections;
using EquipmentTypes;
public class EquipmentStats : UniqueID
{
    public Equipment e_type;
    public int sub_type;

    public string id;
    public string name;

    public int m_Level, m_Rare, m_RuneSlots, m_RunesEquiped;
    public float m_Attack, m_Dexterity, m_Defence, m_Speed, m_DOT;

    public void Build(int a_Level)
    {
        e_type  = (Equipment)Random.Range(0, 5);
        m_Level = a_Level;
        m_Rare  = Random.Range(1, 102);

        m_Attack = m_Dexterity = m_Defence = m_Speed = m_DOT = 0;   // Defaults stats to 0

        if (e_type == (Equipment.e_Weapon))         // Weapon
        {
            int r = Random.Range(0, 12);
            switch (r)
            {
                case  0: m_Attack = 4; m_Dexterity = 6; break; // Mace
                case  1: m_Attack = 6; m_Dexterity = 4; break; // Hammer
                case  2: m_Attack = 3; m_Dexterity = 7; break; // ShortBow
                case  3: m_Attack = 5; m_Dexterity = 5; break; // LongBow
                case  4: m_Attack = 7; m_Dexterity = 3; break; // CrossBow
                case  5: m_Attack = 4; m_Dexterity = 6; break; // Axe
                case  6: m_Attack = 2; m_Dexterity = 8; break; // Dagger
                case  7: m_Attack = 5; m_Dexterity = 5; break; // ShortSword
                case  8: m_Attack = 6; m_Dexterity = 4; break; // LongSword
                case  9: m_Attack = 8; m_Dexterity = 2; break; // 2-Hand
                case 10: m_Attack = 7; m_Dexterity = 3; break; // BattleAxe
                case 11: m_Attack = 9; m_Dexterity = 1; break; // WarHammer
            }
            sub_type = r;
            WeaponTypes a = (WeaponTypes)sub_type;
            name = a.ToString();
        }
        else if (e_type == (Equipment.e_Shield))    // Shield
        {
            int r = Random.Range(0, 6);
            switch (r)
            {
                case 0: m_Defence = 3; m_Speed = 7; break; // Wood
                case 1: m_Defence = 4; m_Speed = 6; break; // Round
                case 2: m_Defence = 5; m_Speed = 5; break; // Square
                case 3: m_Defence = 6; m_Speed = 4; break; // Heater
                case 4: m_Defence = 7; m_Speed = 3; break; // Tower
                case 5: m_Defence = 8; m_Speed = 2; break; // Battle
            }
            sub_type = r;
            ShieldTypes a = (ShieldTypes)sub_type;
            name = a.ToString();
        }
        else if (e_type == (Equipment.e_Armour))    // Armour
        {
            int r = Random.Range(0, 6);
            switch (r)
            {
                case 0: m_Defence = 3; m_Speed = 7; break; // Cloth
                case 1: m_Defence = 4; m_Speed = 6; break; // Leather
                case 2: m_Defence = 5; m_Speed = 5; break; // ChainMail
                case 3: m_Defence = 6; m_Speed = 4; break; // FullPlate
                case 4: m_Defence = 7; m_Speed = 3; break; // BattleArmour
                case 5: m_Defence = 7; m_Speed = 5; break; // DragonScale
            }
            sub_type = r;
            ArmourTypes a = (ArmourTypes)sub_type;
            name = a.ToString();
        }
        else if (e_type == (Equipment.e_Throw))     // Throw
        {
            int r = Random.Range(0, 2);
            switch (r)
            {
                case 0: m_Attack = 3; m_Dexterity = 7; break;   // Knife
                case 1: m_DOT = 3;    m_Dexterity = 5; break;   // Potion
            }
            sub_type = r;
            ThrowTypes a = (ThrowTypes)sub_type;
            name = a.ToString();
        }
        else if (e_type == (Equipment.e_Rune))      // Rune
        {
            if (m_Rare == 101)                      // EPIC
            {
                m_Attack    = 10;
                m_Dexterity = 10;
                m_Defence   = 10;
                m_Speed     = 10;
                m_DOT       = 10;
                sub_type    = 12;
            }
            else
            {
                int r = Random.Range(0, 12);
                switch (r)
                {
                    case  0: m_Attack    = 2; m_Speed = 2;  break; // Fire
                    case  1: m_Attack    = 5;               break; // Earth
                    case  2: m_Dexterity = 5;               break; // Water
                    case  3: m_Dexterity = 2; m_Speed = 3;  break; // Air
                    case  4: m_Attack    = 6;               break; // Explosion
                    case  5: m_Attack    = 4; m_DOT = 2;    break; // Ice
                    case  6: m_DOT       = 3;               break; // Toxic
                    case  7: m_Dexterity = 3; m_Speed = 2;  break; // Lightning
                    case  8: m_Attack    = 7;               break; // Attack
                    case  9: m_Dexterity = 7;               break; // Dexterity
                    case 10: m_Defence   = 7;               break; // Defence
                    case 11: m_Speed     = 7;               break; // Speed
                }
                sub_type = r;
            }
                
                RuneTypes a = (RuneTypes)sub_type;
                name = a.ToString();
        }
        else { sub_type = -1; } // Annoying little shit, but necessary

        if      (e_type == Equipment.e_Rune) m_RuneSlots = 0; // Can not equip runes to runes... yet
        else if (m_Rare == 101) m_RuneSlots = 5;    // EPIC
        else if (m_Rare >=  90) m_RuneSlots = 4;    // Legendary
        else if (m_Rare >=  75) m_RuneSlots = 3;    // Rare
        else if (m_Rare >=  50) m_RuneSlots = 2;    // Uncommon
        else if (m_Rare >=  10) m_RuneSlots = 1;    // Common
        else                    m_RuneSlots = 0;    // Lame
        
        m_RunesEquiped = 0;

        m_Attack    *= m_Level * m_Rare;
        m_Dexterity *= m_Level * m_Rare;
        m_Defence   *= m_Level * m_Rare;
        m_Speed     *= m_Level * m_Rare;
        m_DOT       *= m_Level * m_Rare;

       
        name = "Level " + m_Rare.ToString() + " " +  name.Replace("e_", "") + " " + e_type.ToString().Replace("e_", "");

        if (UniqueID.ID > 999999)
            id = UniqueID.ID.ToString();
        else if (UniqueID.ID > 99999)
            id = "0" + UniqueID.ID.ToString();
        else if (UniqueID.ID > 9999)
            id = "00" + UniqueID.ID.ToString();
        else if (UniqueID.ID > 999)
            id = "000" + UniqueID.ID.ToString();
        else if (UniqueID.ID > 99)
            id = "0000" + UniqueID.ID.ToString();
        else if (UniqueID.ID > 9)
            id = "00000" + UniqueID.ID.ToString();
        else
            id = "000000" + UniqueID.ID.ToString();

        UniqueID.ID++;
    }
}