using OsuAchievedOverlay.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuAchievedOverlay.Managers
{
    public class WindowManager : Manager<WindowManager>
    {
        public DisplayWindow DisplayWin { get; set; }
        public LoadSessionWindow SessionWin { get; set; }
        public LocalApiWindow ApiWin { get; set; }
        public LaunchWindow LaunchWin { get; set; }
        public UpdateWindow UpdateWin { get; set; }

        public void CloseAll(){
            DisplayWin?.Close();
            DisplayWin = null;
            SessionWin?.Close();
            SessionWin = null;
            ApiWin?.Close();
            ApiWin = null;
        }

        public override void Start()
        {
        }

        public override void Stop()
        {
        }
    }
}
