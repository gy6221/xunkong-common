﻿namespace Xunkong.GenshinData.Text;

[Flags]
public enum TextMapType
{

    None = 0,

    CharacterName = 0x01,

    CharacterOthers = 0x02,

    Constellation = 0x04,

    Talent = 0x08,

    WeaponName = 0x10,

    WeaponOthers = 0x20,

    WeaponSkill = 0x40,

    Readable = 0x100,

}
