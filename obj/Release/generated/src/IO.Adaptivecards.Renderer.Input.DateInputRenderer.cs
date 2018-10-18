using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DateInputRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/input/DateInputRenderer", DoNotGenerateAcw=true)]
	public partial class DateInputRenderer : global::IO.Adaptivecards.Renderer.Input.TextInputRenderer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/input/DateInputRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateInputRenderer); }
		}

		protected DateInputRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DateInputRenderer']/constructor[@name='DateInputRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe DateInputRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateInputRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::IO.Adaptivecards.Renderer.Input.DateInputRenderer Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DateInputRenderer']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/input/DateInputRenderer;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/input/DateInputRenderer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.DateInputRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
