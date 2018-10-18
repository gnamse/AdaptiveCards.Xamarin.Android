using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TimePickerFragment']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/input/TimePickerFragment", DoNotGenerateAcw=true)]
	public partial class TimePickerFragment : global::Android.Support.V4.App.DialogFragment, global::Android.App.TimePickerDialog.IOnTimeSetListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/input/TimePickerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimePickerFragment); }
		}

		protected TimePickerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TimePickerFragment']/constructor[@name='TimePickerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimePickerFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TimePickerFragment)) {
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

		static Delegate cb_initialize_Landroid_widget_EditText_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_widget_EditText_Handler ()
		{
			if (cb_initialize_Landroid_widget_EditText_ == null)
				cb_initialize_Landroid_widget_EditText_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Initialize_Landroid_widget_EditText_);
			return cb_initialize_Landroid_widget_EditText_;
		}

		static void n_Initialize_Landroid_widget_EditText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Input.TimePickerFragment __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TimePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.EditText p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Landroid_widget_EditText_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TimePickerFragment']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.widget.EditText']]"
		[Register ("initialize", "(Landroid/widget/EditText;)V", "GetInitialize_Landroid_widget_EditText_Handler")]
		public virtual unsafe void Initialize (global::Android.Widget.EditText p0)
		{
			if (id_initialize_Landroid_widget_EditText_ == IntPtr.Zero)
				id_initialize_Landroid_widget_EditText_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Landroid/widget/EditText;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Landroid_widget_EditText_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Landroid/widget/EditText;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTimeSet_Landroid_widget_TimePicker_II;
#pragma warning disable 0169
		static Delegate GetOnTimeSet_Landroid_widget_TimePicker_IIHandler ()
		{
			if (cb_onTimeSet_Landroid_widget_TimePicker_II == null)
				cb_onTimeSet_Landroid_widget_TimePicker_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnTimeSet_Landroid_widget_TimePicker_II);
			return cb_onTimeSet_Landroid_widget_TimePicker_II;
		}

		static void n_OnTimeSet_Landroid_widget_TimePicker_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Adaptivecards.Renderer.Input.TimePickerFragment __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.TimePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TimePicker p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TimePicker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTimeSet (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onTimeSet_Landroid_widget_TimePicker_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='TimePickerFragment']/method[@name='onTimeSet' and count(parameter)=3 and parameter[1][@type='android.widget.TimePicker'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onTimeSet", "(Landroid/widget/TimePicker;II)V", "GetOnTimeSet_Landroid_widget_TimePicker_IIHandler")]
		public virtual unsafe void OnTimeSet (global::Android.Widget.TimePicker p0, int p1, int p2)
		{
			if (id_onTimeSet_Landroid_widget_TimePicker_II == IntPtr.Zero)
				id_onTimeSet_Landroid_widget_TimePicker_II = JNIEnv.GetMethodID (class_ref, "onTimeSet", "(Landroid/widget/TimePicker;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimeSet_Landroid_widget_TimePicker_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTimeSet", "(Landroid/widget/TimePicker;II)V"), __args);
			} finally {
			}
		}

	}
}
