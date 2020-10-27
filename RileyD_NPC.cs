using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RileyD_NPC {

    string name;
    RileyD_Weapon weapon;

    // Constructor
    public RileyD_NPC (string n, RileyD_Weapon w)
    {
        name = n;
        weapon = w;
    }

    // Properties
    public string Name
    {
        get { return name; }
    }

    public RileyD_Weapon Weapon
    {
        get { return weapon; }
    }

}
