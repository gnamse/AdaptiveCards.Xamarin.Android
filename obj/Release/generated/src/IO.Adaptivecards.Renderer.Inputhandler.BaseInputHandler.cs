using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Inputhandler {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/inputhandler/BaseInputHandler", DoNotGenerateAcw=true)]
	public abstract partial class BaseInputHandler : global::Java.Lang.Object, global::IO.Adaptivecards.Renderer.Inputhandler.IInputHandler {


		static IntPtr m_baseInputElement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/field[@name='m_baseInputElement']"
		[Register ("m_baseInputElement")]
		protected global::IO.Adaptivecards.Objectmodel.BaseInputElement MBaseInputElement {
			get {
				if (m_baseInputElement_jfieldId == IntPtr.Zero)
					m_baseInputElement_jfieldId = JNIEnv.GetFieldID (class_ref, "m_baseInputElement", "Lio/adaptivecards/objectmodel/BaseInputElement;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_baseInputElement_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseInputElement> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_baseInputElement_jfieldId == IntPtr.Zero)
					m_baseInputElement_jfieldId = JNIEnv.GetFieldID (class_ref, "m_baseInputElement", "Lio/adaptivecards/objectmodel/BaseInputElement;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_baseInputElement_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_view_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/field[@name='m_view']"
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
				return JNIEnv.FindClass ("io/adaptivecards/renderer/inputhandler/BaseInputHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInputHandler); }
		}

		protected BaseInputHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/constructor[@name='BaseInputHandler' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseInputElement']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/BaseInputElement;)V", "")]
		public unsafe BaseInputHandler (global::IO.Adaptivecards.Objectmodel.BaseInputElement p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseInputHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/BaseInputElement;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/BaseInputElement;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/BaseInputElement;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_, __args);
			} finally {
			}
		}

		static Delegate cb_getBaseInputElement;
#pragma warning disable 0169
		static Delegate GetGetBaseInputElementHandler ()
		{
			if (cb_getBaseInputElement == null)
				cb_getBaseInputElement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseInputElement);
			return cb_getBaseInputElement;
		}

		static IntPtr n_GetBaseInputElement (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseInputElement);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseInputElement;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseInputElement BaseInputElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='getBaseInputElement' and count(parameter)=0]"
			[Register ("getBaseInputElement", "()Lio/adaptivecards/objectmodel/BaseInputElement;", "GetGetBaseInputElementHandler")]
			get {
				if (id_getBaseInputElement == IntPtr.Zero)
					id_getBaseInputElement = JNIEnv.GetMethodID (class_ref, "getBaseInputElement", "()Lio/adaptivecards/objectmodel/BaseInputElement;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseInputElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseInputElement), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseInputElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseInputElement", "()Lio/adaptivecards/objectmodel/BaseInputElement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setInput_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInput_Ljava_lang_String_Handler ()
		{
			if (cb_setInput_Ljava_lang_String_ == null)
				cb_setInput_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInput_Ljava_lang_String_);
			return cb_setInput_Ljava_lang_String_;
		}

		static void n_SetInput_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInput (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInput", "(Ljava/lang/String;)V", "GetSetInput_Ljava_lang_String_Handler")]
		public abstract void SetInput (string p0);

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
			global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
		public virtual unsafe void SetView (global::Android.Views.View p0)
		{
			if (id_setView_Landroid_view_View_ == IntPtr.Zero)
				id_setView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getInput;
#pragma warning disable 0169
		static Delegate GetGetInputHandler ()
		{
			if (cb_getInput == null)
				cb_getInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInput);
			return cb_getInput;
		}

		static IntPtr n_GetInput (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Input);
		}
#pragma warning restore 0169

		public abstract string Input {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='getInput' and count(parameter)=0]"
			[Register ("getInput", "()Ljava/lang/String;", "GetGetInputHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/inputhandler/BaseInputHandler", DoNotGenerateAcw=true)]
	internal partial class BaseInputHandlerInvoker : BaseInputHandler {

		public BaseInputHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInputHandlerInvoker); }
		}

		static IntPtr id_setInput_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInput", "(Ljava/lang/String;)V", "GetSetInput_Ljava_lang_String_Handler")]
		public override unsafe void SetInput (string p0)
		{
			if (id_setInput_Ljava_lang_String_ == IntPtr.Zero)
				id_setInput_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInput", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInput_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInput;
		public override unsafe string Input {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='BaseInputHandler']/method[@name='getInput' and count(parameter)=0]"
			[Register ("getInput", "()Ljava/lang/String;", "GetGetInputHandler")]
			get {
				if (id_getInput == IntPtr.Zero)
					id_getInput = JNIEnv.GetMethodID (class_ref, "getInput", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInput), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
