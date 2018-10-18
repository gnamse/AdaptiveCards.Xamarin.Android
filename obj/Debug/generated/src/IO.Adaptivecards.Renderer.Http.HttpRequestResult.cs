using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/http/HttpRequestResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"RESULT"})]
	public partial class HttpRequestResult : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/http/HttpRequestResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequestResult); }
		}

		protected HttpRequestResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']/constructor[@name='HttpRequestResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpRequestResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpRequestResult)) {
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

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']/constructor[@name='HttpRequestResult' and count(parameter)=1 and parameter[1][@type='RESULT']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe HttpRequestResult (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (HttpRequestResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']/constructor[@name='HttpRequestResult' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public unsafe HttpRequestResult (global::Java.Lang.Exception p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (HttpRequestResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Exception;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Exception;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Exception_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Exception;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Exception_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Http.HttpRequestResult __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		static IntPtr id_getException;
		public virtual unsafe global::Java.Lang.Exception Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")]
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Ljava/lang/Exception;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getException), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getException", "()Ljava/lang/Exception;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSuccessful;
#pragma warning disable 0169
		static Delegate GetIsSuccessfulHandler ()
		{
			if (cb_isSuccessful == null)
				cb_isSuccessful = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccessful);
			return cb_isSuccessful;
		}

		static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Http.HttpRequestResult __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccessful;
		public virtual unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get {
				if (id_isSuccessful == IntPtr.Zero)
					id_isSuccessful = JNIEnv.GetMethodID (class_ref, "isSuccessful", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccessful);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccessful", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Http.HttpRequestResult __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		static IntPtr id_getResult;
		public virtual unsafe global::Java.Lang.Object Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestResult']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
			get {
				if (id_getResult == IntPtr.Zero)
					id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResult", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
