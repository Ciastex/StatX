﻿using System;
using System.Timers;
using System.Windows;
using OverCR.StatX.Config;
using OverCR.StatX.Tray;

namespace OverCR.StatX
{
    public partial class App
    {
        public static TrayIconProvider TrayIconProvider { get; set; }
        public static Settings StatisticsSaveFile { get; set; }

        private static Timer SettingsTimer { get; set; }

        public App()
        {
            TrayIconProvider = new TrayIconProvider();
            StatisticsSaveFile = new Settings("./_settings/stats.json");

            SettingsTimer = new Timer(10000);
            SettingsTimer.Elapsed += SettingsTimer_Elapsed;
            SettingsTimer.Start();

            Exit += App_Exit;
        }

        public static void CriticalFailure(string message, Window owner)
        {
            var win = AlertWindow.ErrorBox(message, owner);
            win.Closed += (sender, args) =>
            {
                Environment.Exit(1);
            };
            win.ShowDialog();
        }

        private void SettingsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StatisticsSaveFile.Save();
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            StatisticsSaveFile.Save();
            TrayIconProvider.HideIcon();
        }
    }
}
