using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='ActionLayoutRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/ActionLayoutRenderer", DoNotGenerateAcw=true)]
	public partial class ActionLayoutRenderer : global::Java.Lang.Object, global::IO.Adaptivecards.Renderer.IActionLayoutRenderer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/ActionLayoutRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionLayoutRenderer); }
		}

		protected ActionLayoutRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='ActionLayoutRenderer']/constructor[@name='ActionLayoutRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ActionLayoutRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ActionLayoutRenderer)) {
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
		public static unsafe global::IO.Adaptivecards.Renderer.ActionLayoutRenderer Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='ActionLayoutRenderer']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/ActionLayoutRenderer;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/ActionLayoutRenderer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.ActionLayoutRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
#pragma warning disable 0169
		static Delegate GetRenderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler ()
		{
			if (cb_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ == null)
				cb_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RenderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_);
			return cb_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		}

		static void n_RenderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::IO.Adaptivecards.Renderer.ActionLayoutRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.ActionLayoutRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p3 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElementVector p4 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElementVector> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p6 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.RenderActions (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='ActionLayoutRenderer']/method[@name='renderActions' and count(parameter)=7 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseActionElementVector'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig']]"
		[Register ("renderActions", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElementVector;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)V", "GetRenderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler")]
		public virtual unsafe void RenderActions (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Support.V4.App.FragmentManager p2, global::Android.Views.ViewGroup p3, global::IO.Adaptivecards.Objectmodel.BaseActionElementVector p4, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5, global::IO.Adaptivecards.Objectmodel.HostConfig p6)
		{
			if (id_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ == IntPtr.Zero)
				id_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNIEnv.GetMethodID (class_ref, "renderActions", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElementVector;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderActions_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElementVector_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderActions", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElementVector;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)V"), __args);
			} finally {
			}
		}

	}
}
