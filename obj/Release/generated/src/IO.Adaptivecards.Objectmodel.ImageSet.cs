using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ImageSet", DoNotGenerateAcw=true)]
	public partial class ImageSet : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ImageSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSet); }
		}

		protected ImageSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/constructor[@name='ImageSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ImageSet)) {
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

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/constructor[@name='ImageSet' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ImageSet (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ImageSet)) {
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

		static Delegate cb_GetImageSize;
#pragma warning disable 0169
		static Delegate GetGetImageSizeHandler ()
		{
			if (cb_GetImageSize == null)
				cb_GetImageSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageSize);
			return cb_GetImageSize;
		}

		static IntPtr n_GetImageSize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageSize);
		}
#pragma warning restore 0169

		static Delegate cb_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
#pragma warning disable 0169
		static Delegate GetSetImageSize_Lio_adaptivecards_objectmodel_ImageSize_Handler ()
		{
			if (cb_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_ == null)
				cb_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_);
			return cb_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
		}

		static void n_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageSize p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetImageSize;
		static IntPtr id_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageSize ImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/method[@name='GetImageSize' and count(parameter)=0]"
			[Register ("GetImageSize", "()Lio/adaptivecards/objectmodel/ImageSize;", "GetGetImageSizeHandler")]
			get {
				if (id_GetImageSize == IntPtr.Zero)
					id_GetImageSize = JNIEnv.GetMethodID (class_ref, "GetImageSize", "()Lio/adaptivecards/objectmodel/ImageSize;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetImageSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetImageSize", "()Lio/adaptivecards/objectmodel/ImageSize;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/method[@name='SetImageSize' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSize']]"
			[Register ("SetImageSize", "(Lio/adaptivecards/objectmodel/ImageSize;)V", "GetSetImageSize_Lio_adaptivecards_objectmodel_ImageSize_Handler")]
			set {
				if (id_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_ == IntPtr.Zero)
					id_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_ = JNIEnv.GetMethodID (class_ref, "SetImageSize", "(Lio/adaptivecards/objectmodel/ImageSize;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetImageSize", "(Lio/adaptivecards/objectmodel/ImageSize;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetImages;
#pragma warning disable 0169
		static Delegate GetGetImagesHandler ()
		{
			if (cb_GetImages == null)
				cb_GetImages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImages);
			return cb_GetImages;
		}

		static IntPtr n_GetImages (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ImageSet __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Images);
		}
#pragma warning restore 0169

		static IntPtr id_GetImages;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageVector Images {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/method[@name='GetImages' and count(parameter)=0]"
			[Register ("GetImages", "()Lio/adaptivecards/objectmodel/ImageVector;", "GetGetImagesHandler")]
			get {
				if (id_GetImages == IntPtr.Zero)
					id_GetImages = JNIEnv.GetMethodID (class_ref, "GetImages", "()Lio/adaptivecards/objectmodel/ImageVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetImages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetImages", "()Lio/adaptivecards/objectmodel/ImageVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ImageSet;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSet Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/ImageSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.ImageSet __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ImageSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSet']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSet']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ImageSet;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ImageSet p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ImageSet_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ImageSet_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ImageSet;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ImageSet_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
