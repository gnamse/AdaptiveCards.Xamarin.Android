using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/AdaptiveWarning", DoNotGenerateAcw=true)]
	public partial class AdaptiveWarning : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/field[@name='INTERACTIVITY_DISALLOWED']"
		[Register ("INTERACTIVITY_DISALLOWED")]
		public const int InteractivityDisallowed = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/field[@name='MAX_ACTIONS_EXCEEDED']"
		[Register ("MAX_ACTIONS_EXCEEDED")]
		public const int MaxActionsExceeded = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/field[@name='TOGGLE_MISSING_VALUE']"
		[Register ("TOGGLE_MISSING_VALUE")]
		public const int ToggleMissingValue = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/field[@name='UNABLE_TO_LOAD_IMAGE']"
		[Register ("UNABLE_TO_LOAD_IMAGE")]
		public const int UnableToLoadImage = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/field[@name='UNKNOWN_ELEMENT_TYPE']"
		[Register ("UNKNOWN_ELEMENT_TYPE")]
		public const int UnknownElementType = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/AdaptiveWarning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdaptiveWarning); }
		}

		protected AdaptiveWarning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/constructor[@name='AdaptiveWarning' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe AdaptiveWarning (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AdaptiveWarning)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.AdaptiveWarning __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveWarning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		public virtual unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.AdaptiveWarning __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveWarning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveWarning']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
