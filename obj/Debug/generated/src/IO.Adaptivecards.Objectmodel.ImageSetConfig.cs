using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ImageSetConfig", DoNotGenerateAcw=true)]
	public partial class ImageSetConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ImageSetConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSetConfig); }
		}

		protected ImageSetConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/constructor[@name='ImageSetConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageSetConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ImageSetConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/constructor[@name='ImageSetConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ImageSetConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ImageSetConfig)) {
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

		static Delegate cb_getImageSize;
#pragma warning disable 0169
		static Delegate GetGetImageSizeHandler ()
		{
			if (cb_getImageSize == null)
				cb_getImageSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageSize);
			return cb_getImageSize;
		}

		static IntPtr n_GetImageSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageSize);
		}
#pragma warning restore 0169

		static Delegate cb_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
#pragma warning disable 0169
		static Delegate GetSetImageSize_Lio_adaptivecards_objectmodel_ImageSize_Handler ()
		{
			if (cb_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_ == null)
				cb_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_);
			return cb_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
		}

		static void n_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageSize p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageSize;
		static IntPtr id_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageSize ImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='getImageSize' and count(parameter)=0]"
			[Register ("getImageSize", "()Lio/adaptivecards/objectmodel/ImageSize;", "GetGetImageSizeHandler")]
			get {
				if (id_getImageSize == IntPtr.Zero)
					id_getImageSize = JNIEnv.GetMethodID (class_ref, "getImageSize", "()Lio/adaptivecards/objectmodel/ImageSize;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageSize", "()Lio/adaptivecards/objectmodel/ImageSize;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='setImageSize' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSize']]"
			[Register ("setImageSize", "(Lio/adaptivecards/objectmodel/ImageSize;)V", "GetSetImageSize_Lio_adaptivecards_objectmodel_ImageSize_Handler")]
			set {
				if (id_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_ == IntPtr.Zero)
					id_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_ = JNIEnv.GetMethodID (class_ref, "setImageSize", "(Lio/adaptivecards/objectmodel/ImageSize;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageSize_Lio_adaptivecards_objectmodel_ImageSize_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageSize", "(Lio/adaptivecards/objectmodel/ImageSize;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxImageHeight;
#pragma warning disable 0169
		static Delegate GetGetMaxImageHeightHandler ()
		{
			if (cb_getMaxImageHeight == null)
				cb_getMaxImageHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxImageHeight);
			return cb_getMaxImageHeight;
		}

		static long n_GetMaxImageHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxImageHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxImageHeight_J;
#pragma warning disable 0169
		static Delegate GetSetMaxImageHeight_JHandler ()
		{
			if (cb_setMaxImageHeight_J == null)
				cb_setMaxImageHeight_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxImageHeight_J);
			return cb_setMaxImageHeight_J;
		}

		static void n_SetMaxImageHeight_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxImageHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxImageHeight;
		static IntPtr id_setMaxImageHeight_J;
		public virtual unsafe long MaxImageHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='getMaxImageHeight' and count(parameter)=0]"
			[Register ("getMaxImageHeight", "()J", "GetGetMaxImageHeightHandler")]
			get {
				if (id_getMaxImageHeight == IntPtr.Zero)
					id_getMaxImageHeight = JNIEnv.GetMethodID (class_ref, "getMaxImageHeight", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxImageHeight);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxImageHeight", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='setMaxImageHeight' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxImageHeight", "(J)V", "GetSetMaxImageHeight_JHandler")]
			set {
				if (id_setMaxImageHeight_J == IntPtr.Zero)
					id_setMaxImageHeight_J = JNIEnv.GetMethodID (class_ref, "setMaxImageHeight", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxImageHeight_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxImageHeight", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSetConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ImageSetConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ImageSetConfig;)Lio/adaptivecards/objectmodel/ImageSetConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSetConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ImageSetConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSetConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSetConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ImageSetConfig;)Lio/adaptivecards/objectmodel/ImageSetConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ImageSetConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ImageSetConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ImageSetConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ImageSetConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSetConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSetConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ImageSetConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ImageSetConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ImageSetConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ImageSetConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ImageSetConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ImageSetConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
