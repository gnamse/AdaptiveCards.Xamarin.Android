using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/FontSizesConfig", DoNotGenerateAcw=true)]
	public partial class FontSizesConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/FontSizesConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FontSizesConfig); }
		}

		protected FontSizesConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/constructor[@name='FontSizesConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FontSizesConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FontSizesConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/constructor[@name='FontSizesConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe FontSizesConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FontSizesConfig)) {
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

		static Delegate cb_getDefaultFontSize;
#pragma warning disable 0169
		static Delegate GetGetDefaultFontSizeHandler ()
		{
			if (cb_getDefaultFontSize == null)
				cb_getDefaultFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDefaultFontSize);
			return cb_getDefaultFontSize;
		}

		static long n_GetDefaultFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultFontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultFontSize_J;
#pragma warning disable 0169
		static Delegate GetSetDefaultFontSize_JHandler ()
		{
			if (cb_setDefaultFontSize_J == null)
				cb_setDefaultFontSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDefaultFontSize_J);
			return cb_setDefaultFontSize_J;
		}

		static void n_SetDefaultFontSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultFontSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultFontSize;
		static IntPtr id_setDefaultFontSize_J;
		public virtual unsafe long DefaultFontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='getDefaultFontSize' and count(parameter)=0]"
			[Register ("getDefaultFontSize", "()J", "GetGetDefaultFontSizeHandler")]
			get {
				if (id_getDefaultFontSize == IntPtr.Zero)
					id_getDefaultFontSize = JNIEnv.GetMethodID (class_ref, "getDefaultFontSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultFontSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultFontSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='setDefaultFontSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDefaultFontSize", "(J)V", "GetSetDefaultFontSize_JHandler")]
			set {
				if (id_setDefaultFontSize_J == IntPtr.Zero)
					id_setDefaultFontSize_J = JNIEnv.GetMethodID (class_ref, "setDefaultFontSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultFontSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultFontSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraLargeFontSize;
#pragma warning disable 0169
		static Delegate GetGetExtraLargeFontSizeHandler ()
		{
			if (cb_getExtraLargeFontSize == null)
				cb_getExtraLargeFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExtraLargeFontSize);
			return cb_getExtraLargeFontSize;
		}

		static long n_GetExtraLargeFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraLargeFontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraLargeFontSize_J;
#pragma warning disable 0169
		static Delegate GetSetExtraLargeFontSize_JHandler ()
		{
			if (cb_setExtraLargeFontSize_J == null)
				cb_setExtraLargeFontSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExtraLargeFontSize_J);
			return cb_setExtraLargeFontSize_J;
		}

		static void n_SetExtraLargeFontSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraLargeFontSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtraLargeFontSize;
		static IntPtr id_setExtraLargeFontSize_J;
		public virtual unsafe long ExtraLargeFontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='getExtraLargeFontSize' and count(parameter)=0]"
			[Register ("getExtraLargeFontSize", "()J", "GetGetExtraLargeFontSizeHandler")]
			get {
				if (id_getExtraLargeFontSize == IntPtr.Zero)
					id_getExtraLargeFontSize = JNIEnv.GetMethodID (class_ref, "getExtraLargeFontSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getExtraLargeFontSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraLargeFontSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='setExtraLargeFontSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExtraLargeFontSize", "(J)V", "GetSetExtraLargeFontSize_JHandler")]
			set {
				if (id_setExtraLargeFontSize_J == IntPtr.Zero)
					id_setExtraLargeFontSize_J = JNIEnv.GetMethodID (class_ref, "setExtraLargeFontSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtraLargeFontSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtraLargeFontSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLargeFontSize;
#pragma warning disable 0169
		static Delegate GetGetLargeFontSizeHandler ()
		{
			if (cb_getLargeFontSize == null)
				cb_getLargeFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLargeFontSize);
			return cb_getLargeFontSize;
		}

		static long n_GetLargeFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LargeFontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setLargeFontSize_J;
#pragma warning disable 0169
		static Delegate GetSetLargeFontSize_JHandler ()
		{
			if (cb_setLargeFontSize_J == null)
				cb_setLargeFontSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLargeFontSize_J);
			return cb_setLargeFontSize_J;
		}

		static void n_SetLargeFontSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LargeFontSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLargeFontSize;
		static IntPtr id_setLargeFontSize_J;
		public virtual unsafe long LargeFontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='getLargeFontSize' and count(parameter)=0]"
			[Register ("getLargeFontSize", "()J", "GetGetLargeFontSizeHandler")]
			get {
				if (id_getLargeFontSize == IntPtr.Zero)
					id_getLargeFontSize = JNIEnv.GetMethodID (class_ref, "getLargeFontSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLargeFontSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLargeFontSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='setLargeFontSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLargeFontSize", "(J)V", "GetSetLargeFontSize_JHandler")]
			set {
				if (id_setLargeFontSize_J == IntPtr.Zero)
					id_setLargeFontSize_J = JNIEnv.GetMethodID (class_ref, "setLargeFontSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLargeFontSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLargeFontSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMediumFontSize;
#pragma warning disable 0169
		static Delegate GetGetMediumFontSizeHandler ()
		{
			if (cb_getMediumFontSize == null)
				cb_getMediumFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMediumFontSize);
			return cb_getMediumFontSize;
		}

		static long n_GetMediumFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediumFontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setMediumFontSize_J;
#pragma warning disable 0169
		static Delegate GetSetMediumFontSize_JHandler ()
		{
			if (cb_setMediumFontSize_J == null)
				cb_setMediumFontSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMediumFontSize_J);
			return cb_setMediumFontSize_J;
		}

		static void n_SetMediumFontSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediumFontSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediumFontSize;
		static IntPtr id_setMediumFontSize_J;
		public virtual unsafe long MediumFontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='getMediumFontSize' and count(parameter)=0]"
			[Register ("getMediumFontSize", "()J", "GetGetMediumFontSizeHandler")]
			get {
				if (id_getMediumFontSize == IntPtr.Zero)
					id_getMediumFontSize = JNIEnv.GetMethodID (class_ref, "getMediumFontSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMediumFontSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediumFontSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='setMediumFontSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMediumFontSize", "(J)V", "GetSetMediumFontSize_JHandler")]
			set {
				if (id_setMediumFontSize_J == IntPtr.Zero)
					id_setMediumFontSize_J = JNIEnv.GetMethodID (class_ref, "setMediumFontSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediumFontSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediumFontSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSmallFontSize;
#pragma warning disable 0169
		static Delegate GetGetSmallFontSizeHandler ()
		{
			if (cb_getSmallFontSize == null)
				cb_getSmallFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSmallFontSize);
			return cb_getSmallFontSize;
		}

		static long n_GetSmallFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmallFontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setSmallFontSize_J;
#pragma warning disable 0169
		static Delegate GetSetSmallFontSize_JHandler ()
		{
			if (cb_setSmallFontSize_J == null)
				cb_setSmallFontSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSmallFontSize_J);
			return cb_setSmallFontSize_J;
		}

		static void n_SetSmallFontSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmallFontSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSmallFontSize;
		static IntPtr id_setSmallFontSize_J;
		public virtual unsafe long SmallFontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='getSmallFontSize' and count(parameter)=0]"
			[Register ("getSmallFontSize", "()J", "GetGetSmallFontSizeHandler")]
			get {
				if (id_getSmallFontSize == IntPtr.Zero)
					id_getSmallFontSize = JNIEnv.GetMethodID (class_ref, "getSmallFontSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSmallFontSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmallFontSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='setSmallFontSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSmallFontSize", "(J)V", "GetSetSmallFontSize_JHandler")]
			set {
				if (id_setSmallFontSize_J == IntPtr.Zero)
					id_setSmallFontSize_J = JNIEnv.GetMethodID (class_ref, "setSmallFontSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmallFontSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmallFontSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontSizesConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.FontSizesConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/FontSizesConfig;)Lio/adaptivecards/objectmodel/FontSizesConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.FontSizesConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.FontSizesConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontSizesConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontSizesConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/FontSizesConfig;)Lio/adaptivecards/objectmodel/FontSizesConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.FontSizesConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_FontSizesConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_FontSizesConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FontSizesConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.FontSizesConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/FontSizesConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.FontSizesConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_FontSizesConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_FontSizesConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/FontSizesConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_FontSizesConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
