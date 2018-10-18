using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ParseResult", DoNotGenerateAcw=true)]
	public partial class ParseResult : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ParseResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseResult); }
		}

		protected ParseResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']/constructor[@name='ParseResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe ParseResult (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ParseResult)) {
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

		static IntPtr id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']/constructor[@name='ParseResult' and count(parameter)=2 and parameter[1][@type='io.adaptivecards.objectmodel.AdaptiveCard'] and parameter[2][@type='io.adaptivecards.objectmodel.AdaptiveCardParseWarningVector']]"
		[Register (".ctor", "(Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;)V", "")]
		public unsafe ParseResult (global::IO.Adaptivecards.Objectmodel.AdaptiveCard p0, global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ParseResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;)V", __args);
					return;
				}

				if (id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_ == IntPtr.Zero)
					id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/adaptivecards/objectmodel/AdaptiveCard;Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_adaptivecards_objectmodel_AdaptiveCard_Lio_adaptivecards_objectmodel_AdaptiveCardParseWarningVector_, __args);
			} finally {
			}
		}

		static Delegate cb_GetAdaptiveCard;
#pragma warning disable 0169
		static Delegate GetGetAdaptiveCardHandler ()
		{
			if (cb_GetAdaptiveCard == null)
				cb_GetAdaptiveCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdaptiveCard);
			return cb_GetAdaptiveCard;
		}

		static IntPtr n_GetAdaptiveCard (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ParseResult __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdaptiveCard);
		}
#pragma warning restore 0169

		static IntPtr id_GetAdaptiveCard;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCard AdaptiveCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']/method[@name='GetAdaptiveCard' and count(parameter)=0]"
			[Register ("GetAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;", "GetGetAdaptiveCardHandler")]
			get {
				if (id_GetAdaptiveCard == IntPtr.Zero)
					id_GetAdaptiveCard = JNIEnv.GetMethodID (class_ref, "GetAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetAdaptiveCard), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCard> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAdaptiveCard", "()Lio/adaptivecards/objectmodel/AdaptiveCard;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetWarnings;
#pragma warning disable 0169
		static Delegate GetGetWarningsHandler ()
		{
			if (cb_GetWarnings == null)
				cb_GetWarnings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWarnings);
			return cb_GetWarnings;
		}

		static IntPtr n_GetWarnings (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.ParseResult __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Warnings);
		}
#pragma warning restore 0169

		static IntPtr id_GetWarnings;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector Warnings {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']/method[@name='GetWarnings' and count(parameter)=0]"
			[Register ("GetWarnings", "()Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;", "GetGetWarningsHandler")]
			get {
				if (id_GetWarnings == IntPtr.Zero)
					id_GetWarnings = JNIEnv.GetMethodID (class_ref, "GetWarnings", "()Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetWarnings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarningVector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetWarnings", "()Lio/adaptivecards/objectmodel/AdaptiveCardParseWarningVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::IO.Adaptivecards.Objectmodel.ParseResult __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ParseResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_ParseResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ParseResult']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.ParseResult']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/ParseResult;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.ParseResult p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_ParseResult_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_ParseResult_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/ParseResult;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_ParseResult_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
