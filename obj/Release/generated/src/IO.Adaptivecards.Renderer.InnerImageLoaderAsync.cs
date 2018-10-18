using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='InnerImageLoaderAsync']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/InnerImageLoaderAsync", DoNotGenerateAcw=true)]
	public abstract partial class InnerImageLoaderAsync : global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync {


		static IntPtr m_view_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='InnerImageLoaderAsync']/field[@name='m_view']"
		[Register ("m_view")]
		protected global::Android.Views.View MView {
			get {
				if (m_view_jfieldId == IntPtr.Zero)
					m_view_jfieldId = JNIEnv.GetFieldID (class_ref, "m_view", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_view_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_view_jfieldId == IntPtr.Zero)
					m_view_jfieldId = JNIEnv.GetFieldID (class_ref, "m_view", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_view_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/InnerImageLoaderAsync", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InnerImageLoaderAsync); }
		}

		protected InnerImageLoaderAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_view_View_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='InnerImageLoaderAsync']/constructor[@name='InnerImageLoaderAsync' and count(parameter)=3 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.view.View'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/view/View;Ljava/lang/String;)V", "")]
		public unsafe InnerImageLoaderAsync (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Views.View p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (InnerImageLoaderAsync)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/view/View;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/view/View;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/view/View;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_view_View_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_view_View_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_String_ == null)
				cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
			return cb_doInBackground_arrayLjava_lang_String_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.InnerImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.InnerImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='InnerImageLoaderAsync']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("doInBackground", "([Ljava/lang/String;)Lio/adaptivecards/renderer/http/HttpRequestResult;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
		protected virtual unsafe global::IO.Adaptivecards.Renderer.Http.HttpRequestResult DoInBackground (params string[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Lio/adaptivecards/renderer/http/HttpRequestResult;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::IO.Adaptivecards.Renderer.Http.HttpRequestResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Http.HttpRequestResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Lio/adaptivecards/renderer/http/HttpRequestResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_renderBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetRenderBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_renderBitmap_Landroid_graphics_Bitmap_ == null)
				cb_renderBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderBitmap_Landroid_graphics_Bitmap_);
			return cb_renderBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_RenderBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.InnerImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.InnerImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderBitmap (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='InnerImageLoaderAsync']/method[@name='renderBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("renderBitmap", "(Landroid/graphics/Bitmap;)V", "GetRenderBitmap_Landroid_graphics_Bitmap_Handler")]
		protected abstract void RenderBitmap (global::Android.Graphics.Bitmap p0);

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/InnerImageLoaderAsync", DoNotGenerateAcw=true)]
	internal partial class InnerImageLoaderAsyncInvoker : InnerImageLoaderAsync {

		public InnerImageLoaderAsyncInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InnerImageLoaderAsyncInvoker); }
		}

		static IntPtr id_renderBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='InnerImageLoaderAsync']/method[@name='renderBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("renderBitmap", "(Landroid/graphics/Bitmap;)V", "GetRenderBitmap_Landroid_graphics_Bitmap_Handler")]
		protected override unsafe void RenderBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_renderBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_renderBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "renderBitmap", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderBitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
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
