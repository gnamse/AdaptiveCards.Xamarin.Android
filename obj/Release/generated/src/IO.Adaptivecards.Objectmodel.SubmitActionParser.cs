using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitActionParser']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/SubmitActionParser", DoNotGenerateAcw=true)]
	public partial class SubmitActionParser : global::IO.Adaptivecards.Objectmodel.ActionElementParser {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/SubmitActionParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubmitActionParser); }
		}

		protected SubmitActionParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_SubmitActionParser_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitActionParser']/constructor[@name='SubmitActionParser' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SubmitActionParser']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/SubmitActionParser;)V", "")]
		public unsafe SubmitActionParser (global::IO.Adaptivecards.Objectmodel.SubmitActionParser p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SubmitActionParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/SubmitActionParser;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/SubmitActionParser;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_SubmitActionParser_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_SubmitActionParser_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/SubmitActionParser;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_SubmitActionParser_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_SubmitActionParser_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitActionParser']/constructor[@name='SubmitActionParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubmitActionParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SubmitActionParser)) {
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

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitActionParser']/constructor[@name='SubmitActionParser' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe SubmitActionParser (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SubmitActionParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static Delegate cb_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_Handler ()
		{
			if (cb_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ == null)
				cb_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_);
			return cb_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_;
		}

		static IntPtr n_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::IO.Adaptivecards.Objectmodel.SubmitActionParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SubmitActionParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ElementParserRegistration> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionParserRegistration> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeserializeFromString (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitActionParser']/method[@name='DeserializeFromString' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='java.lang.String']]"
		[Register ("DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/BaseActionElement;", "GetDeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElement DeserializeFromString (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, string p3)
		{
			if (id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/BaseActionElement;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				global::IO.Adaptivecards.Objectmodel.BaseActionElement __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/BaseActionElement;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_SubmitActionParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitActionParser']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SubmitActionParser']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/SubmitActionParser;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.SubmitActionParser p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_SubmitActionParser_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_SubmitActionParser_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/SubmitActionParser;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_SubmitActionParser_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
