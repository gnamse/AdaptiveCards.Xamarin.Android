using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/Image", DoNotGenerateAcw=true)]
	public partial class Image : global::IO.Adaptivecards.Objectmodel.BaseCardElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/Image", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Image); }
		}

		protected Image (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/constructor[@name='Image' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Image ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Image)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/constructor[@name='Image' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Image (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Image)) {
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

		static Delegate cb_GetAltText;
#pragma warning disable 0169
		static Delegate GetGetAltTextHandler ()
		{
			if (cb_GetAltText == null)
				cb_GetAltText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAltText);
			return cb_GetAltText;
		}

		static IntPtr n_GetAltText (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AltText);
		}
#pragma warning restore 0169

		static Delegate cb_SetAltText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAltText_Ljava_lang_String_Handler ()
		{
			if (cb_SetAltText_Ljava_lang_String_ == null)
				cb_SetAltText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAltText_Ljava_lang_String_);
			return cb_SetAltText_Ljava_lang_String_;
		}

		static void n_SetAltText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AltText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetAltText;
		static IntPtr id_SetAltText_Ljava_lang_String_;
		public virtual unsafe string AltText {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetAltText' and count(parameter)=0]"
			[Register ("GetAltText", "()Ljava/lang/String;", "GetGetAltTextHandler")]
			get {
				if (id_GetAltText == IntPtr.Zero)
					id_GetAltText = JNIEnv.GetMethodID (class_ref, "GetAltText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetAltText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAltText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetAltText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetAltText", "(Ljava/lang/String;)V", "GetSetAltText_Ljava_lang_String_Handler")]
			set {
				if (id_SetAltText_Ljava_lang_String_ == IntPtr.Zero)
					id_SetAltText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetAltText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetAltText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetAltText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_GetBackgroundColor == null)
				cb_GetBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackgroundColor);
			return cb_GetBackgroundColor;
		}

		static IntPtr n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackgroundColor);
		}
#pragma warning restore 0169

		static Delegate cb_SetBackgroundColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_Ljava_lang_String_Handler ()
		{
			if (cb_SetBackgroundColor_Ljava_lang_String_ == null)
				cb_SetBackgroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundColor_Ljava_lang_String_);
			return cb_SetBackgroundColor_Ljava_lang_String_;
		}

		static void n_SetBackgroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetBackgroundColor;
		static IntPtr id_SetBackgroundColor_Ljava_lang_String_;
		public virtual unsafe string BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetBackgroundColor' and count(parameter)=0]"
			[Register ("GetBackgroundColor", "()Ljava/lang/String;", "GetGetBackgroundColorHandler")]
			get {
				if (id_GetBackgroundColor == IntPtr.Zero)
					id_GetBackgroundColor = JNIEnv.GetMethodID (class_ref, "GetBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetBackgroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetBackgroundColor", "(Ljava/lang/String;)V", "GetSetBackgroundColor_Ljava_lang_String_Handler")]
			set {
				if (id_SetBackgroundColor_Ljava_lang_String_ == IntPtr.Zero)
					id_SetBackgroundColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetBackgroundColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetBackgroundColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetBackgroundColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetHorizontalAlignment;
#pragma warning disable 0169
		static Delegate GetGetHorizontalAlignmentHandler ()
		{
			if (cb_GetHorizontalAlignment == null)
				cb_GetHorizontalAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHorizontalAlignment);
			return cb_GetHorizontalAlignment;
		}

		static IntPtr n_GetHorizontalAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HorizontalAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
