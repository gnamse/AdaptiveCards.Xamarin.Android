using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/FactSetConfig", DoNotGenerateAcw=true)]
	public partial class FactSetConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/FactSetConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FactSetConfig); }
		}

		protected FactSetConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/constructor[@name='FactSetConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FactSetConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FactSetConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/constructor[@name='FactSetConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe FactSetConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FactSetConfig)) {
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

		static Delegate cb_getSpacing;
#pragma warning disable 0169
		static Delegate GetGetSpacingHandler ()
		{
			if (cb_getSpacing == null)
				cb_getSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSpacing);
			return cb_getSpacing;
		}

		static long n_GetSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Spacing;
		}
#pragma warning restore 0169

		static Delegate cb_setSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetSpacing_JHandler ()
		{
			if (cb_setSpacing_J == null)
				cb_setSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSpacing_J);
			return cb_setSpacing_J;
		}

		static void n_SetSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Spacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpacing;
		static IntPtr id_setSpacing_J;
		public virtual unsafe long Spacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='getSpacing' and count(parameter)=0]"
			[Register ("getSpacing", "()J", "GetGetSpacingHandler")]
			get {
				if (id_getSpacing == IntPtr.Zero)
					id_getSpacing = JNIEnv.GetMethodID (class_ref, "getSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='setSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSpacing", "(J)V", "GetSetSpacing_JHandler")]
			set {
				if (id_setSpacing_J == IntPtr.Zero)
					id_setSpacing_J = JNIEnv.GetMethodID (class_ref, "setSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Lio_adaptivecards_objectmodel_TextConfig_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Lio_adaptivecards_objectmodel_TextConfig_Handler ()
		{
			if (cb_setTitle_Lio_adaptivecards_objectmodel_TextConfig_ == null)
				cb_setTitle_Lio_adaptivecards_objectmodel_TextConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Lio_adaptivecards_objectmodel_TextConfig_);
			return cb_setTitle_Lio_adaptivecards_objectmodel_TextConfig_;
		}

		static void n_SetTitle_Lio_adaptivecards_objectmodel_TextConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Lio_adaptivecards_objectmodel_TextConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextConfig Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Lio/adaptivecards/objectmodel/TextConfig;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Lio/adaptivecards/objectmodel/TextConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Lio/adaptivecards/objectmodel/TextConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextConfig']]"
			[Register ("setTitle", "(Lio/adaptivecards/objectmodel/TextConfig;)V", "GetSetTitle_Lio_adaptivecards_objectmodel_TextConfig_Handler")]
			set {
				if (id_setTitle_Lio_adaptivecards_objectmodel_TextConfig_ == IntPtr.Zero)
					id_setTitle_Lio_adaptivecards_objectmodel_TextConfig_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Lio/adaptivecards/objectmodel/TextConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Lio_adaptivecards_objectmodel_TextConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Lio/adaptivecards/objectmodel/TextConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Lio_adaptivecards_objectmodel_TextConfig_;
#pragma warning disable 0169
		static Delegate GetSetValue_Lio_adaptivecards_objectmodel_TextConfig_Handler ()
		{
			if (cb_setValue_Lio_adaptivecards_objectmodel_TextConfig_ == null)
				cb_setValue_Lio_adaptivecards_objectmodel_TextConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Lio_adaptivecards_objectmodel_TextConfig_);
			return cb_setValue_Lio_adaptivecards_objectmodel_TextConfig_;
		}

		static void n_SetValue_Lio_adaptivecards_objectmodel_TextConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Lio_adaptivecards_objectmodel_TextConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextConfig Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Lio/adaptivecards/objectmodel/TextConfig;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Lio/adaptivecards/objectmodel/TextConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Lio/adaptivecards/objectmodel/TextConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextConfig']]"
			[Register ("setValue", "(Lio/adaptivecards/objectmodel/TextConfig;)V", "GetSetValue_Lio_adaptivecards_objectmodel_TextConfig_Handler")]
			set {
				if (id_setValue_Lio_adaptivecards_objectmodel_TextConfig_ == IntPtr.Zero)
					id_setValue_Lio_adaptivecards_objectmodel_TextConfig_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Lio/adaptivecards/objectmodel/TextConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Lio_adaptivecards_objectmodel_TextConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Lio/adaptivecards/objectmodel/TextConfig;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FactSetConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.FactSetConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/FactSetConfig;)Lio/adaptivecards/objectmodel/FactSetConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.FactSetConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.FactSetConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FactSetConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FactSetConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/FactSetConfig;)Lio/adaptivecards/objectmodel/FactSetConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.FactSetConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FactSetConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.FactSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_FactSetConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactSetConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.FactSetConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/FactSetConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.FactSetConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_FactSetConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_FactSetConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/FactSetConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_FactSetConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
