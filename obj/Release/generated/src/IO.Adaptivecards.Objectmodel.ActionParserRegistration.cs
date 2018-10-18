using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ActionParserRegistration", DoNotGenerateAcw=true)]
	public partial class ActionParserRegistration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ActionParserRegistration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionParserRegistration); }
		}

		protected ActionParserRegistration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/constructor[@name='ActionParserRegistration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActionParserRegistration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ActionParserRegistration)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/constructor[@name='ActionParserRegistration' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ActionParserRegistration (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ActionParserRegistration)) {
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

		static Delegate cb_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_;
#pragma warning disable 0169
		static Delegate GetAddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_Handler ()
		{
			if (cb_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_ == null)
				cb_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_);
			return cb_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_;
		}

		static void n_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Objectmodel.ActionParserRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionParserRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ActionElementParser p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddParser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/method[@name='AddParser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.adaptivecards.objectmodel.ActionElementParser']]"
		[Register ("AddParser", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/ActionElementParser;)V", "GetAddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_Handler")]
		public virtual unsafe void AddParser (string p0, global::IO.Adaptivecards.Objectmodel.ActionElementParser p1)
		{
			if (id_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_ == IntPtr.Zero)
				id_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_ = JNIEnv.GetMethodID (class_ref, "AddParser", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/ActionElementParser;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AddParser_Ljava_lang_String_Lio_adaptivecards_objectmodel_ActionElementParser_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddParser", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/ActionElementParser;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_GetParser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParser_Ljava_lang_String_Handler ()
		{
			if (cb_GetParser_Ljava_lang_String_ == null)
				cb_GetParser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParser_Ljava_lang_String_);
			return cb_GetParser_Ljava_lang_String_;
		}

		static IntPtr n_GetParser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionParserRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionParserRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParser (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetParser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/method[@name='GetParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("GetParser", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionElementParser;", "GetGetParser_Ljava_lang_String_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ActionElementParser GetParser (string p0)
		{
			if (id_GetParser_Ljava_lang_String_ == IntPtr.Zero)
				id_GetParser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetParser", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionElementParser;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IO.Adaptivecards.Objectmodel.ActionElementParser __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetParser_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionElementParser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetParser", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionElementParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_RemoveParser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveParser_Ljava_lang_String_Handler ()
		{
			if (cb_RemoveParser_Ljava_lang_String_ == null)
				cb_RemoveParser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveParser_Ljava_lang_String_);
			return cb_RemoveParser_Ljava_lang_String_;
		}

		static void n_RemoveParser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ActionParserRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionParserRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveParser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemoveParser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/method[@name='RemoveParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("RemoveParser", "(Ljava/lang/String;)V", "GetRemoveParser_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveParser (string p0)
		{
			if (id_RemoveParser_Ljava_lang_String_ == IntPtr.Zero)
				id_RemoveParser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "RemoveParser", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RemoveParser_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveParser", "(Ljava/lang/String;)V"), __args);
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
			global::IO.Adaptivecards.Objectmodel.ActionParserRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionParserRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ActionParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionParserRegistration']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ActionParserRegistration']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ActionParserRegistration;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ActionParserRegistration_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ActionParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ActionParserRegistration;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ActionParserRegistration_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
