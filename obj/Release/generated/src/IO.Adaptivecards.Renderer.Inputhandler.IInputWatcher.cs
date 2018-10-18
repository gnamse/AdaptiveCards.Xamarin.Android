using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Inputhandler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/interface[@name='IInputWatcher']"
	[Register ("io/adaptivecards/renderer/inputhandler/IInputWatcher", "", "IO.Adaptivecards.Renderer.Inputhandler.IInputWatcherInvoker")]
	public partial interface IInputWatcher : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/interface[@name='IInputWatcher']/method[@name='onInputChange' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onInputChange", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnInputChange_Ljava_lang_String_Ljava_lang_String_Handler:IO.Adaptivecards.Renderer.Inputhandler.IInputWatcherInvoker, AdaptiveCards.Xamarin.Android")]
		void OnInputChange (string p0, string p1);

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/inputhandler/IInputWatcher", DoNotGenerateAcw=true)]
	internal class IInputWatcherInvoker : global::Java.Lang.Object, IInputWatcher {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/adaptivecards/renderer/inputhandler/IInputWatcher");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInputWatcherInvoker); }
		}

		IntPtr class_ref;

		public static IInputWatcher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInputWatcher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.adaptivecards.renderer.inputhandler.IInputWatcher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInputWatcherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInputChange_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInputChange_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onInputChange_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onInputChange_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInputChange_Ljava_lang_String_Ljava_lang_String_);
			return cb_onInputChange_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnInputChange_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInputChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInputChange_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnInputChange (string p0, string p1)
		{
			if (id_onInputChange_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onInputChange_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInputChange", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInputChange_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
