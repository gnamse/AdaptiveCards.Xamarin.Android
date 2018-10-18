using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Inputhandler {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='TimeInputHandler']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/inputhandler/TimeInputHandler", DoNotGenerateAcw=true)]
	public partial class TimeInputHandler : global::IO.Adaptivecards.Renderer.Inputhandler.TextInputHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='TimeInputHandler']/field[@name='TIME_FORMAT_SUBMIT']"
		[Register ("TIME_FORMAT_SUBMIT")]
		public const string TimeFormatSubmit = (string) "kk:mm";

		static IntPtr s_simpleDateFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='TimeInputHandler']/field[@name='s_simpleDateFormat']"
		[Register ("s_simpleDateFormat")]
		public static global::Java.Text.SimpleDateFormat SSimpleDateFormat {
			get {
				if (s_simpleDateFormat_jfieldId == IntPtr.Zero)
					s_simpleDateFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s_simpleDateFormat", "Ljava/text/SimpleDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, s_simpleDateFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (s_simpleDateFormat_jfieldId == IntPtr.Zero)
					s_simpleDateFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s_simpleDateFormat", "Ljava/text/SimpleDateFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, s_simpleDateFormat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/inputhandler/TimeInputHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeInputHandler); }
		}

		protected TimeInputHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_Landroid_support_v4_app_FragmentManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='TimeInputHandler']/constructor[@name='TimeInputHandler' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.BaseInputElement'] and parameter[2][@type='android.support.v4.app.FragmentManager']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/BaseInputElement;Landroid/support/v4/app/FragmentManager;)V", "")]
		public unsafe TimeInputHandler (global::IO.Adaptivecards.Objectmodel.BaseInputElement p0, global::Android.Support.V4.App.FragmentManager p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TimeInputHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/BaseInputElement;Landroid/support/v4/app/FragmentManager;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/BaseInputElement;Landroid/support/v4/app/FragmentManager;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_Landroid_support_v4_app_FragmentManager_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_Landroid_support_v4_app_FragmentManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/BaseInputElement;Landroid/support/v4/app/FragmentManager;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_Landroid_support_v4_app_FragmentManager_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_BaseInputElement_Landroid_support_v4_app_FragmentManager_, __args);
			} finally {
			}
		}

		static Delegate cb_getFragmentManager;
#pragma warning disable 0169
		static Delegate GetGetFragmentManagerHandler ()
		{
			if (cb_getFragmentManager == null)
				cb_getFragmentManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFragmentManager);
			return cb_getFragmentManager;
		}

		static IntPtr n_GetFragmentManager (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Inputhandler.TimeInputHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Inputhandler.TimeInputHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FragmentManager);
		}
#pragma warning restore 0169

		static IntPtr id_getFragmentManager;
		public virtual unsafe global::Android.Support.V4.App.FragmentManager FragmentManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.inputhandler']/class[@name='TimeInputHandler']/method[@name='getFragmentManager' and count(parameter)=0]"
			[Register ("getFragmentManager", "()Landroid/support/v4/app/FragmentManager;", "GetGetFragmentManagerHandler")]
			get {
				if (id_getFragmentManager == IntPtr.Zero)
					id_getFragmentManager = JNIEnv.GetMethodID (class_ref, "getFragmentManager", "()Landroid/support/v4/app/FragmentManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFragmentManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFragmentManager", "()Landroid/support/v4/app/FragmentManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
