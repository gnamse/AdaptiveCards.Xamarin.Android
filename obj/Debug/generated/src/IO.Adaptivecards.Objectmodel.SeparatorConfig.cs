using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/SeparatorConfig", DoNotGenerateAcw=true)]
	public partial class SeparatorConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/SeparatorConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SeparatorConfig); }
		}

		protected SeparatorConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/constructor[@name='SeparatorConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SeparatorConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SeparatorConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/constructor[@name='SeparatorConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe SeparatorConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SeparatorConfig)) {
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

		static Delegate cb_getLineColor;
#pragma warning disable 0169
		static Delegate GetGetLineColorHandler ()
		{
			if (cb_getLineColor == null)
				cb_getLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLineColor);
			return cb_getLineColor;
		}

		static IntPtr n_GetLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SeparatorConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LineColor);
		}
#pragma warning restore 0169

		static Delegate cb_setLineColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLineColor_Ljava_lang_String_Handler ()
		{
			if (cb_setLineColor_Ljava_lang_String_ == null)
				cb_setLineColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLineColor_Ljava_lang_String_);
			return cb_setLineColor_Ljava_lang_String_;
		}

		static void n_SetLineColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.SeparatorConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LineColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLineColor;
		static IntPtr id_setLineColor_Ljava_lang_String_;
		public virtual unsafe string LineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='getLineColor' and count(parameter)=0]"
			[Register ("getLineColor", "()Ljava/lang/String;", "GetGetLineColorHandler")]
			get {
				if (id_getLineColor == IntPtr.Zero)
					id_getLineColor = JNIEnv.GetMethodID (class_ref, "getLineColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLineColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='setLineColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLineColor", "(Ljava/lang/String;)V", "GetSetLineColor_Ljava_lang_String_Handler")]
			set {
				if (id_setLineColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setLineColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLineColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLineColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLineThickness;
#pragma warning disable 0169
		static Delegate GetGetLineThicknessHandler ()
		{
			if (cb_getLineThickness == null)
				cb_getLineThickness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLineThickness);
			return cb_getLineThickness;
		}

		static long n_GetLineThickness (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.SeparatorConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineThickness;
		}
#pragma warning restore 0169

		static Delegate cb_setLineThickness_J;
#pragma warning disable 0169
		static Delegate GetSetLineThickness_JHandler ()
		{
			if (cb_setLineThickness_J == null)
				cb_setLineThickness_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLineThickness_J);
			return cb_setLineThickness_J;
		}

		static void n_SetLineThickness_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.SeparatorConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineThickness = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLineThickness;
		static IntPtr id_setLineThickness_J;
		public virtual unsafe long LineThickness {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='getLineThickness' and count(parameter)=0]"
			[Register ("getLineThickness", "()J", "GetGetLineThicknessHandler")]
			get {
				if (id_getLineThickness == IntPtr.Zero)
					id_getLineThickness = JNIEnv.GetMethodID (class_ref, "getLineThickness", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLineThickness);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineThickness", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='setLineThickness' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLineThickness", "(J)V", "GetSetLineThickness_JHandler")]
			set {
				if (id_setLineThickness_J == IntPtr.Zero)
					id_setLineThickness_J = JNIEnv.GetMethodID (class_ref, "setLineThickness", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLineThickness_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineThickness", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SeparatorConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.SeparatorConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/SeparatorConfig;)Lio/adaptivecards/objectmodel/SeparatorConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SeparatorConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.SeparatorConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SeparatorConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SeparatorConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/SeparatorConfig;)Lio/adaptivecards/objectmodel/SeparatorConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.SeparatorConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_SeparatorConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.SeparatorConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_SeparatorConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SeparatorConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/SeparatorConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.SeparatorConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_SeparatorConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_SeparatorConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/SeparatorConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_SeparatorConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
