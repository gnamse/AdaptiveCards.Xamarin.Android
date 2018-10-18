using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='MediaLoaderAsync']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/MediaLoaderAsync", DoNotGenerateAcw=true)]
	public partial class MediaLoaderAsync : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/MediaLoaderAsync", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaLoaderAsync); }
		}

		protected MediaLoaderAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
