using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='OnlineImageLoader']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/OnlineImageLoader", DoNotGenerateAcw=true)]
	public partial class OnlineImageLoader : global::Java.Lang.Object, global::IO.Adaptivecards.Renderer.IOnlineImageLoader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/OnlineImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OnlineImageLoader); }
		}

		protected OnlineImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='OnlineImageLoader']/constructor[@name='OnlineImageLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OnlineImageLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OnlineImageLoader)) {
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

		static Delegate cb_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_;
#pragma warning disable 0169
		static Delegate GetLoadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_Handler ()
		{
			if (cb_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ == null)
				cb_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_);
			return cb_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_;
		}

		static IntPtr n_LoadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.OnlineImageLoader __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.OnlineImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadOnlineImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='OnlineImageLoader']/method[@name='loadOnlineImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.adaptivecards.renderer.GenericImageLoaderAsync']]"
		[Register ("loadOnlineImage", "(Ljava/lang/String;Lio/adaptivecards/renderer/GenericImageLoaderAsync;)Lio/adaptivecards/renderer/http/HttpRequestResult;", "GetLoadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Renderer.Http.HttpRequestResult LoadOnlineImage (string p0, global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync p1)
		{
			if (id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ == IntPtr.Zero)
				id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ = JNIEnv.GetMethodID (class_ref, "loadOnlineImage", "(Ljava/lang/String;Lio/adaptivecards/renderer/GenericImageLoaderAsync;)Lio/adaptivecards/renderer/http/HttpRequestResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::IO.Adaptivecards.Renderer.Http.HttpRequestResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadOnlineImage", "(Ljava/lang/String;Lio/adaptivecards/renderer/GenericImageLoaderAsync;)Lio/adaptivecards/renderer/http/HttpRequestResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
