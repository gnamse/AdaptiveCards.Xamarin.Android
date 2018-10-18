using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/AdaptiveCardParseException", DoNotGenerateAcw=true)]
	public partial class AdaptiveCardParseException : global::Java.Lang.Exception {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Throwable) this).Handle, swigCMemOwn_jfieldId);
			}
			set {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Throwable) this).Handle, swigCMemOwn_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/AdaptiveCardParseException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdaptiveCardParseException); }
		}

		protected AdaptiveCardParseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/constructor[@name='AdaptiveCardParseException' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe AdaptiveCardParseException (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AdaptiveCardParseException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_ErrorStatusCode_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/constructor[@name='AdaptiveCardParseException' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.ErrorStatusCode'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/ErrorStatusCode;Ljava/lang/String;)V", "")]
		public unsafe AdaptiveCardParseException (global::IO.Adaptivecards.Objectmodel.ErrorStatusCode p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AdaptiveCardParseException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/ErrorStatusCode;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lio/adaptivecards/objectmodel/ErrorStatusCode;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_ErrorStatusCode_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_ErrorStatusCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/ErrorStatusCode;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_ErrorStatusCode_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_ErrorStatusCode_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_GetReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_GetReason == null)
				cb_GetReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReason);
			return cb_GetReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reason);
		}
#pragma warning restore 0169

		static IntPtr id_GetReason;
		public virtual unsafe string Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/method[@name='GetReason' and count(parameter)=0]"
			[Register ("GetReason", "()Ljava/lang/String;", "GetGetReasonHandler")]
			get {
				if (id_GetReason == IntPtr.Zero)
					id_GetReason = JNIEnv.GetMethodID (class_ref, "GetReason", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_GetReason), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetReason", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_GetStatusCode == null)
				cb_GetStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatusCode);
			return cb_GetStatusCode;
		}

		static IntPtr n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StatusCode);
		}
#pragma warning restore 0169

		static IntPtr id_GetStatusCode;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ErrorStatusCode StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/method[@name='GetStatusCode' and count(parameter)=0]"
			[Register ("GetStatusCode", "()Lio/adaptivecards/objectmodel/ErrorStatusCode;", "GetGetStatusCodeHandler")]
			get {
				if (id_GetStatusCode == IntPtr.Zero)
					id_GetStatusCode = JNIEnv.GetMethodID (class_ref, "GetStatusCode", "()Lio/adaptivecards/objectmodel/ErrorStatusCode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_GetStatusCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStatusCode", "()Lio/adaptivecards/objectmodel/ErrorStatusCode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Throwable) this).Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCardParseException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCardParseException']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/AdaptiveCardParseException;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCardParseException_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCardParseException_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/AdaptiveCardParseException;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCardParseException_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_what;
#pragma warning disable 0169
		static Delegate GetWhatHandler ()
		{
			if (cb_what == null)
				cb_what = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_What);
			return cb_what;
		}

		static IntPtr n_What (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.What ());
		}
#pragma warning restore 0169

		static IntPtr id_what;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCardParseException']/method[@name='what' and count(parameter)=0]"
		[Register ("what", "()Ljava/lang/String;", "GetWhatHandler")]
		public virtual unsafe string What ()
		{
			if (id_what == IntPtr.Zero)
				id_what = JNIEnv.GetMethodID (class_ref, "what", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_what), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "what", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
