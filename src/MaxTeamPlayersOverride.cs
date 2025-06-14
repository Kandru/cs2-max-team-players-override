using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace MaxTeamPlayersOverride
{
    public partial class MaxTeamPlayersOverride : BasePlugin
    {
        public override string ModuleName => "Max Team Players Override Plugin";

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventRoundStart>((_, _) =>
            {
                int maxTs = Config.MaxTs;
                int maxCTs = Config.MaxCTs;

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

        private static void SetMaxTs(int num)
        {
            IEnumerable<CCSGameRulesProxy> ents = Utilities.FindAllEntitiesByDesignerName<CCSGameRulesProxy>("cs_gamerules");
            foreach (CCSGameRulesProxy ent in ents)
            {
                ent.GameRules!.NumSpawnableTerrorist = num;
                ent.GameRules.MaxNumTerrorists = num;
            }
        }

        private static void SetMaxCTs(int num)
        {
            IEnumerable<CCSGameRulesProxy> ents = Utilities.FindAllEntitiesByDesignerName<CCSGameRulesProxy>("cs_gamerules");
            foreach (CCSGameRulesProxy ent in ents)
            {
                ent.GameRules!.NumSpawnableCT = num;
                ent.GameRules.MaxNumCTs = num;
            }
        }
    }
}