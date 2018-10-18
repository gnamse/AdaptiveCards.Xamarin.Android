using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ContainerStylesDefinition", DoNotGenerateAcw=true)]
	public partial class ContainerStylesDefinition : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ContainerStylesDefinition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContainerStylesDefinition); }
		}

		protected ContainerStylesDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/constructor[@name='ContainerStylesDefinition' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContainerStylesDefinition ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ContainerStylesDefinition)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/constructor[@name='ContainerStylesDefinition' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ContainerStylesDefinition (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ContainerStylesDefinition)) {
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

		static Delegate cb_getDefaultPalette;
#pragma warning disable 0169
		static Delegate GetGetDefaultPaletteHandler ()
		{
			if (cb_getDefaultPalette == null)
				cb_getDefaultPalette = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultPalette);
			return cb_getDefaultPalette;
		}

		static IntPtr n_GetDefaultPalette (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultPalette);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
#pragma warning disable 0169
		static Delegate GetSetDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_Handler ()
		{
			if (cb_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ == null)
				cb_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_);
			return cb_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
		}

		static void n_SetDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultPalette = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultPalette;
		static IntPtr id_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition DefaultPalette {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='getDefaultPalette' and count(parameter)=0]"
			[Register ("getDefaultPalette", "()Lio/adaptivecards/objectmodel/ContainerStyleDefinition;", "GetGetDefaultPaletteHandler")]
			get {
				if (id_getDefaultPalette == IntPtr.Zero)
					id_getDefaultPalette = JNIEnv.GetMethodID (class_ref, "getDefaultPalette", "()Lio/adaptivecards/objectmodel/ContainerStyleDefinition;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultPalette), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultPalette", "()Lio/adaptivecards/objectmodel/ContainerStyleDefinition;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='setDefaultPalette' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyleDefinition']]"
			[Register ("setDefaultPalette", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)V", "GetSetDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_Handler")]
			set {
				if (id_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ == IntPtr.Zero)
					id_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ = JNIEnv.GetMethodID (class_ref, "setDefaultPalette", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultPalette", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEmphasisPalette;
#pragma warning disable 0169
		static Delegate GetGetEmphasisPaletteHandler ()
		{
			if (cb_getEmphasisPalette == null)
				cb_getEmphasisPalette = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmphasisPalette);
			return cb_getEmphasisPalette;
		}

		static IntPtr n_GetEmphasisPalette (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EmphasisPalette);
		}
#pragma warning restore 0169

		static Delegate cb_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
#pragma warning disable 0169
		static Delegate GetSetEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_Handler ()
		{
			if (cb_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ == null)
				cb_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_);
			return cb_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
		}

		static void n_SetEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmphasisPalette = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmphasisPalette;
		static IntPtr id_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition EmphasisPalette {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='getEmphasisPalette' and count(parameter)=0]"
			[Register ("getEmphasisPalette", "()Lio/adaptivecards/objectmodel/ContainerStyleDefinition;", "GetGetEmphasisPaletteHandler")]
			get {
				if (id_getEmphasisPalette == IntPtr.Zero)
					id_getEmphasisPalette = JNIEnv.GetMethodID (class_ref, "getEmphasisPalette", "()Lio/adaptivecards/objectmodel/ContainerStyleDefinition;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmphasisPalette), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyleDefinition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmphasisPalette", "()Lio/adaptivecards/objectmodel/ContainerStyleDefinition;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='setEmphasisPalette' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyleDefinition']]"
			[Register ("setEmphasisPalette", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)V", "GetSetEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_Handler")]
			set {
				if (id_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ == IntPtr.Zero)
					id_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_ = JNIEnv.GetMethodID (class_ref, "setEmphasisPalette", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmphasisPalette_Lio_adaptivecards_objectmodel_ContainerStyleDefinition_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmphasisPalette", "(Lio/adaptivecards/objectmodel/ContainerStyleDefinition;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ContainerStylesDefinition']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)Lio/adaptivecards/objectmodel/ContainerStylesDefinition;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)Lio/adaptivecards/objectmodel/ContainerStylesDefinition;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ContainerStylesDefinition']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStylesDefinition']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
