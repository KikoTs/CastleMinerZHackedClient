using DNA.CastleMinerZ.Net;

namespace CastleMod
{
    internal class Hooks
    {
        public static void PreventPlayerJoin(bool state)
        {
            if (state)
            {
                GameWorld.instance.CurrentNetworkSession.GamerJoined += CurrentNetworkSession_GamerJoined;
            }
            else
            {
                GameWorld.instance.CurrentNetworkSession.GamerJoined -= CurrentNetworkSession_GamerJoined;
            }
        }

        private static void CurrentNetworkSession_GamerJoined(object sender, DNA.Net.GamerServices.GamerJoinedEventArgs e)
        {
            if (e.Gamer.Gamertag != GameWorld.instance.MyNetworkGamer.Gamertag)
            {
                KickMessage.Send(GameWorld.instance.MyNetworkGamer, e.Gamer, true);
            }
        }
    }
}