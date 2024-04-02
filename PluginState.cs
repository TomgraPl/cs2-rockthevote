namespace cs2_rockthevote
{
    public class PluginState : IPluginDependency<Plugin, Config>
    {
        public bool MapChangeScheduled { get; set; }
        public bool EofVoteHappening { get; set; }
        public Api Api { get; set; } = null!;

        public PluginState()
        {

        }

        public bool DisableCommands => MapChangeScheduled || EofVoteHappening;
        public void OnLoad(Plugin plugin) {
            Api = plugin.Api;
        }
        public void OnMapStart(string map)
        {
            MapChangeScheduled = false;
            EofVoteHappening = false;
        }

        public void RTVReached() {
            Api.RTVReached();
        }
        public void EndMapVote() {
            Api.EndMapVote();
        }
    }
}
