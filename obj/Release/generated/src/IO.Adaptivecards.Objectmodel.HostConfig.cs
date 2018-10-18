using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/HostConfig", DoNotGenerateAcw=true)]
	public partial class HostConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/HostConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HostConfig); }
		}

		protected HostConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/constructor[@name='HostConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HostConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HostConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/constructor[@name='HostConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe HostConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (HostConfig)) {
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

		static Delegate cb_getActions;
#pragma warning disable 0169
		static Delegate GetGetActionsHandler ()
		{
			if (cb_getActions == null)
				cb_getActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActions);
			return cb_getActions;
		}

		static IntPtr n_GetActions (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Actions);
		}
#pragma warning restore 0169

		static Delegate cb_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_;
#pragma warning disable 0169
		static Delegate GetSetActions_Lio_adaptivecards_objectmodel_ActionsConfig_Handler ()
		{
			if (cb_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_ == null)
				cb_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActions_Lio_adaptivecards_objectmodel_ActionsConfig_);
			return cb_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_;
		}

		static void n_SetActions_Lio_adaptivecards_objectmodel_ActionsConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionsConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Actions = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActions;
		static IntPtr id_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ActionsConfig Actions {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getActions' and count(parameter)=0]"
			[Register ("getActions", "()Lio/adaptivecards/objectmodel/ActionsConfig;", "GetGetActionsHandler")]
			get {
				if (id_getActions == IntPtr.Zero)
					id_getActions = JNIEnv.GetMethodID (class_ref, "getActions", "()Lio/adaptivecards/objectmodel/ActionsConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActions", "()Lio/adaptivecards/objectmodel/ActionsConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setActions' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionsConfig']]"
			[Register ("setActions", "(Lio/adaptivecards/objectmodel/ActionsConfig;)V", "GetSetActions_Lio_adaptivecards_objectmodel_ActionsConfig_Handler")]
			set {
				if (id_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_ == IntPtr.Zero)
					id_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_ = JNIEnv.GetMethodID (class_ref, "setActions", "(Lio/adaptivecards/objectmodel/ActionsConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActions_Lio_adaptivecards_objectmodel_ActionsConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActions", "(Lio/adaptivecards/objectmodel/ActionsConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAdaptiveCard;
#pragma warning disable 0169
		static Delegate GetGetAdaptiveCardHandler ()
		{
			if (cb_getAdaptiveCard == null)
				cb_getAdaptiveCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdaptiveCard);
			return cb_getAdaptiveCard;
		}

		static IntPtr n_GetAdaptiveCard (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdaptiveCard);
		}
#pragma warning restore 0169

		static Delegate cb_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_;
#pragma warning disable 0169
		static Delegate GetSetAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_Handler ()
		{
			if (cb_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_ == null)
				cb_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_);
			return cb_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_;
		}

		static void n_SetAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCardConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdaptiveCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdaptiveCard;
		static IntPtr id_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCardConfig AdaptiveCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getAdaptiveCard' and count(parameter)=0]"
			[Register ("getAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCardConfig;", "GetGetAdaptiveCardHandler")]
			get {
				if (id_getAdaptiveCard == IntPtr.Zero)
					id_getAdaptiveCard = JNIEnv.GetMethodID (class_ref, "getAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCardConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdaptiveCard), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCardConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setAdaptiveCard' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCardConfig']]"
			[Register ("setAdaptiveCard", "(Lio/adaptivecards/objectmodel/AdaptiveCardConfig;)V", "GetSetAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_Handler")]
			set {
				if (id_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_ == IntPtr.Zero)
					id_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_ = JNIEnv.GetMethodID (class_ref, "setAdaptiveCard", "(Lio/adaptivecards/objectmodel/AdaptiveCardConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdaptiveCard", "(Lio/adaptivecards/objectmodel/AdaptiveCardConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContainerStyles;
#pragma warning disable 0169
		static Delegate GetGetContainerStylesHandler ()
		{
			if (cb_getContainerStyles == null)
				cb_getContainerStyles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContainerStyles);
			return cb_getContainerStyles;
		}

		static IntPtr n_GetContainerStyles (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContainerStyles);
		}
#pragma warning restore 0169

		static Delegate cb_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_;
#pragma warning disable 0169
		static Delegate GetSetContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_Handler ()
		{
			if (cb_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ == null)
				cb_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_);
			return cb_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_;
		}

		static void n_SetContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContainerStyles = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContainerStyles;
		static IntPtr id_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition ContainerStyles {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getContainerStyles' and count(parameter)=0]"
			[Register ("getContainerStyles", "()Lio/adaptivecards/objectmodel/ContainerStylesDefinition;", "GetGetContainerStylesHandler")]
			get {
				if (id_getContainerStyles == IntPtr.Zero)
					id_getContainerStyles = JNIEnv.GetMethodID (class_ref, "getContainerStyles", "()Lio/adaptivecards/objectmodel/ContainerStylesDefinition;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContainerStyles), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStylesDefinition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContainerStyles", "()Lio/adaptivecards/objectmodel/ContainerStylesDefinition;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setContainerStyles' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStylesDefinition']]"
			[Register ("setContainerStyles", "(Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)V", "GetSetContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_Handler")]
			set {
				if (id_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ == IntPtr.Zero)
					id_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_ = JNIEnv.GetMethodID (class_ref, "setContainerStyles", "(Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContainerStyles_Lio_adaptivecards_objectmodel_ContainerStylesDefinition_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContainerStyles", "(Lio/adaptivecards/objectmodel/ContainerStylesDefinition;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFactSet;
#pragma warning disable 0169
		static Delegate GetGetFactSetHandler ()
		{
			if (cb_getFactSet == null)
				cb_getFactSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFactSet);
			return cb_getFactSet;
		}

		static IntPtr n_GetFactSet (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FactSet);
		}
#pragma warning restore 0169

		static Delegate cb_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_;
#pragma warning disable 0169
		static Delegate GetSetFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_Handler ()
		{
			if (cb_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_ == null)
				cb_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_);
			return cb_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_;
		}

		static void n_SetFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.FactSetConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FactSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFactSet;
		static IntPtr id_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.FactSetConfig FactSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getFactSet' and count(parameter)=0]"
			[Register ("getFactSet", "()Lio/adaptivecards/objectmodel/FactSetConfig;", "GetGetFactSetHandler")]
			get {
				if (id_getFactSet == IntPtr.Zero)
					id_getFactSet = JNIEnv.GetMethodID (class_ref, "getFactSet", "()Lio/adaptivecards/objectmodel/FactSetConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFactSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FactSetConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFactSet", "()Lio/adaptivecards/objectmodel/FactSetConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setFactSet' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.FactSetConfig']]"
			[Register ("setFactSet", "(Lio/adaptivecards/objectmodel/FactSetConfig;)V", "GetSetFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_Handler")]
			set {
				if (id_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_ == IntPtr.Zero)
					id_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_ = JNIEnv.GetMethodID (class_ref, "setFactSet", "(Lio/adaptivecards/objectmodel/FactSetConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFactSet_Lio_adaptivecards_objectmodel_FactSetConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFactSet", "(Lio/adaptivecards/objectmodel/FactSetConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFontFamily;
#pragma warning disable 0169
		static Delegate GetGetFontFamilyHandler ()
		{
			if (cb_getFontFamily == null)
				cb_getFontFamily = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontFamily);
			return cb_getFontFamily;
		}

		static IntPtr n_GetFontFamily (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FontFamily);
		}
#pragma warning restore 0169

		static Delegate cb_setFontFamily_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFontFamily_Ljava_lang_String_Handler ()
		{
			if (cb_setFontFamily_Ljava_lang_String_ == null)
				cb_setFontFamily_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontFamily_Ljava_lang_String_);
			return cb_setFontFamily_Ljava_lang_String_;
		}

		static void n_SetFontFamily_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FontFamily = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFontFamily;
		static IntPtr id_setFontFamily_Ljava_lang_String_;
		public virtual unsafe string FontFamily {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getFontFamily' and count(parameter)=0]"
			[Register ("getFontFamily", "()Ljava/lang/String;", "GetGetFontFamilyHandler")]
			get {
				if (id_getFontFamily == IntPtr.Zero)
					id_getFontFamily = JNIEnv.GetMethodID (class_ref, "getFontFamily", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFontFamily), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontFamily", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setFontFamily' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFontFamily", "(Ljava/lang/String;)V", "GetSetFontFamily_Ljava_lang_String_Handler")]
			set {
				if (id_setFontFamily_Ljava_lang_String_ == IntPtr.Zero)
					id_setFontFamily_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFontFamily", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontFamily_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFontFamily", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFontSizes;
#pragma warning disable 0169
		static Delegate GetGetFontSizesHandler ()
		{
			if (cb_getFontSizes == null)
				cb_getFontSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontSizes);
			return cb_getFontSizes;
		}

		static IntPtr n_GetFontSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FontSizes);
		}
#pragma warning restore 0169

		static Delegate cb_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_;
#pragma warning disable 0169
		static Delegate GetSetFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_Handler ()
		{
			if (cb_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_ == null)
				cb_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_);
			return cb_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_;
		}

		static void n_SetFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.FontSizesConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FontSizes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFontSizes;
		static IntPtr id_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.FontSizesConfig FontSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getFontSizes' and count(parameter)=0]"
			[Register ("getFontSizes", "()Lio/adaptivecards/objectmodel/FontSizesConfig;", "GetGetFontSizesHandler")]
			get {
				if (id_getFontSizes == IntPtr.Zero)
					id_getFontSizes = JNIEnv.GetMethodID (class_ref, "getFontSizes", "()Lio/adaptivecards/objectmodel/FontSizesConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFontSizes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontSizesConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontSizes", "()Lio/adaptivecards/objectmodel/FontSizesConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setFontSizes' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.FontSizesConfig']]"
			[Register ("setFontSizes", "(Lio/adaptivecards/objectmodel/FontSizesConfig;)V", "GetSetFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_Handler")]
			set {
				if (id_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_ == IntPtr.Zero)
					id_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_ = JNIEnv.GetMethodID (class_ref, "setFontSizes", "(Lio/adaptivecards/objectmodel/FontSizesConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontSizes_Lio_adaptivecards_objectmodel_FontSizesConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFontSizes", "(Lio/adaptivecards/objectmodel/FontSizesConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFontWeights;
#pragma warning disable 0169
		static Delegate GetGetFontWeightsHandler ()
		{
			if (cb_getFontWeights == null)
				cb_getFontWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontWeights);
			return cb_getFontWeights;
		}

		static IntPtr n_GetFontWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FontWeights);
		}
#pragma warning restore 0169

		static Delegate cb_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_;
#pragma warning disable 0169
		static Delegate GetSetFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_Handler ()
		{
			if (cb_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_ == null)
				cb_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_);
			return cb_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_;
		}

		static void n_SetFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.FontWeightsConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FontWeights = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFontWeights;
		static IntPtr id_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.FontWeightsConfig FontWeights {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getFontWeights' and count(parameter)=0]"
			[Register ("getFontWeights", "()Lio/adaptivecards/objectmodel/FontWeightsConfig;", "GetGetFontWeightsHandler")]
			get {
				if (id_getFontWeights == IntPtr.Zero)
					id_getFontWeights = JNIEnv.GetMethodID (class_ref, "getFontWeights", "()Lio/adaptivecards/objectmodel/FontWeightsConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFontWeights), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.FontWeightsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontWeights", "()Lio/adaptivecards/objectmodel/FontWeightsConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setFontWeights' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.FontWeightsConfig']]"
			[Register ("setFontWeights", "(Lio/adaptivecards/objectmodel/FontWeightsConfig;)V", "GetSetFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_Handler")]
			set {
				if (id_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_ == IntPtr.Zero)
					id_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_ = JNIEnv.GetMethodID (class_ref, "setFontWeights", "(Lio/adaptivecards/objectmodel/FontWeightsConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontWeights_Lio_adaptivecards_objectmodel_FontWeightsConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFontWeights", "(Lio/adaptivecards/objectmodel/FontWeightsConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static Delegate cb_setImage_Lio_adaptivecards_objectmodel_ImageConfig_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lio_adaptivecards_objectmodel_ImageConfig_Handler ()
		{
			if (cb_setImage_Lio_adaptivecards_objectmodel_ImageConfig_ == null)
				cb_setImage_Lio_adaptivecards_objectmodel_ImageConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Lio_adaptivecards_objectmodel_ImageConfig_);
			return cb_setImage_Lio_adaptivecards_objectmodel_ImageConfig_;
		}

		static void n_SetImage_Lio_adaptivecards_objectmodel_ImageConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		static IntPtr id_setImage_Lio_adaptivecards_objectmodel_ImageConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageConfig Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lio/adaptivecards/objectmodel/ImageConfig;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lio/adaptivecards/objectmodel/ImageConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Lio/adaptivecards/objectmodel/ImageConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageConfig']]"
			[Register ("setImage", "(Lio/adaptivecards/objectmodel/ImageConfig;)V", "GetSetImage_Lio_adaptivecards_objectmodel_ImageConfig_Handler")]
			set {
				if (id_setImage_Lio_adaptivecards_objectmodel_ImageConfig_ == IntPtr.Zero)
					id_setImage_Lio_adaptivecards_objectmodel_ImageConfig_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lio/adaptivecards/objectmodel/ImageConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lio_adaptivecards_objectmodel_ImageConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lio/adaptivecards/objectmodel/ImageConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageBaseUrl;
#pragma warning disable 0169
		static Delegate GetGetImageBaseUrlHandler ()
		{
			if (cb_getImageBaseUrl == null)
				cb_getImageBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageBaseUrl);
			return cb_getImageBaseUrl;
		}

		static IntPtr n_GetImageBaseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageBaseUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setImageBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setImageBaseUrl_Ljava_lang_String_ == null)
				cb_setImageBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageBaseUrl_Ljava_lang_String_);
			return cb_setImageBaseUrl_Ljava_lang_String_;
		}

		static void n_SetImageBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageBaseUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageBaseUrl;
		static IntPtr id_setImageBaseUrl_Ljava_lang_String_;
		public virtual unsafe string ImageBaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getImageBaseUrl' and count(parameter)=0]"
			[Register ("getImageBaseUrl", "()Ljava/lang/String;", "GetGetImageBaseUrlHandler")]
			get {
				if (id_getImageBaseUrl == IntPtr.Zero)
					id_getImageBaseUrl = JNIEnv.GetMethodID (class_ref, "getImageBaseUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageBaseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageBaseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setImageBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageBaseUrl", "(Ljava/lang/String;)V", "GetSetImageBaseUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setImageBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageBaseUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageBaseUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageBaseUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImageSet;
#pragma warning disable 0169
		static Delegate GetGetImageSetHandler ()
		{
			if (cb_getImageSet == null)
				cb_getImageSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageSet);
			return cb_getImageSet;
		}

		static IntPtr n_GetImageSet (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageSet);
		}
#pragma warning restore 0169

		static Delegate cb_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_;
#pragma warning disable 0169
		static Delegate GetSetImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_Handler ()
		{
			if (cb_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_ == null)
				cb_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_);
			return cb_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_;
		}

		static void n_SetImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageSetConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageSet;
		static IntPtr id_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageSetConfig ImageSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getImageSet' and count(parameter)=0]"
			[Register ("getImageSet", "()Lio/adaptivecards/objectmodel/ImageSetConfig;", "GetGetImageSetHandler")]
			get {
				if (id_getImageSet == IntPtr.Zero)
					id_getImageSet = JNIEnv.GetMethodID (class_ref, "getImageSet", "()Lio/adaptivecards/objectmodel/ImageSetConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSetConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageSet", "()Lio/adaptivecards/objectmodel/ImageSetConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setImageSet' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSetConfig']]"
			[Register ("setImageSet", "(Lio/adaptivecards/objectmodel/ImageSetConfig;)V", "GetSetImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_Handler")]
			set {
				if (id_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_ == IntPtr.Zero)
					id_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_ = JNIEnv.GetMethodID (class_ref, "setImageSet", "(Lio/adaptivecards/objectmodel/ImageSetConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageSet_Lio_adaptivecards_objectmodel_ImageSetConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageSet", "(Lio/adaptivecards/objectmodel/ImageSetConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageSizes;
#pragma warning disable 0169
		static Delegate GetGetImageSizesHandler ()
		{
			if (cb_getImageSizes == null)
				cb_getImageSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageSizes);
			return cb_getImageSizes;
		}

		static IntPtr n_GetImageSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageSizes);
		}
#pragma warning restore 0169

		static Delegate cb_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_;
#pragma warning disable 0169
		static Delegate GetSetImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_Handler ()
		{
			if (cb_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_ == null)
				cb_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_);
			return cb_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_;
		}

		static void n_SetImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageSizesConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageSizes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageSizes;
		static IntPtr id_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageSizesConfig ImageSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getImageSizes' and count(parameter)=0]"
			[Register ("getImageSizes", "()Lio/adaptivecards/objectmodel/ImageSizesConfig;", "GetGetImageSizesHandler")]
			get {
				if (id_getImageSizes == IntPtr.Zero)
					id_getImageSizes = JNIEnv.GetMethodID (class_ref, "getImageSizes", "()Lio/adaptivecards/objectmodel/ImageSizesConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageSizes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSizesConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageSizes", "()Lio/adaptivecards/objectmodel/ImageSizesConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setImageSizes' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSizesConfig']]"
			[Register ("setImageSizes", "(Lio/adaptivecards/objectmodel/ImageSizesConfig;)V", "GetSetImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_Handler")]
			set {
				if (id_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_ == IntPtr.Zero)
					id_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_ = JNIEnv.GetMethodID (class_ref, "setImageSizes", "(Lio/adaptivecards/objectmodel/ImageSizesConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageSizes_Lio_adaptivecards_objectmodel_ImageSizesConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageSizes", "(Lio/adaptivecards/objectmodel/ImageSizesConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMedia;
#pragma warning disable 0169
		static Delegate GetGetMediaHandler ()
		{
			if (cb_getMedia == null)
				cb_getMedia = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMedia);
			return cb_getMedia;
		}

		static IntPtr n_GetMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Media);
		}
#pragma warning restore 0169

		static Delegate cb_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_;
#pragma warning disable 0169
		static Delegate GetSetMedia_Lio_adaptivecards_objectmodel_MediaConfig_Handler ()
		{
			if (cb_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_ == null)
				cb_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMedia_Lio_adaptivecards_objectmodel_MediaConfig_);
			return cb_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_;
		}

		static void n_SetMedia_Lio_adaptivecards_objectmodel_MediaConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.MediaConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Media = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMedia;
		static IntPtr id_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.MediaConfig Media {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getMedia' and count(parameter)=0]"
			[Register ("getMedia", "()Lio/adaptivecards/objectmodel/MediaConfig;", "GetGetMediaHandler")]
			get {
				if (id_getMedia == IntPtr.Zero)
					id_getMedia = JNIEnv.GetMethodID (class_ref, "getMedia", "()Lio/adaptivecards/objectmodel/MediaConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMedia), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMedia", "()Lio/adaptivecards/objectmodel/MediaConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setMedia' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MediaConfig']]"
			[Register ("setMedia", "(Lio/adaptivecards/objectmodel/MediaConfig;)V", "GetSetMedia_Lio_adaptivecards_objectmodel_MediaConfig_Handler")]
			set {
				if (id_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_ == IntPtr.Zero)
					id_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_ = JNIEnv.GetMethodID (class_ref, "setMedia", "(Lio/adaptivecards/objectmodel/MediaConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMedia_Lio_adaptivecards_objectmodel_MediaConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMedia", "(Lio/adaptivecards/objectmodel/MediaConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSeparator;
#pragma warning disable 0169
		static Delegate GetGetSeparatorHandler ()
		{
			if (cb_getSeparator == null)
				cb_getSeparator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeparator);
			return cb_getSeparator;
		}

		static IntPtr n_GetSeparator (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Separator);
		}
#pragma warning restore 0169

		static Delegate cb_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_;
#pragma warning disable 0169
		static Delegate GetSetSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_Handler ()
		{
			if (cb_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_ == null)
				cb_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_);
			return cb_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_;
		}

		static void n_SetSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.SeparatorConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Separator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSeparator;
		static IntPtr id_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.SeparatorConfig Separator {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getSeparator' and count(parameter)=0]"
			[Register ("getSeparator", "()Lio/adaptivecards/objectmodel/SeparatorConfig;", "GetGetSeparatorHandler")]
			get {
				if (id_getSeparator == IntPtr.Zero)
					id_getSeparator = JNIEnv.GetMethodID (class_ref, "getSeparator", "()Lio/adaptivecards/objectmodel/SeparatorConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeparator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeparator", "()Lio/adaptivecards/objectmodel/SeparatorConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setSeparator' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SeparatorConfig']]"
			[Register ("setSeparator", "(Lio/adaptivecards/objectmodel/SeparatorConfig;)V", "GetSetSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_Handler")]
			set {
				if (id_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_ == IntPtr.Zero)
					id_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_ = JNIEnv.GetMethodID (class_ref, "setSeparator", "(Lio/adaptivecards/objectmodel/SeparatorConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSeparator_Lio_adaptivecards_objectmodel_SeparatorConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSeparator", "(Lio/adaptivecards/objectmodel/SeparatorConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpacing;
#pragma warning disable 0169
		static Delegate GetGetSpacingHandler ()
		{
			if (cb_getSpacing == null)
				cb_getSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpacing);
			return cb_getSpacing;
		}

		static IntPtr n_GetSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Spacing);
		}
#pragma warning restore 0169

		static Delegate cb_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_;
#pragma warning disable 0169
		static Delegate GetSetSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_Handler ()
		{
			if (cb_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_ == null)
				cb_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_);
			return cb_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_;
		}

		static void n_SetSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.SpacingConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Spacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpacing;
		static IntPtr id_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.SpacingConfig Spacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getSpacing' and count(parameter)=0]"
			[Register ("getSpacing", "()Lio/adaptivecards/objectmodel/SpacingConfig;", "GetGetSpacingHandler")]
			get {
				if (id_getSpacing == IntPtr.Zero)
					id_getSpacing = JNIEnv.GetMethodID (class_ref, "getSpacing", "()Lio/adaptivecards/objectmodel/SpacingConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpacing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SpacingConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpacing", "()Lio/adaptivecards/objectmodel/SpacingConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setSpacing' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.SpacingConfig']]"
			[Register ("setSpacing", "(Lio/adaptivecards/objectmodel/SpacingConfig;)V", "GetSetSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_Handler")]
			set {
				if (id_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_ == IntPtr.Zero)
					id_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_ = JNIEnv.GetMethodID (class_ref, "setSpacing", "(Lio/adaptivecards/objectmodel/SpacingConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpacing_Lio_adaptivecards_objectmodel_SpacingConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpacing", "(Lio/adaptivecards/objectmodel/SpacingConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportsInteractivity;
#pragma warning disable 0169
		static Delegate GetGetSupportsInteractivityHandler ()
		{
			if (cb_getSupportsInteractivity == null)
				cb_getSupportsInteractivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSupportsInteractivity);
			return cb_getSupportsInteractivity;
		}

		static bool n_GetSupportsInteractivity (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportsInteractivity;
		}
#pragma warning restore 0169

		static Delegate cb_setSupportsInteractivity_Z;
#pragma warning disable 0169
		static Delegate GetSetSupportsInteractivity_ZHandler ()
		{
			if (cb_setSupportsInteractivity_Z == null)
				cb_setSupportsInteractivity_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSupportsInteractivity_Z);
			return cb_setSupportsInteractivity_Z;
		}

		static void n_SetSupportsInteractivity_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SupportsInteractivity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSupportsInteractivity;
		static IntPtr id_setSupportsInteractivity_Z;
		public virtual unsafe bool SupportsInteractivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getSupportsInteractivity' and count(parameter)=0]"
			[Register ("getSupportsInteractivity", "()Z", "GetGetSupportsInteractivityHandler")]
			get {
				if (id_getSupportsInteractivity == IntPtr.Zero)
					id_getSupportsInteractivity = JNIEnv.GetMethodID (class_ref, "getSupportsInteractivity", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSupportsInteractivity);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportsInteractivity", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='setSupportsInteractivity' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSupportsInteractivity", "(Z)V", "GetSetSupportsInteractivity_ZHandler")]
			set {
				if (id_setSupportsInteractivity_Z == IntPtr.Zero)
					id_setSupportsInteractivity_Z = JNIEnv.GetMethodID (class_ref, "setSupportsInteractivity", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSupportsInteractivity_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSupportsInteractivity", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='Deserialize' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/HostConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HostConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;)Lio/adaptivecards/objectmodel/HostConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.HostConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_DeserializeFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='DeserializeFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("DeserializeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HostConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HostConfig DeserializeFromString (string p0)
		{
			if (id_DeserializeFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HostConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.HostConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::IO.Adaptivecards.Objectmodel.HostConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_HostConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HostConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HostConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/HostConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.HostConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_HostConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_HostConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/HostConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_HostConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
