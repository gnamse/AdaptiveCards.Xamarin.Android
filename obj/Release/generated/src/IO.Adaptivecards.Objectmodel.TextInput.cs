using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextInput", DoNotGenerateAcw=true)]
	public partial class TextInput : global::IO.Adaptivecards.Objectmodel.BaseInputElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextInput); }
		}

		protected TextInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/constructor[@name='TextInput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextInput ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextInput)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/constructor[@name='TextInput' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe TextInput (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TextInput)) {
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

		static Delegate cb_GetIsMultiline;
#pragma warning disable 0169
		static Delegate GetGetIsMultilineHandler ()
		{
			if (cb_GetIsMultiline == null)
				cb_GetIsMultiline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsMultiline);
			return cb_GetIsMultiline;
		}

		static bool n_GetIsMultiline (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMultiline;
		}
#pragma warning restore 0169

		static Delegate cb_SetIsMultiline_Z;
#pragma warning disable 0169
		static Delegate GetSetIsMultiline_ZHandler ()
		{
			if (cb_SetIsMultiline_Z == null)
				cb_SetIsMultiline_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsMultiline_Z);
			return cb_SetIsMultiline_Z;
		}

		static void n_SetIsMultiline_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsMultiline = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetIsMultiline;
		static IntPtr id_SetIsMultiline_Z;
		public virtual unsafe bool IsMultiline {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='GetIsMultiline' and count(parameter)=0]"
			[Register ("GetIsMultiline", "()Z", "GetGetIsMultilineHandler")]
			get {
				if (id_GetIsMultiline == IntPtr.Zero)
					id_GetIsMultiline = JNIEnv.GetMethodID (class_ref, "GetIsMultiline", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetIsMultiline);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetIsMultiline", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='SetIsMultiline' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetIsMultiline", "(Z)V", "GetSetIsMultiline_ZHandler")]
			set {
				if (id_SetIsMultiline_Z == IntPtr.Zero)
					id_SetIsMultiline_Z = JNIEnv.GetMethodID (class_ref, "SetIsMultiline", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetIsMultiline_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetIsMultiline", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetMaxLength;
#pragma warning disable 0169
		static Delegate GetGetMaxLengthHandler ()
		{
			if (cb_GetMaxLength == null)
				cb_GetMaxLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxLength);
			return cb_GetMaxLength;
		}

		static long n_GetMaxLength (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLength;
		}
#pragma warning restore 0169

		static Delegate cb_SetMaxLength_J;
#pragma warning disable 0169
		static Delegate GetSetMaxLength_JHandler ()
		{
			if (cb_SetMaxLength_J == null)
				cb_SetMaxLength_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxLength_J);
			return cb_SetMaxLength_J;
		}

		static void n_SetMaxLength_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetMaxLength;
		static IntPtr id_SetMaxLength_J;
		public virtual unsafe long MaxLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='GetMaxLength' and count(parameter)=0]"
			[Register ("GetMaxLength", "()J", "GetGetMaxLengthHandler")]
			get {
				if (id_GetMaxLength == IntPtr.Zero)
					id_GetMaxLength = JNIEnv.GetMethodID (class_ref, "GetMaxLength", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetMaxLength);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMaxLength", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='SetMaxLength' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("SetMaxLength", "(J)V", "GetSetMaxLength_JHandler")]
			set {
				if (id_SetMaxLength_J == IntPtr.Zero)
					id_SetMaxLength_J = JNIEnv.GetMethodID (class_ref, "SetMaxLength", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetMaxLength_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMaxLength", "(J)V"), __args);
				} finally {
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
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Placeholder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetPlaceholder;
		static IntPtr id_SetPlaceholder_Ljava_lang_String_;
		public virtual unsafe string Placeholder {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='GetPlaceholder' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='SetPlaceholder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_GetTextInputStyle;
#pragma warning disable 0169
		static Delegate GetGetTextInputStyleHandler ()
		{
			if (cb_GetTextInputStyle == null)
				cb_GetTextInputStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextInputStyle);
			return cb_GetTextInputStyle;
		}

		static IntPtr n_GetTextInputStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextInputStyle);
		}
#pragma warning restore 0169

		static Delegate cb_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_;
#pragma warning disable 0169
		static Delegate GetSetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_Handler ()
		{
			if (cb_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_ == null)
				cb_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_);
			return cb_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_;
		}

		static void n_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextInputStyle p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextInputStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetTextInputStyle;
		static IntPtr id_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextInputStyle TextInputStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='GetTextInputStyle' and count(parameter)=0]"
			[Register ("GetTextInputStyle", "()Lio/adaptivecards/objectmodel/TextInputStyle;", "GetGetTextInputStyleHandler")]
			get {
				if (id_GetTextInputStyle == IntPtr.Zero)
					id_GetTextInputStyle = JNIEnv.GetMethodID (class_ref, "GetTextInputStyle", "()Lio/adaptivecards/objectmodel/TextInputStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTextInputStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTextInputStyle", "()Lio/adaptivecards/objectmodel/TextInputStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='SetTextInputStyle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextInputStyle']]"
			[Register ("SetTextInputStyle", "(Lio/adaptivecards/objectmodel/TextInputStyle;)V", "GetSetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_Handler")]
			set {
				if (id_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_ == IntPtr.Zero)
					id_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_ = JNIEnv.GetMethodID (class_ref, "SetTextInputStyle", "(Lio/adaptivecards/objectmodel/TextInputStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetTextInputStyle_Lio_adaptivecards_objectmodel_TextInputStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetTextInputStyle", "(Lio/adaptivecards/objectmodel/TextInputStyle;)V"), __args);
				} finally {
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
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.TextInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValue;
		static IntPtr id_SetValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='GetValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='SetValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/TextInput;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextInput Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/TextInput;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.TextInput __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInput> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_TextInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInput']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextInput']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/TextInput;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.TextInput p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_TextInput_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_TextInput_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/TextInput;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_TextInput_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
