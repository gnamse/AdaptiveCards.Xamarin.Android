using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DatePickerFragment']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/input/DatePickerFragment", DoNotGenerateAcw=true)]
	public partial class DatePickerFragment : global::Android.Support.V4.App.DialogFragment, global::Android.App.DatePickerDialog.IOnDateSetListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/input/DatePickerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatePickerFragment); }
		}

		protected DatePickerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DatePickerFragment']/constructor[@name='DatePickerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatePickerFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DatePickerFragment)) {
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

		static Delegate cb_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_Handler ()
		{
			if (cb_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_ == null)
				cb_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_);
			return cb_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_;
		}

		static void n_Initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Input.DatePickerFragment __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.DatePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.DateInput p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.EditText p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DatePickerFragment']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.DateInput'] and parameter[2][@type='android.widget.EditText']]"
		[Register ("initialize", "(Lio/adaptivecards/objectmodel/DateInput;Landroid/widget/EditText;)V", "GetInitialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_Handler")]
		public virtual unsafe void Initialize (global::IO.Adaptivecards.Objectmodel.DateInput p0, global::Android.Widget.EditText p1)
		{
			if (id_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_ == IntPtr.Zero)
				id_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lio/adaptivecards/objectmodel/DateInput;Landroid/widget/EditText;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lio_adaptivecards_objectmodel_DateInput_Landroid_widget_EditText_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Lio/adaptivecards/objectmodel/DateInput;Landroid/widget/EditText;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDateSet_Landroid_widget_DatePicker_III;
#pragma warning disable 0169
		static Delegate GetOnDateSet_Landroid_widget_DatePicker_IIIHandler ()
		{
			if (cb_onDateSet_Landroid_widget_DatePicker_III == null)
				cb_onDateSet_Landroid_widget_DatePicker_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnDateSet_Landroid_widget_DatePicker_III);
			return cb_onDateSet_Landroid_widget_DatePicker_III;
		}

		static void n_OnDateSet_Landroid_widget_DatePicker_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::IO.Adaptivecards.Renderer.Input.DatePickerFragment __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Input.DatePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.DatePicker p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.DatePicker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDateSet (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onDateSet_Landroid_widget_DatePicker_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.input']/class[@name='DatePickerFragment']/method[@name='onDateSet' and count(parameter)=4 and parameter[1][@type='android.widget.DatePicker'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onDateSet", "(Landroid/widget/DatePicker;III)V", "GetOnDateSet_Landroid_widget_DatePicker_IIIHandler")]
		public virtual unsafe void OnDateSet (global::Android.Widget.DatePicker p0, int p1, int p2, int p3)
		{
			if (id_onDateSet_Landroid_widget_DatePicker_III == IntPtr.Zero)
				id_onDateSet_Landroid_widget_DatePicker_III = JNIEnv.GetMethodID (class_ref, "onDateSet", "(Landroid/widget/DatePicker;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDateSet_Landroid_widget_DatePicker_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDateSet", "(Landroid/widget/DatePicker;III)V"), __args);
			} finally {
			}
		}

	}
}
