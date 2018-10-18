using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ColumnSet", DoNotGenerateAcw=true)]
	public partial class ColumnSet : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ColumnSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColumnSet); }
		}

		protected ColumnSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/constructor[@name='ColumnSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColumnSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ColumnSet)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/constructor[@name='ColumnSet' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ColumnSet (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ColumnSet)) {
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

		static Delegate cb_GetColumns;
#pragma warning disable 0169
		static Delegate GetGetColumnsHandler ()
		{
			if (cb_GetColumns == null)
				cb_GetColumns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColumns);
			return cb_GetColumns;
		}

		static IntPtr n_GetColumns (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColumnSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Columns);
		}
#pragma warning restore 0169

		static IntPtr id_GetColumns;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ColumnVector Columns {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/method[@name='GetColumns' and count(parameter)=0]"
			[Register ("GetColumns", "()Lio/adaptivecards/objectmodel/ColumnVector;", "GetGetColumnsHandler")]
			get {
				if (id_GetColumns == IntPtr.Zero)
					id_GetColumns = JNIEnv.GetMethodID (class_ref, "GetColumns", "()Lio/adaptivecards/objectmodel/ColumnVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetColumns), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetColumns", "()Lio/adaptivecards/objectmodel/ColumnVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetSelectAction;
#pragma warning disable 0169
		static Delegate GetGetSelectActionHandler ()
		{
			if (cb_GetSelectAction == null)
				cb_GetSelectAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectAction);
			return cb_GetSelectAction;
		}

		static IntPtr n_GetSelectAction (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ColumnSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectAction);
		}
#pragma warning restore 0169

		static Delegate cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
#pragma warning disable 0169
		static Delegate GetSetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_Handler ()
		{
			if (cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ == null)
				cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_);
			return cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		}

		static void n_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ColumnSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectAction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectAction;
		static IntPtr id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElement SelectAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/method[@name='GetSelectAction' and count(parameter)=0]"
			[Register ("GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;", "GetGetSelectActionHandler")]
			get {
				if (id_GetSelectAction == IntPtr.Zero)
					id_GetSelectAction = JNIEnv.GetMethodID (class_ref, "GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectAction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/method[@name='SetSelectAction' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement']]"
			[Register ("SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V", "GetSetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_Handler")]
			set {
				if (id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ == IntPtr.Zero)
					id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNIEnv.GetMethodID (class_ref, "SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V"), __args);
				} finally {
				}
			}
		}

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
			global::IO.Adaptivecards.Objectmodel.ColumnSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLanguage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetLanguage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/method[@name='SetLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLanguage (string p0)
		{
			if (id_SetLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_SetLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetLanguage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetLanguage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLanguage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ColumnSet;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ColumnSet Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ColumnSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.ColumnSet __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ColumnSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ColumnSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnSet']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ColumnSet']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ColumnSet;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ColumnSet p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ColumnSet_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ColumnSet_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ColumnSet;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ColumnSet_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
