using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/MediaConfig", DoNotGenerateAcw=true)]
	public partial class MediaConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/MediaConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaConfig); }
		}

		protected MediaConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/constructor[@name='MediaConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/constructor[@name='MediaConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe MediaConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MediaConfig)) {
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

		static Delegate cb_getAllowInlinePlayback;
#pragma warning disable 0169
		static Delegate GetGetAllowInlinePlaybackHandler ()
		{
			if (cb_getAllowInlinePlayback == null)
				cb_getAllowInlinePlayback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAllowInlinePlayback);
			return cb_getAllowInlinePlayback;
		}

		static bool n_GetAllowInlinePlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AllowInlinePlayback;
		}
#pragma warning restore 0169

		static Delegate cb_setAllowInlinePlayback_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowInlinePlayback_ZHandler ()
		{
			if (cb_setAllowInlinePlayback_Z == null)
				cb_setAllowInlinePlayback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowInlinePlayback_Z);
			return cb_setAllowInlinePlayback_Z;
		}

		static void n_SetAllowInlinePlayback_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowInlinePlayback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAllowInlinePlayback;
		static IntPtr id_setAllowInlinePlayback_Z;
		public virtual unsafe bool AllowInlinePlayback {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='getAllowInlinePlayback' and count(parameter)=0]"
			[Register ("getAllowInlinePlayback", "()Z", "GetGetAllowInlinePlaybackHandler")]
			get {
				if (id_getAllowInlinePlayback == IntPtr.Zero)
					id_getAllowInlinePlayback = JNIEnv.GetMethodID (class_ref, "getAllowInlinePlayback", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAllowInlinePlayback);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllowInlinePlayback", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='setAllowInlinePlayback' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowInlinePlayback", "(Z)V", "GetSetAllowInlinePlayback_ZHandler")]
			set {
				if (id_setAllowInlinePlayback_Z == IntPtr.Zero)
					id_setAllowInlinePlayback_Z = JNIEnv.GetMethodID (class_ref, "setAllowInlinePlayback", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllowInlinePlayback_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowInlinePlayback", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultPoster;
#pragma warning disable 0169
		static Delegate GetGetDefaultPosterHandler ()
		{
			if (cb_getDefaultPoster == null)
				cb_getDefaultPoster = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultPoster);
			return cb_getDefaultPoster;
		}

		static IntPtr n_GetDefaultPoster (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultPoster);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultPoster_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultPoster_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultPoster_Ljava_lang_String_ == null)
				cb_setDefaultPoster_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultPoster_Ljava_lang_String_);
			return cb_setDefaultPoster_Ljava_lang_String_;
		}

		static void n_SetDefaultPoster_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultPoster = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultPoster;
		static IntPtr id_setDefaultPoster_Ljava_lang_String_;
		public virtual unsafe string DefaultPoster {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='getDefaultPoster' and count(parameter)=0]"
			[Register ("getDefaultPoster", "()Ljava/lang/String;", "GetGetDefaultPosterHandler")]
			get {
				if (id_getDefaultPoster == IntPtr.Zero)
					id_getDefaultPoster = JNIEnv.GetMethodID (class_ref, "getDefaultPoster", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultPoster), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultPoster", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='setDefaultPoster' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDefaultPoster", "(Ljava/lang/String;)V", "GetSetDefaultPoster_Ljava_lang_String_Handler")]
			set {
				if (id_setDefaultPoster_Ljava_lang_String_ == IntPtr.Zero)
					id_setDefaultPoster_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultPoster", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultPoster_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultPoster", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPlayButton;
#pragma warning disable 0169
		static Delegate GetGetPlayButtonHandler ()
		{
			if (cb_getPlayButton == null)
				cb_getPlayButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayButton);
			return cb_getPlayButton;
		}

		static IntPtr n_GetPlayButton (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayButton);
		}
#pragma warning restore 0169

		static Delegate cb_setPlayButton_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlayButton_Ljava_lang_String_Handler ()
		{
			if (cb_setPlayButton_Ljava_lang_String_ == null)
				cb_setPlayButton_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayButton_Ljava_lang_String_);
			return cb_setPlayButton_Ljava_lang_String_;
		}

		static void n_SetPlayButton_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayButton = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPlayButton;
		static IntPtr id_setPlayButton_Ljava_lang_String_;
		public virtual unsafe string PlayButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='getPlayButton' and count(parameter)=0]"
			[Register ("getPlayButton", "()Ljava/lang/String;", "GetGetPlayButtonHandler")]
			get {
				if (id_getPlayButton == IntPtr.Zero)
					id_getPlayButton = JNIEnv.GetMethodID (class_ref, "getPlayButton", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayButton), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayButton", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='setPlayButton' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPlayButton", "(Ljava/lang/String;)V", "GetSetPlayButton_Ljava_lang_String_Handler")]
			set {
				if (id_setPlayButton_Ljava_lang_String_ == IntPtr.Zero)
					id_setPlayButton_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayButton", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayButton_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlayButton", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_MediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.MediaConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/MediaConfig;)Lio/adaptivecards/objectmodel/MediaConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.MediaConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.MediaConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_MediaConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_MediaConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/MediaConfig;)Lio/adaptivecards/objectmodel/MediaConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.MediaConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_MediaConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.MediaConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_MediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/MediaConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.MediaConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_MediaConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_MediaConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/MediaConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_MediaConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
