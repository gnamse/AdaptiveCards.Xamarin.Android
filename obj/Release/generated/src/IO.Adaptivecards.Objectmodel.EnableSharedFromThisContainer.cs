using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='EnableSharedFromThisContainer']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/EnableSharedFromThisContainer", DoNotGenerateAcw=true)]
	public partial class EnableSharedFromThisContainer : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='EnableSharedFromThisContainer']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/EnableSharedFromThisContainer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnableSharedFromThisContainer); }
		}

		protected EnableSharedFromThisContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='EnableSharedFromThisContainer']/constructor[@name='EnableSharedFromThisContainer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe EnableSharedFromThisContainer (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (EnableSharedFromThisContainer)) {
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
			global::IO.Adaptivecards.Objectmodel.EnableSharedFromThisContainer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.EnableSharedFromThisContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='EnableSharedFromThisContainer']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_EnableSharedFromThisContainer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='EnableSharedFromThisContainer']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.EnableSharedFromThisContainer']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/EnableSharedFromThisContainer;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.EnableSharedFromThisContainer p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_EnableSharedFromThisContainer_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_EnableSharedFromThisContainer_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/EnableSharedFromThisContainer;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_EnableSharedFromThisContainer_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_shared_from_this;
#pragma warning disable 0169
		static Delegate GetShared_from_thisHandler ()
		{
			if (cb_shared_from_this == null)
				cb_shared_from_this = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Shared_from_this);
			return cb_shared_from_this;
		}

		static IntPtr n_Shared_from_this (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.EnableSharedFromThisContainer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.EnableSharedFromThisContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Shared_from_this ());
		}
#pragma warning restore 0169

		static IntPtr id_shared_from_this;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='EnableSharedFromThisContainer']/method[@name='shared_from_this' and count(parameter)=0]"
		[Register ("shared_from_this", "()Lio/adaptivecards/objectmodel/Container;", "GetShared_from_thisHandler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.Container Shared_from_this ()
		{
			if (id_shared_from_this == IntPtr.Zero)
				id_shared_from_this = JNIEnv.GetMethodID (class_ref, "shared_from_this", "()Lio/adaptivecards/objectmodel/Container;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Container> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_shared_from_this), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Container> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shared_from_this", "()Lio/adaptivecards/objectmodel/Container;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
