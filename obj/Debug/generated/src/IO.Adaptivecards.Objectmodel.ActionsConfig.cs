using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ActionsConfig", DoNotGenerateAcw=true)]
	public partial class ActionsConfig : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ActionsConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionsConfig); }
		}

		protected ActionsConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/constructor[@name='ActionsConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActionsConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ActionsConfig)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/constructor[@name='ActionsConfig' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ActionsConfig (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ActionsConfig)) {
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

		static Delegate cb_getActionAlignment;
#pragma warning disable 0169
		static Delegate GetGetActionAlignmentHandler ()
		{
			if (cb_getActionAlignment == null)
				cb_getActionAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionAlignment);
			return cb_getActionAlignment;
		}

		static IntPtr n_GetActionAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_;
#pragma warning disable 0169
		static Delegate GetSetActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_Handler ()
		{
			if (cb_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_ == null)
				cb_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_);
			return cb_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_;
		}

		static void n_SetActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionAlignment p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionAlignment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionAlignment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActionAlignment;
		static IntPtr id_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ActionAlignment ActionAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getActionAlignment' and count(parameter)=0]"
			[Register ("getActionAlignment", "()Lio/adaptivecards/objectmodel/ActionAlignment;", "GetGetActionAlignmentHandler")]
			get {
				if (id_getActionAlignment == IntPtr.Zero)
					id_getActionAlignment = JNIEnv.GetMethodID (class_ref, "getActionAlignment", "()Lio/adaptivecards/objectmodel/ActionAlignment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionAlignment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionAlignment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionAlignment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionAlignment", "()Lio/adaptivecards/objectmodel/ActionAlignment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setActionAlignment' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionAlignment']]"
			[Register ("setActionAlignment", "(Lio/adaptivecards/objectmodel/ActionAlignment;)V", "GetSetActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_Handler")]
			set {
				if (id_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_ == IntPtr.Zero)
					id_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_ = JNIEnv.GetMethodID (class_ref, "setActionAlignment", "(Lio/adaptivecards/objectmodel/ActionAlignment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionAlignment_Lio_adaptivecards_objectmodel_ActionAlignment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionAlignment", "(Lio/adaptivecards/objectmodel/ActionAlignment;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getActionsOrientation;
#pragma warning disable 0169
		static Delegate GetGetActionsOrientationHandler ()
		{
			if (cb_getActionsOrientation == null)
				cb_getActionsOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionsOrientation);
			return cb_getActionsOrientation;
		}

		static IntPtr n_GetActionsOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionsOrientation);
		}
#pragma warning restore 0169

		static Delegate cb_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_;
#pragma warning disable 0169
		static Delegate GetSetActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_Handler ()
		{
			if (cb_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_ == null)
				cb_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_);
			return cb_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_;
		}

		static void n_SetActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionsOrientation p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsOrientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionsOrientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActionsOrientation;
		static IntPtr id_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ActionsOrientation ActionsOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getActionsOrientation' and count(parameter)=0]"
			[Register ("getActionsOrientation", "()Lio/adaptivecards/objectmodel/ActionsOrientation;", "GetGetActionsOrientationHandler")]
			get {
				if (id_getActionsOrientation == IntPtr.Zero)
					id_getActionsOrientation = JNIEnv.GetMethodID (class_ref, "getActionsOrientation", "()Lio/adaptivecards/objectmodel/ActionsOrientation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsOrientation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionsOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsOrientation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionsOrientation", "()Lio/adaptivecards/objectmodel/ActionsOrientation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setActionsOrientation' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionsOrientation']]"
			[Register ("setActionsOrientation", "(Lio/adaptivecards/objectmodel/ActionsOrientation;)V", "GetSetActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_Handler")]
			set {
				if (id_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_ == IntPtr.Zero)
					id_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_ = JNIEnv.GetMethodID (class_ref, "setActionsOrientation", "(Lio/adaptivecards/objectmodel/ActionsOrientation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionsOrientation_Lio_adaptivecards_objectmodel_ActionsOrientation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionsOrientation", "(Lio/adaptivecards/objectmodel/ActionsOrientation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonSpacing;
#pragma warning disable 0169
		static Delegate GetGetButtonSpacingHandler ()
		{
			if (cb_getButtonSpacing == null)
				cb_getButtonSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetButtonSpacing);
			return cb_getButtonSpacing;
		}

		static long n_GetButtonSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonSpacing_J;
#pragma warning disable 0169
		static Delegate GetSetButtonSpacing_JHandler ()
		{
			if (cb_setButtonSpacing_J == null)
				cb_setButtonSpacing_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetButtonSpacing_J);
			return cb_setButtonSpacing_J;
		}

		static void n_SetButtonSpacing_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getButtonSpacing;
		static IntPtr id_setButtonSpacing_J;
		public virtual unsafe long ButtonSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getButtonSpacing' and count(parameter)=0]"
			[Register ("getButtonSpacing", "()J", "GetGetButtonSpacingHandler")]
			get {
				if (id_getButtonSpacing == IntPtr.Zero)
					id_getButtonSpacing = JNIEnv.GetMethodID (class_ref, "getButtonSpacing", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getButtonSpacing);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getButtonSpacing", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setButtonSpacing' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setButtonSpacing", "(J)V", "GetSetButtonSpacing_JHandler")]
			set {
				if (id_setButtonSpacing_J == IntPtr.Zero)
					id_setButtonSpacing_J = JNIEnv.GetMethodID (class_ref, "setButtonSpacing", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setButtonSpacing_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButtonSpacing", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconPlacement;
#pragma warning disable 0169
		static Delegate GetGetIconPlacementHandler ()
		{
			if (cb_getIconPlacement == null)
				cb_getIconPlacement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconPlacement);
			return cb_getIconPlacement;
		}

		static IntPtr n_GetIconPlacement (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconPlacement);
		}
#pragma warning restore 0169

		static Delegate cb_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_;
#pragma warning disable 0169
		static Delegate GetSetIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_Handler ()
		{
			if (cb_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_ == null)
				cb_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_);
			return cb_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_;
		}

		static void n_SetIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.IconPlacement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.IconPlacement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IconPlacement = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIconPlacement;
		static IntPtr id_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.IconPlacement IconPlacement {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getIconPlacement' and count(parameter)=0]"
			[Register ("getIconPlacement", "()Lio/adaptivecards/objectmodel/IconPlacement;", "GetGetIconPlacementHandler")]
			get {
				if (id_getIconPlacement == IntPtr.Zero)
					id_getIconPlacement = JNIEnv.GetMethodID (class_ref, "getIconPlacement", "()Lio/adaptivecards/objectmodel/IconPlacement;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.IconPlacement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconPlacement), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.IconPlacement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconPlacement", "()Lio/adaptivecards/objectmodel/IconPlacement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setIconPlacement' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.IconPlacement']]"
			[Register ("setIconPlacement", "(Lio/adaptivecards/objectmodel/IconPlacement;)V", "GetSetIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_Handler")]
			set {
				if (id_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_ == IntPtr.Zero)
					id_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_ = JNIEnv.GetMethodID (class_ref, "setIconPlacement", "(Lio/adaptivecards/objectmodel/IconPlacement;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconPlacement_Lio_adaptivecards_objectmodel_IconPlacement_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconPlacement", "(Lio/adaptivecards/objectmodel/IconPlacement;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconSize;
#pragma warning disable 0169
		static Delegate GetGetIconSizeHandler ()
		{
			if (cb_getIconSize == null)
				cb_getIconSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIconSize);
			return cb_getIconSize;
		}

		static long n_GetIconSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconSize;
		}
#pragma warning restore 0169

		static Delegate cb_setIconSize_J;
#pragma warning disable 0169
		static Delegate GetSetIconSize_JHandler ()
		{
			if (cb_setIconSize_J == null)
				cb_setIconSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetIconSize_J);
			return cb_setIconSize_J;
		}

		static void n_SetIconSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IconSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIconSize;
		static IntPtr id_setIconSize_J;
		public virtual unsafe long IconSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getIconSize' and count(parameter)=0]"
			[Register ("getIconSize", "()J", "GetGetIconSizeHandler")]
			get {
				if (id_getIconSize == IntPtr.Zero)
					id_getIconSize = JNIEnv.GetMethodID (class_ref, "getIconSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIconSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setIconSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setIconSize", "(J)V", "GetSetIconSize_JHandler")]
			set {
				if (id_setIconSize_J == IntPtr.Zero)
					id_setIconSize_J = JNIEnv.GetMethodID (class_ref, "setIconSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxActions;
#pragma warning disable 0169
		static Delegate GetGetMaxActionsHandler ()
		{
			if (cb_getMaxActions == null)
				cb_getMaxActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxActions);
			return cb_getMaxActions;
		}

		static long n_GetMaxActions (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxActions;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxActions_J;
#pragma warning disable 0169
		static Delegate GetSetMaxActions_JHandler ()
		{
			if (cb_setMaxActions_J == null)
				cb_setMaxActions_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxActions_J);
			return cb_setMaxActions_J;
		}

		static void n_SetMaxActions_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxActions = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxActions;
		static IntPtr id_setMaxActions_J;
		public virtual unsafe long MaxActions {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getMaxActions' and count(parameter)=0]"
			[Register ("getMaxActions", "()J", "GetGetMaxActionsHandler")]
			get {
				if (id_getMaxActions == IntPtr.Zero)
					id_getMaxActions = JNIEnv.GetMethodID (class_ref, "getMaxActions", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxActions);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxActions", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setMaxActions' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxActions", "(J)V", "GetSetMaxActions_JHandler")]
			set {
				if (id_setMaxActions_J == IntPtr.Zero)
					id_setMaxActions_J = JNIEnv.GetMethodID (class_ref, "setMaxActions", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxActions_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxActions", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowCard;
#pragma warning disable 0169
		static Delegate GetGetShowCardHandler ()
		{
			if (cb_getShowCard == null)
				cb_getShowCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShowCard);
			return cb_getShowCard;
		}

		static IntPtr n_GetShowCard (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowCard);
		}
#pragma warning restore 0169

		static Delegate cb_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_;
#pragma warning disable 0169
		static Delegate GetSetShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_Handler ()
		{
			if (cb_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ == null)
				cb_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_);
			return cb_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_;
		}

		static void n_SetShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShowCard;
		static IntPtr id_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig ShowCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getShowCard' and count(parameter)=0]"
			[Register ("getShowCard", "()Lio/adaptivecards/objectmodel/ShowCardActionConfig;", "GetGetShowCardHandler")]
			get {
				if (id_getShowCard == IntPtr.Zero)
					id_getShowCard = JNIEnv.GetMethodID (class_ref, "getShowCard", "()Lio/adaptivecards/objectmodel/ShowCardActionConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShowCard), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardActionConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowCard", "()Lio/adaptivecards/objectmodel/ShowCardActionConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setShowCard' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ShowCardActionConfig']]"
			[Register ("setShowCard", "(Lio/adaptivecards/objectmodel/ShowCardActionConfig;)V", "GetSetShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_Handler")]
			set {
				if (id_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ == IntPtr.Zero)
					id_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_ = JNIEnv.GetMethodID (class_ref, "setShowCard", "(Lio/adaptivecards/objectmodel/ShowCardActionConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowCard_Lio_adaptivecards_objectmodel_ShowCardActionConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowCard", "(Lio/adaptivecards/objectmodel/ShowCardActionConfig;)V"), __args);
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
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Spacing);
		}
#pragma warning restore 0169

		static Delegate cb_setSpacing_Lio_adaptivecards_objectmodel_Spacing_;
#pragma warning disable 0169
		static Delegate GetSetSpacing_Lio_adaptivecards_objectmodel_Spacing_Handler ()
		{
			if (cb_setSpacing_Lio_adaptivecards_objectmodel_Spacing_ == null)
				cb_setSpacing_Lio_adaptivecards_objectmodel_Spacing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_);
			return cb_setSpacing_Lio_adaptivecards_objectmodel_Spacing_;
		}

		static void n_SetSpacing_Lio_adaptivecards_objectmodel_Spacing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.Spacing p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Spacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpacing;
		static IntPtr id_setSpacing_Lio_adaptivecards_objectmodel_Spacing_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.Spacing Spacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getSpacing' and count(parameter)=0]"
			[Register ("getSpacing", "()Lio/adaptivecards/objectmodel/Spacing;", "GetGetSpacingHandler")]
			get {
				if (id_getSpacing == IntPtr.Zero)
					id_getSpacing = JNIEnv.GetMethodID (class_ref, "getSpacing", "()Lio/adaptivecards/objectmodel/Spacing;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpacing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpacing", "()Lio/adaptivecards/objectmodel/Spacing;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='setSpacing' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Spacing']]"
			[Register ("setSpacing", "(Lio/adaptivecards/objectmodel/Spacing;)V", "GetSetSpacing_Lio_adaptivecards_objectmodel_Spacing_Handler")]
			set {
				if (id_setSpacing_Lio_adaptivecards_objectmodel_Spacing_ == IntPtr.Zero)
					id_setSpacing_Lio_adaptivecards_objectmodel_Spacing_ = JNIEnv.GetMethodID (class_ref, "setSpacing", "(Lio/adaptivecards/objectmodel/Spacing;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpacing_Lio_adaptivecards_objectmodel_Spacing_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpacing", "(Lio/adaptivecards/objectmodel/Spacing;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ActionsConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionsConfig']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ActionsConfig;)Lio/adaptivecards/objectmodel/ActionsConfig;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionsConfig Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, global::IO.Adaptivecards.Objectmodel.ActionsConfig p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ActionsConfig_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ActionsConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Lio/adaptivecards/objectmodel/ActionsConfig;)Lio/adaptivecards/objectmodel/ActionsConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::IO.Adaptivecards.Objectmodel.ActionsConfig __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Lio_adaptivecards_objectmodel_ActionsConfig_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.ActionsConfig __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ActionsConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionsConfig']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionsConfig']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ActionsConfig;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ActionsConfig p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ActionsConfig_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ActionsConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ActionsConfig;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ActionsConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
