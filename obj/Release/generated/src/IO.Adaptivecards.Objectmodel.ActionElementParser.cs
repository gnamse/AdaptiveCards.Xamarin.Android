using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ActionElementParser", DoNotGenerateAcw=true)]
	public partial class ActionElementParser : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ActionElementParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionElementParser); }
		}

		protected ActionElementParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/constructor[@name='ActionElementParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActionElementParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ActionElementParser)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/constructor[@name='ActionElementParser' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ActionElementParser (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ActionElementParser)) {
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

		static Delegate cb_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_;
#pragma warning disable 0169
		static Delegate GetDeserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_Handler ()
		{
			if (cb_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ == null)
				cb_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_);
			return cb_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_;
		}

		static IntPtr n_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::IO.Adaptivecards.Objectmodel.ActionElementParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ElementParserRegistration> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionParserRegistration> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.JsonValue p3 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Deserialize (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/method[@name='Deserialize' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='io.adaptivecards.objectmodel.JsonValue']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/BaseActionElement;", "GetDeserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElement Deserialize (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, global::IO.Adaptivecards.Objectmodel.JsonValue p3)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/BaseActionElement;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::IO.Adaptivecards.Objectmodel.BaseActionElement __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/BaseActionElement;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::IO.Adaptivecards.Objectmodel.ActionElementParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ActionElementParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionElementParser']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ActionElementParser;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ActionElementParser p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ActionElementParser_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ActionElementParser_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ActionElementParser;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ActionElementParser_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_swigDirectorDisconnect;
#pragma warning disable 0169
		static Delegate GetSwigDirectorDisconnectHandler ()
		{
			if (cb_swigDirectorDisconnect == null)
				cb_swigDirectorDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigDirectorDisconnect);
			return cb_swigDirectorDisconnect;
		}

		static void n_SwigDirectorDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionElementParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigDirectorDisconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_swigDirectorDisconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/method[@name='swigDirectorDisconnect' and count(parameter)=0]"
		[Register ("swigDirectorDisconnect", "()V", "GetSwigDirectorDisconnectHandler")]
		protected virtual unsafe void SwigDirectorDisconnect ()
		{
			if (id_swigDirectorDisconnect == IntPtr.Zero)
				id_swigDirectorDisconnect = JNIEnv.GetMethodID (class_ref, "swigDirectorDisconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swigDirectorDisconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigDirectorDisconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_swigReleaseOwnership;
#pragma warning disable 0169
		static Delegate GetSwigReleaseOwnershipHandler ()
		{
			if (cb_swigReleaseOwnership == null)
				cb_swigReleaseOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigReleaseOwnership);
			return cb_swigReleaseOwnership;
		}

		static void n_SwigReleaseOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionElementParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigReleaseOwnership ();
		}
#pragma warning restore 0169

		static IntPtr id_swigReleaseOwnership;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/method[@name='swigReleaseOwnership' and count(parameter)=0]"
		[Register ("swigReleaseOwnership", "()V", "GetSwigReleaseOwnershipHandler")]
		public virtual unsafe void SwigReleaseOwnership ()
		{
			if (id_swigReleaseOwnership == IntPtr.Zero)
				id_swigReleaseOwnership = JNIEnv.GetMethodID (class_ref, "swigReleaseOwnership", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swigReleaseOwnership);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigReleaseOwnership", "()V"));
			} finally {
			}
		}

		static Delegate cb_swigTakeOwnership;
#pragma warning disable 0169
		static Delegate GetSwigTakeOwnershipHandler ()
		{
			if (cb_swigTakeOwnership == null)
				cb_swigTakeOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigTakeOwnership);
			return cb_swigTakeOwnership;
		}

		static void n_SwigTakeOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionElementParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigTakeOwnership ();
		}
#pragma warning restore 0169

		static IntPtr id_swigTakeOwnership;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionElementParser']/method[@name='swigTakeOwnership' and count(parameter)=0]"
		[Register ("swigTakeOwnership", "()V", "GetSwigTakeOwnershipHandler")]
		public virtual unsafe void SwigTakeOwnership ()
		{
			if (id_swigTakeOwnership == IntPtr.Zero)
				id_swigTakeOwnership = JNIEnv.GetMethodID (class_ref, "swigTakeOwnership", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swigTakeOwnership);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigTakeOwnership", "()V"));
			} finally {
			}
		}

	}
}
