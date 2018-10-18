using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	[Register ("io/adaptivecards/objectmodel/AdaptiveCardObjectModelConstants", DoNotGenerateAcw=true)]
	public abstract class AdaptiveCardObjectModelConstants : Java.Lang.Object {

		internal AdaptiveCardObjectModelConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/interface[@name='AdaptiveCardObjectModelConstants']/field[@name='__ANDROID__']"
		[Register ("__ANDROID__")]
		public const int Android = (int) 1;
	}

	[Register ("io/adaptivecards/objectmodel/AdaptiveCardObjectModelConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AdaptiveCardObjectModelConstants' type. This type will be removed in a future release.")]
	public abstract class AdaptiveCardObjectModelConstantsConsts : AdaptiveCardObjectModelConstants {

		private AdaptiveCardObjectModelConstantsConsts ()
		{
		}
	}

}
