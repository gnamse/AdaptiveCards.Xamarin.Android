using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Action {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/action/ActionElementRenderer", DoNotGenerateAcw=true)]
	public partial class ActionElementRenderer : global::Java.Lang.Object, global::IO.Adaptivecards.Renderer.IBaseActionElementRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ActionElementRendererIconImageLoaderAsync']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/action/ActionElementRenderer$ActionElementRendererIconImageLoaderAsync", DoNotGenerateAcw=true)]
		public partial class ActionElementRendererIconImageLoaderAsync : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/action/ActionElementRenderer$ActionElementRendererIconImageLoaderAsync", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActionElementRendererIconImageLoaderAsync); }
			}

			protected ActionElementRendererIconImageLoaderAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ButtonOnClickListener']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/action/ActionElementRenderer$ButtonOnClickListener", DoNotGenerateAcw=true)]
		public partial class ButtonOnClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/action/ActionElementRenderer$ButtonOnClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ButtonOnClickListener); }
			}

			protected ButtonOnClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ButtonOnClickListener']/constructor[@name='ActionElementRenderer.ButtonOnClickListener' and count(parameter)=3 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='io.adaptivecards.objectmodel.BaseActionElement'] and parameter[3][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler']]"
			[Register (".ctor", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V", "")]
			public unsafe ButtonOnClickListener (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::IO.Adaptivecards.Objectmodel.BaseActionElement p1, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (((object) this).GetType () != typeof (ButtonOnClickListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V", __args);
						return;
					}

					if (id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ == IntPtr.Zero)
						id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_, __args);
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
				global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer.ButtonOnClickListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer.ButtonOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ButtonOnClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ButtonOnLayoutChangedListener']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/action/ActionElementRenderer$ButtonOnLayoutChangedListener", DoNotGenerateAcw=true)]
		public partial class ButtonOnLayoutChangedListener : global::Java.Lang.Object, global::Android.Views.View.IOnLayoutChangeListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/action/ActionElementRenderer$ButtonOnLayoutChangedListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ButtonOnLayoutChangedListener); }
			}

			protected ButtonOnLayoutChangedListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ButtonOnLayoutChangedListener']/constructor[@name='ActionElementRenderer.ButtonOnLayoutChangedListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ButtonOnLayoutChangedListener ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (ButtonOnLayoutChangedListener)) {
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

			static Delegate cb_onLayoutChange_Landroid_view_View_IIIIIIII;
#pragma warning disable 0169
			static Delegate GetOnLayoutChange_Landroid_view_View_IIIIIIIIHandler ()
			{
				if (cb_onLayoutChange_Landroid_view_View_IIIIIIII == null)
					cb_onLayoutChange_Landroid_view_View_IIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, int>) n_OnLayoutChange_Landroid_view_View_IIIIIIII);
				return cb_onLayoutChange_Landroid_view_View_IIIIIIII;
			}

			static void n_OnLayoutChange_Landroid_view_View_IIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
			{
				global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer.ButtonOnLayoutChangedListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer.ButtonOnLayoutChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLayoutChange (p0, p1, p2, p3, p4, p5, p6, p7, p8);
			}
