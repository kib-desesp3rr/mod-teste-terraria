using Terraria.ModLoader;

namespace AlemDosCeusOrigem;

public sealed class OriginMod : Mod
{
    internal static ModKeybind Meditate;
    internal static ModKeybind Journal;
    internal static ModKeybind[] Skills;
    public override void Load() {
        Meditate = KeybindLoader.RegisterKeybind(this, "Meditate", "V");
        Journal = KeybindLoader.RegisterKeybind(this, "Journal", "C");
        Skills = new[] {KeybindLoader.RegisterKeybind(this,"Palm","Z"),KeybindLoader.RegisterKeybind(this,"Wave","X"),KeybindLoader.RegisterKeybind(this,"Guard","G"),KeybindLoader.RegisterKeybind(this,"Step","N")};
    }
    public override void Unload() {Meditate = null;Journal=null;Skills=null;}
}
