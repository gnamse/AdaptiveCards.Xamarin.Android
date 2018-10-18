using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/MarkDownParser", DoNotGenerateAcw=true)]
	public partial class MarkDownParser : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/field[@name='swigCMemOwn']"
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/MarkDownParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkDownParser); }
		}

		protected MarkDownParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/constructor[@name='MarkDownParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MarkDownParser (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MarkDownParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/constructor[@name='MarkDownParser' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe MarkDownParser (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MarkDownParser)) {
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

		static Delegate cb_HasHtmlTags;
#pragma warning disable 0169
		static Delegate GetHasHtmlTagsHandler ()
		{
			if (cb_HasHtmlTags == null)
				cb_HasHtmlTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHtmlTags);
			return cb_HasHtmlTags;
		}

		static bool n_HasHtmlTags (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MarkDownParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MarkDownParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHtmlTags;
		}
#pragma warning restore 0169

		static IntPtr id_HasHtmlTags;
		public virtual unsafe bool HasHtmlTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/method[@name='HasHtmlTags' and count(parameter)=0]"
			[Register ("HasHtmlTags", "()Z", "GetHasHtmlTagsHandler")]
			get {
				if (id_HasHtmlTags == IntPtr.Zero)
					id_HasHtmlTags = JNIEnv.GetMethodID (class_ref, "HasHtmlTags", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_HasHtmlTags);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HasHtmlTags", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_IsEscaped;
#pragma warning disable 0169
		static Delegate GetIsEscapedHandler ()
		{
			if (cb_IsEscaped == null)
				cb_IsEscaped = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEscaped);
			return cb_IsEscaped;
		}

		static bool n_IsEscaped (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MarkDownParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MarkDownParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEscaped;
		}
#pragma warning restore 0169

		static IntPtr id_IsEscaped;
		public virtual unsafe bool IsEscaped {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/method[@name='IsEscaped' and count(parameter)=0]"
			[Register ("IsEscaped", "()Z", "GetIsEscapedHandler")]
			get {
				if (id_IsEscaped == IntPtr.Zero)
					id_IsEscaped = JNIEnv.GetMethodID (class_ref, "IsEscaped", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_IsEscaped);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsEscaped", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_TransformToHtml;
#pragma warning disable 0169
		static Delegate GetTransformToHtmlHandler ()
		{
			if (cb_TransformToHtml == null)
				cb_TransformToHtml = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TransformToHtml);
			return cb_TransformToHtml;
		}

		static IntPtr n_TransformToHtml (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.MarkDownParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MarkDownParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransformToHtml ());
		}
#pragma warning restore 0169

		static IntPtr id_TransformToHtml;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/method[@name='TransformToHtml' and count(parameter)=0]"
		[Register ("TransformToHtml", "()Ljava/lang/String;", "GetTransformToHtmlHandler")]
		public virtual unsafe string TransformToHtml ()
		{
			if (id_TransformToHtml == IntPtr.Zero)
				id_TransformToHtml = JNIEnv.GetMethodID (class_ref, "TransformToHtml", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_TransformToHtml), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TransformToHtml", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.MarkDownParser __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MarkDownParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_MarkDownParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MarkDownParser']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.MarkDownParser']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/MarkDownParser;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.MarkDownParser p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_MarkDownParser_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_MarkDownParser_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/MarkDownParser;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_MarkDownParser_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
