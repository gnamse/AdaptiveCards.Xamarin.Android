using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ShowCardAction", DoNotGenerateAcw=true)]
	public partial class ShowCardAction : global::IO.Adaptivecards.Objectmodel.BaseActionElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ShowCardAction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShowCardAction); }
		}

		protected ShowCardAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/constructor[@name='ShowCardAction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShowCardAction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ShowCardAction)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/constructor[@name='ShowCardAction' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ShowCardAction (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ShowCardAction)) {
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

		static Delegate cb_GetCard;
#pragma warning disable 0169
		static Delegate GetGetCardHandler ()
		{
			if (cb_GetCard == null)
				cb_GetCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCard);
			return cb_GetCard;
		}

		static IntPtr n_GetCard (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardAction __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Card);
		}
#pragma warning restore 0169

		static Delegate cb_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_;
#pragma warning disable 0169
		static Delegate GetSetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_Handler ()
		{
			if (cb_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_ == null)
				cb_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_);
			return cb_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_;
		}

		static void n_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Objectmodel.ShowCardAction __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::IO.Adaptivecards.Objectmodel.AdaptiveCard p0 = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Card = p0;
		}
#pragma warning restore 0169

		static IntPtr id_GetCard;
		static IntPtr id_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCard Card {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/method[@name='GetCard' and count(parameter)=0]"
			[Register ("GetCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;", "GetGetCardHandler")]
			get {
				if (id_GetCard == IntPtr.Zero)
					id_GetCard = JNIEnv.GetMethodID (class_ref, "GetCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetCard), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/method[@name='SetCard' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCard']]"
			[Register ("SetCard", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V", "GetSetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_Handler")]
			set {
				if (id_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_ == IntPtr.Zero)
					id_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_ = JNIEnv.GetMethodID (class_ref, "SetCard", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetCard_Lio_adaptivecards_objectmodel_AdaptiveCard_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCard", "(Lio/adaptivecards/objectmodel/AdaptiveCard;)V"), __args);
				} finally {
				}
			}
		}

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
			global::IO.Adaptivecards.Objectmodel.ShowCardAction __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLanguage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetLanguage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/method[@name='SetLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLanguage (string p0)
		{
			if (id_SetLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_SetLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetLanguage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetLanguage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLanguage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/method[@name='dynamic_cast' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.BaseActionElement']]"
		[Register ("dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseActionElement;)Lio/adaptivecards/objectmodel/ShowCardAction;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ShowCardAction Dynamic_cast (global::IO.Adaptivecards.Objectmodel.BaseActionElement p0)
		{
			if (id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_ == IntPtr.Zero)
				id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_ = JNIEnv.GetStaticMethodID (class_ref, "dynamic_cast", "(Lio/adaptivecards/objectmodel/BaseActionElement;)Lio/adaptivecards/objectmodel/ShowCardAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::IO.Adaptivecards.Objectmodel.ShowCardAction __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ShowCardAction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_dynamic_cast_Lio_adaptivecards_objectmodel_BaseActionElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardAction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ShowCardAction']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ShowCardAction']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ShowCardAction;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ShowCardAction p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardAction_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardAction_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ShowCardAction;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ShowCardAction_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
