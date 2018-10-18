using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextBlock", DoNotGenerateAcw=true)]
	public partial class TextBlock : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextBlock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextBlock); }
		}

		protected TextBlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/constructor[@name='TextBlock' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe TextBlock (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TextBlock)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/constructor[@name='TextBlock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextBlock ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextBlock)) {
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

		static Delegate cb_GetHorizontalAlignment;
#pragma warning disable 0169
		static Delegate GetGetHorizontalAlignmentHandler ()
		{
			if (cb_GetHorizontalAlignment == null)
				cb_GetHorizontalAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHorizontalAlignment);
			return cb_GetHorizontalAlignment;
		}

		static IntPtr n_GetHorizontalAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HorizontalAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
#pragma warning disable 0169
		static Delegate GetSetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_Handler ()
		{
			if (cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ == null)
				cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_);
			return cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
		}

		static void n_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HorizontalAlignment p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HorizontalAlignment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetHorizontalAlignment;
		static IntPtr id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.HorizontalAlignment HorizontalAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetHorizontalAlignment' and count(parameter)=0]"
			[Register ("GetHorizontalAlignment", "()Lio/adaptivecards/objectmodel/HorizontalAlignment;", "GetGetHorizontalAlignmentHandler")]
			get {
				if (id_GetHorizontalAlignment == IntPtr.Zero)
					id_GetHorizontalAlignment = JNIEnv.GetMethodID (class_ref, "GetHorizontalAlignment", "()Lio/adaptivecards/objectmodel/HorizontalAlignment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetHorizontalAlignment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHorizontalAlignment", "()Lio/adaptivecards/objectmodel/HorizontalAlignment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetHorizontalAlignment' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HorizontalAlignment']]"
			[Register ("SetHorizontalAlignment", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)V", "GetSetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_Handler")]
			set {
				if (id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ == IntPtr.Zero)
					id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ = JNIEnv.GetMethodID (class_ref, "SetHorizontalAlignment", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetHorizontalAlignment", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetIsSubtle;
#pragma warning disable 0169
		static Delegate GetGetIsSubtleHandler ()
		{
			if (cb_GetIsSubtle == null)
				cb_GetIsSubtle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsSubtle);
			return cb_GetIsSubtle;
		}

		static bool n_GetIsSubtle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSubtle;
		}
#pragma warning restore 0169

		static Delegate cb_SetIsSubtle_Z;
#pragma warning disable 0169
		static Delegate GetSetIsSubtle_ZHandler ()
		{
			if (cb_SetIsSubtle_Z == null)
				cb_SetIsSubtle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsSubtle_Z);
			return cb_SetIsSubtle_Z;
		}

		static void n_SetIsSubtle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsSubtle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetIsSubtle;
		static IntPtr id_SetIsSubtle_Z;
		public virtual unsafe bool IsSubtle {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetIsSubtle' and count(parameter)=0]"
			[Register ("GetIsSubtle", "()Z", "GetGetIsSubtleHandler")]
			get {
				if (id_GetIsSubtle == IntPtr.Zero)
					id_GetIsSubtle = JNIEnv.GetMethodID (class_ref, "GetIsSubtle", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetIsSubtle);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetIsSubtle", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetIsSubtle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetIsSubtle", "(Z)V", "GetSetIsSubtle_ZHandler")]
			set {
				if (id_SetIsSubtle_Z == IntPtr.Zero)
					id_SetIsSubtle_Z = JNIEnv.GetMethodID (class_ref, "SetIsSubtle", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetIsSubtle_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetIsSubtle", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_GetLanguage == null)
				cb_GetLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_GetLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate cb_SetLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_SetLanguage_Ljava_lang_String_ == null)
				cb_SetLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanguage_Ljava_lang_String_);
			return cb_SetLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Language = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetLanguage;
		static IntPtr id_SetLanguage_Ljava_lang_String_;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetLanguage' and count(parameter)=0]"
			[Register ("GetLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_GetLanguage == IntPtr.Zero)
					id_GetLanguage = JNIEnv.GetMethodID (class_ref, "GetLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				if (id_SetLanguage_Ljava_lang_String_ == IntPtr.Zero)
					id_SetLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetLanguage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetLanguage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLanguage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetMaxLines;
#pragma warning disable 0169
		static Delegate GetGetMaxLinesHandler ()
		{
			if (cb_GetMaxLines == null)
				cb_GetMaxLines = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxLines);
			return cb_GetMaxLines;
		}

		static long n_GetMaxLines (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLines;
		}
#pragma warning restore 0169

		static Delegate cb_SetMaxLines_J;
#pragma warning disable 0169
		static Delegate GetSetMaxLines_JHandler ()
		{
			if (cb_SetMaxLines_J == null)
				cb_SetMaxLines_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxLines_J);
			return cb_SetMaxLines_J;
		}

		static void n_SetMaxLines_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLines = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetMaxLines;
		static IntPtr id_SetMaxLines_J;
		public virtual unsafe long MaxLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetMaxLines' and count(parameter)=0]"
			[Register ("GetMaxLines", "()J", "GetGetMaxLinesHandler")]
			get {
				if (id_GetMaxLines == IntPtr.Zero)
					id_GetMaxLines = JNIEnv.GetMethodID (class_ref, "GetMaxLines", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetMaxLines);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMaxLines", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetMaxLines' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("SetMaxLines", "(J)V", "GetSetMaxLines_JHandler")]
			set {
				if (id_SetMaxLines_J == IntPtr.Zero)
					id_SetMaxLines_J = JNIEnv.GetMethodID (class_ref, "SetMaxLines", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetMaxLines_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMaxLines", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_GetText == null)
				cb_GetText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_GetText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_SetText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_SetText_Ljava_lang_String_ == null)
				cb_SetText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_SetText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Text = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetText;
		static IntPtr id_SetText_Ljava_lang_String_;
		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetText' and count(parameter)=0]"
			[Register ("GetText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_GetText == IntPtr.Zero)
					id_GetText = JNIEnv.GetMethodID (class_ref, "GetText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				if (id_SetText_Ljava_lang_String_ == IntPtr.Zero)
					id_SetText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_GetTextColor == null)
				cb_GetTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_GetTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor);
		}
#pragma warning restore 0169

		static Delegate cb_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_;
#pragma warning disable 0169
		static Delegate GetSetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_Handler ()
		{
			if (cb_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_ == null)
				cb_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_);
			return cb_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_;
		}

		static void n_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ForegroundColor p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetTextColor;
		static IntPtr id_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ForegroundColor TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetTextColor' and count(parameter)=0]"
			[Register ("GetTextColor", "()Lio/adaptivecards/objectmodel/ForegroundColor;", "GetGetTextColorHandler")]
			get {
				if (id_GetTextColor == IntPtr.Zero)
					id_GetTextColor = JNIEnv.GetMethodID (class_ref, "GetTextColor", "()Lio/adaptivecards/objectmodel/ForegroundColor;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTextColor", "()Lio/adaptivecards/objectmodel/ForegroundColor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetTextColor' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ForegroundColor']]"
			[Register ("SetTextColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;)V", "GetSetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_Handler")]
			set {
				if (id_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_ == IntPtr.Zero)
					id_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_ = JNIEnv.GetMethodID (class_ref, "SetTextColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetTextColor_Lio_adaptivecards_objectmodel_ForegroundColor_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetTextColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetTextForDateParsing;
#pragma warning disable 0169
		static Delegate GetGetTextForDateParsingHandler ()
		{
			if (cb_GetTextForDateParsing == null)
				cb_GetTextForDateParsing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextForDateParsing);
			return cb_GetTextForDateParsing;
		}

		static IntPtr n_GetTextForDateParsing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextForDateParsing);
		}
#pragma warning restore 0169

		static IntPtr id_GetTextForDateParsing;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparser TextForDateParsing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetTextForDateParsing' and count(parameter)=0]"
			[Register ("GetTextForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;", "GetGetTextForDateParsingHandler")]
			get {
				if (id_GetTextForDateParsing == IntPtr.Zero)
					id_GetTextForDateParsing = JNIEnv.GetMethodID (class_ref, "GetTextForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTextForDateParsing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTextForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_GetTextSize == null)
				cb_GetTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextSize);
			return cb_GetTextSize;
		}

		static IntPtr n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextSize);
		}
#pragma warning restore 0169

		static Delegate cb_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_;
#pragma warning disable 0169
		static Delegate GetSetTextSize_Lio_adaptivecards_objectmodel_TextSize_Handler ()
		{
			if (cb_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_ == null)
				cb_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_);
			return cb_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_;
		}

		static void n_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextSize p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetTextSize;
		static IntPtr id_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextSize TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetTextSize' and count(parameter)=0]"
			[Register ("GetTextSize", "()Lio/adaptivecards/objectmodel/TextSize;", "GetGetTextSizeHandler")]
			get {
				if (id_GetTextSize == IntPtr.Zero)
					id_GetTextSize = JNIEnv.GetMethodID (class_ref, "GetTextSize", "()Lio/adaptivecards/objectmodel/TextSize;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTextSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextSize> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTextSize", "()Lio/adaptivecards/objectmodel/TextSize;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetTextSize' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextSize']]"
			[Register ("SetTextSize", "(Lio/adaptivecards/objectmodel/TextSize;)V", "GetSetTextSize_Lio_adaptivecards_objectmodel_TextSize_Handler")]
			set {
				if (id_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_ == IntPtr.Zero)
					id_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_ = JNIEnv.GetMethodID (class_ref, "SetTextSize", "(Lio/adaptivecards/objectmodel/TextSize;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetTextSize_Lio_adaptivecards_objectmodel_TextSize_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetTextSize", "(Lio/adaptivecards/objectmodel/TextSize;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetTextWeight;
#pragma warning disable 0169
		static Delegate GetGetTextWeightHandler ()
		{
			if (cb_GetTextWeight == null)
				cb_GetTextWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextWeight);
			return cb_GetTextWeight;
		}

		static IntPtr n_GetTextWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextWeight);
		}
#pragma warning restore 0169

		static Delegate cb_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_;
#pragma warning disable 0169
		static Delegate GetSetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_Handler ()
		{
			if (cb_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_ == null)
				cb_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_);
			return cb_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_;
		}

		static void n_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextWeight p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetTextWeight;
		static IntPtr id_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.TextWeight TextWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetTextWeight' and count(parameter)=0]"
			[Register ("GetTextWeight", "()Lio/adaptivecards/objectmodel/TextWeight;", "GetGetTextWeightHandler")]
			get {
				if (id_GetTextWeight == IntPtr.Zero)
					id_GetTextWeight = JNIEnv.GetMethodID (class_ref, "GetTextWeight", "()Lio/adaptivecards/objectmodel/TextWeight;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTextWeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTextWeight", "()Lio/adaptivecards/objectmodel/TextWeight;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetTextWeight' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextWeight']]"
			[Register ("SetTextWeight", "(Lio/adaptivecards/objectmodel/TextWeight;)V", "GetSetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_Handler")]
			set {
				if (id_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_ == IntPtr.Zero)
					id_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_ = JNIEnv.GetMethodID (class_ref, "SetTextWeight", "(Lio/adaptivecards/objectmodel/TextWeight;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetTextWeight_Lio_adaptivecards_objectmodel_TextWeight_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetTextWeight", "(Lio/adaptivecards/objectmodel/TextWeight;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetWrap;
#pragma warning disable 0169
		static Delegate GetGetWrapHandler ()
		{
			if (cb_GetWrap == null)
				cb_GetWrap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWrap);
			return cb_GetWrap;
		}

		static bool n_GetWrap (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Wrap;
		}
#pragma warning restore 0169

		static Delegate cb_SetWrap_Z;
#pragma warning disable 0169
		static Delegate GetSetWrap_ZHandler ()
		{
			if (cb_SetWrap_Z == null)
				cb_SetWrap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWrap_Z);
			return cb_SetWrap_Z;
		}

		static void n_SetWrap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.TextBlock __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Wrap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetWrap;
		static IntPtr id_SetWrap_Z;
		public virtual unsafe bool Wrap {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='GetWrap' and count(parameter)=0]"
			[Register ("GetWrap", "()Z", "GetGetWrapHandler")]
			get {
				if (id_GetWrap == IntPtr.Zero)
					id_GetWrap = JNIEnv.GetMethodID (class_ref, "GetWrap", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetWrap);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetWrap", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='SetWrap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetWrap", "(Z)V", "GetSetWrap_ZHandler")]
			set {
				if (id_SetWrap_Z == IntPtr.Zero)
					id_SetWrap_Z = JNIEnv.GetMethodID (class_ref, "SetWrap", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetWrap_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetWrap", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/TextBlock;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextBlock Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/TextBlock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.TextBlock __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextBlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_TextBlock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextBlock']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.TextBlock']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/TextBlock;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.TextBlock p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_TextBlock_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_TextBlock_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/TextBlock;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_TextBlock_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
