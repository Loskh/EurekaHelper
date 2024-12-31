using System.Collections.Generic;
using EurekaHelper.XIV;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace EurekaHelper.System
{
    public static class SoundManager
    {
        public static void PlaySoundEffect(ChatSoundEffect soundEffect)
        {
            var soundEffectId = (uint)soundEffect;
            if (soundEffectId is < 1 or > 16)
            {
                soundEffect = ChatSoundEffect.SoundEffect1;
            }

            UIGlobals.PlayChatSoundEffect((uint)soundEffect);
        }
    }
}
