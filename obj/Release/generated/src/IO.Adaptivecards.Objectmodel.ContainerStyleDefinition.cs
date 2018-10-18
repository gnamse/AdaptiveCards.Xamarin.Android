using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ContainerStyleDefinition", DoNotGenerateAcw=true)]
	public partial class ContainerStyleDefinition : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ContainerStyleDefinition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContainerStyleDefinition); }
		}

		protected ContainerStyleDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/constructor[@name='ContainerStyleDefinition' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContainerStyleDefinition ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ContainerStyleDefinition)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/constructor[@name='ContainerStyleDefinition' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ContainerStyleDefinition (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ContainerStyleDefinition)) {
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

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static IntPtr n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackgroundColor);
		}
#pragma warning restore 0169

		static Delegate cb_setBackgroundColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_Ljava_lang_String_Handler ()
		{
			if (cb_setBackgroundColor_Ljava_lang_String_ == null)
				cb_setBackgroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundColor_Ljava_lang_String_);
			return cb_setBackgroundColor_Ljava_lang_String_;
		}

		static void n_SetBackgroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundColor;
		static IntPtr id_setBackgroundColor_Ljava_lang_String_;
		public virtual unsafe string BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()Ljava/lang/String;", "GetGetBackgroundColorHandler")]
			get {
				if (id_getBackgroundColor == IntPtr.Zero)
					id_getBackgroundColor = JNIEnv.GetMethodID (class_ref, "getBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBackgroundColor", "(Ljava/lang/String;)V", "GetSetBackgroundColor_Ljava_lang_String_Handler")]
			set {
				if (id_setBackgroundColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setBackgroundColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBackgroundColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static IntPtr n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BorderColor);
		}
#pragma warning restore 0169

		static Delegate cb_setBorderColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_Ljava_lang_String_Handler ()
		{
			if (cb_setBorderColor_Ljava_lang_String_ == null)
				cb_setBorderColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBorderColor_Ljava_lang_String_);
			return cb_setBorderColor_Ljava_lang_String_;
		}

		static void n_SetBorderColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BorderColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderColor;
		static IntPtr id_setBorderColor_Ljava_lang_String_;
		public virtual unsafe string BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()Ljava/lang/String;", "GetGetBorderColorHandler")]
			get {
				if (id_getBorderColor == IntPtr.Zero)
					id_getBorderColor = JNIEnv.GetMethodID (class_ref, "getBorderColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBorderColor", "(Ljava/lang/String;)V", "GetSetBorderColor_Ljava_lang_String_Handler")]
			set {
				if (id_setBorderColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setBorderColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBorderColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBorderColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBorderThickness;
#pragma warning disable 0169
		static Delegate GetGetBorderThicknessHandler ()
		{
			if (cb_getBorderThickness == null)
				cb_getBorderThickness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBorderThickness);
			return cb_getBorderThickness;
		}

		static long n_GetBorderThickness (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderThickness;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderThickness_J;
#pragma warning disable 0169
		static Delegate GetSetBorderThickness_JHandler ()
		{
			if (cb_setBorderThickness_J == null)
				cb_setBorderThickness_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBorderThickness_J);
			return cb_setBorderThickness_J;
		}

		static void n_SetBorderThickness_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderThickness = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderThickness;
		static IntPtr id_setBorderThickness_J;
		public virtual unsafe long BorderThickness {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='getBorderThickness' and count(parameter)=0]"
			[Register ("getBorderThickness", "()J", "GetGetBorderThicknessHandler")]
			get {
				if (id_getBorderThickness == IntPtr.Zero)
					id_getBorderThickness = JNIEnv.GetMethodID (class_ref, "getBorderThickness", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBorderThickness);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderThickness", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='setBorderThickness' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBorderThickness", "(J)V", "GetSetBorderThickness_JHandler")]
			set {
				if (id_setBorderThickness_J == IntPtr.Zero)
					id_setBorderThickness_J = JNIEnv.GetMethodID (class_ref, "setBorderThickness", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBorderThickness_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderThickness", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getForegroundColors;
#pragma warning disable 0169
		static Delegate GetGetForegroundColorsHandler ()
		{
			if (cb_getForegroundColors == null)
				cb_getForegroundColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForegroundColors);
			return cb_getForegroundColors;
		}

		static IntPtr n_GetForegroundColors (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForegroundColors);
		}
#pragma warning restore 0169

		static Delegate cb_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_;
#pragma warning disable 0169
		static Delegate GetSetForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_Handler ()
		{
			if (cb_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_ == null)
				cb_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_);
			return cb_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_;
		}

		static void n_SetForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ColorsConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ForegroundColors = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getForegroundColors;
		static IntPtr id_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColorsConfig ForegroundColors {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='getForegroundColors' and count(parameter)=0]"
			[Register ("getForegroundColors", "()Lio/adaptivecards/objectmodel/ColorsConfig;", "GetGetForegroundColorsHandler")]
			get {
				if (id_getForegroundColors == IntPtr.Zero)
					id_getForegroundColors = JNIEnv.GetMethodID (class_ref, "getForegroundColors", "()Lio/adaptivecards/objectmodel/ColorsConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForegroundColors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColorsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getForegroundColors", "()Lio/adaptivecards/objectmodel/ColorsConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='setForegroundColors' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColorsConfig']]"
			[Register ("setForegroundColors", "(Lio/adaptivecards/objectmodel/ColorsConfig;)V", "GetSetForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_Handler")]
			set {
				if (id_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_ == IntPtr.Zero)
					id_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_ = JNIEnv.GetMethodID (class_ref, "setForegroundColors", "(Lio/adaptivecards/objectmodel/ColorsConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setForegroundColors_Lio_adaptivecards_objectmodel_ColorsConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setForegroundColors", "(Lio/adaptivecards/objectmodel/ColorsConfig;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ContainerStyleDefinition']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)Lio/adaptivecards/objectmodel/ContainerStyleDefinition;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)Lio/adaptivecards/objectmodel/ContainerStyleDefinition;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStyleDefinition']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyleDefinition']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
