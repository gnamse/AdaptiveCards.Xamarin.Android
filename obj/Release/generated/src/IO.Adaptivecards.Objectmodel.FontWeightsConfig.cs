using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/FontWeightsConfig", DoNotGenerateAcw=true)]
	public partial class FontWeightsConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/FontWeightsConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FontWeightsConfig); }
		}

		protected FontWeightsConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/constructor[@name='FontWeightsConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FontWeightsConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FontWeightsConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/constructor[@name='FontWeightsConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe FontWeightsConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FontWeightsConfig)) {
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

		static Delegate cb_getBolderWeight;
#pragma warning disable 0169
		static Delegate GetGetBolderWeightHandler ()
		{
			if (cb_getBolderWeight == null)
				cb_getBolderWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBolderWeight);
			return cb_getBolderWeight;
		}

		static long n_GetBolderWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BolderWeight;
		}
#pragma warning restore 0169

		static Delegate cb_setBolderWeight_J;
#pragma warning disable 0169
		static Delegate GetSetBolderWeight_JHandler ()
		{
			if (cb_setBolderWeight_J == null)
				cb_setBolderWeight_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBolderWeight_J);
			return cb_setBolderWeight_J;
		}

		static void n_SetBolderWeight_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BolderWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBolderWeight;
		static IntPtr id_setBolderWeight_J;
		public virtual unsafe long BolderWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='getBolderWeight' and count(parameter)=0]"
			[Register ("getBolderWeight", "()J", "GetGetBolderWeightHandler")]
			get {
				if (id_getBolderWeight == IntPtr.Zero)
					id_getBolderWeight = JNIEnv.GetMethodID (class_ref, "getBolderWeight", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBolderWeight);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBolderWeight", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='setBolderWeight' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBolderWeight", "(J)V", "GetSetBolderWeight_JHandler")]
			set {
				if (id_setBolderWeight_J == IntPtr.Zero)
					id_setBolderWeight_J = JNIEnv.GetMethodID (class_ref, "setBolderWeight", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBolderWeight_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBolderWeight", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultWeight;
#pragma warning disable 0169
		static Delegate GetGetDefaultWeightHandler ()
		{
			if (cb_getDefaultWeight == null)
				cb_getDefaultWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDefaultWeight);
			return cb_getDefaultWeight;
		}

		static long n_GetDefaultWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultWeight;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultWeight_J;
#pragma warning disable 0169
		static Delegate GetSetDefaultWeight_JHandler ()
		{
			if (cb_setDefaultWeight_J == null)
				cb_setDefaultWeight_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDefaultWeight_J);
			return cb_setDefaultWeight_J;
		}

		static void n_SetDefaultWeight_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultWeight;
		static IntPtr id_setDefaultWeight_J;
		public virtual unsafe long DefaultWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='getDefaultWeight' and count(parameter)=0]"
			[Register ("getDefaultWeight", "()J", "GetGetDefaultWeightHandler")]
			get {
				if (id_getDefaultWeight == IntPtr.Zero)
					id_getDefaultWeight = JNIEnv.GetMethodID (class_ref, "getDefaultWeight", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultWeight);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultWeight", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='setDefaultWeight' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDefaultWeight", "(J)V", "GetSetDefaultWeight_JHandler")]
			set {
				if (id_setDefaultWeight_J == IntPtr.Zero)
					id_setDefaultWeight_J = JNIEnv.GetMethodID (class_ref, "setDefaultWeight", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultWeight_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultWeight", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLighterWeight;
#pragma warning disable 0169
		static Delegate GetGetLighterWeightHandler ()
		{
			if (cb_getLighterWeight == null)
				cb_getLighterWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLighterWeight);
			return cb_getLighterWeight;
		}

		static long n_GetLighterWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LighterWeight;
		}
#pragma warning restore 0169

		static Delegate cb_setLighterWeight_J;
#pragma warning disable 0169
		static Delegate GetSetLighterWeight_JHandler ()
		{
			if (cb_setLighterWeight_J == null)
				cb_setLighterWeight_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLighterWeight_J);
			return cb_setLighterWeight_J;
		}

		static void n_SetLighterWeight_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LighterWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLighterWeight;
		static IntPtr id_setLighterWeight_J;
		public virtual unsafe long LighterWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='getLighterWeight' and count(parameter)=0]"
			[Register ("getLighterWeight", "()J", "GetGetLighterWeightHandler")]
			get {
				if (id_getLighterWeight == IntPtr.Zero)
					id_getLighterWeight = JNIEnv.GetMethodID (class_ref, "getLighterWeight", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLighterWeight);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLighterWeight", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='setLighterWeight' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLighterWeight", "(J)V", "GetSetLighterWeight_JHandler")]
			set {
				if (id_setLighterWeight_J == IntPtr.Zero)
					id_setLighterWeight_J = JNIEnv.GetMethodID (class_ref, "setLighterWeight", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLighterWeight_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLighterWeight", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontWeightsConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.FontWeightsConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/FontWeightsConfig;)Lio/adaptivecards/objectmodel/FontWeightsConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.FontWeightsConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.FontWeightsConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontWeightsConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontWeightsConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/FontWeightsConfig;)Lio/adaptivecards/objectmodel/FontWeightsConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontWeightsConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_FontWeightsConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontWeightsConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.FontWeightsConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/FontWeightsConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.FontWeightsConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_FontWeightsConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_FontWeightsConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/FontWeightsConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_FontWeightsConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
