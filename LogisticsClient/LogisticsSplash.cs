using System;
using DevExpress.XtraSplashScreen;

namespace LogisticsClient
{
    public partial class LogisticsSplash : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public LogisticsSplash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}