using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='BaseCardElementRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/BaseCardElementRenderer", DoNotGenerateAcw=true)]
	public abstract partial class BaseCardElementRenderer : global::Java.Lang.Object, global::IO.Adaptivecards.Renderer.IBaseCardElementRenderer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/BaseCardElementRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCardElementRenderer); }
		}

		protected BaseCardElementRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='BaseCardElementRenderer']/constructor[@name='BaseCardElementRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseCardElementRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseCardElementRenderer)) {
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

		static IntPtr id_getColor_Lio_adaptivecards_objectmodel_ForegroundColor_Lio_adaptivecards_objectmodel_ColorsConfig_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='BaseCardElementRenderer']/method[@name='getColor' and count(parameter)=3 and parameter[1][@type='io.adaptivecards.objectmodel.ForegroundColor'] and parameter[2][@type='io.adaptivecards.objectmodel.ColorsConfig'] and parameter[3][@type='boolean']]"
		[Register ("getColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;Lio/adaptivecards/objectmodel/ColorsConfig;Z)I", "")]
		protected static unsafe int GetColor (global::IO.Adaptivecards.Objectmodel.ForegroundColor p0, global::IO.Adaptivecards.Objectmodel.ColorsConfig p1, bool p2)
		{
			if (id_getColor_Lio_adaptivecards_objectmodel_ForegroundColor_Lio_adaptivecards_objectmodel_ColorsConfig_Z == IntPtr.Zero)
				id_getColor_Lio_adaptivecards_objectmodel_ForegroundColor_Lio_adaptivecards_objectmodel_ColorsConfig_Z = JNIEnv.GetStaticMethodID (class_ref, "getColor", "(Lio/adaptivecards/objectmodel/ForegroundColor;Lio/adaptivecards/objectmodel/ColorsConfig;Z)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getColor_Lio_adaptivecards_objectmodel_ForegroundColor_Lio_adaptivecards_objectmodel_ColorsConfig_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSpacingSize_Lio_adaptivecards_objectmodel_Spacing_Lio_adaptivecards_objectmodel_SpacingConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='BaseCardElementRenderer']/method[@name='getSpacingSize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.Spacing'] and parameter[2][@type='io.adaptivecards.objectmodel.SpacingConfig']]"
		[Register ("getSpacingSize", "(Lio/adaptivecards/objectmodel/Spacing;Lio/adaptivecards/objectmodel/SpacingConfig;)J", "")]
		protected static unsafe long GetSpacingSize (global::IO.Adaptivecards.Objectmodel.Spacing p0, global::IO.Adaptivecards.Objectmodel.SpacingConfig p1)
		{
			if (id_getSpacingSize_Lio_adaptivecards_objectmodel_Spacing_Lio_adaptivecards_objectmodel_SpacingConfig_ == IntPtr.Zero)
				id_getSpacingSize_Lio_adaptivecards_objectmodel_Spacing_Lio_adaptivecards_objectmodel_SpacingConfig_ = JNIEnv.GetStaticMethodID (class_ref, "getSpacingSize", "(Lio/adaptivecards/objectmodel/Spacing;Lio/adaptivecards/objectmodel/SpacingConfig;)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getSpacingSize_Lio_adaptivecards_objectmodel_Spacing_Lio_adaptivecards_objectmodel_SpacingConfig_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='BaseCardElementRenderer']/method[@name='setSpacingAndSeparator' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='io.adaptivecards.objectmodel.Spacing'] and parameter[4][@type='boolean'] and parameter[5][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[6][@type='boolean']]"
		[Register ("setSpacingAndSeparator", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HostConfig;Z)V", "")]
		protected static unsafe void SetSpacingAndSeparator (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1, global::IO.Adaptivecards.Objectmodel.Spacing p2, bool p3, global::IO.Adaptivecards.Objectmodel.HostConfig p4, bool p5)
		{
			if (id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_Z == IntPtr.Zero)
				id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_Z = JNIEnv.GetStaticMethodID (class_ref, "setSpacingAndSeparator", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HostConfig;Z)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='BaseCardElementRenderer']/method[@name='setSpacingAndSeparator' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='io.adaptivecards.objectmodel.Spacing'] and parameter[4][@type='boolean'] and parameter[5][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("setSpacingAndSeparator", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HostConfig;ZZ)V", "")]
		protected static unsafe void SetSpacingAndSeparator (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1, global::IO.Adaptivecards.Objectmodel.Spacing p2, bool p3, global::IO.Adaptivecards.Objectmodel.HostConfig p4, bool p5, bool p6)
		{
			if (id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_ZZ == IntPtr.Zero)
				id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_ZZ = JNIEnv.GetStaticMethodID (class_ref, "setSpacingAndSeparator", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HostConfig;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSpacingAndSeparator_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HostConfig_ZZ, __args);
			} finally {
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
			global::IO.Adaptivecards.Renderer.BaseCardElementRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.BaseCardElementRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/interface[@name='IBaseCardElementRenderer']/method[@name='render' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[8][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
		[Register ("render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/objectmodel/ContainerStyle;)Landroid/view/View;", "GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_Handler")]
		public abstract global::Android.Views.View Render (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Support.V4.App.FragmentManager p2, global::Android.Views.ViewGroup p3, global::IO.Adaptivecards.Objectmodel.BaseCardElement p4, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5, global::IO.Adaptivecards.Objectmodel.HostConfig p6, global::IO.Adaptivecards.Objectmodel.ContainerStyle p7);

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/BaseCardElementRenderer", DoNotGenerateAcw=true)]
	internal partial class BaseCardElementRendererInvoker : BaseCardElementRenderer {

		public BaseCardElementRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCardElementRendererInvoker); }
		}

		static IntPtr id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/interface[@name='IBaseCardElementRenderer']/method[@name='render' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[8][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
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
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_objectmodel_ContainerStyle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
