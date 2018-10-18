using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/MediaSourceParser", DoNotGenerateAcw=true)]
	public partial class MediaSourceParser : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, swigCMemOwn_jfieldId);
			}
			set {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, swigCMemOwn_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/MediaSourceParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaSourceParser); }
		}

		protected MediaSourceParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_MediaSourceParser_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/constructor[@name='MediaSourceParser' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaSourceParser']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/MediaSourceParser;)V", "")]
		public unsafe MediaSourceParser (global::IO.Adaptivecards.Objectmodel.MediaSourceParser p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MediaSourceParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/MediaSourceParser;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/MediaSourceParser;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_MediaSourceParser_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_MediaSourceParser_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/MediaSourceParser;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_MediaSourceParser_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_MediaSourceParser_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/constructor[@name='MediaSourceParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaSourceParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaSourceParser)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/constructor[@name='MediaSourceParser' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe MediaSourceParser (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MediaSourceParser)) {
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

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/method[@name='Deserialize' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='io.adaptivecards.objectmodel.JsonValue']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/MediaSource;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.MediaSource Deserialize (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, global::IO.Adaptivecards.Objectmodel.JsonValue p3)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/MediaSource;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::IO.Adaptivecards.Objectmodel.MediaSource __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/method[@name='DeserializeFromString' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='java.lang.String']]"
		[Register ("DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/MediaSource;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.MediaSource DeserializeFromString (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, string p3)
		{
			if (id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/MediaSource;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::IO.Adaptivecards.Objectmodel.MediaSource __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSourceParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceParser']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaSourceParser']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/MediaSourceParser;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.MediaSourceParser p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceParser_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceParser_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/MediaSourceParser;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_MediaSourceParser_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
