using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/MediaSource", DoNotGenerateAcw=true)]
	public partial class MediaSource : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/MediaSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaSource); }
		}

		protected MediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/constructor[@name='MediaSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaSource ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaSource)) {
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

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_MediaSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/constructor[@name='MediaSource' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaSource']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/MediaSource;)V", "")]
		public unsafe MediaSource (global::IO.Adaptivecards.Objectmodel.MediaSource p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MediaSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/MediaSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/MediaSource;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_MediaSource_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_MediaSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/MediaSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_MediaSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_MediaSource_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/constructor[@name='MediaSource' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe MediaSource (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MediaSource)) {
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

		static Delegate cb_GetMimeType;
#pragma warning disable 0169
		static Delegate GetGetMimeTypeHandler ()
		{
			if (cb_GetMimeType == null)
				cb_GetMimeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMimeType);
			return cb_GetMimeType;
		}

		static IntPtr n_GetMimeType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		static Delegate cb_SetMimeType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMimeType_Ljava_lang_String_Handler ()
		{
			if (cb_SetMimeType_Ljava_lang_String_ == null)
				cb_SetMimeType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMimeType_Ljava_lang_String_);
			return cb_SetMimeType_Ljava_lang_String_;
		}

		static void n_SetMimeType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MimeType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetMimeType;
		static IntPtr id_SetMimeType_Ljava_lang_String_;
		public virtual unsafe string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='GetMimeType' and count(parameter)=0]"
			[Register ("GetMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				if (id_GetMimeType == IntPtr.Zero)
					id_GetMimeType = JNIEnv.GetMethodID (class_ref, "GetMimeType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetMimeType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMimeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='SetMimeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetMimeType", "(Ljava/lang/String;)V", "GetSetMimeType_Ljava_lang_String_Handler")]
			set {
				if (id_SetMimeType_Ljava_lang_String_ == IntPtr.Zero)
					id_SetMimeType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetMimeType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetMimeType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMimeType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_GetUrl == null)
				cb_GetUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_GetUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_SetUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_SetUrl_Ljava_lang_String_ == null)
				cb_SetUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_SetUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetUrl;
		static IntPtr id_SetUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='GetUrl' and count(parameter)=0]"
			[Register ("GetUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_GetUrl == IntPtr.Zero)
					id_GetUrl = JNIEnv.GetMethodID (class_ref, "GetUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='SetUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_SetUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_SetUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_;
#pragma warning disable 0169
		static Delegate GetGetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_Handler ()
		{
			if (cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ == null)
				cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_);
			return cb_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_;
		}

		static void n_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetResourceInformation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='GetResourceInformation' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.RemoteResourceInformationVector']]"
		[Register ("GetResourceInformation", "(Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;)V", "GetGetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_Handler")]
		public virtual unsafe void GetResourceInformation (global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector p0)
		{
			if (id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ == IntPtr.Zero)
				id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_ = JNIEnv.GetMethodID (class_ref, "GetResourceInformation", "(Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_GetResourceInformation_Lio_adaptivecards_objectmodel_RemoteResourceInformationVector_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetResourceInformation", "(Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_SerializeToJsonValue;
#pragma warning disable 0169
		static Delegate GetSerializeToJsonValueHandler ()
		{
			if (cb_SerializeToJsonValue == null)
				cb_SerializeToJsonValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SerializeToJsonValue);
			return cb_SerializeToJsonValue;
		}

		static IntPtr n_SerializeToJsonValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerializeToJsonValue ());
		}
#pragma warning restore 0169

		static IntPtr id_SerializeToJsonValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='SerializeToJsonValue' and count(parameter)=0]"
		[Register ("SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;", "GetSerializeToJsonValueHandler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.JsonValue SerializeToJsonValue ()
		{
			if (id_SerializeToJsonValue == IntPtr.Zero)
				id_SerializeToJsonValue = JNIEnv.GetMethodID (class_ref, "SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_SerializeToJsonValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;")), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.MediaSource __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_MediaSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSource']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaSource']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/MediaSource;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.MediaSource p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_MediaSource_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_MediaSource_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/MediaSource;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_MediaSource_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
