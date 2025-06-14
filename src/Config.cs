using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

namespace MaxTeamPlayersOverride
{
    public class PluginConfig : BasePluginConfig
    {
        [JsonPropertyName("max_ts")]
        public int MaxTs { get; set; } = -1;

        [JsonPropertyName("max_cts")]
        public int MaxCTs { get; set; } = -1;
    }

    public partial class MaxTeamPlayersOverride : IPluginConfig<PluginConfig>
    {
        public PluginConfig Config { get; set; } = new PluginConfig();

        public void OnConfigParsed(PluginConfig? config)
        {
            if (config == null)
            {
                return;
            }

            Config = config;
        }
    }
}