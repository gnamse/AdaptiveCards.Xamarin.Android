using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/Media", DoNotGenerateAcw=true)]
	public partial class Media : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/Media", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Media); }
		}

		protected Media (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/constructor[@name='Media' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Media (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Media)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/constructor[@name='Media' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Media ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Media)) {
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

		static Delegate cb_GetAltText;
#pragma warning disable 0169
		static Delegate GetGetAltTextHandler ()
		{
			if (cb_GetAltText == null)
				cb_GetAltText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAltText);
			return cb_GetAltText;
		}

		static IntPtr n_GetAltText (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Media __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AltText);
		}
#pragma warning restore 0169

		static Delegate cb_SetAltText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAltText_Ljava_lang_String_Handler ()
		{
			if (cb_SetAltText_Ljava_lang_String_ == null)
				cb_SetAltText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAltText_Ljava_lang_String_);
			return cb_SetAltText_Ljava_lang_String_;
		}

		static void n_SetAltText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Media __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AltText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetAltText;
		static IntPtr id_SetAltText_Ljava_lang_String_;
		public virtual unsafe string AltText {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='GetAltText' and count(parameter)=0]"
			[Register ("GetAltText", "()Ljava/lang/String;", "GetGetAltTextHandler")]
			get {
				if (id_GetAltText == IntPtr.Zero)
					id_GetAltText = JNIEnv.GetMethodID (class_ref, "GetAltText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetAltText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAltText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='SetAltText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetAltText", "(Ljava/lang/String;)V", "GetSetAltText_Ljava_lang_String_Handler")]
			set {
				if (id_SetAltText_Ljava_lang_String_ == IntPtr.Zero)
					id_SetAltText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetAltText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetAltText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetAltText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetPoster;
#pragma warning disable 0169
		static Delegate GetGetPosterHandler ()
		{
			if (cb_GetPoster == null)
				cb_GetPoster = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoster);
			return cb_GetPoster;
		}

		static IntPtr n_GetPoster (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Media __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Poster);
		}
#pragma warning restore 0169

		static Delegate cb_SetPoster_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPoster_Ljava_lang_String_Handler ()
		{
			if (cb_SetPoster_Ljava_lang_String_ == null)
				cb_SetPoster_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoster_Ljava_lang_String_);
			return cb_SetPoster_Ljava_lang_String_;
		}

		static void n_SetPoster_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Media __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Poster = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetPoster;
		static IntPtr id_SetPoster_Ljava_lang_String_;
		public virtual unsafe string Poster {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='GetPoster' and count(parameter)=0]"
			[Register ("GetPoster", "()Ljava/lang/String;", "GetGetPosterHandler")]
			get {
				if (id_GetPoster == IntPtr.Zero)
					id_GetPoster = JNIEnv.GetMethodID (class_ref, "GetPoster", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetPoster), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPoster", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='SetPoster' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetPoster", "(Ljava/lang/String;)V", "GetSetPoster_Ljava_lang_String_Handler")]
			set {
				if (id_SetPoster_Ljava_lang_String_ == IntPtr.Zero)
					id_SetPoster_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetPoster", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetPoster_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPoster", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetSources;
#pragma warning disable 0169
		static Delegate GetGetSourcesHandler ()
		{
			if (cb_GetSources == null)
				cb_GetSources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSources);
			return cb_GetSources;
		}

		static IntPtr n_GetSources (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Media __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sources);
		}
#pragma warning restore 0169

		static IntPtr id_GetSources;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.MediaSourceVector Sources {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='GetSources' and count(parameter)=0]"
			[Register ("GetSources", "()Lio/adaptivecards/objectmodel/MediaSourceVector;", "GetGetSourcesHandler")]
			get {
				if (id_GetSources == IntPtr.Zero)
					id_GetSources = JNIEnv.GetMethodID (class_ref, "GetSources", "()Lio/adaptivecards/objectmodel/MediaSourceVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSources), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSourceVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSources", "()Lio/adaptivecards/objectmodel/MediaSourceVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/Media;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Media Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/Media;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.Media __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Media> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_Media_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Media']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Media']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/Media;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.Media p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_Media_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_Media_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/Media;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_Media_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
