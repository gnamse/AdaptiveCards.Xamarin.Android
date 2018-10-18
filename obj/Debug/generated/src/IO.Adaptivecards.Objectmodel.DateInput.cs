using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/DateInput", DoNotGenerateAcw=true)]
	public partial class DateInput : global::IO.Adaptivecards.Objectmodel.BaseInputElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/DateInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateInput); }
		}

		protected DateInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/constructor[@name='DateInput' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe DateInput (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (DateInput)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/constructor[@name='DateInput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateInput ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateInput)) {
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

		static Delegate cb_GetMax;
#pragma warning disable 0169
		static Delegate GetGetMaxHandler ()
		{
			if (cb_GetMax == null)
				cb_GetMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMax);
			return cb_GetMax;
		}

		static IntPtr n_GetMax (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Max);
		}
#pragma warning restore 0169

		static Delegate cb_SetMax_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMax_Ljava_lang_String_Handler ()
		{
			if (cb_SetMax_Ljava_lang_String_ == null)
				cb_SetMax_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMax_Ljava_lang_String_);
			return cb_SetMax_Ljava_lang_String_;
		}

		static void n_SetMax_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Max = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetMax;
		static IntPtr id_SetMax_Ljava_lang_String_;
		public virtual unsafe string Max {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='GetMax' and count(parameter)=0]"
			[Register ("GetMax", "()Ljava/lang/String;", "GetGetMaxHandler")]
			get {
				if (id_GetMax == IntPtr.Zero)
					id_GetMax = JNIEnv.GetMethodID (class_ref, "GetMax", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetMax), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMax", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='SetMax' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetMax", "(Ljava/lang/String;)V", "GetSetMax_Ljava_lang_String_Handler")]
			set {
				if (id_SetMax_Ljava_lang_String_ == IntPtr.Zero)
					id_SetMax_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetMax", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetMax_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMax", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetMin;
#pragma warning disable 0169
		static Delegate GetGetMinHandler ()
		{
			if (cb_GetMin == null)
				cb_GetMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMin);
			return cb_GetMin;
		}

		static IntPtr n_GetMin (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Min);
		}
#pragma warning restore 0169

		static Delegate cb_SetMin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMin_Ljava_lang_String_Handler ()
		{
			if (cb_SetMin_Ljava_lang_String_ == null)
				cb_SetMin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMin_Ljava_lang_String_);
			return cb_SetMin_Ljava_lang_String_;
		}

		static void n_SetMin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Min = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetMin;
		static IntPtr id_SetMin_Ljava_lang_String_;
		public virtual unsafe string Min {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='GetMin' and count(parameter)=0]"
			[Register ("GetMin", "()Ljava/lang/String;", "GetGetMinHandler")]
			get {
				if (id_GetMin == IntPtr.Zero)
					id_GetMin = JNIEnv.GetMethodID (class_ref, "GetMin", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetMin), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMin", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='SetMin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetMin", "(Ljava/lang/String;)V", "GetSetMin_Ljava_lang_String_Handler")]
			set {
				if (id_SetMin_Ljava_lang_String_ == IntPtr.Zero)
					id_SetMin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetMin", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetMin_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMin", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetPlaceholder;
#pragma warning disable 0169
		static Delegate GetGetPlaceholderHandler ()
		{
			if (cb_GetPlaceholder == null)
				cb_GetPlaceholder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaceholder);
			return cb_GetPlaceholder;
		}

		static IntPtr n_GetPlaceholder (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Placeholder);
		}
#pragma warning restore 0169

		static Delegate cb_SetPlaceholder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholder_Ljava_lang_String_Handler ()
		{
			if (cb_SetPlaceholder_Ljava_lang_String_ == null)
				cb_SetPlaceholder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceholder_Ljava_lang_String_);
			return cb_SetPlaceholder_Ljava_lang_String_;
		}

		static void n_SetPlaceholder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Placeholder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetPlaceholder;
		static IntPtr id_SetPlaceholder_Ljava_lang_String_;
		public virtual unsafe string Placeholder {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='GetPlaceholder' and count(parameter)=0]"
			[Register ("GetPlaceholder", "()Ljava/lang/String;", "GetGetPlaceholderHandler")]
			get {
				if (id_GetPlaceholder == IntPtr.Zero)
					id_GetPlaceholder = JNIEnv.GetMethodID (class_ref, "GetPlaceholder", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetPlaceholder), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPlaceholder", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='SetPlaceholder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetPlaceholder", "(Ljava/lang/String;)V", "GetSetPlaceholder_Ljava_lang_String_Handler")]
			set {
				if (id_SetPlaceholder_Ljava_lang_String_ == IntPtr.Zero)
					id_SetPlaceholder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetPlaceholder", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetPlaceholder_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPlaceholder", "(Ljava/lang/String;)V"), __args);
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
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.DateInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValue;
		static IntPtr id_SetValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='GetValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='SetValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/DateInput;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.DateInput Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/DateInput;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.DateInput __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_DateInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateInput']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.DateInput']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/DateInput;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.DateInput p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_DateInput_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_DateInput_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/DateInput;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_DateInput_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
