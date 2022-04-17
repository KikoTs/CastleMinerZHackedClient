namespace CastleMod
{
    public class Init
    {
        public static LocalPlayer MSGHANDLER { get; private set; }

        public static void Load()
        {
            MSGHANDLER = new LocalPlayer();
            new Forms.MainUI().Show();
        }
    }
}