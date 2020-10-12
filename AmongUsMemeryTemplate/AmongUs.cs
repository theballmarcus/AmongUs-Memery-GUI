
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HamsterCheese.AmongUsMemory;

namespace AmongUsMemeryTemplate
{
    class Globals
    {
        public static float speed;
        public static float killTimer;
        public static byte clientImposter;
        public static byte clientDead;

        public static bool updateSpeed;
        public static bool updateKillTimer;
        public static bool updateClientImposter;
        public static bool updateClientDead;

        public static bool running;
        public static string[] imposters = new string[] { };
    }
    class Handler
    {
        static int tableWidth = 75;

        static List<PlayerData> playerDatas = new List<PlayerData>();
        static List<PlayerPhysics> playerPhysics = new List<PlayerPhysics>();
        static void UpdateCheat()
        {
            while (Globals.running)
            {
                //Console.Clear();
                Console.WriteLine("Test Read Player Datas..");
                PrintRow("offset", "Name", "OwnerId", "PlayerId", "spawnid", "spawnflag");
                PrintLine();
                foreach (var data in playerDatas)
                {
                    var Name = HamsterCheese.AmongUsMemory.Utils.ReadString(data.PlayerInfo.Value.PlayerName);
                    if(data.IsLocalPlayer)
                    {
                        if (Globals.updateSpeed)
                        {
                            data.WriteMemory_Speed(Globals.speed);
                            Globals.updateSpeed = false;
                        }
                        if (Globals.updateKillTimer)
                        {
                            data.WriteMemory_KillTimer(Globals.killTimer);
                            Globals.updateKillTimer = false;
                        }
                        if (Globals.updateClientImposter)
                        {
                            data.WriteMemory_Impostor(Globals.clientImposter);
                            Globals.updateClientImposter = false;
                        }
                        if (Globals.updateClientDead)
                        {
                            data.WriteMemory_IsDead(Globals.clientDead);
                            Globals.updateClientDead = false;
                        }
                    }

                    if (data.IsLocalPlayer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        data.WriteMemory_SetNameTextColor(new Color(0, 1, 0, 1));
                    }
                    Console.WriteLine();
                    PrintRow($"{(data.IsLocalPlayer == true ? "Me->" : "")}{data.PlayerControllPTROffset}", $"{Name}", $"{data.Instance.OwnerId}", $"{data.Instance.PlayerId}", $"{data.Instance.SpawnId}", $"{data.Instance.SpawnFlags}");
                    Console.ForegroundColor = ConsoleColor.White;

                    PrintLine();
                }
                Console.WriteLine("The imposter is: ");
                Console.WriteLine("[{0}]", string.Join(", ", Globals.imposters));
                Console.Write(Globals.updateClientImposter);
                System.Threading.Thread.Sleep(1000);
            }
        }
       public static void Init()
        {
            // Cheat Init
            if (HamsterCheese.AmongUsMemory.Cheese.Init())
            {
                // Update Player Data When Every Game
                HamsterCheese.AmongUsMemory.Cheese.ObserveShipStatus((x) =>
                {
                    //stop observe state for init. 
                    foreach (var player in playerDatas) { 
                        player.StopObserveState();
                    }

                    playerDatas = HamsterCheese.AmongUsMemory.Cheese.GetAllPlayers();

                    foreach (var player in playerDatas)
                    {
                        player.onDie += (pos, colorId) => {
                            Console.WriteLine("OnPlayerDied! Color ID :" + colorId);
                        };

                        if (player.PlayerInfo.Value.IsImpostor == 1)
                        {
                            Array.Resize(ref Globals.imposters, Globals.imposters.Length + 1);
                            Globals.imposters[Globals.imposters.Length - 1] = HamsterCheese.AmongUsMemory.Utils.ReadString(player.PlayerInfo.Value.PlayerName);
                        }
                        // player state check
                        player.StartObserveState();
                    }
                });

                // Cheat Logic
                CancellationTokenSource cts = new CancellationTokenSource();
                Task.Factory.StartNew(
                    UpdateCheat
                , cts.Token);
            }

            System.Threading.Thread.Sleep(1000000);
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);


        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}