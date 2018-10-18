using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/Fact", DoNotGenerateAcw=true)]
	public partial class Fact : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/Fact", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Fact); }
		}

		protected Fact (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/constructor[@name='Fact' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Fact ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Fact)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/constructor[@name='Fact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Fact (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (Fact)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/constructor[@name='Fact' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Fact (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Fact)) {
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Language = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetLanguage;
		static IntPtr id_SetLanguage_Ljava_lang_String_;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='GetLanguage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='SetLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetTitle;
		static IntPtr id_SetTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='GetTitle' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='SetTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_GetTitleForDateParsing;
#pragma warning disable 0169
		static Delegate GetGetTitleForDateParsingHandler ()
		{
			if (cb_GetTitleForDateParsing == null)
				cb_GetTitleForDateParsing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleForDateParsing);
			return cb_GetTitleForDateParsing;
		}

		static IntPtr n_GetTitleForDateParsing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleForDateParsing);
		}
#pragma warning restore 0169

		static IntPtr id_GetTitleForDateParsing;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparser TitleForDateParsing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='GetTitleForDateParsing' and count(parameter)=0]"
			[Register ("GetTitleForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;", "GetGetTitleForDateParsingHandler")]
			get {
				if (id_GetTitleForDateParsing == IntPtr.Zero)
					id_GetTitleForDateParsing = JNIEnv.GetMethodID (class_ref, "GetTitleForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetTitleForDateParsing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTitleForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;")), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetValue;
		static IntPtr id_SetValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='GetValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='SetValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_GetValueForDateParsing;
#pragma warning disable 0169
		static Delegate GetGetValueForDateParsingHandler ()
		{
			if (cb_GetValueForDateParsing == null)
				cb_GetValueForDateParsing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueForDateParsing);
			return cb_GetValueForDateParsing;
		}

		static IntPtr n_GetValueForDateParsing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueForDateParsing);
		}
#pragma warning restore 0169

		static IntPtr id_GetValueForDateParsing;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparser ValueForDateParsing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='GetValueForDateParsing' and count(parameter)=0]"
			[Register ("GetValueForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;", "GetGetValueForDateParsingHandler")]
			get {
				if (id_GetValueForDateParsing == IntPtr.Zero)
					id_GetValueForDateParsing = JNIEnv.GetMethodID (class_ref, "GetValueForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetValueForDateParsing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetValueForDateParsing", "()Lio/adaptivecards/objectmodel/DateTimePreparser;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='Deserialize' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='io.adaptivecards.objectmodel.JsonValue']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/Fact;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Fact Deserialize (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, global::IO.Adaptivecards.Objectmodel.JsonValue p3)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/Fact;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::IO.Adaptivecards.Objectmodel.Fact __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Lio_adaptivecards_objectmodel_JsonValue_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='DeserializeFromString' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionParserRegistration'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector'] and parameter[4][@type='java.lang.String']]"
		[Register ("DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/Fact;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Fact DeserializeFromString (global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p0, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p2, string p3)
		{
			if (id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;Ljava/lang/String;)Lio/adaptivecards/objectmodel/Fact;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::IO.Adaptivecards.Objectmodel.Fact __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_Serialize;
#pragma warning disable 0169
		static Delegate GetSerializeHandler ()
		{
			if (cb_Serialize == null)
				cb_Serialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Serialize);
			return cb_Serialize;
		}

		static IntPtr n_Serialize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Serialize ());
		}
#pragma warning restore 0169

		static IntPtr id_Serialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='Serialize' and count(parameter)=0]"
		[Register ("Serialize", "()Ljava/lang/String;", "GetSerializeHandler")]
		public virtual unsafe string Serialize ()
		{
			if (id_Serialize == IntPtr.Zero)
				id_Serialize = JNIEnv.GetMethodID (class_ref, "Serialize", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Serialize), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Serialize", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerializeToJsonValue ());
		}
#pragma warning restore 0169

		static IntPtr id_SerializeToJsonValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='SerializeToJsonValue' and count(parameter)=0]"
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
			global::IO.Adaptivecards.Objectmodel.Fact __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_Fact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Fact']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Fact']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/Fact;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.Fact p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_Fact_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_Fact_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/Fact;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_Fact_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