#pragma warning restore 0169

			static IntPtr id_onLayoutChange_Landroid_view_View_IIIIIIII;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ButtonOnLayoutChangedListener']/method[@name='onLayoutChange' and count(parameter)=9 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
			[Register ("onLayoutChange", "(Landroid/view/View;IIIIIIII)V", "GetOnLayoutChange_Landroid_view_View_IIIIIIIIHandler")]
			public virtual unsafe void OnLayoutChange (global::Android.Views.View p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
			{
				if (id_onLayoutChange_Landroid_view_View_IIIIIIII == IntPtr.Zero)
					id_onLayoutChange_Landroid_view_View_IIIIIIII = JNIEnv.GetMethodID (class_ref, "onLayoutChange", "(Landroid/view/View;IIIIIIII)V");
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

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayoutChange_Landroid_view_View_IIIIIIII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayoutChange", "(Landroid/view/View;IIIIIIII)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ShowCardInlineClickListener']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/action/ActionElementRenderer$ShowCardInlineClickListener", DoNotGenerateAcw=true)]
		protected internal partial class ShowCardInlineClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/action/ActionElementRenderer$ShowCardInlineClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShowCardInlineClickListener); }
			}

			protected ShowCardInlineClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lio_adaptivecards_renderer_action_ActionElementRenderer_Landroid_view_View_Landroid_view_ViewGroup_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ShowCardInlineClickListener']/constructor[@name='ActionElementRenderer.ShowCardInlineClickListener' and count(parameter)=3 and parameter[1][@type='io.adaptivecards.renderer.action.ActionElementRenderer'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
			[Register (".ctor", "(Lio/adaptivecards/renderer/action/ActionElementRenderer;Landroid/view/View;Landroid/view/ViewGroup;)V", "")]
			public unsafe ShowCardInlineClickListener (global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer __self, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (((object) this).GetType () != typeof (ShowCardInlineClickListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;Landroid/view/ViewGroup;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;Landroid/view/ViewGroup;)V", __args);
						return;
					}

					if (id_ctor_Lio_adaptivecards_renderer_action_ActionElementRenderer_Landroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
						id_ctor_Lio_adaptivecards_renderer_action_ActionElementRenderer_Landroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/renderer/action/ActionElementRenderer;Landroid/view/View;Landroid/view/ViewGroup;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_renderer_action_ActionElementRenderer_Landroid_view_View_Landroid_view_ViewGroup_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_renderer_action_ActionElementRenderer_Landroid_view_View_Landroid_view_ViewGroup_, __args);
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
				global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer.ShowCardInlineClickListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer.ShowCardInlineClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer.ShowCardInlineClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
				return JNIEnv.FindClass ("io/adaptivecards/renderer/action/ActionElementRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionElementRenderer); }
		}

		protected ActionElementRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer']/constructor[@name='ActionElementRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ActionElementRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ActionElementRenderer)) {
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
		public static unsafe global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lio/adaptivecards/renderer/action/ActionElementRenderer;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lio/adaptivecards/renderer/action/ActionElementRenderer;");
				try {
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
#pragma warning disable 0169
		static Delegate GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler ()
		{
			if (cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ == null)
				cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_);
			return cb_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		}

		static IntPtr n_Render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p3 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p4 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5 = (global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p6 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Render (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer']/method[@name='render' and count(parameter)=7 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseActionElement'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig']]"
		[Register ("render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)Landroid/widget/Button;", "GetRender_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Handler")]
		public virtual unsafe global::Android.Widget.Button Render (global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p0, global::Android.Content.Context p1, global::Android.Support.V4.App.FragmentManager p2, global::Android.Views.ViewGroup p3, global::IO.Adaptivecards.Objectmodel.BaseActionElement p4, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler p5, global::IO.Adaptivecards.Objectmodel.HostConfig p6)
		{
			if (id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ == IntPtr.Zero)
				id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_ = JNIEnv.GetMethodID (class_ref, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)Landroid/widget/Button;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				global::Android.Widget.Button __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;)Landroid/widget/Button;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
#pragma warning disable 0169
		static Delegate GetRenderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler ()
		{
			if (cb_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == null)
				cb_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RenderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_);
			return cb_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		}

		static IntPtr n_RenderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Action.ActionElementRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p2 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HostConfig p3 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HostConfig> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p4 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RenderButton (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.action']/class[@name='ActionElementRenderer']/method[@name='renderButton' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='io.adaptivecards.objectmodel.BaseActionElement'] and parameter[4][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[5][@type='io.adaptivecards.renderer.RenderedAdaptiveCard']]"
		[Register ("renderButton", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)Landroid/widget/Button;", "GetRenderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler")]
		public virtual unsafe global::Android.Widget.Button RenderButton (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1, global::IO.Adaptivecards.Objectmodel.BaseActionElement p2, global::IO.Adaptivecards.Objectmodel.HostConfig p3, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p4)
		{
			if (id_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == IntPtr.Zero)
				id_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNIEnv.GetMethodID (class_ref, "renderButton", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)Landroid/widget/Button;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Android.Widget.Button __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_renderButton_Landroid_content_Context_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderedAdaptiveCard_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderButton", "(Landroid/content/Context;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)Landroid/widget/Button;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
