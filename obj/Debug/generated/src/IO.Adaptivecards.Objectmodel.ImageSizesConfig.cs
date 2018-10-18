using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ImageSizesConfig", DoNotGenerateAcw=true)]
	public partial class ImageSizesConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ImageSizesConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSizesConfig); }
		}

		protected ImageSizesConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/constructor[@name='ImageSizesConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageSizesConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ImageSizesConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/constructor[@name='ImageSizesConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ImageSizesConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ImageSizesConfig)) {
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

		static Delegate cb_getLargeSize;
#pragma warning disable 0169
		static Delegate GetGetLargeSizeHandler ()
		{
			if (cb_getLargeSize == null)
				cb_getLargeSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLargeSize);
			return cb_getLargeSize;
		}

		static long n_GetLargeSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LargeSize;
		}
#pragma warning restore 0169

		static Delegate cb_setLargeSize_J;
#pragma warning disable 0169
		static Delegate GetSetLargeSize_JHandler ()
		{
			if (cb_setLargeSize_J == null)
				cb_setLargeSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLargeSize_J);
			return cb_setLargeSize_J;
		}

		static void n_SetLargeSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LargeSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLargeSize;
		static IntPtr id_setLargeSize_J;
		public virtual unsafe long LargeSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='getLargeSize' and count(parameter)=0]"
			[Register ("getLargeSize", "()J", "GetGetLargeSizeHandler")]
			get {
				if (id_getLargeSize == IntPtr.Zero)
					id_getLargeSize = JNIEnv.GetMethodID (class_ref, "getLargeSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLargeSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLargeSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='setLargeSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLargeSize", "(J)V", "GetSetLargeSize_JHandler")]
			set {
				if (id_setLargeSize_J == IntPtr.Zero)
					id_setLargeSize_J = JNIEnv.GetMethodID (class_ref, "setLargeSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLargeSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLargeSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMediumSize;
#pragma warning disable 0169
		static Delegate GetGetMediumSizeHandler ()
		{
			if (cb_getMediumSize == null)
				cb_getMediumSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMediumSize);
			return cb_getMediumSize;
		}

		static long n_GetMediumSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediumSize;
		}
#pragma warning restore 0169

		static Delegate cb_setMediumSize_J;
#pragma warning disable 0169
		static Delegate GetSetMediumSize_JHandler ()
		{
			if (cb_setMediumSize_J == null)
				cb_setMediumSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMediumSize_J);
			return cb_setMediumSize_J;
		}

		static void n_SetMediumSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediumSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediumSize;
		static IntPtr id_setMediumSize_J;
		public virtual unsafe long MediumSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='getMediumSize' and count(parameter)=0]"
			[Register ("getMediumSize", "()J", "GetGetMediumSizeHandler")]
			get {
				if (id_getMediumSize == IntPtr.Zero)
					id_getMediumSize = JNIEnv.GetMethodID (class_ref, "getMediumSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMediumSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediumSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='setMediumSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMediumSize", "(J)V", "GetSetMediumSize_JHandler")]
			set {
				if (id_setMediumSize_J == IntPtr.Zero)
					id_setMediumSize_J = JNIEnv.GetMethodID (class_ref, "setMediumSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediumSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediumSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSmallSize;
#pragma warning disable 0169
		static Delegate GetGetSmallSizeHandler ()
		{
			if (cb_getSmallSize == null)
				cb_getSmallSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSmallSize);
			return cb_getSmallSize;
		}

		static long n_GetSmallSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmallSize;
		}
#pragma warning restore 0169

		static Delegate cb_setSmallSize_J;
#pragma warning disable 0169
		static Delegate GetSetSmallSize_JHandler ()
		{
			if (cb_setSmallSize_J == null)
				cb_setSmallSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSmallSize_J);
			return cb_setSmallSize_J;
		}

		static void n_SetSmallSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmallSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSmallSize;
		static IntPtr id_setSmallSize_J;
		public virtual unsafe long SmallSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='getSmallSize' and count(parameter)=0]"
			[Register ("getSmallSize", "()J", "GetGetSmallSizeHandler")]
			get {
				if (id_getSmallSize == IntPtr.Zero)
					id_getSmallSize = JNIEnv.GetMethodID (class_ref, "getSmallSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSmallSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmallSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='setSmallSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSmallSize", "(J)V", "GetSetSmallSize_JHandler")]
			set {
				if (id_setSmallSize_J == IntPtr.Zero)
					id_setSmallSize_J = JNIEnv.GetMethodID (class_ref, "setSmallSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmallSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmallSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSizesConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ImageSizesConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ImageSizesConfig;)Lio/adaptivecards/objectmodel/ImageSizesConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSizesConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ImageSizesConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSizesConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSizesConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ImageSizesConfig;)Lio/adaptivecards/objectmodel/ImageSizesConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSizesConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ImageSizesConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSizesConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSizesConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ImageSizesConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ImageSizesConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ImageSizesConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ImageSizesConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ImageSizesConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ImageSizesConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
