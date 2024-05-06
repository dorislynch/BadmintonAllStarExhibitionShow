using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Badminton.All.Star.Exhibition.Show.RNBadmintonAllStarExhibitionShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBadmintonAllStarExhibitionShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBadmintonAllStarExhibitionShowModule"/>.
        /// </summary>
        internal RNBadmintonAllStarExhibitionShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBadmintonAllStarExhibitionShow";
            }
        }
    }
}
