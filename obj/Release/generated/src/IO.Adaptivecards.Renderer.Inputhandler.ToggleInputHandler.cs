using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Inputhandler {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='ToggleInputHandler']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/inputhandler/ToggleInputHandler", DoNotGenerateAcw=true)]
	public partial class ToggleInputHandler : global::IO.Adaptivecards.Renderer.Inputhandler.BaseInputHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/inputhandler/ToggleInputHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToggleInputHandler); }
		}

		protected ToggleInputHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='ToggleInputHandler']/constructor[@name='ToggleInputHandler' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseInputElement']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/BaseInputElement;)V", "")]
		public unsafe ToggleInputHandler (global::IO.Adaptivecards.Objectmodel.BaseInputElement p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ToggleInputHandler)) {
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

		static Delegate cb_getCheckBox;
#pragma warning disable 0169
		static Delegate GetGetCheckBoxHandler ()
		{
			if (cb_getCheckBox == null)
				cb_getCheckBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckBox);
			return cb_getCheckBox;
		}

		static IntPtr n_GetCheckBox (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.ToggleInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.ToggleInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckBox);
		}
#pragma warning restore 0169

		static IntPtr id_getCheckBox;
		protected virtual unsafe global::Android.Widget.CheckBox CheckBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='ToggleInputHandler']/method[@name='getCheckBox' and count(parameter)=0]"
			[Register ("getCheckBox", "()Landroid/widget/CheckBox;", "GetGetCheckBoxHandler")]
			get {
				if (id_getCheckBox == IntPtr.Zero)
					id_getCheckBox = JNIEnv.GetMethodID (class_ref, "getCheckBox", "()Landroid/widget/CheckBox;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.CheckBox> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCheckBox), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.CheckBox> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckBox", "()Landroid/widget/CheckBox;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::IO.Adaptivecards.Renderer.Inputhandler.ToggleInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.ToggleInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Input);
		}
#pragma warning restore 0169

		static IntPtr id_getInput;
		public override unsafe string Input {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='ToggleInputHandler']/method[@name='getInput' and count(parameter)=0]"
			[Register ("getInput", "()Ljava/lang/String;", "GetGetInputHandler")]
			get {
				if (id_getInput == IntPtr.Zero)
					id_getInput = JNIEnv.GetMethodID (class_ref, "getInput", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInput), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInput", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Renderer.Inputhandler.ToggleInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.ToggleInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInput_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='ToggleInputHandler']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInput", "(Ljava/lang/String;)V", "GetSetInput_Ljava_lang_String_Handler")]
		public override unsafe void SetInput (string p0)
		{
			if (id_setInput_Ljava_lang_String_ == IntPtr.Zero)
				id_setInput_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInput", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInput_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
