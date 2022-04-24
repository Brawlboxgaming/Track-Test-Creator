using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Xml;

namespace Track_Test_Creator
{
    public partial class Form1 : Form
    {
        private struct CupInfo
        {
            public string Track1Name;
            public string Track2Name;
            public string Track3Name;
            public string Track4Name;
            public string Track1BMG;
            public string Track2BMG;
            public string Track3BMG;
            public string Track4BMG;
            public int Track1Slot;
            public int Track2Slot;
            public int Track3Slot;
            public int Track4Slot;
            public int Track1Music;
            public int Track2Music;
            public int Track3Music;
            public int Track4Music;

            public CupInfo(string t1n, string t2n, string t3n, string t4n, string t1b, string t2b, string t3b, string t4b, int t1s, int t2s, int t3s, int t4s, int t1m, int t2m, int t3m, int t4m)
            {
                Track1Name = t1n;
                Track2Name = t2n;
                Track3Name = t3n;
                Track4Name = t4n;
                Track1BMG = t1b;
                Track2BMG = t2b;
                Track3BMG = t3b;
                Track4BMG = t4b;
                Track1Slot = t1s;
                Track2Slot = t2s;
                Track3Slot = t3s;
                Track4Slot = t4s;
                Track1Music = t1m;
                Track2Music = t2m;
                Track3Music = t3m;
                Track4Music = t4m;
            }
        }
        List<CupInfo> cups = new List<CupInfo>();
        readonly string[] courseStrings = new[] { "Luigi Circuit",
            "Moo Moo Meadows",
            "Mushroom Gorge",
            "Toad's Factory",
            "Mario Circuit",
            "Coconut Mall",
            "DK Summit",
            "Wario's Gold Mine",
            "Daisy Circuit",
            "Koopa Cape",
            "Maple Treeway",
            "Grumble Volcano",
            "Dry Dry Ruins",
            "Moonview Highway",
            "Bowser Castle",
            "Rainbow Road",
            "GCN Peach Beach",
            "DS Yoshi Falls",
            "SNES Ghost Valley 2",
            "N64 Mario Raceway",
            "N64 Sherbet Land",
            "GBA Shy Guy Beach",
            "DS Delfino Square",
            "GCN Waluigi Stadium",
            "DS Desert Hills",
            "GBA Bowser Castle 3",
            "N64 DK's Jungle Parkway",
            "GCN Mario Circuit",
            "SNES Mario Circuit 3",
            "DS Peach Gardens",
            "GCN DK Mountain",
            "N64 Bowser's Castle",
            "Block Plaza",
            "Delfino Pier",
            "Funky Stadium",
            "Chain Chomp Wheel",
            "Thwomp Desert",
            "SNES Battle Course 4",
            "GBA Battle Course 3",
            "N64 Skyscraper",
            "GCN Cookie Land",
            "DS Twilight House" };
        readonly string[] courseMusicIds = new[] { "117",
            "119",
            "121",
            "123",
            "125",
            "127",
            "129",
            "131",
            "135",
            "133",
            "143",
            "139",
            "137",
            "141",
            "145",
            "147",
            "165",
            "173",
            "151",
            "159",
            "157",
            "149",
            "175",
            "169",
            "177",
            "155",
            "161",
            "167",
            "153",
            "179",
            "171",
            "163",
            "33",
            "32",
            "35",
            "34",
            "36",
            "39",
            "40",
            "41",
            "37",
            "38", };
        readonly string[] courseSlotIds = new[] { "T11",
            "T12",
            "T13",
            "T14",
            "T21",
            "T22",
            "T23",
            "T24",
            "T31",
            "T32",
            "T33",
            "T34",
            "T41",
            "T42",
            "T43",
            "T44",
            "T51",
            "T52",
            "T53",
            "T54",
            "T61",
            "T62",
            "T63",
            "T64",
            "T71",
            "T72",
            "T73",
            "T74",
            "T81",
            "T82",
            "T83",
            "T84" };
        int currentCup = 1;
        public Form1()
        {
            cups.Add(new CupInfo("", "", "", "", "", "", "", "", 1, 1, 1, 1, 1, 1, 1, 1));
            InitializeComponent();
        }

