using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Toast.RNToast
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNToastModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNToastModule"/>.
        /// </summary>
        internal RNToastModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNToast";
            }
        }
    }
}
