using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/RenderedAdaptiveCard", DoNotGenerateAcw=true)]
	public partial class RenderedAdaptiveCard : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/RenderedAdaptiveCard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RenderedAdaptiveCard); }
		}

		protected RenderedAdaptiveCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/constructor[@name='RenderedAdaptiveCard' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCard']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V", "")]
		protected unsafe RenderedAdaptiveCard (global::IO.Adaptivecards.Objectmodel.AdaptiveCard p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RenderedAdaptiveCard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdaptiveCard;
#pragma warning disable 0169
		static Delegate GetGetAdaptiveCardHandler ()
		{
			if (cb_getAdaptiveCard == null)
				cb_getAdaptiveCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdaptiveCard);
			return cb_getAdaptiveCard;
		}

		static IntPtr n_GetAdaptiveCard (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdaptiveCard);
		}
#pragma warning restore 0169

		static IntPtr id_getAdaptiveCard;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCard AdaptiveCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='getAdaptiveCard' and count(parameter)=0]"
			[Register ("getAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;", "GetGetAdaptiveCardHandler")]
			get {
				if (id_getAdaptiveCard == IntPtr.Zero)
					id_getAdaptiveCard = JNIEnv.GetMethodID (class_ref, "getAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdaptiveCard), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInputs;
#pragma warning disable 0169
		static Delegate GetGetInputsHandler ()
		{
			if (cb_getInputs == null)
				cb_getInputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputs);
			return cb_getInputs;
		}

		static IntPtr n_GetInputs (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Inputs);
		}
#pragma warning restore 0169

		static Delegate cb_setInputs_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetInputs_Ljava_util_Map_Handler ()
		{
			if (cb_setInputs_Ljava_util_Map_ == null)
				cb_setInputs_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputs_Ljava_util_Map_);
			return cb_setInputs_Ljava_util_Map_;
		}

		static void n_SetInputs_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Inputs = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputs;
		static IntPtr id_setInputs_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Inputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='getInputs' and count(parameter)=0]"
			[Register ("getInputs", "()Ljava/util/Map;", "GetGetInputsHandler")]
			get {
				if (id_getInputs == IntPtr.Zero)
					id_getInputs = JNIEnv.GetMethodID (class_ref, "getInputs", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputs", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='setInputs' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setInputs", "(Ljava/util/Map;)V", "GetSetInputs_Ljava_util_Map_Handler")]
			set {
				if (id_setInputs_Ljava_util_Map_ == IntPtr.Zero)
					id_setInputs_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setInputs", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInputs_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputs", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_Handler ()
		{
			if (cb_setView_Landroid_view_View_ == null)
				cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
			return cb_setView_Landroid_view_View_;
		}

		static void n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.View = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		static IntPtr id_setView_Landroid_view_View_;
		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
			set {
				if (id_setView_Landroid_view_View_ == IntPtr.Zero)
					id_setView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setView_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWarnings;
#pragma warning disable 0169
		static Delegate GetGetWarningsHandler ()
		{
			if (cb_getWarnings == null)
				cb_getWarnings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWarnings);
			return cb_getWarnings;
		}

		static IntPtr n_GetWarnings (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Warnings);
		}
#pragma warning restore 0169

		static IntPtr id_getWarnings;
		public virtual unsafe global::Java.Util.Vector Warnings {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='getWarnings' and count(parameter)=0]"
			[Register ("getWarnings", "()Ljava/util/Vector;", "GetGetWarningsHandler")]
			get {
				if (id_getWarnings == IntPtr.Zero)
					id_getWarnings = JNIEnv.GetMethodID (class_ref, "getWarnings", "()Ljava/util/Vector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWarnings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWarnings", "()Ljava/util/Vector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_;
#pragma warning disable 0169
		static Delegate GetAddWarning_Lio_adaptivecards_renderer_AdaptiveWarning_Handler ()
		{
			if (cb_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_ == null)
				cb_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddWarning_Lio_adaptivecards_renderer_AdaptiveWarning_);
			return cb_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_;
		}

		static void n_AddWarning_Lio_adaptivecards_renderer_AdaptiveWarning_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.AdaptiveWarning p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.AdaptiveWarning> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddWarning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='addWarning' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.AdaptiveWarning']]"
		[Register ("addWarning", "(Lio/adaptivecards/renderer/AdaptiveWarning;)V", "GetAddWarning_Lio_adaptivecards_renderer_AdaptiveWarning_Handler")]
		public virtual unsafe void AddWarning (global::IO.Adaptivecards.Renderer.AdaptiveWarning p0)
		{
			if (id_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_ == IntPtr.Zero)
				id_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_ = JNIEnv.GetMethodID (class_ref, "addWarning", "(Lio/adaptivecards/renderer/AdaptiveWarning;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addWarning_Lio_adaptivecards_renderer_AdaptiveWarning_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addWarning", "(Lio/adaptivecards/renderer/AdaptiveWarning;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_Handler ()
		{
			if (cb_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_ == null)
				cb_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_);
			return cb_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_;
		}

		static void n_RegisterInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Renderer.Inputhandler.IInputHandler p0 = (global::IO.Adaptivecards.Renderer.Inputhandler.IInputHandler)global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.IInputHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterInputHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/class[@name='RenderedAdaptiveCard']/method[@name='registerInputHandler' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.renderer.inputhandler.IInputHandler']]"
		[Register ("registerInputHandler", "(Lio/adaptivecards/renderer/inputhandler/IInputHandler;)V", "GetRegisterInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_Handler")]
		public virtual unsafe void RegisterInputHandler (global::IO.Adaptivecards.Renderer.Inputhandler.IInputHandler p0)
		{
			if (id_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_ == IntPtr.Zero)
				id_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_ = JNIEnv.GetMethodID (class_ref, "registerInputHandler", "(Lio/adaptivecards/renderer/inputhandler/IInputHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerInputHandler_Lio_adaptivecards_renderer_inputhandler_IInputHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerInputHandler", "(Lio/adaptivecards/renderer/inputhandler/IInputHandler;)V"), __args);
			} finally {
			}
		}

	}
}
