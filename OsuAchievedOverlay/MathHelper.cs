﻿namespace OsuAchievedOverlay
{
    public static class MathHelper
    {
        public static decimal Map(this decimal value, decimal fromSource, decimal toSource, decimal fromTarget, decimal toTarget)
        {
            decimal val = ((value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget);
            return val;
        }

        public static int Map(this int value, int fromSource, int toSource, int fromTarget, int toTarget)
        {
            double val = ((value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget);
            return val;
        }

        public static double Map(this double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            double val = ((value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget);
            return val;
        }
    }
}
