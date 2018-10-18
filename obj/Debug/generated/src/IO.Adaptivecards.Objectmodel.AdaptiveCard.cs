using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/AdaptiveCard", DoNotGenerateAcw=true)]
	public partial class AdaptiveCard : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/AdaptiveCard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdaptiveCard); }
		}

		protected AdaptiveCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/constructor[@name='AdaptiveCard' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='io.adaptivecards.objectmodel.ContainerStyle'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='io.adaptivecards.objectmodel.VerticalContentAlignment'] and parameter[8][@type='io.adaptivecards.objectmodel.HeightType']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;)V", "")]
		public unsafe AdaptiveCard (string p0, string p1, string p2, global::IO.Adaptivecards.Objectmodel.ContainerStyle p3, string p4, string p5, global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment p6, global::IO.Adaptivecards.Objectmodel.HeightType p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (AdaptiveCard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/constructor[@name='AdaptiveCard' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdaptiveCard ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AdaptiveCard)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_objectmodel_BaseActionElementVector_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/constructor[@name='AdaptiveCard' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='io.adaptivecards.objectmodel.ContainerStyle'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='io.adaptivecards.objectmodel.VerticalContentAlignment'] and parameter[8][@type='io.adaptivecards.objectmodel.HeightType'] and parameter[9][@type='io.adaptivecards.objectmodel.BaseCardElementVector'] and parameter[10][@type='io.adaptivecards.objectmodel.BaseActionElementVector']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/objectmodel/BaseActionElementVector;)V", "")]
		public unsafe AdaptiveCard (string p0, string p1, string p2, global::IO.Adaptivecards.Objectmodel.ContainerStyle p3, string p4, string p5, global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment p6, global::IO.Adaptivecards.Objectmodel.HeightType p7, global::IO.Adaptivecards.Objectmodel.BaseCardElementVector p8, global::IO.Adaptivecards.Objectmodel.BaseActionElementVector p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				if (((object) this).GetType () != typeof (AdaptiveCard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/objectmodel/BaseActionElementVector;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/objectmodel/BaseActionElementVector;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_objectmodel_BaseActionElementVector_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_objectmodel_BaseActionElementVector_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ContainerStyle;Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/VerticalContentAlignment;Lio/adaptivecards/objectmodel/HeightType;Lio/adaptivecards/objectmodel/BaseCardElementVector;Lio/adaptivecards/objectmodel/BaseActionElementVector;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_objectmodel_BaseActionElementVector_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ContainerStyle_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Lio_adaptivecards_objectmodel_HeightType_Lio_adaptivecards_objectmodel_BaseCardElementVector_Lio_adaptivecards_objectmodel_BaseActionElementVector_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/constructor[@name='AdaptiveCard' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe AdaptiveCard (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AdaptiveCard)) {
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

		static Delegate cb_GetActions;
#pragma warning disable 0169
		static Delegate GetGetActionsHandler ()
		{
			if (cb_GetActions == null)
				cb_GetActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActions);
			return cb_GetActions;
		}

		static IntPtr n_GetActions (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Actions);
		}
#pragma warning restore 0169

		static IntPtr id_GetActions;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElementVector Actions {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetActions' and count(parameter)=0]"
			[Register ("GetActions", "()Lio/adaptivecards/objectmodel/BaseActionElementVector;", "GetGetActionsHandler")]
			get {
				if (id_GetActions == IntPtr.Zero)
					id_GetActions = JNIEnv.GetMethodID (class_ref, "GetActions", "()Lio/adaptivecards/objectmodel/BaseActionElementVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElementVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetActions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElementVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetActions", "()Lio/adaptivecards/objectmodel/BaseActionElementVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetBackgroundImage;
#pragma warning disable 0169
		static Delegate GetGetBackgroundImageHandler ()
		{
			if (cb_GetBackgroundImage == null)
				cb_GetBackgroundImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackgroundImage);
			return cb_GetBackgroundImage;
		}

		static IntPtr n_GetBackgroundImage (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackgroundImage);
		}
#pragma warning restore 0169

		static Delegate cb_SetBackgroundImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundImage_Ljava_lang_String_Handler ()
		{
			if (cb_SetBackgroundImage_Ljava_lang_String_ == null)
				cb_SetBackgroundImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundImage_Ljava_lang_String_);
			return cb_SetBackgroundImage_Ljava_lang_String_;
		}

		static void n_SetBackgroundImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundImage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetBackgroundImage;
		static IntPtr id_SetBackgroundImage_Ljava_lang_String_;
		public virtual unsafe string BackgroundImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetBackgroundImage' and count(parameter)=0]"
			[Register ("GetBackgroundImage", "()Ljava/lang/String;", "GetGetBackgroundImageHandler")]
			get {
				if (id_GetBackgroundImage == IntPtr.Zero)
					id_GetBackgroundImage = JNIEnv.GetMethodID (class_ref, "GetBackgroundImage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetBackgroundImage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetBackgroundImage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetBackgroundImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetBackgroundImage", "(Ljava/lang/String;)V", "GetSetBackgroundImage_Ljava_lang_String_Handler")]
			set {
				if (id_SetBackgroundImage_Ljava_lang_String_ == IntPtr.Zero)
					id_SetBackgroundImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetBackgroundImage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetBackgroundImage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetBackgroundImage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_GetBody == null)
				cb_GetBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_GetBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_GetBody;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseCardElementVector Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetBody' and count(parameter)=0]"
			[Register ("GetBody", "()Lio/adaptivecards/objectmodel/BaseCardElementVector;", "GetGetBodyHandler")]
			get {
				if (id_GetBody == IntPtr.Zero)
					id_GetBody = JNIEnv.GetMethodID (class_ref, "GetBody", "()Lio/adaptivecards/objectmodel/BaseCardElementVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElementVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElementVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetBody", "()Lio/adaptivecards/objectmodel/BaseCardElementVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetElementType;
#pragma warning disable 0169
		static Delegate GetGetElementTypeHandler ()
		{
			if (cb_GetElementType == null)
				cb_GetElementType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElementType);
			return cb_GetElementType;
		}

		static IntPtr n_GetElementType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ElementType);
		}
#pragma warning restore 0169

		static IntPtr id_GetElementType;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.CardElementType ElementType {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetElementType' and count(parameter)=0]"
			[Register ("GetElementType", "()Lio/adaptivecards/objectmodel/CardElementType;", "GetGetElementTypeHandler")]
			get {
				if (id_GetElementType == IntPtr.Zero)
					id_GetElementType = JNIEnv.GetMethodID (class_ref, "GetElementType", "()Lio/adaptivecards/objectmodel/CardElementType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetElementType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetElementType", "()Lio/adaptivecards/objectmodel/CardElementType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetFallbackText;
#pragma warning disable 0169
		static Delegate GetGetFallbackTextHandler ()
		{
			if (cb_GetFallbackText == null)
				cb_GetFallbackText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFallbackText);
			return cb_GetFallbackText;
		}

		static IntPtr n_GetFallbackText (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FallbackText);
		}
#pragma warning restore 0169

		static Delegate cb_SetFallbackText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFallbackText_Ljava_lang_String_Handler ()
		{
			if (cb_SetFallbackText_Ljava_lang_String_ == null)
				cb_SetFallbackText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFallbackText_Ljava_lang_String_);
			return cb_SetFallbackText_Ljava_lang_String_;
		}

		static void n_SetFallbackText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FallbackText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetFallbackText;
		static IntPtr id_SetFallbackText_Ljava_lang_String_;
		public virtual unsafe string FallbackText {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetFallbackText' and count(parameter)=0]"
			[Register ("GetFallbackText", "()Ljava/lang/String;", "GetGetFallbackTextHandler")]
			get {
				if (id_GetFallbackText == IntPtr.Zero)
					id_GetFallbackText = JNIEnv.GetMethodID (class_ref, "GetFallbackText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetFallbackText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFallbackText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetFallbackText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetFallbackText", "(Ljava/lang/String;)V", "GetSetFallbackText_Ljava_lang_String_Handler")]
			set {
				if (id_SetFallbackText_Ljava_lang_String_ == IntPtr.Zero)
					id_SetFallbackText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetFallbackText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetFallbackText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFallbackText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_GetHeight == null)
				cb_GetHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_GetHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		static Delegate cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_;
#pragma warning disable 0169
		static Delegate GetSetHeight_Lio_adaptivecards_objectmodel_HeightType_Handler ()
		{
			if (cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ == null)
				cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeight_Lio_adaptivecards_objectmodel_HeightType_);
			return cb_SetHeight_Lio_adaptivecards_objectmodel_HeightType_;
		}

		static void n_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.HeightType p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetHeight;
		static IntPtr id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.HeightType Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetHeight' and count(parameter)=0]"
			[Register ("GetHeight", "()Lio/adaptivecards/objectmodel/HeightType;", "GetGetHeightHandler")]
			get {
				if (id_GetHeight == IntPtr.Zero)
					id_GetHeight = JNIEnv.GetMethodID (class_ref, "GetHeight", "()Lio/adaptivecards/objectmodel/HeightType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HeightType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHeight", "()Lio/adaptivecards/objectmodel/HeightType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetHeight' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.HeightType']]"
			[Register ("SetHeight", "(Lio/adaptivecards/objectmodel/HeightType;)V", "GetSetHeight_Lio_adaptivecards_objectmodel_HeightType_Handler")]
			set {
				if (id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ == IntPtr.Zero)
					id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_ = JNIEnv.GetMethodID (class_ref, "SetHeight", "(Lio/adaptivecards/objectmodel/HeightType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetHeight_Lio_adaptivecards_objectmodel_HeightType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetHeight", "(Lio/adaptivecards/objectmodel/HeightType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_GetLanguage == null)
				cb_GetLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_GetLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate cb_SetLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_SetLanguage_Ljava_lang_String_ == null)
				cb_SetLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanguage_Ljava_lang_String_);
			return cb_SetLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Language = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetLanguage;
		static IntPtr id_SetLanguage_Ljava_lang_String_;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetLanguage' and count(parameter)=0]"
			[Register ("GetLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_GetLanguage == IntPtr.Zero)
					id_GetLanguage = JNIEnv.GetMethodID (class_ref, "GetLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				if (id_SetLanguage_Ljava_lang_String_ == IntPtr.Zero)
					id_SetLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetLanguage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetLanguage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLanguage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetResourceInformation;
#pragma warning disable 0169
		static Delegate GetGetResourceInformationHandler ()
		{
			if (cb_GetResourceInformation == null)
				cb_GetResourceInformation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceInformation);
			return cb_GetResourceInformation;
		}

		static IntPtr n_GetResourceInformation (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResourceInformation);
		}
#pragma warning restore 0169

		static IntPtr id_GetResourceInformation;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector ResourceInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetResourceInformation' and count(parameter)=0]"
			[Register ("GetResourceInformation", "()Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;", "GetGetResourceInformationHandler")]
			get {
				if (id_GetResourceInformation == IntPtr.Zero)
					id_GetResourceInformation = JNIEnv.GetMethodID (class_ref, "GetResourceInformation", "()Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetResourceInformation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.RemoteResourceInformationVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetResourceInformation", "()Lio/adaptivecards/objectmodel/RemoteResourceInformationVector;")), JniHandleOwnership.TransferLocalRef);
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
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.BaseActionElement p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectAction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSelectAction;
		static IntPtr id_SetSelectAction_Lio_adaptivecards_objectmodel_BaseActionElement_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.BaseActionElement SelectAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetSelectAction' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetSelectAction' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement']]"
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

		static Delegate cb_GetSpeak;
#pragma warning disable 0169
		static Delegate GetGetSpeakHandler ()
		{
			if (cb_GetSpeak == null)
				cb_GetSpeak = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpeak);
			return cb_GetSpeak;
		}

		static IntPtr n_GetSpeak (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Speak);
		}
#pragma warning restore 0169

		static Delegate cb_SetSpeak_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSpeak_Ljava_lang_String_Handler ()
		{
			if (cb_SetSpeak_Ljava_lang_String_ == null)
				cb_SetSpeak_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpeak_Ljava_lang_String_);
			return cb_SetSpeak_Ljava_lang_String_;
		}

		static void n_SetSpeak_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Speak = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetSpeak;
		static IntPtr id_SetSpeak_Ljava_lang_String_;
		public virtual unsafe string Speak {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetSpeak' and count(parameter)=0]"
			[Register ("GetSpeak", "()Ljava/lang/String;", "GetGetSpeakHandler")]
			get {
				if (id_GetSpeak == IntPtr.Zero)
					id_GetSpeak = JNIEnv.GetMethodID (class_ref, "GetSpeak", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetSpeak), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSpeak", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetSpeak' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetSpeak", "(Ljava/lang/String;)V", "GetSetSpeak_Ljava_lang_String_Handler")]
			set {
				if (id_SetSpeak_Ljava_lang_String_ == IntPtr.Zero)
					id_SetSpeak_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetSpeak", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetSpeak_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSpeak", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetStyle;
#pragma warning disable 0169
		static Delegate GetGetStyleHandler ()
		{
			if (cb_GetStyle == null)
				cb_GetStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyle);
			return cb_GetStyle;
		}

		static IntPtr n_GetStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Style);
		}
