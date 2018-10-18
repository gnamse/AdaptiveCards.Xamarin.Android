using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Registration {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/registration/CardRendererRegistration", DoNotGenerateAcw=true)]
	public partial class CardRendererRegistration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/registration/CardRendererRegistration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardRendererRegistration); }
		}

		protected CardRendererRegistration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getActionLayoutRenderer;
#pragma warning disable 0169
		static Delegate GetGetActionLayoutRendererHandler ()
		{
			if (cb_getActionLayoutRenderer == null)
				cb_getActionLayoutRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionLayoutRenderer);
			return cb_getActionLayoutRenderer;
		}

		static IntPtr n_GetActionLayoutRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionLayoutRenderer);
		}
#pragma warning restore 0169

		static IntPtr id_getActionLayoutRenderer;
		public virtual unsafe global::IO.Adaptivecards.Renderer.IActionLayoutRenderer ActionLayoutRenderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getActionLayoutRenderer' and count(parameter)=0]"
			[Register ("getActionLayoutRenderer", "()Lio/adaptivecards/renderer/IActionLayoutRenderer;", "GetGetActionLayoutRendererHandler")]
			get {
				if (id_getActionLayoutRenderer == IntPtr.Zero)
					id_getActionLayoutRenderer = JNIEnv.GetMethodID (class_ref, "getActionLayoutRenderer", "()Lio/adaptivecards/renderer/IActionLayoutRenderer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IActionLayoutRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionLayoutRenderer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IActionLayoutRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionLayoutRenderer", "()Lio/adaptivecards/renderer/IActionLayoutRenderer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getActionRenderer;
#pragma warning disable 0169
		static Delegate GetGetActionRendererHandler ()
		{
			if (cb_getActionRenderer == null)
				cb_getActionRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionRenderer);
			return cb_getActionRenderer;
		}

		static IntPtr n_GetActionRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionRenderer);
		}
#pragma warning restore 0169

		static IntPtr id_getActionRenderer;
		public virtual unsafe global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer ActionRenderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getActionRenderer' and count(parameter)=0]"
			[Register ("getActionRenderer", "()Lio/adaptivecards/renderer/IBaseActionElementRenderer;", "GetGetActionRendererHandler")]
			get {
				if (id_getActionRenderer == IntPtr.Zero)
					id_getActionRenderer = JNIEnv.GetMethodID (class_ref, "getActionRenderer", "()Lio/adaptivecards/renderer/IBaseActionElementRenderer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionRenderer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionRenderer", "()Lio/adaptivecards/renderer/IBaseActionElementRenderer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInputWatcher;
#pragma warning disable 0169
		static Delegate GetGetInputWatcherHandler ()
		{
			if (cb_getInputWatcher == null)
				cb_getInputWatcher = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputWatcher);
			return cb_getInputWatcher;
		}

		static IntPtr n_GetInputWatcher (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputWatcher);
		}
#pragma warning restore 0169

		static Delegate cb_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_;
