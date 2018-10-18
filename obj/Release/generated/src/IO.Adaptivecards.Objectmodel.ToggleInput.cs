using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ToggleInput", DoNotGenerateAcw=true)]
	public partial class ToggleInput : global::IO.Adaptivecards.Objectmodel.BaseInputElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ToggleInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToggleInput); }
		}

		protected ToggleInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/constructor[@name='ToggleInput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ToggleInput ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ToggleInput)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/constructor[@name='ToggleInput' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ToggleInput (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ToggleInput)) {
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

		static Delegate cb_GetTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_GetTitle == null)
				cb_GetTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_GetTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_SetTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_SetTitle_Ljava_lang_String_ == null)
				cb_SetTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_SetTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetTitle;
		static IntPtr id_SetTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='GetTitle' and count(parameter)=0]"
			[Register ("GetTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_GetTitle == IntPtr.Zero)
					id_GetTitle = JNIEnv.GetMethodID (class_ref, "GetTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='SetTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_SetTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_SetTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_GetValue == null)
				cb_GetValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_GetValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_SetValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_SetValue_Ljava_lang_String_ == null)
				cb_SetValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_SetValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValue;
		static IntPtr id_SetValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='GetValue' and count(parameter)=0]"
			[Register ("GetValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_GetValue == IntPtr.Zero)
					id_GetValue = JNIEnv.GetMethodID (class_ref, "GetValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='SetValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
			set {
				if (id_SetValue_Ljava_lang_String_ == IntPtr.Zero)
					id_SetValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetValueOff;
#pragma warning disable 0169
		static Delegate GetGetValueOffHandler ()
		{
			if (cb_GetValueOff == null)
				cb_GetValueOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueOff);
			return cb_GetValueOff;
		}

		static IntPtr n_GetValueOff (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ValueOff);
		}
#pragma warning restore 0169

		static Delegate cb_SetValueOff_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValueOff_Ljava_lang_String_Handler ()
		{
			if (cb_SetValueOff_Ljava_lang_String_ == null)
				cb_SetValueOff_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueOff_Ljava_lang_String_);
			return cb_SetValueOff_Ljava_lang_String_;
		}

		static void n_SetValueOff_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueOff = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValueOff;
		static IntPtr id_SetValueOff_Ljava_lang_String_;
		public virtual unsafe string ValueOff {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='GetValueOff' and count(parameter)=0]"
			[Register ("GetValueOff", "()Ljava/lang/String;", "GetGetValueOffHandler")]
			get {
				if (id_GetValueOff == IntPtr.Zero)
					id_GetValueOff = JNIEnv.GetMethodID (class_ref, "GetValueOff", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetValueOff), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetValueOff", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='SetValueOff' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetValueOff", "(Ljava/lang/String;)V", "GetSetValueOff_Ljava_lang_String_Handler")]
			set {
				if (id_SetValueOff_Ljava_lang_String_ == IntPtr.Zero)
					id_SetValueOff_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetValueOff", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetValueOff_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetValueOff", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetValueOn;
#pragma warning disable 0169
		static Delegate GetGetValueOnHandler ()
		{
			if (cb_GetValueOn == null)
				cb_GetValueOn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueOn);
			return cb_GetValueOn;
		}

		static IntPtr n_GetValueOn (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ValueOn);
		}
#pragma warning restore 0169

		static Delegate cb_SetValueOn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValueOn_Ljava_lang_String_Handler ()
		{
			if (cb_SetValueOn_Ljava_lang_String_ == null)
				cb_SetValueOn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueOn_Ljava_lang_String_);
			return cb_SetValueOn_Ljava_lang_String_;
		}

		static void n_SetValueOn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ToggleInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueOn = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValueOn;
		static IntPtr id_SetValueOn_Ljava_lang_String_;
		public virtual unsafe string ValueOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='GetValueOn' and count(parameter)=0]"
			[Register ("GetValueOn", "()Ljava/lang/String;", "GetGetValueOnHandler")]
			get {
				if (id_GetValueOn == IntPtr.Zero)
					id_GetValueOn = JNIEnv.GetMethodID (class_ref, "GetValueOn", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetValueOn), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetValueOn", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='SetValueOn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetValueOn", "(Ljava/lang/String;)V", "GetSetValueOn_Ljava_lang_String_Handler")]
			set {
				if (id_SetValueOn_Ljava_lang_String_ == IntPtr.Zero)
					id_SetValueOn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetValueOn", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetValueOn_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetValueOn", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ToggleInput;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ToggleInput Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ToggleInput;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.ToggleInput __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleInput> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ToggleInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleInput']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ToggleInput']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ToggleInput;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ToggleInput p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ToggleInput_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ToggleInput_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ToggleInput;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ToggleInput_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
