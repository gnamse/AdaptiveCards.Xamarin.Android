using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/AdaptiveCardRenderer", DoNotGenerateAcw=true)]
	public partial class AdaptiveCardRenderer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.1";
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer.BackgroundImageLoaderAsync']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/AdaptiveCardRenderer$BackgroundImageLoaderAsync", DoNotGenerateAcw=true)]
		public partial class BackgroundImageLoaderAsync : global::IO.Adaptivecards.Renderer.GenericImageLoaderAsync {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/AdaptiveCardRenderer$BackgroundImageLoaderAsync", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BackgroundImageLoaderAsync); }
			}

			protected BackgroundImageLoaderAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_adaptivecards_renderer_AdaptiveCardRenderer_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_widget_LinearLayout_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer.BackgroundImageLoaderAsync']/constructor[@name='AdaptiveCardRenderer.BackgroundImageLoaderAsync' and count(parameter)=5 and parameter[1][@type='io.adaptivecards.renderer.AdaptiveCardRenderer'] and parameter[2][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[3][@type='android.content.Context'] and parameter[4][@type='android.widget.LinearLayout'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Lio/adaptivecards/renderer/AdaptiveCardRenderer;Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/widget/LinearLayout;Ljava/lang/String;)V", "")]
			public unsafe BackgroundImageLoaderAsync (global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer __self, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1, global::Android.Content.Context p2, global::Android.Widget.LinearLayout p3, string p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p4 = JNIEnv.NewString (p4);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (native_p4);
					if (((object) this).GetType () != typeof (BackgroundImageLoaderAsync)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/widget/LinearLayout;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/widget/LinearLayout;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lio_adaptivecards_renderer_AdaptiveCardRenderer_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_widget_LinearLayout_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lio_adaptivecards_renderer_AdaptiveCardRenderer_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_widget_LinearLayout_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/renderer/AdaptiveCardRenderer;Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/widget/LinearLayout;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_renderer_AdaptiveCardRenderer_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_widget_LinearLayout_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_renderer_AdaptiveCardRenderer_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_widget_LinearLayout_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer.BackgroundImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer.BackgroundImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer.BackgroundImageLoaderAsync']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
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
				global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer.BackgroundImageLoaderAsync __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer.BackgroundImageLoaderAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer.BackgroundImageLoaderAsync']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/AdaptiveCardRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdaptiveCardRenderer); }
		}

		protected AdaptiveCardRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']/constructor[@name='AdaptiveCardRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AdaptiveCardRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AdaptiveCardRenderer)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/AdaptiveCardRenderer;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/AdaptiveCardRenderer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z;
#pragma warning disable 0169
		static Delegate GetInternalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ZHandler ()
		{
			if (cb_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z == null)
				cb_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_InternalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z);
			return cb_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z;
		}

		static IntPtr n_InternalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, bool p6)
		{
			global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard p3 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p4 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p5 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalRender (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']/method[@name='internalRender' and count(parameter)=7 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='io.adaptivecards.objectmodel.AdaptiveCard'] and parameter[5][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[6][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[7][@type='boolean']]"
		[Register ("internalRender", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Z)Landroid/view/View;", "GetInternalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ZHandler")]
		public virtual unsafe global::Android.Views.View InternalRender (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Support.V4.App.FragmentManager p2, global::IO.Adaptivecards.Objectmodel.AdaptiveCard p3, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p4, global::IO.Adaptivecards.Objectmodel.HostConfig p5, bool p6)
		{
			if (id_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z == IntPtr.Zero)
				id_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z = JNIEnv.GetMethodID (class_ref, "internalRender", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Z)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_internalRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalRender", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Z)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_;
#pragma warning disable 0169
		static Delegate GetRender_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Handler ()
		{
			if (cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ == null)
				cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_);
			return cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_;
		}

		static IntPtr n_Render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard p2 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p3 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Render (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']/method[@name='render' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.support.v4.app.FragmentManager'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCard'] and parameter[4][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler']]"
		[Register ("render", "(Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)Lio/adaptivecards/renderer/RenderedAdaptiveCard;", "GetRender_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard Render (global::Android.Content.Context p0, global::Android.Support.V4.App.FragmentManager p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCard p2, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p3)
		{
			if (id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ == IntPtr.Zero)
				id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ = JNIEnv.GetMethodID (class_ref, "render", "(Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)Lio/adaptivecards/renderer/RenderedAdaptiveCard;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "(Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)Lio/adaptivecards/renderer/RenderedAdaptiveCard;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
#pragma warning disable 0169
		static Delegate GetRender_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler ()
		{
			if (cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ == null)
				cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_);
			return cb_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		}

		static IntPtr n_Render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveCardRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard p2 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p3 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p4 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Render (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='AdaptiveCardRenderer']/method[@name='render' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.support.v4.app.FragmentManager'] and parameter[3][@type='io.adaptivecards.objectmodel.AdaptiveCard'] and parameter[4][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[5][@type='io.adaptivecards.objectmodel.HostConfig']]"
		[Register ("render", "(Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)Lio/adaptivecards/renderer/RenderedAdaptiveCard;", "GetRender_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler")]
		public virtual unsafe global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard Render (global::Android.Content.Context p0, global::Android.Support.V4.App.FragmentManager p1, global::IO.Adaptivecards.Objectmodel.AdaptiveCard p2, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p3, global::IO.Adaptivecards.Objectmodel.HostConfig p4)
		{
			if (id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ == IntPtr.Zero)
				id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNIEnv.GetMethodID (class_ref, "render", "(Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)Lio/adaptivecards/renderer/RenderedAdaptiveCard;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "(Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)Lio/adaptivecards/renderer/RenderedAdaptiveCard;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
