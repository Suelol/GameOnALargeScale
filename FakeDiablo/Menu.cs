using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDiablo
{
    public interface Menu
    {
         int Strength
        { get; set; }
         int Vitality
        { get; set; }
         int Inteligence
        { get; set; }
         int Dexterity
        { get; set; }
         int Health
        { get; set; }
         int MaxHealth
        { get; set; }
         int Mana
        { get; set; }
         int MaxMana
        { get; set; }
         int PDmg
        { get; set; }
         int Armor
        { get; set; }
         int MDmg
        { get; set; }
         int MDef
        { get; set; }
         int CrtChance
        { get; set; }
         int CrtDmg
        { get; set; }


   
    }
}
