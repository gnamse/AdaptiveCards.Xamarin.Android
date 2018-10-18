using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/BaseInputElement", DoNotGenerateAcw=true)]
	public partial class BaseInputElement : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/BaseInputElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInputElement); }
		}

		protected BaseInputElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']/constructor[@name='BaseInputElement' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.CardElementType'] and parameter[2][@type='io.adaptivecards.objectmodel.Spacing'] and parameter[3][@type='boolean'] and parameter[4][@type='io.adaptivecards.objectmodel.HeightType']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V", "")]
		public unsafe BaseInputElement (global::IO.Adaptivecards.Objectmodel.CardElementType p0, global::IO.Adaptivecards.Objectmodel.Spacing p1, bool p2, global::IO.Adaptivecards.Objectmodel.HeightType p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (BaseInputElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/CardElementType;Lio/adaptivecards/objectmodel/Spacing;ZLio/adaptivecards/objectmodel/HeightType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_Lio_adaptivecards_objectmodel_Spacing_ZLio_adaptivecards_objectmodel_HeightType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_CardElementType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']/constructor[@name='BaseInputElement' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.CardElementType']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/CardElementType;)V", "")]
		public unsafe BaseInputElement (global::IO.Adaptivecards.Objectmodel.CardElementType p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseInputElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/CardElementType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/CardElementType;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_CardElementType_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_CardElementType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/CardElementType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_CardElementType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']/constructor[@name='BaseInputElement' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe BaseInputElement (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseInputElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static Delegate cb_GetIsRequired;
#pragma warning disable 0169
		static Delegate GetGetIsRequiredHandler ()
		{
			if (cb_GetIsRequired == null)
				cb_GetIsRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsRequired);
			return cb_GetIsRequired;
		}

		static bool n_GetIsRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.BaseInputElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseInputElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRequired;
		}
#pragma warning restore 0169

		static Delegate cb_SetIsRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetIsRequired_ZHandler ()
		{
			if (cb_SetIsRequired_Z == null)
				cb_SetIsRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsRequired_Z);
			return cb_SetIsRequired_Z;
		}

		static void n_SetIsRequired_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Objectmodel.BaseInputElement __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseInputElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsRequired = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetIsRequired;
		static IntPtr id_SetIsRequired_Z;
		public virtual unsafe bool IsRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']/method[@name='GetIsRequired' and count(parameter)=0]"
			[Register ("GetIsRequired", "()Z", "GetGetIsRequiredHandler")]
			get {
				if (id_GetIsRequired == IntPtr.Zero)
					id_GetIsRequired = JNIEnv.GetMethodID (class_ref, "GetIsRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_GetIsRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetIsRequired", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']/method[@name='SetIsRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetIsRequired", "(Z)V", "GetSetIsRequired_ZHandler")]
			set {
				if (id_SetIsRequired_Z == IntPtr.Zero)
					id_SetIsRequired_Z = JNIEnv.GetMethodID (class_ref, "SetIsRequired", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetIsRequired_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetIsRequired", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_BaseInputElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseInputElement']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseInputElement']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/BaseInputElement;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.BaseInputElement p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_BaseInputElement_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_BaseInputElement_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/BaseInputElement;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_BaseInputElement_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
