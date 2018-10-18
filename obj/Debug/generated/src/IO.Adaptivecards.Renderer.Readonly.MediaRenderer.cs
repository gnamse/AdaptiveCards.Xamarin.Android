using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Readonly {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/readonly/MediaRenderer", DoNotGenerateAcw=true)]
	public partial class MediaRenderer : global::IO.Adaptivecards.Renderer.BaseCardElementRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer.MediaOnCompletionListener']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/readonly/MediaRenderer$MediaOnCompletionListener", DoNotGenerateAcw=true)]
		public partial class MediaOnCompletionListener : global::Java.Lang.Object, global::Android.Media.MediaPlayer.IOnCompletionListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/readonly/MediaRenderer$MediaOnCompletionListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaOnCompletionListener); }
			}

			protected MediaOnCompletionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onCompletion_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
			static Delegate GetOnCompletion_Landroid_media_MediaPlayer_Handler ()
			{
				if (cb_onCompletion_Landroid_media_MediaPlayer_ == null)
					cb_onCompletion_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompletion_Landroid_media_MediaPlayer_);
				return cb_onCompletion_Landroid_media_MediaPlayer_;
			}

			static void n_OnCompletion_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer.MediaOnCompletionListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer.MediaOnCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCompletion (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCompletion_Landroid_media_MediaPlayer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer.MediaOnCompletionListener']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
			[Register ("onCompletion", "(Landroid/media/MediaPlayer;)V", "GetOnCompletion_Landroid_media_MediaPlayer_Handler")]
			public virtual unsafe void OnCompletion (global::Android.Media.MediaPlayer p0)
			{
				if (id_onCompletion_Landroid_media_MediaPlayer_ == IntPtr.Zero)
					id_onCompletion_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onCompletion", "(Landroid/media/MediaPlayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletion_Landroid_media_MediaPlayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompletion", "(Landroid/media/MediaPlayer;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer.PosterOnClickListener']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/readonly/MediaRenderer$PosterOnClickListener", DoNotGenerateAcw=true)]
		public partial class PosterOnClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/readonly/MediaRenderer$PosterOnClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PosterOnClickListener); }
			}

			protected PosterOnClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_adaptivecards_renderer_readonly_MediaRenderer_Landroid_widget_ImageView_Landroid_widget_ImageView_Lio_adaptivecards_renderer_layout_FullscreenVideoView_ZLio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer.PosterOnClickListener']/constructor[@name='MediaRenderer.PosterOnClickListener' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.readonly.MediaRenderer'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='android.widget.ImageView'] and parameter[4][@type='io.adaptivecards.renderer.layout.FullscreenVideoView'] and parameter[5][@type='boolean'] and parameter[6][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[7][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[8][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler']]"
			[Register (".ctor", "(Lio/adaptivecards/renderer/readonly/MediaRenderer;Landroid/widget/ImageView;Landroid/widget/ImageView;Lio/adaptivecards/renderer/layout/FullscreenVideoView;ZLio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V", "")]
			public unsafe PosterOnClickListener (global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer __self, global::Android.Widget.ImageView p1, global::Android.Widget.ImageView p2, global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView p3, bool p4, global::IO.Adaptivecards.Objectmodel.BaseCardElement p5, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p6, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p7)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [8];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);
					if (((object) this).GetType () != typeof (PosterOnClickListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/widget/ImageView;Landroid/widget/ImageView;Lio/adaptivecards/renderer/layout/FullscreenVideoView;ZLio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/widget/ImageView;Landroid/widget/ImageView;Lio/adaptivecards/renderer/layout/FullscreenVideoView;ZLio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V", __args);
						return;
					}

					if (id_ctor_Lio_adaptivecards_renderer_readonly_MediaRenderer_Landroid_widget_ImageView_Landroid_widget_ImageView_Lio_adaptivecards_renderer_layout_FullscreenVideoView_ZLio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ == IntPtr.Zero)
						id_ctor_Lio_adaptivecards_renderer_readonly_MediaRenderer_Landroid_widget_ImageView_Landroid_widget_ImageView_Lio_adaptivecards_renderer_layout_FullscreenVideoView_ZLio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/renderer/readonly/MediaRenderer;Landroid/widget/ImageView;Landroid/widget/ImageView;Lio/adaptivecards/renderer/layout/FullscreenVideoView;ZLio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_renderer_readonly_MediaRenderer_Landroid_widget_ImageView_Landroid_widget_ImageView_Lio_adaptivecards_renderer_layout_FullscreenVideoView_ZLio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_renderer_readonly_MediaRenderer_Landroid_widget_ImageView_Landroid_widget_ImageView_Lio_adaptivecards_renderer_layout_FullscreenVideoView_ZLio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_, __args);
				} finally {
				}
			}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer.PosterOnClickListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer.PosterOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer.PosterOnClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual unsafe void OnClick (global::Android.Views.View p0)
			{
				if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/readonly/MediaRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaRenderer); }
		}

		protected MediaRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/readonly/MediaRenderer;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/readonly/MediaRenderer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
#pragma warning disable 0169
		static Delegate GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_Handler ()
		{
			if (cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ == null)
				cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_);
			return cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
		}

		static IntPtr n_Render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Readonly.MediaRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p3 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseCardElement p4 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p6 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyle p7 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Render (p0, p1, p2, p3, p4, p5, p6, p7));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='MediaRenderer']/method[@name='render' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[8][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
		[Register ("render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;", "GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_Handler")]
		public override unsafe global::Android.Views.View Render (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Support.V4.App.FragmentManager p2, global::Android.Views.ViewGroup p3, global::IO.Adaptivecards.Objectmodel.BaseCardElement p4, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5, global::IO.Adaptivecards.Objectmodel.HostConfig p6, global::IO.Adaptivecards.Objectmodel.ContainerStyle p7)
		{
			if (id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ == IntPtr.Zero)
				id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNIEnv.GetMethodID (class_ref, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
