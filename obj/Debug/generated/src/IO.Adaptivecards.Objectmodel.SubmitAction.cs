using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/SubmitAction", DoNotGenerateAcw=true)]
	public partial class SubmitAction : global::IO.Adaptivecards.Objectmodel.BaseActionElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/SubmitAction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubmitAction); }
		}

		protected SubmitAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/constructor[@name='SubmitAction' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe SubmitAction (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SubmitAction)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/constructor[@name='SubmitAction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubmitAction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SubmitAction)) {
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

		static Delegate cb_GetDataJson;
#pragma warning disable 0169
		static Delegate GetGetDataJsonHandler ()
		{
			if (cb_GetDataJson == null)
				cb_GetDataJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataJson);
			return cb_GetDataJson;
		}

		static IntPtr n_GetDataJson (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SubmitAction __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SubmitAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataJson);
		}
#pragma warning restore 0169

		static IntPtr id_GetDataJson;
		public virtual unsafe string DataJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/method[@name='GetDataJson' and count(parameter)=0]"
			[Register ("GetDataJson", "()Ljava/lang/String;", "GetGetDataJsonHandler")]
			get {
				if (id_GetDataJson == IntPtr.Zero)
					id_GetDataJson = JNIEnv.GetMethodID (class_ref, "GetDataJson", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetDataJson), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetDataJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetDataJsonAsValue;
#pragma warning disable 0169
		static Delegate GetGetDataJsonAsValueHandler ()
		{
			if (cb_GetDataJsonAsValue == null)
				cb_GetDataJsonAsValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataJsonAsValue);
			return cb_GetDataJsonAsValue;
		}

		static IntPtr n_GetDataJsonAsValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SubmitAction __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SubmitAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataJsonAsValue);
		}
#pragma warning restore 0169

		static IntPtr id_GetDataJsonAsValue;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.JsonValue DataJsonAsValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/method[@name='GetDataJsonAsValue' and count(parameter)=0]"
			[Register ("GetDataJsonAsValue", "()Lio/adaptivecards/objectmodel/JsonValue;", "GetGetDataJsonAsValueHandler")]
			get {
				if (id_GetDataJsonAsValue == IntPtr.Zero)
					id_GetDataJsonAsValue = JNIEnv.GetMethodID (class_ref, "GetDataJsonAsValue", "()Lio/adaptivecards/objectmodel/JsonValue;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetDataJsonAsValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetDataJsonAsValue", "()Lio/adaptivecards/objectmodel/JsonValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_;
#pragma warning disable 0169
		static Delegate GetSetDataJson_Lio_adaptivecards_objectmodel_JsonValue_Handler ()
		{
			if (cb_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_ == null)
				cb_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_);
			return cb_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_;
		}

		static void n_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.SubmitAction __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SubmitAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.JsonValue p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/method[@name='SetDataJson' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue']]"
		[Register ("SetDataJson", "(Lio/adaptivecards/objectmodel/JsonValue;)V", "GetSetDataJson_Lio_adaptivecards_objectmodel_JsonValue_Handler")]
		public virtual unsafe void SetDataJson (global::IO.Adaptivecards.Objectmodel.JsonValue p0)
		{
			if (id_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
				id_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetMethodID (class_ref, "SetDataJson", "(Lio/adaptivecards/objectmodel/JsonValue;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetDataJson_Lio_adaptivecards_objectmodel_JsonValue_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetDataJson", "(Lio/adaptivecards/objectmodel/JsonValue;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseActionElement;)Lio/adaptivecards/objectmodel/SubmitAction;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SubmitAction Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseActionElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseActionElement;)Lio/adaptivecards/objectmodel/SubmitAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.SubmitAction __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SubmitAction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_SubmitAction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SubmitAction']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SubmitAction']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/SubmitAction;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.SubmitAction p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_SubmitAction_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_SubmitAction_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/SubmitAction;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_SubmitAction_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