        private void build_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"workdir/");
            Directory.CreateDirectory(@"workdir/input");
            Directory.CreateDirectory(@"workdir/output");
            if (Directory.Exists(@"output"))
                Directory.Delete(@"output", true);
            Directory.CreateDirectory(@"output/");
            Directory.CreateDirectory(@"output/CTTP");
            Directory.CreateDirectory(@"output/CTTP/rel");
            Directory.CreateDirectory(@"output/CTTP/Scene");
            Directory.CreateDirectory(@"output/CTTP/Scene/YourMom");
            StoreText();
            CreateConfig();
            EncodeFiles();
        }

        private void EncodeFiles()
        {
            foreach (var file in Directory.GetFiles(@"input/"))
            {
                File.Copy(file, $@"workdir/{file}", true);
            }

            File.WriteAllBytes("workdir/lecode-JAP.bin", Properties.Resources.lecode_JAP);
            File.WriteAllBytes("workdir/lecode-USA.bin", Properties.Resources.lecode_USA);
            File.WriteAllBytes("workdir/lecode-PAL.bin", Properties.Resources.lecode_PAL);

            File.WriteAllBytes("workdir/wszst.exe", Properties.Resources.wszst);
            File.WriteAllBytes("workdir/wlect.exe", Properties.Resources.wlect);
            File.WriteAllBytes("workdir/wbmgt.exe", Properties.Resources.wbmgt);

            File.WriteAllBytes("workdir/cygattr-1.dll", Properties.Resources.cygattr_1);
            File.WriteAllBytes("workdir/cygcrypto-1.1.dll", Properties.Resources.cygcrypto_1_1);
            File.WriteAllBytes("workdir/cygiconv-2.dll", Properties.Resources.cygiconv_2);
            File.WriteAllBytes("workdir/cygintl-8.dll", Properties.Resources.cygintl_8);
            File.WriteAllBytes("workdir/cygncursesw-10.dll", Properties.Resources.cygncursesw_10);
            File.WriteAllBytes("workdir/cygpcre-1.dll", Properties.Resources.cygpcre_1);
            File.WriteAllBytes("workdir/cygpng16-16.dll", Properties.Resources.cygpng16_16);
            File.WriteAllBytes("workdir/cygreadline7.dll", Properties.Resources.cygreadline7);
            File.WriteAllBytes("workdir/cygwin1.dll", Properties.Resources.cygwin1);
            File.WriteAllBytes("workdir/cygz.dll", Properties.Resources.cygz);

            File.WriteAllBytes("workdir/MenuSingle_E_reg.szs", Properties.Resources.MenuSingle_E_reg);
            File.WriteAllBytes("workdir/MenuSingle_E_mom.szs", Properties.Resources.MenuSingle_E_mom);

            var processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wszst.exe " + "extract MenuSingle_E_reg.szs";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            var process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wbmgt.exe " + "decode Common.bmg";
            processInfo.WorkingDirectory = @"workdir/MenuSingle_E_reg.d/message/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            StreamWriter sw = new StreamWriter(@"workdir\MenuSingle_E_reg.d\message\Common.txt", true);
            sw.WriteLine("\n\n#--- [7000:7fff] LE-CODE: track names");
            sw.WriteLine(@"  7000	= \c{blue1}Wii \c{off}Mario Circuit");
            sw.WriteLine(@"  7001	= \c{blue1}Wii \c{off}Moo Moo Meadows");
            sw.WriteLine(@"  7002	= \c{blue1}Wii \c{off}Mushroom Gorge");
            sw.WriteLine(@"  7003	= \c{blue1}Wii \c{off}Grumble Volcano");
            sw.WriteLine(@"  7004	= \c{blue1}Wii \c{off}Toad's Factory");
            sw.WriteLine(@"  7005	= \c{blue1}Wii \c{off}Coconut Mall");
            sw.WriteLine(@"  7006	= \c{blue1}Wii \c{off}DK's Snowboard Cross");
            sw.WriteLine(@"  7007	= \c{blue1}Wii \c{off}Wario's Gold Mine");
            sw.WriteLine(@"  7008	= \c{blue1}Wii \c{off}Luigi Circuit");
            sw.WriteLine(@"  7009	= \c{blue1}Wii \c{off}Daisy Circuit");
            sw.WriteLine(@"  700a	= \c{blue1}Wii \c{off}Moonview Highway");
            sw.WriteLine(@"  700b	= \c{blue1}Wii \c{off}Maple Treeway");
            sw.WriteLine(@"  700c	= \c{blue1}Wii \c{off}Bowser's Castle");
            sw.WriteLine(@"  700d	= \c{blue1}Wii \c{off}Rainbow Road");
            sw.WriteLine(@"  700e	= \c{blue1}Wii \c{off}Dry Dry Ruins");
            sw.WriteLine(@"  700f	= \c{blue1}Wii \c{off}Koopa Cape");
            sw.WriteLine(@"  7010	= \c{blue1}GCN \c{off}Peach Beach");
            sw.WriteLine(@"  7011	= \c{blue1}GCN \c{off}Mario Circuit");
            sw.WriteLine(@"  7012	= \c{blue1}GCN \c{off}Waluigi Stadium");
            sw.WriteLine(@"  7013	= \c{blue1}GCN \c{off}DK Mountain");
            sw.WriteLine(@"  7014	= \c{blue1}DS \c{off}Yoshi Falls");
            sw.WriteLine(@"  7015	= \c{blue1}DS \c{off}Desert Hills");
            sw.WriteLine(@"  7016	= \c{blue1}DS \c{off}Peach Gardens");
            sw.WriteLine(@"  7017	= \c{blue1}DS \c{off}Delfino Square");
            sw.WriteLine(@"  7018	= \c{blue1}SNES \c{off}Mario Circuit 3");
            sw.WriteLine(@"  7019	= \c{blue1}SNES \c{off}Ghost Valley 2");
            sw.WriteLine(@"  701a	= \c{blue1}N64 \c{off}Mario Raceway");
            sw.WriteLine(@"  701b	= \c{blue1}N64 \c{off}Sherbet Land");
            sw.WriteLine(@"  701c	= \c{blue1}N64 \c{off}Bowser's Castle");
            sw.WriteLine(@"  701d	= \c{blue1}N64 \c{off}DK's Jungle Parkway");
            sw.WriteLine(@"  701e	= \c{blue1}GBA \c{off}Bowser Castle 3");
            sw.WriteLine(@"  701f	= \c{blue1}GBA \c{off}Shy Guy Beach");
            sw.WriteLine(@"  7020	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7021	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7022	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7023	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7024	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7025	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7026	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7027	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7028	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7029	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  702a	/");
            sw.WriteLine(@"  702b	/");
            sw.WriteLine(@"  702c	/");
            sw.WriteLine(@"  702d	/");
            sw.WriteLine(@"  702e	/");
            sw.WriteLine(@"  702f	/");
            sw.WriteLine(@"  7030	/");
            sw.WriteLine(@"  7031	/");
            sw.WriteLine(@"  7032	/");
            sw.WriteLine(@"  7033	/");
            sw.WriteLine(@"  7034	/");
            sw.WriteLine(@"  7035	/");
            sw.WriteLine(@"  7036	= Ring Mission");
            sw.WriteLine(@"  7037	= Winningrun Demo");
            sw.WriteLine(@"  7038	= Loser Demo");
            sw.WriteLine(@"  7039	= Draw Demo");
            sw.WriteLine(@"  703a	= Ending Demo");
            sw.WriteLine(@"  703b	/");
            sw.WriteLine(@"  703c	/");
            sw.WriteLine(@"  703d	/");
            sw.WriteLine(@"  703e	/");
            sw.WriteLine(@"  703f	/");
            sw.WriteLine(@"  7040	/");
            sw.WriteLine(@"  7041	/");
            sw.WriteLine(@"  7042	/");
            sw.WriteLine(@"  7043	=  Wiimms SZS Toolset v2.25a r8443");
            for (int i = 0; i < cups.Count; i++)
            {
                sw.WriteLine($"  {28740 + i * 4:X}	= {cups[i].Track1BMG}");
                sw.WriteLine($"  {28741 + i * 4:X}	= {cups[i].Track2BMG}");
                sw.WriteLine($"  {28742 + i * 4:X}	= {cups[i].Track3BMG}");
                sw.WriteLine($"  {28743 + i * 4:X}	= {cups[i].Track4BMG}");
            }
            sw.WriteLine(@"");
            sw.WriteLine(@" 18697	/");
            sw.WriteLine(@" 18698	/");
            sw.WriteLine(@" 18699	/");
            sw.WriteLine(@" 1869a	/");
            sw.WriteLine(@" 1869b	/");
            sw.WriteLine(@" 1869c	/");
            sw.WriteLine(@" 1869d	/");
            sw.WriteLine(@" 1869e	/");
            sw.Close();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wbmgt.exe " + "encode Common.txt -o";
            processInfo.WorkingDirectory = @"workdir/MenuSingle_E_reg.d/message/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wszst.exe " + "create MenuSingle_E_reg.d -o";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wszst.exe " + "extract MenuSingle_E_mom.szs";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wbmgt.exe " + "decode Common.bmg";
            processInfo.WorkingDirectory = @"workdir/MenuSingle_E_mom.d/message/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            sw = new StreamWriter(@"workdir\MenuSingle_E_mom.d\message\Common.txt", true);
            sw.WriteLine("\n\n#--- [7000:7fff] LE-CODE: track names");
            sw.WriteLine(@"  7000	= \c{blue1}Wii \c{off}Mario Circuit");
            sw.WriteLine(@"  7001	= \c{blue1}Wii \c{off}Moo Moo Meadows");
            sw.WriteLine(@"  7002	= \c{blue1}Wii \c{off}Mushroom Gorge");
            sw.WriteLine(@"  7003	= \c{blue1}Wii \c{off}Grumble Volcano");
            sw.WriteLine(@"  7004	= \c{blue1}Wii \c{off}Toad's Factory");
            sw.WriteLine(@"  7005	= \c{blue1}Wii \c{off}Coconut Mall");
            sw.WriteLine(@"  7006	= \c{blue1}Wii \c{off}DK's Snowboard Cross");
            sw.WriteLine(@"  7007	= \c{blue1}Wii \c{off}Wario's Gold Mine");
            sw.WriteLine(@"  7008	= \c{blue1}Wii \c{off}Luigi Circuit");
            sw.WriteLine(@"  7009	= \c{blue1}Wii \c{off}Daisy Circuit");
            sw.WriteLine(@"  700a	= \c{blue1}Wii \c{off}Moonview Highway");
            sw.WriteLine(@"  700b	= \c{blue1}Wii \c{off}Maple Treeway");
            sw.WriteLine(@"  700c	= \c{blue1}Wii \c{off}Bowser's Castle");
            sw.WriteLine(@"  700d	= \c{blue1}Wii \c{off}Rainbow Road");
            sw.WriteLine(@"  700e	= \c{blue1}Wii \c{off}Dry Dry Ruins");
            sw.WriteLine(@"  700f	= \c{blue1}Wii \c{off}Koopa Cape");
            sw.WriteLine(@"  7010	= \c{blue1}GCN \c{off}Peach Beach");
            sw.WriteLine(@"  7011	= \c{blue1}GCN \c{off}Mario Circuit");
            sw.WriteLine(@"  7012	= \c{blue1}GCN \c{off}Waluigi Stadium");
            sw.WriteLine(@"  7013	= \c{blue1}GCN \c{off}DK Mountain");
            sw.WriteLine(@"  7014	= \c{blue1}DS \c{off}Yoshi Falls");
            sw.WriteLine(@"  7015	= \c{blue1}DS \c{off}Desert Hills");
            sw.WriteLine(@"  7016	= \c{blue1}DS \c{off}Peach Gardens");
            sw.WriteLine(@"  7017	= \c{blue1}DS \c{off}Delfino Square");
            sw.WriteLine(@"  7018	= \c{blue1}SNES \c{off}Mario Circuit 3");
            sw.WriteLine(@"  7019	= \c{blue1}SNES \c{off}Ghost Valley 2");
            sw.WriteLine(@"  701a	= \c{blue1}N64 \c{off}Mario Raceway");
            sw.WriteLine(@"  701b	= \c{blue1}N64 \c{off}Sherbet Land");
            sw.WriteLine(@"  701c	= \c{blue1}N64 \c{off}Bowser's Castle");
            sw.WriteLine(@"  701d	= \c{blue1}N64 \c{off}DK's Jungle Parkway");
            sw.WriteLine(@"  701e	= \c{blue1}GBA \c{off}Bowser Castle 3");
            sw.WriteLine(@"  701f	= \c{blue1}GBA \c{off}Shy Guy Beach");
            sw.WriteLine(@"  7020	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7021	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7022	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7023	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7024	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7025	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7026	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7027	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7028	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  7029	= \c{yor7}-----\c{off}");
            sw.WriteLine(@"  702a	/");
            sw.WriteLine(@"  702b	/");
            sw.WriteLine(@"  702c	/");
            sw.WriteLine(@"  702d	/");
            sw.WriteLine(@"  702e	/");
            sw.WriteLine(@"  702f	/");
            sw.WriteLine(@"  7030	/");
            sw.WriteLine(@"  7031	/");
            sw.WriteLine(@"  7032	/");
            sw.WriteLine(@"  7033	/");
            sw.WriteLine(@"  7034	/");
            sw.WriteLine(@"  7035	/");
            sw.WriteLine(@"  7036	= Ring Mission");
            sw.WriteLine(@"  7037	= Winningrun Demo");
            sw.WriteLine(@"  7038	= Loser Demo");
            sw.WriteLine(@"  7039	= Draw Demo");
            sw.WriteLine(@"  703a	= Ending Demo");
            sw.WriteLine(@"  703b	/");
            sw.WriteLine(@"  703c	/");
            sw.WriteLine(@"  703d	/");
            sw.WriteLine(@"  703e	/");
            sw.WriteLine(@"  703f	/");
            sw.WriteLine(@"  7040	/");
            sw.WriteLine(@"  7041	/");
            sw.WriteLine(@"  7042	/");
            sw.WriteLine(@"  7043	=  Wiimms SZS Toolset v2.25a r8443");
            for (int i = 0; i < cups.Count; i++)
            {
                sw.WriteLine($"  {28740 + i * 4:X}	= {cups[i].Track1BMG}");
                sw.WriteLine($"  {28741 + i * 4:X}	= {cups[i].Track2BMG}");
                sw.WriteLine($"  {28742 + i * 4:X}	= {cups[i].Track3BMG}");
                sw.WriteLine($"  {28743 + i * 4:X}	= {cups[i].Track4BMG}");
            }
            sw.WriteLine(@"");
            sw.WriteLine(@" 18697	/");
            sw.WriteLine(@" 18698	/");
            sw.WriteLine(@" 18699	/");
            sw.WriteLine(@" 1869a	/");
            sw.WriteLine(@" 1869b	/");
            sw.WriteLine(@" 1869c	/");
            sw.WriteLine(@" 1869d	/");
            sw.WriteLine(@" 1869e	/");
            sw.Close();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wbmgt.exe " + "encode Common.txt -o";
            processInfo.WorkingDirectory = @"workdir/MenuSingle_E_mom.d/message/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wszst.exe " + "create MenuSingle_E_mom.d -o";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wlect.exe " + "patch lecode-PAL.bin --le-define config.txt --custom-tt -o";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wlect.exe " + "patch lecode-USA.bin --le-define config.txt --custom-tt -o";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wlect.exe " + "patch lecode-JAP.bin --le-define config.txt --custom-tt -o";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wlect.exe " + "patch lecode-PAL.bin -od lecode-PAL.bin --le-define config.txt --track-dir output --copy-tracks input";
            processInfo.WorkingDirectory = @"workdir/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();
            process.WaitForExit();

            Directory.Move(@"workdir\output", @"output\CTTP\Course");
            File.Move(@"workdir\MenuSingle_E_reg.szs", @"output\CTTP\Scene\MenuSingle_E.szs");
            File.Move(@"workdir\MenuSingle_E_mom.szs", @"output\CTTP\Scene\YourMom\MenuSingle_E.szs");
            File.Move(@"workdir\lecode-PAL.bin", @"output\CTTP\rel\lecode-PAL.bin");
            File.Move(@"workdir\lecode-USA.bin", @"output\CTTP\rel\lecode-USA.bin");
            File.Move(@"workdir\lecode-JAP.bin", @"output\CTTP\rel\lecode-JAP.bin");
            Directory.Delete(@"workdir\", true);

            MessageBox.Show("Building Complete", "Complete");
        }

        private void CreateConfig()
        {
            string fileName = @"workdir/config.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("#CT-CODE\n\n");
                sw.WriteLine("[RACING-TRACK-LIST]\n");
                sw.WriteLine("%LE-FLAGS  = 1\n");
                sw.WriteLine("%WIIMM-CUP = 0\n");
                sw.WriteLine("N N$SWAP | N$F_WII");

                for (int i = 0; i < cups.Count; i++)
                {
                    sw.WriteLine($"\nC \"{i + 1}\" # {i + 12}");
                    sw.WriteLine($"T {courseMusicIds[Convert.ToInt32(cups[i].Track1Music) - 1]}; {courseSlotIds[Convert.ToInt32(cups[i].Track1Slot) - 1]}; 0x00; \"{cups[i].Track1Name}\"; \"{cups[i].Track1Name}\"; \"\"");
                    sw.WriteLine($"T {courseMusicIds[Convert.ToInt32(cups[i].Track2Music) - 1]}; {courseSlotIds[Convert.ToInt32(cups[i].Track2Slot) - 1]}; 0x00; \"{cups[i].Track2Name}\"; \"{cups[i].Track2Name}\"; \"\"");
                    sw.WriteLine($"T {courseMusicIds[Convert.ToInt32(cups[i].Track3Music) - 1]}; {courseSlotIds[Convert.ToInt32(cups[i].Track3Slot) - 1]}; 0x00; \"{cups[i].Track3Name}\"; \"{cups[i].Track3Name}\"; \"\"");
                    sw.WriteLine($"T {courseMusicIds[Convert.ToInt32(cups[i].Track4Music) - 1]}; {courseSlotIds[Convert.ToInt32(cups[i].Track4Slot) - 1]}; 0x00; \"{cups[i].Track4Name}\"; \"{cups[i].Track4Name}\"; \"\"");

                }
                sw.Close();
            }
        }

        private void StoreText()
        {
            cups[currentCup - 1] = new CupInfo(
                Track1Name.Text,
                Track2Name.Text,
                Track3Name.Text,
                Track4Name.Text,
                Track1BMG.Text,
                Track2BMG.Text,
                Track3BMG.Text,
                Track4BMG.Text,
                decimal.ToInt32(Track1Slot.Value),
                decimal.ToInt32(Track2Slot.Value),
                decimal.ToInt32(Track3Slot.Value),
                decimal.ToInt32(Track4Slot.Value),
                decimal.ToInt32(Track1Music.Value),
                decimal.ToInt32(Track2Music.Value),
                decimal.ToInt32(Track3Music.Value),
                decimal.ToInt32(Track4Music.Value));
        }

        private void SetText()
        {
            Track1Name.Text = cups[currentCup - 1].Track1Name;
            Track2Name.Text = cups[currentCup - 1].Track2Name;
            Track3Name.Text = cups[currentCup - 1].Track3Name;
            Track4Name.Text = cups[currentCup - 1].Track4Name;
            Track1BMG.Text = cups[currentCup - 1].Track1BMG;
            Track2BMG.Text = cups[currentCup - 1].Track2BMG;
            Track3BMG.Text = cups[currentCup - 1].Track3BMG;
            Track4BMG.Text = cups[currentCup - 1].Track4BMG;
            Track1Slot.Value = cups[currentCup - 1].Track1Slot;
            Track2Slot.Value = cups[currentCup - 1].Track2Slot;
            Track3Slot.Value = cups[currentCup - 1].Track3Slot;
            Track4Slot.Value = cups[currentCup - 1].Track4Slot;
            Track1Music.Value = cups[currentCup - 1].Track1Music;
            Track2Music.Value = cups[currentCup - 1].Track2Music;
            Track3Music.Value = cups[currentCup - 1].Track3Music;
            Track4Music.Value = cups[currentCup - 1].Track4Music;
            cupLabel.Text = $"Cup {currentCup}";
            cupInput.Value = cups.Count;
        }

        private void cupInput_ValueChanged(object sender, EventArgs e)
        {
            while (cupInput.Value > cups.Count)
            {
                cups.Add(new CupInfo("", "", "", "", "", "", "", "", 1, 1, 1, 1, 1, 1, 1, 1));
            }
            while (cupInput.Value < cups.Count)
            {
                cups.RemoveAt(cups.Count - 1);
            }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            StoreText();
            if (currentCup > 1)
                currentCup--;
            else currentCup = cups.Count;
            SetText();
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            StoreText();
            if (currentCup < cups.Count)
                currentCup++;
            else currentCup = 1;
            SetText();
        }

        private void import_Click(object sender, EventArgs e)
        {
            StoreText();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;
            dialog.Multiselect = false;
            dialog.Title = "Import";
            dialog.Filters.Add(new CommonFileDialogFilter("JSON Files", ".json"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var jsonString = File.ReadAllText(dialog.FileName);
                cups = JsonConvert.DeserializeObject<List<CupInfo>>(jsonString);
                currentCup = 1;
                SetText();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            StoreText();
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.Title = "Export";
            dialog.AlwaysAppendDefaultExtension = true;
            dialog.DefaultExtension = ".json";
            dialog.Filters.Add(new CommonFileDialogFilter("JSON Files", ".json"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string jsonString = JsonConvert.SerializeObject(cups);
                File.WriteAllText(dialog.FileName, jsonString);
            }
        }

        private void Track1Slot_ValueChanged(object sender, EventArgs e)
        {
            Slot1Label.Text = courseStrings[(int)Track1Slot.Value - 1];
        }

        private void Track1Music_ValueChanged(object sender, EventArgs e)
        {
            Music1Label.Text = courseStrings[(int)Track1Music.Value - 1];
        }

        private void Track2Slot_ValueChanged(object sender, EventArgs e)
        {
            Slot2Label.Text = courseStrings[(int)Track2Slot.Value - 1];
        }

        private void Track2Music_ValueChanged(object sender, EventArgs e)
        {
            Music2Label.Text = courseStrings[(int)Track2Music.Value - 1];
        }

        private void Track3Slot_ValueChanged(object sender, EventArgs e)
        {
            Slot3Label.Text = courseStrings[(int)Track3Slot.Value - 1];
        }

        private void Track3Music_ValueChanged(object sender, EventArgs e)
        {
            Music3Label.Text = courseStrings[(int)Track3Music.Value - 1];
        }

        private void Track4Slot_ValueChanged(object sender, EventArgs e)
        {
            Slot4Label.Text = courseStrings[(int)Track4Slot.Value - 1];
        }

        private void Track4Music_ValueChanged(object sender, EventArgs e)
        {
            Music4Label.Text = courseStrings[(int)Track4Music.Value - 1];
        }
    }
}