#pragma warning disable 0169
		static Delegate GetSetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_Handler ()
		{
			if (cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ == null)
				cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_);
			return cb_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
		}

		static void n_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HorizontalAlignment p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HorizontalAlignment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetHorizontalAlignment;
		static IntPtr id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.HorizontalAlignment HorizontalAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetHorizontalAlignment' and count(parameter)=0]"
			[Register ("GetHorizontalAlignment", "()Lio/adaptivecards/objectmodel/HorizontalAlignment;", "GetGetHorizontalAlignmentHandler")]
			get {
				if (id_GetHorizontalAlignment == IntPtr.Zero)
					id_GetHorizontalAlignment = JNIEnv.GetMethodID (class_ref, "GetHorizontalAlignment", "()Lio/adaptivecards/objectmodel/HorizontalAlignment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetHorizontalAlignment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHorizontalAlignment", "()Lio/adaptivecards/objectmodel/HorizontalAlignment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetHorizontalAlignment' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HorizontalAlignment']]"
			[Register ("SetHorizontalAlignment", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)V", "GetSetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_Handler")]
			set {
				if (id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ == IntPtr.Zero)
					id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_ = JNIEnv.GetMethodID (class_ref, "SetHorizontalAlignment", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetHorizontalAlignment_Lio_adaptivecards_objectmodel_HorizontalAlignment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetHorizontalAlignment", "(Lio/adaptivecards/objectmodel/HorizontalAlignment;)V"), __args);
				} finally {
				}
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
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageSize p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetImageSize;
		static IntPtr id_SetImageSize_Lio_adaptivecards_objectmodel_ImageSize_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageSize ImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetImageSize' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetImageSize' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageSize']]"
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

		static Delegate cb_GetImageStyle;
#pragma warning disable 0169
		static Delegate GetGetImageStyleHandler ()
		{
			if (cb_GetImageStyle == null)
				cb_GetImageStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageStyle);
			return cb_GetImageStyle;
		}

		static IntPtr n_GetImageStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageStyle);
		}
#pragma warning restore 0169

		static Delegate cb_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_;
#pragma warning disable 0169
		static Delegate GetSetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_Handler ()
		{
			if (cb_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_ == null)
				cb_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_);
			return cb_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_;
		}

		static void n_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ImageStyle p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetImageStyle;
		static IntPtr id_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ImageStyle ImageStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetImageStyle' and count(parameter)=0]"
			[Register ("GetImageStyle", "()Lio/adaptivecards/objectmodel/ImageStyle;", "GetGetImageStyleHandler")]
			get {
				if (id_GetImageStyle == IntPtr.Zero)
					id_GetImageStyle = JNIEnv.GetMethodID (class_ref, "GetImageStyle", "()Lio/adaptivecards/objectmodel/ImageStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetImageStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetImageStyle", "()Lio/adaptivecards/objectmodel/ImageStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetImageStyle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ImageStyle']]"
			[Register ("SetImageStyle", "(Lio/adaptivecards/objectmodel/ImageStyle;)V", "GetSetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_Handler")]
			set {
				if (id_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_ == IntPtr.Zero)
					id_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_ = JNIEnv.GetMethodID (class_ref, "SetImageStyle", "(Lio/adaptivecards/objectmodel/ImageStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetImageStyle_Lio_adaptivecards_objectmodel_ImageStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetImageStyle", "(Lio/adaptivecards/objectmodel/ImageStyle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetPixelHeight;
#pragma warning disable 0169
		static Delegate GetGetPixelHeightHandler ()
		{
			if (cb_GetPixelHeight == null)
				cb_GetPixelHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPixelHeight);
			return cb_GetPixelHeight;
		}

		static long n_GetPixelHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelHeight;
		}
#pragma warning restore 0169

		static Delegate cb_SetPixelHeight_J;
#pragma warning disable 0169
		static Delegate GetSetPixelHeight_JHandler ()
		{
			if (cb_SetPixelHeight_J == null)
				cb_SetPixelHeight_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetPixelHeight_J);
			return cb_SetPixelHeight_J;
		}

		static void n_SetPixelHeight_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PixelHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetPixelHeight;
		static IntPtr id_SetPixelHeight_J;
		public virtual unsafe long PixelHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetPixelHeight' and count(parameter)=0]"
			[Register ("GetPixelHeight", "()J", "GetGetPixelHeightHandler")]
			get {
				if (id_GetPixelHeight == IntPtr.Zero)
					id_GetPixelHeight = JNIEnv.GetMethodID (class_ref, "GetPixelHeight", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetPixelHeight);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPixelHeight", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetPixelHeight' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("SetPixelHeight", "(J)V", "GetSetPixelHeight_JHandler")]
			set {
				if (id_SetPixelHeight_J == IntPtr.Zero)
					id_SetPixelHeight_J = JNIEnv.GetMethodID (class_ref, "SetPixelHeight", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetPixelHeight_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPixelHeight", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetPixelWidth;
#pragma warning disable 0169
		static Delegate GetGetPixelWidthHandler ()
		{
			if (cb_GetPixelWidth == null)
				cb_GetPixelWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPixelWidth);
			return cb_GetPixelWidth;
		}

		static long n_GetPixelWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelWidth;
		}
#pragma warning restore 0169

		static Delegate cb_SetPixelWidth_J;
#pragma warning disable 0169
		static Delegate GetSetPixelWidth_JHandler ()
		{
			if (cb_SetPixelWidth_J == null)
				cb_SetPixelWidth_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetPixelWidth_J);
			return cb_SetPixelWidth_J;
		}

		static void n_SetPixelWidth_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PixelWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetPixelWidth;
		static IntPtr id_SetPixelWidth_J;
		public virtual unsafe long PixelWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetPixelWidth' and count(parameter)=0]"
			[Register ("GetPixelWidth", "()J", "GetGetPixelWidthHandler")]
			get {
				if (id_GetPixelWidth == IntPtr.Zero)
					id_GetPixelWidth = JNIEnv.GetMethodID (class_ref, "GetPixelWidth", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_GetPixelWidth);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPixelWidth", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetPixelWidth' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("SetPixelWidth", "(J)V", "GetSetPixelWidth_JHandler")]
			set {
				if (id_SetPixelWidth_J == IntPtr.Zero)
					id_SetPixelWidth_J = JNIEnv.GetMethodID (class_ref, "SetPixelWidth", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetPixelWidth_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPixelWidth", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetSelectAction;
#pragma warning disable 0169
		static Delegate GetGetSelectActionHandler ()
		{
			if (cb_GetSelectAction == null)
				cb_GetSelectAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectAction);
			return cb_GetSelectAction;
		}

		static IntPtr n_GetSelectAction (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectAction);
		}
#pragma warning restore 0169

		static Delegate cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
#pragma warning disable 0169
		static Delegate GetSetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_Handler ()
		{
			if (cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ == null)
				cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_);
			return cb_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		}

		static void n_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectAction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectAction;
		static IntPtr id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElement SelectAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetSelectAction' and count(parameter)=0]"
			[Register ("GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;", "GetGetSelectActionHandler")]
			get {
				if (id_GetSelectAction == IntPtr.Zero)
					id_GetSelectAction = JNIEnv.GetMethodID (class_ref, "GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSelectAction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelectAction", "()Lio/adaptivecards/objectmodel/BaseActionElement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetSelectAction' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement']]"
			[Register ("SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V", "GetSetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_Handler")]
			set {
				if (id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ == IntPtr.Zero)
					id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNIEnv.GetMethodID (class_ref, "SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSelectAction", "(Lio/adaptivecards/objectmodel/BaseActionElement;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_GetUrl == null)
				cb_GetUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_GetUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_SetUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_SetUrl_Ljava_lang_String_ == null)
				cb_SetUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_SetUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.Image __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetUrl;
		static IntPtr id_SetUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='GetUrl' and count(parameter)=0]"
			[Register ("GetUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_GetUrl == IntPtr.Zero)
					id_GetUrl = JNIEnv.GetMethodID (class_ref, "GetUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='SetUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_SetUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_SetUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseCardElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/Image;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Image Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseCardElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseCardElement;)Lio/adaptivecards/objectmodel/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.Image __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseCardElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Image']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.Image']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/Image;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.Image p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_Image_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_Image_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/Image;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_Image_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
