using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ShowCardActionConfig", DoNotGenerateAcw=true)]
	public partial class ShowCardActionConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ShowCardActionConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShowCardActionConfig); }
		}

		protected ShowCardActionConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/constructor[@name='ShowCardActionConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShowCardActionConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ShowCardActionConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/constructor[@name='ShowCardActionConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ShowCardActionConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ShowCardActionConfig)) {
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

		static Delegate cb_getActionMode;
#pragma warning disable 0169
		static Delegate GetGetActionModeHandler ()
		{
			if (cb_getActionMode == null)
				cb_getActionMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionMode);
			return cb_getActionMode;
		}

		static IntPtr n_GetActionMode (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionMode);
		}
#pragma warning restore 0169

		static Delegate cb_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_;
#pragma warning disable 0169
		static Delegate GetSetActionMode_Lio_adaptivecards_objectmodel_ActionMode_Handler ()
		{
			if (cb_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_ == null)
				cb_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionMode_Lio_adaptivecards_objectmodel_ActionMode_);
			return cb_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_;
		}

		static void n_SetActionMode_Lio_adaptivecards_objectmodel_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionMode p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActionMode;
		static IntPtr id_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ActionMode ActionMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='getActionMode' and count(parameter)=0]"
			[Register ("getActionMode", "()Lio/adaptivecards/objectmodel/ActionMode;", "GetGetActionModeHandler")]
			get {
				if (id_getActionMode == IntPtr.Zero)
					id_getActionMode = JNIEnv.GetMethodID (class_ref, "getActionMode", "()Lio/adaptivecards/objectmodel/ActionMode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionMode", "()Lio/adaptivecards/objectmodel/ActionMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='setActionMode' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionMode']]"
			[Register ("setActionMode", "(Lio/adaptivecards/objectmodel/ActionMode;)V", "GetSetActionMode_Lio_adaptivecards_objectmodel_ActionMode_Handler")]
			set {
				if (id_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_ == IntPtr.Zero)
					id_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_ = JNIEnv.GetMethodID (class_ref, "setActionMode", "(Lio/adaptivecards/objectmodel/ActionMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionMode_Lio_adaptivecards_objectmodel_ActionMode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionMode", "(Lio/adaptivecards/objectmodel/ActionMode;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInlineTopMargin;
#pragma warning disable 0169
		static Delegate GetGetInlineTopMarginHandler ()
		{
			if (cb_getInlineTopMargin == null)
				cb_getInlineTopMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInlineTopMargin);
			return cb_getInlineTopMargin;
		}

		static long n_GetInlineTopMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InlineTopMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setInlineTopMargin_J;
#pragma warning disable 0169
		static Delegate GetSetInlineTopMargin_JHandler ()
		{
			if (cb_setInlineTopMargin_J == null)
				cb_setInlineTopMargin_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetInlineTopMargin_J);
			return cb_setInlineTopMargin_J;
		}

		static void n_SetInlineTopMargin_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InlineTopMargin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInlineTopMargin;
		static IntPtr id_setInlineTopMargin_J;
		public virtual unsafe long InlineTopMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='getInlineTopMargin' and count(parameter)=0]"
			[Register ("getInlineTopMargin", "()J", "GetGetInlineTopMarginHandler")]
			get {
				if (id_getInlineTopMargin == IntPtr.Zero)
					id_getInlineTopMargin = JNIEnv.GetMethodID (class_ref, "getInlineTopMargin", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getInlineTopMargin);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInlineTopMargin", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='setInlineTopMargin' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setInlineTopMargin", "(J)V", "GetSetInlineTopMargin_JHandler")]
			set {
				if (id_setInlineTopMargin_J == IntPtr.Zero)
					id_setInlineTopMargin_J = JNIEnv.GetMethodID (class_ref, "setInlineTopMargin", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInlineTopMargin_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInlineTopMargin", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStyle;
#pragma warning disable 0169
		static Delegate GetGetStyleHandler ()
		{
			if (cb_getStyle == null)
				cb_getStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyle);
			return cb_getStyle;
		}

		static IntPtr n_GetStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Style);
		}
#pragma warning restore 0169

		static Delegate cb_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_Handler ()
		{
			if (cb_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ == null)
				cb_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_);
			return cb_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
		}

		static void n_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyle p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Style = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStyle;
		static IntPtr id_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyle Style {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='getStyle' and count(parameter)=0]"
			[Register ("getStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;", "GetGetStyleHandler")]
			get {
				if (id_getStyle == IntPtr.Zero)
					id_getStyle = JNIEnv.GetMethodID (class_ref, "getStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='setStyle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
			[Register ("setStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V", "GetSetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_Handler")]
			set {
				if (id_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ == IntPtr.Zero)
					id_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNIEnv.GetMethodID (class_ref, "setStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStyle_Lio_adaptivecards_objectmodel_ContainerStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ShowCardActionConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ShowCardActionConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ShowCardActionConfig;)Lio/adaptivecards/objectmodel/ShowCardActionConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ShowCardActionConfig;)Lio/adaptivecards/objectmodel/ShowCardActionConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ShowCardActionConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardActionConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardActionConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ShowCardActionConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ShowCardActionConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ShowCardActionConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardActionConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
