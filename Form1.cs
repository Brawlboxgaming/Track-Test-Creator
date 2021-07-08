using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_Test_Creator
{
    public partial class Form1 : Form
    {
        readonly string[] course = new[] { "LC", "MMM", "MG", "TF", "MC", "CM", "DKS", "WGM", "DC", "KC", "MT", "GV", "DDR", "MH", "BC", "RR", "gPB", "dYF", "sGV2", "nMR", "nSL", "gSGB", "dDS", "gWS", "dDH", "gBC3", "nDKJP", "gMC", "sMC3", "dPG", "gDKM", "nBC" };

        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void build_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"workdir/");
            Directory.CreateDirectory(@"workdir/input");
            Directory.CreateDirectory(@"workdir/output");
            if (Directory.Exists(@"output"))
                Directory.Delete(@"output", true);
            Directory.CreateDirectory(@"output/");
            Directory.CreateDirectory(@"output/boot");
            Directory.CreateDirectory(@"output/scene");
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

            File.WriteAllBytes("workdir/MenuSingle_E.szs", Properties.Resources.MenuSingle_E);

            var processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wszst.exe " + "extract MenuSingle_E.szs";
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
            processInfo.WorkingDirectory = @"workdir/MenuSingle_E.d/message/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            StreamWriter sw = new StreamWriter(@"workdir\MenuSingle_E.d\message\Common.txt", true);
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
            sw.WriteLine($"  7044	= {cup1Track1BMG.Text}");
            sw.WriteLine($"  7045	= {cup1Track2BMG.Text}");
            sw.WriteLine($"  7046	= {cup1Track3BMG.Text}");
            sw.WriteLine($"  7047	= {cup1Track4BMG.Text}");
            if (cupInput.Value > 1)
            {
                sw.WriteLine($"  7048	= {cup2Track1BMG.Text}");
                sw.WriteLine($"  7049	= {cup2Track2BMG.Text}");
                sw.WriteLine($"  704a	= {cup2Track3BMG.Text}");
                sw.WriteLine($"  704b	= {cup2Track4BMG.Text}");
            }

            if (cupInput.Value > 2)
            {
                sw.WriteLine($"  704c	= {cup3Track1BMG.Text}");
                sw.WriteLine($"  704d	= {cup3Track2BMG.Text}");
                sw.WriteLine($"  704e	= {cup3Track3BMG.Text}");
                sw.WriteLine($"  704f	= {cup3Track4BMG.Text}");
            }

            if (cupInput.Value > 3)
            {
                sw.WriteLine($"  7050	= {cup4Track1BMG.Text}");
                sw.WriteLine($"  7051	= {cup4Track2BMG.Text}");
                sw.WriteLine($"  7052	= {cup4Track3BMG.Text}");
                sw.WriteLine($"  7053	= {cup4Track4BMG.Text}");
            }

            if (cupInput.Value > 4)
            {
                sw.WriteLine($"  7054	= {cup5Track1BMG.Text}");
                sw.WriteLine($"  7055	= {cup5Track2BMG.Text}");
                sw.WriteLine($"  7056	= {cup5Track3BMG.Text}");
                sw.WriteLine($"  7057	= {cup5Track4BMG.Text}");
            }

            if (cupInput.Value > 5)
            {
                sw.WriteLine($"  7058	= {cup6Track1BMG.Text}");
                sw.WriteLine($"  7059	= {cup6Track2BMG.Text}");
                sw.WriteLine($"  705a	= {cup6Track3BMG.Text}");
                sw.WriteLine($"  705b	= {cup6Track4BMG.Text}");
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
            processInfo.WorkingDirectory = @"workdir/MenuSingle_E.d/message/";
            processInfo.CreateNoWindow = true;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            processInfo = new ProcessStartInfo();
            processInfo.FileName = @"cmd.exe";
            processInfo.Arguments = "/C wszst.exe " + "create MenuSingle_E.d -o";
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

            process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            Directory.Move(@"workdir\output", @"output\course");
            File.Move(@"workdir\MenuSingle_E.szs", @"output\scene\MenuSingle_E.szs");
            File.Move(@"workdir\lecode-PAL.bin", @"output\boot\lecode-PAL.bin");
            File.Move(@"workdir\lecode-USA.bin", @"output\boot\lecode-USA.bin");
            File.Move(@"workdir\lecode-JAP.bin", @"output\boot\lecode-JAP.bin");
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

                sw.WriteLine("\nC \"1\" # 12");
                sw.WriteLine($"T {course[Convert.ToInt32(cup1Track1Slot.Value) - 1]}; {course[Convert.ToInt32(cup1Track1Slot.Value) - 1]}; 0x00; \"{cup1Track1Name.Text}\"; \"{cup1Track1Name.Text}\"; \"\"");
                sw.WriteLine($"T {course[Convert.ToInt32(cup1Track2Slot.Value) - 1]}; {course[Convert.ToInt32(cup1Track2Slot.Value) - 1]}; 0x00; \"{cup1Track2Name.Text}\"; \"{cup1Track2Name.Text}\"; \"\"");
                sw.WriteLine($"T {course[Convert.ToInt32(cup1Track3Slot.Value) - 1]}; {course[Convert.ToInt32(cup1Track3Slot.Value) - 1]}; 0x00; \"{cup1Track3Name.Text}\"; \"{cup1Track3Name.Text}\"; \"\"");
                sw.WriteLine($"T {course[Convert.ToInt32(cup1Track4Slot.Value) - 1]}; {course[Convert.ToInt32(cup1Track4Slot.Value) - 1]}; 0x00; \"{cup1Track4Name.Text}\"; \"{cup1Track4Name.Text}\"; \"\"");

                if (cupInput.Value > 1)
                {
                    sw.WriteLine("\nC \"2\" # 13");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup2Track1Slot.Value) - 1]}; {course[Convert.ToInt32(cup2Track1Slot.Value) - 1]}; 0x00; \"{cup2Track1Name.Text}\"; \"{cup2Track1Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup2Track2Slot.Value) - 1]}; {course[Convert.ToInt32(cup2Track2Slot.Value) - 1]}; 0x00; \"{cup2Track2Name.Text}\"; \"{cup2Track2Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup2Track3Slot.Value) - 1]}; {course[Convert.ToInt32(cup2Track3Slot.Value) - 1]}; 0x00; \"{cup2Track3Name.Text}\"; \"{cup2Track3Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup2Track4Slot.Value) - 1]}; {course[Convert.ToInt32(cup2Track4Slot.Value) - 1]}; 0x00; \"{cup2Track4Name.Text}\"; \"{cup2Track4Name.Text}\"; \"\"");
                }

                if (cupInput.Value > 2)
                {
                    sw.WriteLine("\nC \"3\" # 14");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup3Track1Slot.Value) - 1]}; {course[Convert.ToInt32(cup3Track1Slot.Value) - 1]}; 0x00; \"{cup3Track1Name.Text}\"; \"{cup3Track1Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup3Track2Slot.Value) - 1]}; {course[Convert.ToInt32(cup3Track2Slot.Value) - 1]}; 0x00; \"{cup3Track2Name.Text}\"; \"{cup3Track2Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup3Track3Slot.Value) - 1]}; {course[Convert.ToInt32(cup3Track3Slot.Value) - 1]}; 0x00; \"{cup3Track3Name.Text}\"; \"{cup3Track3Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup3Track4Slot.Value) - 1]}; {course[Convert.ToInt32(cup3Track4Slot.Value) - 1]}; 0x00; \"{cup3Track4Name.Text}\"; \"{cup3Track4Name.Text}\"; \"\"");
                }

                if (cupInput.Value > 3)
                {
                    sw.WriteLine("\nC \"4\" # 15");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup4Track1Slot.Value) - 1]}; {course[Convert.ToInt32(cup4Track1Slot.Value) - 1]}; 0x00; \"{cup4Track1Name.Text}\"; \"{cup4Track1Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup4Track2Slot.Value) - 1]}; {course[Convert.ToInt32(cup4Track2Slot.Value) - 1]}; 0x00; \"{cup4Track2Name.Text}\"; \"{cup4Track2Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup4Track3Slot.Value) - 1]}; {course[Convert.ToInt32(cup4Track3Slot.Value) - 1]}; 0x00; \"{cup4Track3Name.Text}\"; \"{cup4Track3Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup4Track4Slot.Value) - 1]}; {course[Convert.ToInt32(cup4Track4Slot.Value) - 1]}; 0x00; \"{cup4Track4Name.Text}\"; \"{cup4Track4Name.Text}\"; \"\"");
                }

                if (cupInput.Value > 4)
                {
                    sw.WriteLine("\nC \"5\" # 16");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup5Track1Slot.Value) - 1]}; {course[Convert.ToInt32(cup5Track1Slot.Value) - 1]}; 0x00; \"{cup5Track1Name.Text}\"; \"{cup5Track1Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup5Track2Slot.Value) - 1]}; {course[Convert.ToInt32(cup5Track2Slot.Value) - 1]}; 0x00; \"{cup5Track2Name.Text}\"; \"{cup5Track2Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup5Track3Slot.Value) - 1]}; {course[Convert.ToInt32(cup5Track3Slot.Value) - 1]}; 0x00; \"{cup5Track3Name.Text}\"; \"{cup5Track3Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup5Track4Slot.Value) - 1]}; {course[Convert.ToInt32(cup5Track4Slot.Value) - 1]}; 0x00; \"{cup5Track4Name.Text}\"; \"{cup5Track4Name.Text}\"; \"\"");
                }

                if (cupInput.Value > 5)
                {
                    sw.WriteLine("\nC \"6\" # 17");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup6Track1Slot.Value) - 1]}; {course[Convert.ToInt32(cup6Track1Slot.Value) - 1]}; 0x00; \"{cup6Track1Name.Text}\"; \"{cup6Track1Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup6Track2Slot.Value) - 1]}; {course[Convert.ToInt32(cup6Track2Slot.Value) - 1]}; 0x00; \"{cup6Track2Name.Text}\"; \"{cup6Track2Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup6Track3Slot.Value) - 1]}; {course[Convert.ToInt32(cup6Track3Slot.Value) - 1]}; 0x00; \"{cup6Track3Name.Text}\"; \"{cup6Track3Name.Text}\"; \"\"");
                    sw.WriteLine($"T {course[Convert.ToInt32(cup6Track4Slot.Value) - 1]}; {course[Convert.ToInt32(cup6Track4Slot.Value) - 1]}; 0x00; \"{cup6Track4Name.Text}\"; \"{cup6Track4Name.Text}\"; \"\"");
                }
                sw.Close();
            }
        }

        private void cupInput_ValueChanged(object sender, EventArgs e)
        {
            if (cupInput.Value > 0)
            {
                panel2.Visible = false;
            }

            if (cupInput.Value > 1)
            {
                panel2.Visible = true;
                panel3.Visible = false;
            }

            if (cupInput.Value > 2)
            {
                panel3.Visible = true;
                panel4.Visible = false;
            }

            if (cupInput.Value > 3)
            {
                panel4.Visible = true;
                panel5.Visible = false;
            }

            if (cupInput.Value > 4)
            {
                panel5.Visible = true;
                panel6.Visible = false;
            }

            if (cupInput.Value > 5)
            {
                panel6.Visible = true;
            }
        }
    }
}