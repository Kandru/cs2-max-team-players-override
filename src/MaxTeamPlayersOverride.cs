using System.Text.Json.Serialization;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace MaxTeamPlayersOverride;

public class PluginConfig : BasePluginConfig
{
    [JsonPropertyName("max_ts")]
    public int MaxTs { get; set; } = -1;
    
    [JsonPropertyName("max_cts")]
    public int MaxCTs { get; set; } = -1;
}

public partial class MaxTeamPlayersOverride : BasePlugin, IPluginConfig<PluginConfig>
{
    public override string ModuleName => "Max Team Players Override Plugin";

    public PluginConfig Config { get; set; }
    
    public void OnConfigParsed(PluginConfig? config)
    {
        if (config == null) return;
        Config = config;
    }
    
    public override void Load(bool hotReload)
    {
        RegisterEventHandler<EventRoundStart>((_, _) =>
        {
            var maxTs = Config.MaxTs;
            var maxCTs = Config.MaxCTs;

            if (maxTs < 0)
            {
                maxTs = Server.MaxPlayers / 2;
            }
            if (maxCTs < 0)
            {
                maxCTs = Server.MaxPlayers / 2;
            }
            
            SetMaxTs(maxTs);
            SetMaxCTs(maxCTs);
            
            return HookResult.Continue;
        });
    }
    
    private void SetMaxTs(int num)
    {
        var ents = Utilities.FindAllEntitiesByDesignerName<CCSGameRulesProxy>("cs_gamerules");
        foreach (var ent in ents)
        {
            ent.GameRules!.NumSpawnableTerrorist = num;
            ent.GameRules.MaxNumTerrorists = num;
        }
    }

    private void SetMaxCTs(int num)
    {
        var ents = Utilities.FindAllEntitiesByDesignerName<CCSGameRulesProxy>("cs_gamerules");
        foreach (var ent in ents)
        {
            ent.GameRules!.NumSpawnableCT = num;
            ent.GameRules.MaxNumCTs = num;
        }
    }
}