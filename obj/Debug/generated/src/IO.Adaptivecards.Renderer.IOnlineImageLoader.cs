using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.adaptivecards.renderer']/interface[@name='IOnlineImageLoader']"
	[Register ("io/adaptivecards/renderer/IOnlineImageLoader", "", "IO.Adaptivecards.Renderer.IOnlineImageLoaderInvoker")]
	public partial interface IOnlineImageLoader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/interface[@name='IOnlineImageLoader']/method[@name='loadOnlineImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.adaptivecards.renderer.GenericImageLoaderAsync']]"
		[Register ("loadOnlineImage", "(Ljava/lang/String;Lio/adaptivecards/renderer/GenericImageLoaderAsync;)Lio/adaptivecards/renderer/http/HttpRequestResult;", "GetLoadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_Handler:IO.Adaptivecards.Renderer.IOnlineImageLoaderInvoker, AdaptiveCards.Xamarin.Android")]
		global::IO.Adaptivecards.Renderer.Http.HttpRequestResult LoadOnlineImage (string p0, global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync p1);

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/IOnlineImageLoader", DoNotGenerateAcw=true)]
	internal class IOnlineImageLoaderInvoker : global::Java.Lang.Object, IOnlineImageLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/adaptivecards/renderer/IOnlineImageLoader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnlineImageLoaderInvoker); }
		}

		IntPtr class_ref;

		public static IOnlineImageLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnlineImageLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.adaptivecards.renderer.IOnlineImageLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnlineImageLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::IO.Adaptivecards.Renderer.IOnlineImageLoader __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadOnlineImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_;
		public unsafe global::IO.Adaptivecards.Renderer.Http.HttpRequestResult LoadOnlineImage (string p0, global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync p1)
		{
			if (id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ == IntPtr.Zero)
				id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_ = JNIEnv.GetMethodID (class_ref, "loadOnlineImage", "(Ljava/lang/String;Lio/adaptivecards/renderer/GenericImageLoaderAsync;)Lio/adaptivecards/renderer/http/HttpRequestResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::IO.Adaptivecards.Renderer.Http.HttpRequestResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadOnlineImage_Ljava_lang_String_Lio_adaptivecards_renderer_GenericImageLoaderAsync_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