#pragma warning disable 0169
		static Delegate GetSetInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_Handler ()
		{
			if (cb_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_ == null)
				cb_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_);
			return cb_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_;
		}

		static void n_SetInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher p0 = (global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputWatcher = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputWatcher;
		static IntPtr id_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_;
		public virtual unsafe global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher InputWatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getInputWatcher' and count(parameter)=0]"
			[Register ("getInputWatcher", "()Lio/adaptivecards/renderer/inputhandler/IInputWatcher;", "GetGetInputWatcherHandler")]
			get {
				if (id_getInputWatcher == IntPtr.Zero)
					id_getInputWatcher = JNIEnv.GetMethodID (class_ref, "getInputWatcher", "()Lio/adaptivecards/renderer/inputhandler/IInputWatcher;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputWatcher), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.IInputWatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputWatcher", "()Lio/adaptivecards/renderer/inputhandler/IInputWatcher;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='setInputWatcher' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.inputhandler.IInputWatcher']]"
			[Register ("setInputWatcher", "(Lio/adaptivecards/renderer/inputhandler/IInputWatcher;)V", "GetSetInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_Handler")]
			set {
				if (id_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_ == IntPtr.Zero)
					id_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_ = JNIEnv.GetMethodID (class_ref, "setInputWatcher", "(Lio/adaptivecards/renderer/inputhandler/IInputWatcher;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInputWatcher_Lio_adaptivecards_renderer_inputhandler_IInputWatcher_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputWatcher", "(Lio/adaptivecards/renderer/inputhandler/IInputWatcher;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/registration/CardRendererRegistration;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/registration/CardRendererRegistration;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnlineImageLoader;
#pragma warning disable 0169
		static Delegate GetGetOnlineImageLoaderHandler ()
		{
			if (cb_getOnlineImageLoader == null)
				cb_getOnlineImageLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnlineImageLoader);
			return cb_getOnlineImageLoader;
		}

		static IntPtr n_GetOnlineImageLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnlineImageLoader);
		}
#pragma warning restore 0169

		static IntPtr id_getOnlineImageLoader;
		public virtual unsafe global::IO.Adaptivecards.Renderer.IOnlineImageLoader OnlineImageLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getOnlineImageLoader' and count(parameter)=0]"
			[Register ("getOnlineImageLoader", "()Lio/adaptivecards/renderer/IOnlineImageLoader;", "GetGetOnlineImageLoaderHandler")]
			get {
				if (id_getOnlineImageLoader == IntPtr.Zero)
					id_getOnlineImageLoader = JNIEnv.GetMethodID (class_ref, "getOnlineImageLoader", "()Lio/adaptivecards/renderer/IOnlineImageLoader;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineImageLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnlineImageLoader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineImageLoader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnlineImageLoader", "()Lio/adaptivecards/renderer/IOnlineImageLoader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnlineMediaLoader;
#pragma warning disable 0169
		static Delegate GetGetOnlineMediaLoaderHandler ()
		{
			if (cb_getOnlineMediaLoader == null)
				cb_getOnlineMediaLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnlineMediaLoader);
			return cb_getOnlineMediaLoader;
		}

		static IntPtr n_GetOnlineMediaLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnlineMediaLoader);
		}
#pragma warning restore 0169

		static IntPtr id_getOnlineMediaLoader;
		public virtual unsafe global::IO.Adaptivecards.Renderer.IOnlineMediaLoader OnlineMediaLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getOnlineMediaLoader' and count(parameter)=0]"
			[Register ("getOnlineMediaLoader", "()Lio/adaptivecards/renderer/IOnlineMediaLoader;", "GetGetOnlineMediaLoaderHandler")]
			get {
				if (id_getOnlineMediaLoader == IntPtr.Zero)
					id_getOnlineMediaLoader = JNIEnv.GetMethodID (class_ref, "getOnlineMediaLoader", "()Lio/adaptivecards/renderer/IOnlineMediaLoader;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineMediaLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnlineMediaLoader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineMediaLoader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnlineMediaLoader", "()Lio/adaptivecards/renderer/IOnlineMediaLoader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRenderer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRenderer_Ljava_lang_String_Handler ()
		{
			if (cb_getRenderer_Ljava_lang_String_ == null)
				cb_getRenderer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRenderer_Ljava_lang_String_);
			return cb_getRenderer_Ljava_lang_String_;
		}

		static IntPtr n_GetRenderer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRenderer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='getRenderer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRenderer", "(Ljava/lang/String;)Lio/adaptivecards/renderer/IBaseCardElementRenderer;", "GetGetRenderer_Ljava_lang_String_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer GetRenderer (string p0)
		{
			if (id_getRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getRenderer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRenderer", "(Ljava/lang/String;)Lio/adaptivecards/renderer/IBaseCardElementRenderer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRenderer", "(Ljava/lang/String;)Lio/adaptivecards/renderer/IBaseCardElementRenderer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_notifyInputChange_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyInputChange_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_notifyInputChange_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_notifyInputChange_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyInputChange_Ljava_lang_String_Ljava_lang_String_);
			return cb_notifyInputChange_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_NotifyInputChange_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyInputChange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyInputChange_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='notifyInputChange' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("notifyInputChange", "(Ljava/lang/String;Ljava/lang/String;)V", "GetNotifyInputChange_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void NotifyInputChange (string p0, string p1)
		{
			if (id_notifyInputChange_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyInputChange_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyInputChange", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyInputChange_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyInputChange", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_;
#pragma warning disable 0169
		static Delegate GetRegisterActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_Handler ()
		{
			if (cb_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_ == null)
				cb_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_);
			return cb_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_;
		}

		static void n_RegisterActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.IActionLayoutRenderer p0 = (global::IO.Adaptivecards.Renderer.IActionLayoutRenderer)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IActionLayoutRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterActionLayoutRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='registerActionLayoutRenderer' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.IActionLayoutRenderer']]"
		[Register ("registerActionLayoutRenderer", "(Lio/adaptivecards/renderer/IActionLayoutRenderer;)V", "GetRegisterActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_Handler")]
		public virtual unsafe void RegisterActionLayoutRenderer (global::IO.Adaptivecards.Renderer.IActionLayoutRenderer p0)
		{
			if (id_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_ == IntPtr.Zero)
				id_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_ = JNIEnv.GetMethodID (class_ref, "registerActionLayoutRenderer", "(Lio/adaptivecards/renderer/IActionLayoutRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerActionLayoutRenderer_Lio_adaptivecards_renderer_IActionLayoutRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerActionLayoutRenderer", "(Lio/adaptivecards/renderer/IActionLayoutRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_;
#pragma warning disable 0169
		static Delegate GetRegisterActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_Handler ()
		{
			if (cb_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_ == null)
				cb_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_);
			return cb_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_;
		}

		static void n_RegisterActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer p0 = (global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterActionRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='registerActionRenderer' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.IBaseActionElementRenderer']]"
		[Register ("registerActionRenderer", "(Lio/adaptivecards/renderer/IBaseActionElementRenderer;)V", "GetRegisterActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_Handler")]
		public virtual unsafe void RegisterActionRenderer (global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer p0)
		{
			if (id_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_ == IntPtr.Zero)
				id_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_ = JNIEnv.GetMethodID (class_ref, "registerActionRenderer", "(Lio/adaptivecards/renderer/IBaseActionElementRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerActionRenderer_Lio_adaptivecards_renderer_IBaseActionElementRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerActionRenderer", "(Lio/adaptivecards/renderer/IBaseActionElementRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_;
#pragma warning disable 0169
		static Delegate GetRegisterOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_Handler ()
		{
			if (cb_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ == null)
				cb_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_);
			return cb_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_;
		}

		static void n_RegisterOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.IOnlineImageLoader p0 = (global::IO.Adaptivecards.Renderer.IOnlineImageLoader)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineImageLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnlineImageLoader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='registerOnlineImageLoader' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.IOnlineImageLoader']]"
		[Register ("registerOnlineImageLoader", "(Lio/adaptivecards/renderer/IOnlineImageLoader;)V", "GetRegisterOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_Handler")]
		public virtual unsafe void RegisterOnlineImageLoader (global::IO.Adaptivecards.Renderer.IOnlineImageLoader p0)
		{
			if (id_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ == IntPtr.Zero)
				id_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ = JNIEnv.GetMethodID (class_ref, "registerOnlineImageLoader", "(Lio/adaptivecards/renderer/IOnlineImageLoader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerOnlineImageLoader", "(Lio/adaptivecards/renderer/IOnlineImageLoader;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_;
#pragma warning disable 0169
		static Delegate GetRegisterOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_Handler ()
		{
			if (cb_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_ == null)
				cb_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_);
			return cb_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_;
		}

		static void n_RegisterOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.IOnlineMediaLoader p0 = (global::IO.Adaptivecards.Renderer.IOnlineMediaLoader)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineMediaLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnlineMediaLoader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='registerOnlineMediaLoader' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.IOnlineMediaLoader']]"
		[Register ("registerOnlineMediaLoader", "(Lio/adaptivecards/renderer/IOnlineMediaLoader;)V", "GetRegisterOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_Handler")]
		public virtual unsafe void RegisterOnlineMediaLoader (global::IO.Adaptivecards.Renderer.IOnlineMediaLoader p0)
		{
			if (id_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_ == IntPtr.Zero)
				id_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_ = JNIEnv.GetMethodID (class_ref, "registerOnlineMediaLoader", "(Lio/adaptivecards/renderer/IOnlineMediaLoader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerOnlineMediaLoader_Lio_adaptivecards_renderer_IOnlineMediaLoader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerOnlineMediaLoader", "(Lio/adaptivecards/renderer/IOnlineMediaLoader;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_;
#pragma warning disable 0169
		static Delegate GetRegisterRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_Handler ()
		{
			if (cb_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_ == null)
				cb_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_);
			return cb_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_;
		}

		static void n_RegisterRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer p1 = (global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterRenderer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='registerRenderer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.adaptivecards.renderer.IBaseCardElementRenderer']]"
		[Register ("registerRenderer", "(Ljava/lang/String;Lio/adaptivecards/renderer/IBaseCardElementRenderer;)V", "GetRegisterRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_Handler")]
		public virtual unsafe void RegisterRenderer (string p0, global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer p1)
		{
			if (id_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_ == IntPtr.Zero)
				id_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_ = JNIEnv.GetMethodID (class_ref, "registerRenderer", "(Ljava/lang/String;Lio/adaptivecards/renderer/IBaseCardElementRenderer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerRenderer_Ljava_lang_String_Lio_adaptivecards_renderer_IBaseCardElementRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerRenderer", "(Ljava/lang/String;Lio/adaptivecards/renderer/IBaseCardElementRenderer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
#pragma warning disable 0169
		static Delegate GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_Handler ()
		{
			if (cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ == null)
				cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_);
			return cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
		}

		static IntPtr n_Render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8)
		{
			global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Registration.CardRendererRegistration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p3 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseCardElementVector p5 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElementVector> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p6 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p7 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p7, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyle p8 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (native_p8, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Render (p0, p1, p2, p3, p4, p5, p6, p7, p8));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.registration']/class[@name='CardRendererRegistration']/method[@name='render' and count(parameter)=9 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='io.adaptivecards.objectmodel.BaseCardElementVector'] and parameter[7][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[8][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[9][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
		[Register ("render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Ljava/lang/Object;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;", "GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_Handler")]
		public virtual unsafe global::Android.Views.View Render (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Support.V4.App.FragmentManager p2, global::Android.Views.ViewGroup p3, global::Java.Lang.Object p4, global::IO.Adaptivecards.Objectmodel.BaseCardElementVector p5, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p6, global::IO.Adaptivecards.Objectmodel.HostConfig p7, global::IO.Adaptivecards.Objectmodel.ContainerStyle p8)
		{
			if (id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ == IntPtr.Zero)
				id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNIEnv.GetMethodID (class_ref, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Ljava/lang/Object;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Ljava_lang_Object_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Ljava/lang/Object;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
