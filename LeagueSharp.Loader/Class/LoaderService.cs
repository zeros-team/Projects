using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using LeagueSharp.Loader.Data;
using LeagueSharp.Sandbox.Shared;

namespace LeagueSharp.Loader.Class
{
    public class LoaderService : ILoaderService
    {
        public List<LSharpAssembly> GetAssemblyList(int pid)
        {
            return Config.Instance.SelectedProfile.InstalledAssemblies
                .Where(a => a.InjectChecked && a.Type != AssemblyType.Library)
                .Select(assembly => new LSharpAssembly
            {
                Name = assembly.Name,
                PathToBinary = assembly.PathToBinary
            }).ToList();
        }

        public Configuration GetConfiguration(int pid)
        {
            var reload = 0x74;
            var recompile = 0x77;
            var antiAfk = false;
            var console = false;
            var towerRange = false;
            var extendedZoom = false;
            var menuToggle = 0x78;
            var menuPress = 0x10;

            try
            {
                reload = KeyInterop.VirtualKeyFromKey(Config.Instance.Hotkeys.SelectedHotkeys.First(h => h.Name == "Reload").Hotkey);
                recompile = KeyInterop.VirtualKeyFromKey(Config.Instance.Hotkeys.SelectedHotkeys.First(h => h.Name == "CompileAndReload").Hotkey);
                antiAfk = Config.Instance.Settings.GameSettings.First(s => s.Name == "Anti-AFK").SelectedValue == "True";
                console = Config.Instance.Settings.GameSettings.First(s => s.Name == "Debug Console").SelectedValue == "True";
                towerRange = Config.Instance.Settings.GameSettings.First(s => s.Name == "Display Enemy Tower Range").SelectedValue == "True";
                extendedZoom = Config.Instance.Settings.GameSettings.First(s => s.Name == "Extended Zoom").SelectedValue == "True";
                menuToggle = KeyInterop.VirtualKeyFromKey(Config.Instance.Hotkeys.SelectedHotkeys.First(h => h.Name == "ShowMenuToggle").Hotkey);
                menuPress = KeyInterop.VirtualKeyFromKey(Config.Instance.Hotkeys.SelectedHotkeys.First(h => h.Name == "ShowMenuPress").Hotkey);
            }
            catch
            {
                // ignored
            }

            return new Configuration
            {
                DataDirectory = Directories.AppDataDirectory,
                LeagueSharpDllPath = PathRandomizer.LeagueSharpDllPath,
                LibrariesDirectory = Directories.CoreDirectory,
                ReloadKey = reload,
                ReloadAndRecompileKey = recompile,
                MenuToggleKey = menuToggle,
                MenuKey = menuPress,
                UnloadKey = 0x75,
                AntiAfk = antiAfk,
                Console = console,
                TowerRange = towerRange,
                ExtendedZoom = false,
                Permissions = null
            };
        }

        public void Recompile(int pid)
        {
            var targetAssemblies =
                    Config.Instance.SelectedProfile.InstalledAssemblies.Where(
                        a => a.InjectChecked || a.Type == AssemblyType.Library).ToList();

            foreach (var assembly in targetAssemblies)
            {
                if (assembly.Type == AssemblyType.Library)
                {
                    assembly.Compile();
                }
            }

            foreach (var assembly in targetAssemblies)
            {
                if (assembly.Type != AssemblyType.Library)
                {
                    assembly.Compile();
                }
            }
        }
    }
}
