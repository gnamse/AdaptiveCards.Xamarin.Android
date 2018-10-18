using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Actionhandler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.adaptivecards.renderer.actionhandler']/interface[@name='ICardActionHandler']"
	[Register ("io/adaptivecards/renderer/actionhandler/ICardActionHandler", "", "IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandlerInvoker")]
	public partial interface ICardActionHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.actionhandler']/interface[@name='ICardActionHandler']/method[@name='onAction' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement'] and parameter[2][@type='io.adaptivecards.renderer.RenderedAdaptiveCard']]"
		[Register ("onAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)V", "GetOnAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler:IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandlerInvoker, AdaptiveCards.Xamarin.Android")]
		void OnAction (global::IO.Adaptivecards.Objectmodel.BaseActionElement p0, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.actionhandler']/interface[@name='ICardActionHandler']/method[@name='onMediaPlay' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[2][@type='io.adaptivecards.renderer.RenderedAdaptiveCard']]"
		[Register ("onMediaPlay", "(Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)V", "GetOnMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler:IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandlerInvoker, AdaptiveCards.Xamarin.Android")]
		void OnMediaPlay (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.actionhandler']/interface[@name='ICardActionHandler']/method[@name='onMediaStop' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[2][@type='io.adaptivecards.renderer.RenderedAdaptiveCard']]"
		[Register ("onMediaStop", "(Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)V", "GetOnMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler:IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandlerInvoker, AdaptiveCards.Xamarin.Android")]
		void OnMediaStop (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1);

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/actionhandler/ICardActionHandler", DoNotGenerateAcw=true)]
	internal class ICardActionHandlerInvoker : global::Java.Lang.Object, ICardActionHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/adaptivecards/renderer/actionhandler/ICardActionHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICardActionHandlerInvoker); }
		}

		IntPtr class_ref;

		public static ICardActionHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICardActionHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.adaptivecards.renderer.actionhandler.ICardActionHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICardActionHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
#pragma warning disable 0169
		static Delegate GetOnAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler ()
		{
			if (cb_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == null)
				cb_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_);
			return cb_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		}

		static void n_OnAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAction (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		public unsafe void OnAction (global::IO.Adaptivecards.Objectmodel.BaseActionElement p0, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1)
		{
			if (id_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == IntPtr.Zero)
				id_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNIEnv.GetMethodID (class_ref, "onAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAction_Lio_adaptivecards_objectmodel_BaseActionElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_, __args);
		}

		static Delegate cb_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
#pragma warning disable 0169
		static Delegate GetOnMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler ()
		{
			if (cb_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == null)
				cb_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_);
			return cb_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		}

		static void n_OnMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseCardElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaPlay (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		public unsafe void OnMediaPlay (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1)
		{
			if (id_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == IntPtr.Zero)
				id_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNIEnv.GetMethodID (class_ref, "onMediaPlay", "(Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMediaPlay_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_, __args);
		}

		static Delegate cb_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
#pragma warning disable 0169
		static Delegate GetOnMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Handler ()
		{
			if (cb_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == null)
				cb_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_);
			return cb_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		}

		static void n_OnMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseCardElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaStop (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_;
		public unsafe void OnMediaStop (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0, global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard p1)
		{
			if (id_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ == IntPtr.Zero)
				id_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_ = JNIEnv.GetMethodID (class_ref, "onMediaStop", "(Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/RenderedAdaptiveCard;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMediaStop_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_RenderedAdaptiveCard_, __args);
		}

	}

}
