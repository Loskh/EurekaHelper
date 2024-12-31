using System.Collections.Generic;

namespace EurekaHelper.XIV;

public enum OldSoundEffect
{
    SoundEffect36 = 0x24,
    SoundEffect37 = 0x25,
    SoundEffect38 = 0x26,
    SoundEffect39 = 0x27,
    SoundEffect40 = 0x28,
    SoundEffect41 = 0x29,
    SoundEffect42 = 0x2A,
    SoundEffect43 = 0x2B,
    SoundEffect44 = 0x2C,
    SoundEffect45 = 0x2D,
    SoundEffect46 = 0x2E,
    SoundEffect47 = 0x2F,
    SoundEffect48 = 0x30,
    SoundEffect49 = 0x31,
    SoundEffect50 = 0x32,
    SoundEffect51 = 0x33,
    SoundEffect52 = 0x34
}
    
public enum ChatSoundEffect
{
    SoundEffect1 = 1,
    SoundEffect2 = 2,
    SoundEffect3 = 3,
    SoundEffect4 = 4,
    SoundEffect5 = 5,
    SoundEffect6 = 6,
    SoundEffect7 = 7,
    SoundEffect8 = 8,
    SoundEffect9 = 9,
    SoundEffect10 = 10,
    SoundEffect11 = 11,
    SoundEffect12 = 12,
    SoundEffect13 = 13,
    SoundEffect14 = 14,
    SoundEffect15 = 15,
    SoundEffect16 = 16,
}

public class SoundEffects
{
    public static ChatSoundEffect MapOldToNew(OldSoundEffect oldSoundEffect)
    {
        switch (oldSoundEffect)
        {
            case OldSoundEffect.SoundEffect36:
                return ChatSoundEffect.SoundEffect1;
            case OldSoundEffect.SoundEffect37:
                return ChatSoundEffect.SoundEffect2;
            case OldSoundEffect.SoundEffect38:
                return ChatSoundEffect.SoundEffect3;
            case OldSoundEffect.SoundEffect39:
                return ChatSoundEffect.SoundEffect4;
            case OldSoundEffect.SoundEffect40:
                return ChatSoundEffect.SoundEffect5;
            case OldSoundEffect.SoundEffect41:
                return ChatSoundEffect.SoundEffect6;
            case OldSoundEffect.SoundEffect42:
                return ChatSoundEffect.SoundEffect7;
            case OldSoundEffect.SoundEffect43:
                return ChatSoundEffect.SoundEffect8;
            case OldSoundEffect.SoundEffect44:
                return ChatSoundEffect.SoundEffect9;
            case OldSoundEffect.SoundEffect45:
                return ChatSoundEffect.SoundEffect10;
            case OldSoundEffect.SoundEffect46:
                return ChatSoundEffect.SoundEffect11;
            case OldSoundEffect.SoundEffect47:
                return ChatSoundEffect.SoundEffect12;
            case OldSoundEffect.SoundEffect48:
                return ChatSoundEffect.SoundEffect13;
            case OldSoundEffect.SoundEffect49:
                return ChatSoundEffect.SoundEffect14;
            case OldSoundEffect.SoundEffect50:
                return ChatSoundEffect.SoundEffect15;
            case OldSoundEffect.SoundEffect51:
                return ChatSoundEffect.SoundEffect16;
            case OldSoundEffect.SoundEffect52:
                return ChatSoundEffect.SoundEffect1;
            default:
                var soundEffectId = (uint)oldSoundEffect;
                if (soundEffectId is < 1 or > 16)
                {
                    return ChatSoundEffect.SoundEffect1;
                }

                return (ChatSoundEffect)soundEffectId;
        }
    }
}