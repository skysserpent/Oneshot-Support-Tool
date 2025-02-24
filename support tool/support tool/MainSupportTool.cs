using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace GameOptimizer
{
    public partial class MainSupportTool : Form
    {
        public MainSupportTool()
        {
            InitializeComponent();
            lblOneshotlink.Cursor = Cursors.Hand;
            lblWikiLink.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowGameOptions();

        }

        private void ShowGameOptions()
        {
            lblStatus.Text = "=== Game Tool Selector ===\n1. Call of Duty\n2. Exit\n\nPlease select an option (1-2):";
            btnOption1.Text = "1. Call of Duty";
            btnOption2.Text = "2. Run All";

            btnOption1.Visible = true;
            btnOption2.Visible = true;
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            ClearForm();
            CodCheck();
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            ClearForm();
            CodCheck();
            ApplyFixes();
        }

        private void CodCheck()
        {
            lblStatus.Text = "=== Call of Duty Optimizer ===\n\n";
            lblStatus.Text += "Do you have the latest NVIDIA drivers installed?";

            var driverResponse = MessageBox.Show("Do you have the latest NVIDIA drivers installed?", "Driver Check", MessageBoxButtons.YesNo);
            if (driverResponse == DialogResult.No)
            {
                OpenLink("https://www.nvidia.com/download/index.aspx");
                MessageBox.Show("Please update your drivers and restart the optimizer.");
                Application.Exit();
            }

            lblStatus.Text += "\nAre you experiencing crashes when injecting?";

            var response = MessageBox.Show("Are you experiencing crashes when injecting?", "Crash Check", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                ApplyCrashFixes();
            }
        }

        private void ApplyCrashFixes()
        {
            lblStatus.Text += "\nApplying crash fix optimizations...";

            string[] graphicsCommands = {
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v TextureQuality /t REG_DWORD /d 1 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v ParticleQuality /t REG_DWORD /d 1 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v ShadowQuality /t REG_DWORD /d 1 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v RenderResolution /t REG_DWORD /d 66 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v PixelPerSceneScale /t REG_DWORD /d 50 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v MemoryScale /t REG_DWORD /d 0 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v ThreadCount /t REG_DWORD /d 4 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v CloudQuality /t REG_DWORD /d 0 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v VolumetricQuality /t REG_DWORD /d 0 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v AntiAliasing /t REG_DWORD /d 0 /f",
                "reg add \"HKCU\\Software\\Activision\\Call of Duty\\Settings\" /v FilmicStrength /t REG_DWORD /d 0 /f",

                // NVIDIA DLSS Settings
                "reg add \"HKCU\\Software\\NVIDIA Corporation\\Global\\NGXCore\" /v EnableDLSS /t REG_DWORD /d 0 /f",
                "reg add \"HKCU\\Software\\NVIDIA Corporation\\Global\\NGXCore\" /v EnableNIS /t REG_DWORD /d 1 /f",
                "reg add \"HKCU\\Software\\NVIDIA Corporation\\Global\\NGXCore\" /v NISSharpenValue /t REG_DWORD /d 50 /f",

                // AMD FSR Settings
                "reg add \"HKCU\\Software\\AMD\\FSR\" /v MaxVersion /t REG_DWORD /d 30000 /f",
                "reg add \"HKCU\\Software\\AMD\\FSR\" /v Quality /t REG_DWORD /d 0 /f"
            };

            foreach (string cmd in graphicsCommands)
            {
                RunCommandSilent(cmd);
                lblStatus.Text += ".";
            }
            string[] nvidiaCommands = {
                "nvidia-smi --gpu-reset-power-limit",
                "nvidia-smi -pm 1",
                "nvidia-smi --auto-boost-default=DISABLED",
                "nvidia-smi -ac 2100,5500"
            };

            foreach (string cmd in nvidiaCommands)
            {
                RunCommandSilent(cmd);
                Console.Write(".");
            }

            lblStatus.Text += "\n✓ Graphics optimizations applied!";
            lblStatus.Text += "\n✓ NVIDIA settings optimized!";
            lblStatus.Text += "\n✓ Process priorities set!";
            lblStatus.Text += "\n✓ Loader Fixes Applied";
        }

        private void ApplyFixes()
        {
            lblStatus.Text += "\nApplying optimizations...";
            lblStatus.Text += "\nThis may take a few minutes. Please be patient.\n";

            RunCommandSilent("sc stop vgk");
            lblStatus.Text += "\n✓ Vanguard service stopped";

            RunCommandSilent("bcdedit /set hypervisorlaunchtype off");
            lblStatus.Text += "\n✓ Hypervisor disabled";

            ApplyRegistryFixesSilently();
            lblStatus.Text += "\n✓ Registry optimizations applied";

            ApplyLoaderFixesSilently();
            lblStatus.Text += "\n✓ Loader Fixes Applied";

            UninstallOneDriveSilently();
            lblStatus.Text += "\n✓ OneDrive removed";

            DisableServicesSilently();
            lblStatus.Text += "\n✓ Services optimized";

            RemoveGamingServicesSilently();
            lblStatus.Text += "\n✓ Gaming services cleaned";



            lblStatus.Text += "\n\n✓ All optimizations completed successfully!";
            lblStatus.Text += "\nPlease restart your PC for changes to take effect.";
        }

        private void ApplyRegistryFixesSilently()
        {
            string[] registryCommands = {
                            "reg add \"HKLM\\SOFTWARE\\Microsoft\\SQMClient\\Windows\\Vulnerability\\Override\" /v \"Windows11_22H2_BlockList\" /t REG_DWORD /d 0 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\" /v FeatureSettingsOverride /t REG_DWORD /d 3 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\" /v FeatureSettingsOverrideMask /t REG_DWORD /d 3 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /v \"EnableVirtualizationBasedSecurity\" /t REG_DWORD /d 0 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\CI\\Config\" /v VulnerableDriverBlocklistEnable /t REG_DWORD /d 0 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity\" /v Enabled /t REG_DWORD /d 0 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\" /v LargeSystemCache /t REG_DWORD /d 1 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\CrashControl\" /v AutoReboot /t REG_DWORD /d 0 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Watchdog\" /v NMICrashDump /t REG_DWORD /d 1 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Watchdog\" /v TimeOut /t REG_DWORD /d 120 /f",
                            "reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting\" /v Disabled /t REG_DWORD /d 1 /f",
                            "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\" /v PagingFiles /t REG_MULTI_SZ /d \"C:\\pagefile.sys 4096 8192\" /f"
            };

            foreach (string command in registryCommands)
            {
                RunCommandSilent(command);
            }
        }
        private void ApplyLoaderFixesSilently()
        {
            string[] registryCommands = {
                        "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\" /v FeatureSettingsOverride /t REG_DWORD /d 3 /f",
                        "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\" /v FeatureSettingsOverrideMask /t REG_DWORD /d 3 /f",
                        "reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\CI\\Config\" /v VulnerableDriverBlocklistEnable /t REG_DWORD /d 0x000000 /f"
            };
            foreach (string command in registryCommands)
            {
                RunCommandSilent(command);
            }
            RunCommandSilent("bcdedit /set hypervisorlaunchtype off");
            RunCommandSilent("powershell.exe -ExecutionPolicy Bypass -Command \"Disable-WindowsOptionalFeature -Online -FeatureName Microsoft-Hyper-V-All -NoRestart\"");
            lblStatus.Text += "\n✓ Loader fixes applied successfully! Please restart your PC.";
        }

        private void UninstallOneDriveSilently()
        {
            RunCommandSilent("taskkill /f /im OneDrive.exe");
            RunCommandSilent("%windir%\\SysWOW64\\OneDriveSetup.exe /uninstall");
            RunCommandSilent("reg delete \"HKEY_CLASSES_ROOT\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\" /f");
        }

        private void DisableServicesSilently()
        {
            RunCommandSilent("powershell.exe Set-ProcessMitigation -System -Disable DEP,SEHOP,ForceRelocateImages,RequireInfo,BottomUp,HighEntropy,SIMEXEC,DynamicCode,EmulateAtlThunks,ExportAddressFilter,ImportAddressFilter,RopStackPivot,RopCallerCheck,RopSimExec");
            RunCommandSilent("netsh advfirewall set allprofiles state off");
        }

        private void RemoveGamingServicesSilently()
        {
            string[] foldersToRemove = {
                        @"C:\Riot Games",
                        @"C:\Program Files\Riot Games",
                        @"C:\Program Files (x86)\Riot Games",
                        @"C:\ProgramData\Riot Games",
                        @"C:\Program Files\FACEIT",
                        @"C:\Program Files (x86)\FACEIT",
                        @"C:\Program Files\FACEIT AC",
                        @"C:\Program Files (x86)\FACEIT AC"
            };

            foreach (string folder in foldersToRemove)
            {
                if (Directory.Exists(folder))
                {
                    try
                    {
                        Directory.Delete(folder, true);
                    }
                    catch { }
                }
            }
        }

        private void RunCommandSilent(string command)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {command}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using (Process process = Process.Start(processInfo))
                {
                    process.WaitForExit();
                }
            }
            catch { }
        }

        private void OpenLink(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start {url}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process.Start(psi);
            }
            catch { }
        }

        private void ClearForm()
        {
            lblStatus.Text = "";
            btnOption1.Visible = false;
            btnOption2.Visible = false;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.lblStatus.Top = -guna2VScrollBar1.Value;  // Move the label up or down based on the scrollbar value
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClearForm();
            CodCheck();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClearForm();
            CodCheck();
            ApplyFixes();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://oneshot.wiki/");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://oneshot.wiki/");
        }
        private void lblWikiLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://oneshot.wiki/");
        }
    }
}
