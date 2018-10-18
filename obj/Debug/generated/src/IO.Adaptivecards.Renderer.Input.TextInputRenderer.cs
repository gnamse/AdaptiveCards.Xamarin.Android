using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/input/TextInputRenderer", DoNotGenerateAcw=true)]
	public partial class TextInputRenderer : global::IO.Adaptivecards.Renderer.BaseCardElementRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer.EditTextTouchListener']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/input/TextInputRenderer$EditTextTouchListener", DoNotGenerateAcw=true)]
		public partial class EditTextTouchListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/input/TextInputRenderer$EditTextTouchListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EditTextTouchListener); }
			}

			protected EditTextTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::IO.Adaptivecards.Renderer.Input.TextInputRenderer.EditTextTouchListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TextInputRenderer.EditTextTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouch (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer.EditTextTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
			{
				if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/input/TextInputRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextInputRenderer); }
		}

		protected TextInputRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer']/constructor[@name='TextInputRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe TextInputRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextInputRenderer)) {
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
		public static unsafe global::IO.Adaptivecards.Renderer.Input.TextInputRenderer Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/input/TextInputRenderer;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/input/TextInputRenderer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TextInputRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Renderer.Input.TextInputRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TextInputRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer']/method[@name='render' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[8][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
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

		static Delegate cb_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_;
#pragma warning disable 0169
		static Delegate GetRenderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler ()
		{
			if (cb_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_ == null)
				cb_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RenderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_);
			return cb_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		}

		static IntPtr n_RenderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::IO.Adaptivecards.Renderer.Input.TextInputRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TextInputRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseInputElement p3 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseInputElement> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Inputhandler.TextInputHandler p6 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.TextInputHandler> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p7 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RenderInternal (p0, p1, p2, p3, p4, p5, p6, p7));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer']/method[@name='renderInternal' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.view.ViewGroup'] and parameter[4][@type='io.adaptivecards.objectmodel.BaseInputElement'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='io.adaptivecards.renderer.inputhandler.TextInputHandler'] and parameter[8][@type='io.adaptivecards.objectmodel.HostConfig']]"
		[Register ("renderInternal", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseInputElement;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/renderer/inputhandler/TextInputHandler;Lio/adaptivecards/objectmodel/HostConfig;)Landroid/widget/EditText;", "GetRenderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler")]
		protected virtual unsafe global::Android.Widget.EditText RenderInternal (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Views.ViewGroup p2, global::IO.Adaptivecards.Objectmodel.BaseInputElement p3, string p4, string p5, global::IO.Adaptivecards.Renderer.Inputhandler.TextInputHandler p6, global::IO.Adaptivecards.Objectmodel.HostConfig p7)
		{
			if (id_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_ == IntPtr.Zero)
				id_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNIEnv.GetMethodID (class_ref, "renderInternal", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseInputElement;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/renderer/inputhandler/TextInputHandler;Lio/adaptivecards/objectmodel/HostConfig;)Landroid/widget/EditText;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				global::Android.Widget.EditText __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_renderInternal_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseInputElement_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_renderer_inputhandler_TextInputHandler_Lio_adaptivecards_objectmodel_HostConfig_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderInternal", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseInputElement;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/renderer/inputhandler/TextInputHandler;Lio/adaptivecards/objectmodel/HostConfig;)Landroid/widget/EditText;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_;
#pragma warning disable 0169
		static Delegate GetSetTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_Handler ()
		{
			if (cb_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_ == null)
				cb_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_);
			return cb_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_;
		}

		static void n_SetTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Input.TextInputRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TextInputRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.EditText p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.TextInputStyle p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTextInputStyle (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TextInputRenderer']/method[@name='setTextInputStyle' and count(parameter)=2 and parameter[1][@type='android.widget.EditText'] and parameter[2][@type='io.adaptivecards.objectmodel.TextInputStyle']]"
		[Register ("setTextInputStyle", "(Landroid/widget/EditText;Lio/adaptivecards/objectmodel/TextInputStyle;)V", "GetSetTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_Handler")]
		protected virtual unsafe void SetTextInputStyle (global::Android.Widget.EditText p0, global::IO.Adaptivecards.Objectmodel.TextInputStyle p1)
		{
			if (id_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_ == IntPtr.Zero)
				id_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_ = JNIEnv.GetMethodID (class_ref, "setTextInputStyle", "(Landroid/widget/EditText;Lio/adaptivecards/objectmodel/TextInputStyle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextInputStyle_Landroid_widget_EditText_Lio_adaptivecards_objectmodel_TextInputStyle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextInputStyle", "(Landroid/widget/EditText;Lio/adaptivecards/objectmodel/TextInputStyle;)V"), __args);
			} finally {
			}
		}

	}
}
