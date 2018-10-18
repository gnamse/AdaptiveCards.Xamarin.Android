using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Readonly {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='DateTimeParser']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/readonly/DateTimeParser", DoNotGenerateAcw=true)]
	public partial class DateTimeParser : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/readonly/DateTimeParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateTimeParser); }
		}

		protected DateTimeParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='DateTimeParser']/constructor[@name='DateTimeParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DateTimeParser (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (DateTimeParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_;
#pragma warning disable 0169
		static Delegate GetGenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_Handler ()
		{
			if (cb_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_ == null)
				cb_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_);
			return cb_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_;
		}

		static IntPtr n_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Readonly.DateTimeParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Readonly.DateTimeParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.DateTimePreparser p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='DateTimeParser']/method[@name='GenerateString' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.DateTimePreparser']]"
		[Register ("GenerateString", "(Lio/adaptivecards/objectmodel/DateTimePreparser;)Ljava/lang/String;", "GetGenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_Handler")]
		public virtual unsafe string GenerateString (global::IO.Adaptivecards.Objectmodel.DateTimePreparser p0)
		{
			if (id_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_ == IntPtr.Zero)
				id_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_ = JNIEnv.GetMethodID (class_ref, "GenerateString", "(Lio/adaptivecards/objectmodel/DateTimePreparser;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GenerateString_Lio_adaptivecards_objectmodel_DateTimePreparser_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GenerateString", "(Lio/adaptivecards/objectmodel/DateTimePreparser;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
