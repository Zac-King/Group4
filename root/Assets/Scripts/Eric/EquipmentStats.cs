using UnityEngine;
using System.Collections;
using EquipmentTypes;
public class EquipmentStats : UniqueID, IPickup
{
    public int sub_type;

    public string id;
    public string name;

    public int m_Level, m_Rare;
    public float m_Attack, m_Dexterity, m_Defence, m_Speed, m_DOT;

    public void Start()
    {
        Build();
    }
    public void Build()
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

        m_Level = 1;
        m_Rare = 1;

        m_Attack    *= m_Level * m_Rare;
        m_Dexterity *= m_Level * m_Rare;
        m_Defence   *= m_Level * m_Rare;
        m_Speed     *= m_Level * m_Rare;
        m_DOT       *= m_Level * m_Rare;

        name = "Level " + m_Rare.ToString() + " " +  name.Replace("e_", "");
        this.gameObject.name = name;

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
    public void PickUp()
    {
        gameObject.SetActive(false);
    }

    public void Drop()
    {

    }
}