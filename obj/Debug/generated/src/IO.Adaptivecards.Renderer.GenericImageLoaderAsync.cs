using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='GenericImageLoaderAsync']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/GenericImageLoaderAsync", DoNotGenerateAcw=true)]
	public abstract partial class GenericImageLoaderAsync : global::Android.OS.AsyncTask {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/GenericImageLoaderAsync", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericImageLoaderAsync); }
		}

		protected GenericImageLoaderAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_Handler ()
		{
			if (cb_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_ == null)
				cb_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_);
			return cb_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_;
		}

		static void n_OnPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Http.HttpRequestResult p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='GenericImageLoaderAsync']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.http.HttpRequestResult&lt;android.graphics.Bitmap&gt;']]"
		[Register ("onPostExecute", "(Lio/adaptivecards/renderer/http/HttpRequestResult;)V", "GetOnPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_Handler")]
		protected virtual unsafe void OnPostExecute (global::IO.Adaptivecards.Renderer.Http.HttpRequestResult p0)
		{
			if (id_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_ == IntPtr.Zero)
				id_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Lio/adaptivecards/renderer/http/HttpRequestResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Lio_adaptivecards_renderer_http_HttpRequestResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Lio/adaptivecards/renderer/http/HttpRequestResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_;
#pragma warning disable 0169
		static Delegate GetRegisterCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_Handler ()
		{
			if (cb_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ == null)
				cb_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_);
			return cb_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_;
		}

		static void n_RegisterCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.IOnlineImageLoader p0 = (global::IO.Adaptivecards.Renderer.IOnlineImageLoader)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IOnlineImageLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCustomOnlineImageLoader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='GenericImageLoaderAsync']/method[@name='registerCustomOnlineImageLoader' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.IOnlineImageLoader']]"
		[Register ("registerCustomOnlineImageLoader", "(Lio/adaptivecards/renderer/IOnlineImageLoader;)V", "GetRegisterCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_Handler")]
		public virtual unsafe void RegisterCustomOnlineImageLoader (global::IO.Adaptivecards.Renderer.IOnlineImageLoader p0)
		{
			if (id_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ == IntPtr.Zero)
				id_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_ = JNIEnv.GetMethodID (class_ref, "registerCustomOnlineImageLoader", "(Lio/adaptivecards/renderer/IOnlineImageLoader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerCustomOnlineImageLoader_Lio_adaptivecards_renderer_IOnlineImageLoader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerCustomOnlineImageLoader", "(Lio/adaptivecards/renderer/IOnlineImageLoader;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_styleBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetStyleBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_styleBitmap_Landroid_graphics_Bitmap_ == null)
				cb_styleBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StyleBitmap_Landroid_graphics_Bitmap_);
			return cb_styleBitmap_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_StyleBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StyleBitmap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_styleBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='GenericImageLoaderAsync']/method[@name='styleBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("styleBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetStyleBitmap_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe global::Android.Graphics.Bitmap StyleBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_styleBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_styleBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "styleBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_styleBitmap_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "styleBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/GenericImageLoaderAsync", DoNotGenerateAcw=true)]
	internal partial class GenericImageLoaderAsyncInvoker : GenericImageLoaderAsync {

		public GenericImageLoaderAsyncInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericImageLoaderAsyncInvoker); }
		}

		static IntPtr id_doInBackground_arrayLjava_lang_Object_;
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
		protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] @params)
		{
			if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

	}

}
