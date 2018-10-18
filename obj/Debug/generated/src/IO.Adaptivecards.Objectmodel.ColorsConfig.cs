using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ColorsConfig", DoNotGenerateAcw=true)]
	public partial class ColorsConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ColorsConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorsConfig); }
		}

		protected ColorsConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/constructor[@name='ColorsConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorsConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ColorsConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/constructor[@name='ColorsConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ColorsConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ColorsConfig)) {
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

		static Delegate cb_getAccent;
#pragma warning disable 0169
		static Delegate GetGetAccentHandler ()
		{
			if (cb_getAccent == null)
				cb_getAccent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccent);
			return cb_getAccent;
		}

		static IntPtr n_GetAccent (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Accent);
		}
#pragma warning restore 0169

		static Delegate cb_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetAccent_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccent_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetAccent_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accent = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccent;
		static IntPtr id_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig Accent {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getAccent' and count(parameter)=0]"
			[Register ("getAccent", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetAccentHandler")]
			get {
				if (id_getAccent == IntPtr.Zero)
					id_getAccent = JNIEnv.GetMethodID (class_ref, "getAccent", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccent", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setAccent' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setAccent", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetAccent_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setAccent", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccent_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccent", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAttention;
#pragma warning disable 0169
		static Delegate GetGetAttentionHandler ()
		{
			if (cb_getAttention == null)
				cb_getAttention = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttention);
			return cb_getAttention;
		}

		static IntPtr n_GetAttention (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attention);
		}
#pragma warning restore 0169

		static Delegate cb_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetAttention_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttention_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetAttention_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Attention = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAttention;
		static IntPtr id_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig Attention {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getAttention' and count(parameter)=0]"
			[Register ("getAttention", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetAttentionHandler")]
			get {
				if (id_getAttention == IntPtr.Zero)
					id_getAttention = JNIEnv.GetMethodID (class_ref, "getAttention", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttention), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttention", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setAttention' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setAttention", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetAttention_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setAttention", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttention_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttention", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDark;
#pragma warning disable 0169
		static Delegate GetGetDarkHandler ()
		{
			if (cb_getDark == null)
				cb_getDark = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDark);
			return cb_getDark;
		}

		static IntPtr n_GetDark (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dark);
		}
#pragma warning restore 0169

		static Delegate cb_setDark_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetDark_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setDark_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setDark_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDark_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setDark_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetDark_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Dark = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDark;
		static IntPtr id_setDark_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig Dark {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getDark' and count(parameter)=0]"
			[Register ("getDark", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetDarkHandler")]
			get {
				if (id_getDark == IntPtr.Zero)
					id_getDark = JNIEnv.GetMethodID (class_ref, "getDark", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDark), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDark", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setDark' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setDark", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetDark_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setDark_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setDark_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setDark", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDark_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDark", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultColor;
#pragma warning disable 0169
		static Delegate GetGetDefaultColorHandler ()
		{
			if (cb_getDefaultColor == null)
				cb_getDefaultColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultColor);
			return cb_getDefaultColor;
		}

		static IntPtr n_GetDefaultColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultColor);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultColor;
		static IntPtr id_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig DefaultColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getDefaultColor' and count(parameter)=0]"
			[Register ("getDefaultColor", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetDefaultColorHandler")]
			get {
				if (id_getDefaultColor == IntPtr.Zero)
					id_getDefaultColor = JNIEnv.GetMethodID (class_ref, "getDefaultColor", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultColor", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setDefaultColor' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setDefaultColor", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setDefaultColor", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultColor_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultColor", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGood;
#pragma warning disable 0169
		static Delegate GetGetGoodHandler ()
		{
			if (cb_getGood == null)
				cb_getGood = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGood);
			return cb_getGood;
		}

		static IntPtr n_GetGood (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Good);
		}
#pragma warning restore 0169

		static Delegate cb_setGood_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetGood_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setGood_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setGood_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGood_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setGood_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetGood_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Good = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGood;
		static IntPtr id_setGood_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig Good {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getGood' and count(parameter)=0]"
			[Register ("getGood", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetGoodHandler")]
			get {
				if (id_getGood == IntPtr.Zero)
					id_getGood = JNIEnv.GetMethodID (class_ref, "getGood", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGood), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGood", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setGood' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setGood", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetGood_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setGood_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setGood_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setGood", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGood_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGood", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLight;
#pragma warning disable 0169
		static Delegate GetGetLightHandler ()
		{
			if (cb_getLight == null)
				cb_getLight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLight);
			return cb_getLight;
		}

		static IntPtr n_GetLight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Light);
		}
#pragma warning restore 0169

		static Delegate cb_setLight_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetLight_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setLight_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setLight_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLight_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setLight_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetLight_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Light = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLight;
		static IntPtr id_setLight_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig Light {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getLight' and count(parameter)=0]"
			[Register ("getLight", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetLightHandler")]
			get {
				if (id_getLight == IntPtr.Zero)
					id_getLight = JNIEnv.GetMethodID (class_ref, "getLight", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLight", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setLight' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setLight", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetLight_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setLight_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setLight_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setLight", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLight_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLight", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWarning;
#pragma warning disable 0169
		static Delegate GetGetWarningHandler ()
		{
			if (cb_getWarning == null)
				cb_getWarning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWarning);
			return cb_getWarning;
		}

		static IntPtr n_GetWarning (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Warning);
		}
#pragma warning restore 0169

		static Delegate cb_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_;
#pragma warning disable 0169
		static Delegate GetSetWarning_Lio_adaptivecards_objectmodel_ColorConfig_Handler ()
		{
			if (cb_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_ == null)
				cb_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWarning_Lio_adaptivecards_objectmodel_ColorConfig_);
			return cb_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_;
		}

		static void n_SetWarning_Lio_adaptivecards_objectmodel_ColorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Warning = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWarning;
		static IntPtr id_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorConfig Warning {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getWarning' and count(parameter)=0]"
			[Register ("getWarning", "()Lio/adaptivecards/objectmodel/ColorConfig;", "GetGetWarningHandler")]
			get {
				if (id_getWarning == IntPtr.Zero)
					id_getWarning = JNIEnv.GetMethodID (class_ref, "getWarning", "()Lio/adaptivecards/objectmodel/ColorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWarning), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWarning", "()Lio/adaptivecards/objectmodel/ColorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='setWarning' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorConfig']]"
			[Register ("setWarning", "(Lio/adaptivecards/objectmodel/ColorConfig;)V", "GetSetWarning_Lio_adaptivecards_objectmodel_ColorConfig_Handler")]
			set {
				if (id_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_ == IntPtr.Zero)
					id_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_ = JNIEnv.GetMethodID (class_ref, "setWarning", "(Lio/adaptivecards/objectmodel/ColorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWarning_Lio_adaptivecards_objectmodel_ColorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWarning", "(Lio/adaptivecards/objectmodel/ColorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ColorsConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ColorsConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ColorsConfig;)Lio/adaptivecards/objectmodel/ColorsConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ColorsConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ColorsConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ColorsConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ColorsConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ColorsConfig;)Lio/adaptivecards/objectmodel/ColorsConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ColorsConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ColorsConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ColorsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ColorsConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColorsConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorsConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ColorsConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ColorsConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ColorsConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ColorsConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ColorsConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ColorsConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
