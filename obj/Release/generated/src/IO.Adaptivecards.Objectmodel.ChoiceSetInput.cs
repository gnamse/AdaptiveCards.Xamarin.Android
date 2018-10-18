using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ChoiceSetInput", DoNotGenerateAcw=true)]
	public partial class ChoiceSetInput : global::IO.Adaptivecards.Objectmodel.BaseInputElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ChoiceSetInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChoiceSetInput); }
		}

		protected ChoiceSetInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/constructor[@name='ChoiceSetInput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChoiceSetInput ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChoiceSetInput)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/constructor[@name='ChoiceSetInput' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ChoiceSetInput (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ChoiceSetInput)) {
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

		static Delegate cb_GetChoiceSetStyle;
#pragma warning disable 0169
		static Delegate GetGetChoiceSetStyleHandler ()
		{
			if (cb_GetChoiceSetStyle == null)
				cb_GetChoiceSetStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChoiceSetStyle);
			return cb_GetChoiceSetStyle;
		}

		static IntPtr n_GetChoiceSetStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChoiceSetStyle);
		}
#pragma warning restore 0169

		static Delegate cb_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_;
#pragma warning disable 0169
		static Delegate GetSetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_Handler ()
		{
			if (cb_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ == null)
				cb_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_);
			return cb_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_;
		}

		static void n_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChoiceSetStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetChoiceSetStyle;
		static IntPtr id_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle ChoiceSetStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='GetChoiceSetStyle' and count(parameter)=0]"
			[Register ("GetChoiceSetStyle", "()Lio/adaptivecards/objectmodel/ChoiceSetStyle;", "GetGetChoiceSetStyleHandler")]
			get {
				if (id_GetChoiceSetStyle == IntPtr.Zero)
					id_GetChoiceSetStyle = JNIEnv.GetMethodID (class_ref, "GetChoiceSetStyle", "()Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetChoiceSetStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetChoiceSetStyle", "()Lio/adaptivecards/objectmodel/ChoiceSetStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='SetChoiceSetStyle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ChoiceSetStyle']]"
			[Register ("SetChoiceSetStyle", "(Lio/adaptivecards/objectmodel/ChoiceSetStyle;)V", "GetSetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_Handler")]
			set {
				if (id_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ == IntPtr.Zero)
					id_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_ = JNIEnv.GetMethodID (class_ref, "SetChoiceSetStyle", "(Lio/adaptivecards/objectmodel/ChoiceSetStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetChoiceSetStyle_Lio_adaptivecards_objectmodel_ChoiceSetStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetChoiceSetStyle", "(Lio/adaptivecards/objectmodel/ChoiceSetStyle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetChoices;
#pragma warning disable 0169
		static Delegate GetGetChoicesHandler ()
		{
			if (cb_GetChoices == null)
				cb_GetChoices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChoices);
			return cb_GetChoices;
		}

		static IntPtr n_GetChoices (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Choices);
		}
#pragma warning restore 0169

		static IntPtr id_GetChoices;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ChoiceInputVector Choices {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='GetChoices' and count(parameter)=0]"
			[Register ("GetChoices", "()Lio/adaptivecards/objectmodel/ChoiceInputVector;", "GetGetChoicesHandler")]
			get {
				if (id_GetChoices == IntPtr.Zero)
					id_GetChoices = JNIEnv.GetMethodID (class_ref, "GetChoices", "()Lio/adaptivecards/objectmodel/ChoiceInputVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceInputVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetChoices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceInputVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetChoices", "()Lio/adaptivecards/objectmodel/ChoiceInputVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetIsMultiSelect;
#pragma warning disable 0169
		static Delegate GetGetIsMultiSelectHandler ()
		{
			if (cb_GetIsMultiSelect == null)
				cb_GetIsMultiSelect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsMultiSelect);
			return cb_GetIsMultiSelect;
		}

		static bool n_GetIsMultiSelect (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMultiSelect;
		}
#pragma warning restore 0169

		static Delegate cb_SetIsMultiSelect_Z;
#pragma warning disable 0169
		static Delegate GetSetIsMultiSelect_ZHandler ()
		{
			if (cb_SetIsMultiSelect_Z == null)
				cb_SetIsMultiSelect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsMultiSelect_Z);
			return cb_SetIsMultiSelect_Z;
		}

		static void n_SetIsMultiSelect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsMultiSelect = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetIsMultiSelect;
		static IntPtr id_SetIsMultiSelect_Z;
		public virtual unsafe bool IsMultiSelect {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='GetIsMultiSelect' and count(parameter)=0]"
			[Register ("GetIsMultiSelect", "()Z", "GetGetIsMultiSelectHandler")]
			get {
				if (id_GetIsMultiSelect == IntPtr.Zero)
					id_GetIsMultiSelect = JNIEnv.GetMethodID (class_ref, "GetIsMultiSelect", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetIsMultiSelect);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetIsMultiSelect", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='SetIsMultiSelect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetIsMultiSelect", "(Z)V", "GetSetIsMultiSelect_ZHandler")]
			set {
				if (id_SetIsMultiSelect_Z == IntPtr.Zero)
					id_SetIsMultiSelect_Z = JNIEnv.GetMethodID (class_ref, "SetIsMultiSelect", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetIsMultiSelect_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetIsMultiSelect", "(Z)V"), __args);
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
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValue;
		static IntPtr id_SetValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='GetValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='SetValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ChoiceSetInput;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ChoiceSetInput Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ChoiceSetInput;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.ChoiceSetInput __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetInput> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ChoiceSetInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetInput']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ChoiceSetInput']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ChoiceSetInput;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ChoiceSetInput p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ChoiceSetInput_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ChoiceSetInput_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ChoiceSetInput;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ChoiceSetInput_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