#pragma warning restore 0169

		static Delegate cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_Handler ()
		{
			if (cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ == null)
				cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_);
			return cb_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
		}

		static void n_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.ContainerStyle p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Style = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetStyle;
		static IntPtr id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.ContainerStyle Style {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetStyle' and count(parameter)=0]"
			[Register ("GetStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;", "GetGetStyleHandler")]
			get {
				if (id_GetStyle == IntPtr.Zero)
					id_GetStyle = JNIEnv.GetMethodID (class_ref, "GetStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ContainerStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStyle", "()Lio/adaptivecards/objectmodel/ContainerStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetStyle' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ContainerStyle']]"
			[Register ("SetStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V", "GetSetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_Handler")]
			set {
				if (id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ == IntPtr.Zero)
					id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_ = JNIEnv.GetMethodID (class_ref, "SetStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetStyle_Lio_adaptivecards_objectmodel_ContainerStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStyle", "(Lio/adaptivecards/objectmodel/ContainerStyle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_GetVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_GetVersion == null)
				cb_GetVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_GetVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_SetVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_SetVersion_Ljava_lang_String_ == null)
				cb_SetVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
			return cb_SetVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetVersion;
		static IntPtr id_SetVersion_Ljava_lang_String_;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetVersion' and count(parameter)=0]"
			[Register ("GetVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_GetVersion == IntPtr.Zero)
					id_GetVersion = JNIEnv.GetMethodID (class_ref, "GetVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
			set {
				if (id_SetVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_SetVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetVersion", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_GetVerticalContentAlignment;
#pragma warning disable 0169
		static Delegate GetGetVerticalContentAlignmentHandler ()
		{
			if (cb_GetVerticalContentAlignment == null)
				cb_GetVerticalContentAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerticalContentAlignment);
			return cb_GetVerticalContentAlignment;
		}

		static IntPtr n_GetVerticalContentAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerticalContentAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
#pragma warning disable 0169
		static Delegate GetSetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Handler ()
		{
			if (cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ == null)
				cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_);
			return cb_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
		}

		static void n_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VerticalContentAlignment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetVerticalContentAlignment;
		static IntPtr id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment VerticalContentAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='GetVerticalContentAlignment' and count(parameter)=0]"
			[Register ("GetVerticalContentAlignment", "()Lio/adaptivecards/objectmodel/VerticalContentAlignment;", "GetGetVerticalContentAlignmentHandler")]
			get {
				if (id_GetVerticalContentAlignment == IntPtr.Zero)
					id_GetVerticalContentAlignment = JNIEnv.GetMethodID (class_ref, "GetVerticalContentAlignment", "()Lio/adaptivecards/objectmodel/VerticalContentAlignment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetVerticalContentAlignment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.VerticalContentAlignment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetVerticalContentAlignment", "()Lio/adaptivecards/objectmodel/VerticalContentAlignment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SetVerticalContentAlignment' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.VerticalContentAlignment']]"
			[Register ("SetVerticalContentAlignment", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)V", "GetSetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_Handler")]
			set {
				if (id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ == IntPtr.Zero)
					id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_ = JNIEnv.GetMethodID (class_ref, "SetVerticalContentAlignment", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetVerticalContentAlignment_Lio_adaptivecards_objectmodel_VerticalContentAlignment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetVerticalContentAlignment", "(Lio/adaptivecards/objectmodel/VerticalContentAlignment;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='Deserialize' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='java.lang.String']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Ljava/lang/String;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, string p1)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Ljava/lang/String;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='Deserialize' and count(parameter)=3 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='io.adaptivecards.objectmodel.ElementParserRegistration']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, string p1, global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p2)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='Deserialize' and count(parameter)=4 and parameter[1][@type='io.adaptivecards.objectmodel.JsonValue'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[4][@type='io.adaptivecards.objectmodel.ActionParserRegistration']]"
		[Register ("Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult Deserialize (global::IO.Adaptivecards.Objectmodel.JsonValue p0, string p1, global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p2, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p3)
		{
			if (id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_ == IntPtr.Zero)
				id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "Deserialize", "(Lio/adaptivecards/objectmodel/JsonValue;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_Deserialize_Lio_adaptivecards_objectmodel_JsonValue_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='DeserializeFromFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("DeserializeFromFile", "(Ljava/lang/String;Ljava/lang/String;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult DeserializeFromFile (string p0, string p1)
		{
			if (id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromFile", "(Ljava/lang/String;Ljava/lang/String;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='DeserializeFromFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='io.adaptivecards.objectmodel.ElementParserRegistration']]"
		[Register ("DeserializeFromFile", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult DeserializeFromFile (string p0, string p1, global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p2)
		{
			if (id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_ == IntPtr.Zero)
				id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromFile", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='DeserializeFromFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[4][@type='io.adaptivecards.objectmodel.ActionParserRegistration']]"
		[Register ("DeserializeFromFile", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult DeserializeFromFile (string p0, string p1, global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p2, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p3)
		{
			if (id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_ == IntPtr.Zero)
				id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromFile", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromFile_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='DeserializeFromString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("DeserializeFromString", "(Ljava/lang/String;Ljava/lang/String;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult DeserializeFromString (string p0, string p1)
		{
			if (id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Ljava/lang/String;Ljava/lang/String;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='DeserializeFromString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='io.adaptivecards.objectmodel.ElementParserRegistration']]"
		[Register ("DeserializeFromString", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult DeserializeFromString (string p0, string p1, global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p2)
		{
			if (id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_ == IntPtr.Zero)
				id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='DeserializeFromString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='io.adaptivecards.objectmodel.ElementParserRegistration'] and parameter[4][@type='io.adaptivecards.objectmodel.ActionParserRegistration']]"
		[Register ("DeserializeFromString", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ParseResult DeserializeFromString (string p0, string p1, global::IO.Adaptivecards.Objectmodel.ElementParserRegistration p2, global::IO.Adaptivecards.Objectmodel.ActionParserRegistration p3)
		{
			if (id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_ == IntPtr.Zero)
				id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_ = JNIEnv.GetStaticMethodID (class_ref, "DeserializeFromString", "(Ljava/lang/String;Ljava/lang/String;Lio/adaptivecards/objectmodel/ElementParserRegistration;Lio/adaptivecards/objectmodel/ActionParserRegistration;)Lio/adaptivecards/objectmodel/ParseResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::IO.Adaptivecards.Objectmodel.ParseResult __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_DeserializeFromString_Ljava_lang_String_Ljava_lang_String_Lio_adaptivecards_objectmodel_ElementParserRegistration_Lio_adaptivecards_objectmodel_ActionParserRegistration_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_MakeFallbackTextCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='MakeFallbackTextCard' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("MakeFallbackTextCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lio/adaptivecards/objectmodel/AdaptiveCard;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCard MakeFallbackTextCard (string p0, string p1, string p2)
		{
			if (id_MakeFallbackTextCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_MakeFallbackTextCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "MakeFallbackTextCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lio/adaptivecards/objectmodel/AdaptiveCard;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::IO.Adaptivecards.Objectmodel.AdaptiveCard __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallStaticObjectMethod  (class_ref, id_MakeFallbackTextCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_Serialize;
#pragma warning disable 0169
		static Delegate GetSerializeHandler ()
		{
			if (cb_Serialize == null)
				cb_Serialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Serialize);
			return cb_Serialize;
		}

		static IntPtr n_Serialize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Serialize ());
		}
#pragma warning restore 0169

		static IntPtr id_Serialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='Serialize' and count(parameter)=0]"
		[Register ("Serialize", "()Ljava/lang/String;", "GetSerializeHandler")]
		public virtual unsafe string Serialize ()
		{
			if (id_Serialize == IntPtr.Zero)
				id_Serialize = JNIEnv.GetMethodID (class_ref, "Serialize", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Serialize), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Serialize", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_SerializeToJsonValue;
#pragma warning disable 0169
		static Delegate GetSerializeToJsonValueHandler ()
		{
			if (cb_SerializeToJsonValue == null)
				cb_SerializeToJsonValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SerializeToJsonValue);
			return cb_SerializeToJsonValue;
		}

		static IntPtr n_SerializeToJsonValue (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerializeToJsonValue ());
		}
#pragma warning restore 0169

		static IntPtr id_SerializeToJsonValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='SerializeToJsonValue' and count(parameter)=0]"
		[Register ("SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;", "GetSerializeToJsonValueHandler")]
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.JsonValue SerializeToJsonValue ()
		{
			if (id_SerializeToJsonValue == IntPtr.Zero)
				id_SerializeToJsonValue = JNIEnv.GetMethodID (class_ref, "SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_SerializeToJsonValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.JsonValue> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SerializeToJsonValue", "()Lio/adaptivecards/objectmodel/JsonValue;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCard_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='AdaptiveCard']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCard']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.AdaptiveCard p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCard_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCard_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_AdaptiveCard_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
