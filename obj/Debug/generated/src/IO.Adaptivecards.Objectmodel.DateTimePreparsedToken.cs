using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/DateTimePreparsedToken", DoNotGenerateAcw=true)]
	public partial class DateTimePreparsedToken : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/DateTimePreparsedToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateTimePreparsedToken); }
		}

		protected DateTimePreparsedToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_CTime_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/constructor[@name='DateTimePreparsedToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.adaptivecards.objectmodel.CTime'] and parameter[3][@type='io.adaptivecards.objectmodel.DateTimePreparsedTokenFormat']]"
		[Register (".ctor", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/CTime;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V", "")]
		public unsafe DateTimePreparsedToken (string p0, global::IO.Adaptivecards.Objectmodel.CTime p1, global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (DateTimePreparsedToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lio/adaptivecards/objectmodel/CTime;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lio/adaptivecards/objectmodel/CTime;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_CTime_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_CTime_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/CTime;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_CTime_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_CTime_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/constructor[@name='DateTimePreparsedToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='io.adaptivecards.objectmodel.DateTimePreparsedTokenFormat']]"
		[Register (".ctor", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V", "")]
		public unsafe DateTimePreparsedToken (string p0, global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (DateTimePreparsedToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lio_adaptivecards_objectmodel_DateTimePreparsedTokenFormat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/constructor[@name='DateTimePreparsedToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateTimePreparsedToken ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateTimePreparsedToken)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/constructor[@name='DateTimePreparsedToken' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe DateTimePreparsedToken (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (DateTimePreparsedToken)) {
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

		static Delegate cb_GetDay;
#pragma warning disable 0169
		static Delegate GetGetDayHandler ()
		{
			if (cb_GetDay == null)
				cb_GetDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDay);
			return cb_GetDay;
		}

		static int n_GetDay (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Day;
		}
#pragma warning restore 0169

		static IntPtr id_GetDay;
		public virtual unsafe int Day {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='GetDay' and count(parameter)=0]"
			[Register ("GetDay", "()I", "GetGetDayHandler")]
			get {
				if (id_GetDay == IntPtr.Zero)
					id_GetDay = JNIEnv.GetMethodID (class_ref, "GetDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetDay", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_GetFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_GetFormat == null)
				cb_GetFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_GetFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		static IntPtr id_GetFormat;
		public virtual unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='GetFormat' and count(parameter)=0]"
			[Register ("GetFormat", "()Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;", "GetGetFormatHandler")]
			get {
				if (id_GetFormat == IntPtr.Zero)
					id_GetFormat = JNIEnv.GetMethodID (class_ref, "GetFormat", "()Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFormat", "()Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetMonth;
#pragma warning disable 0169
		static Delegate GetGetMonthHandler ()
		{
			if (cb_GetMonth == null)
				cb_GetMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMonth);
			return cb_GetMonth;
		}

		static int n_GetMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Month;
		}
#pragma warning restore 0169

		static IntPtr id_GetMonth;
		public virtual unsafe int Month {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='GetMonth' and count(parameter)=0]"
			[Register ("GetMonth", "()I", "GetGetMonthHandler")]
			get {
				if (id_GetMonth == IntPtr.Zero)
					id_GetMonth = JNIEnv.GetMethodID (class_ref, "GetMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMonth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_GetText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_GetText == null)
				cb_GetText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_GetText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static IntPtr id_GetText;
		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='GetText' and count(parameter)=0]"
			[Register ("GetText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_GetText == IntPtr.Zero)
					id_GetText = JNIEnv.GetMethodID (class_ref, "GetText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_GetText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetYear;
#pragma warning disable 0169
		static Delegate GetGetYearHandler ()
		{
			if (cb_GetYear == null)
				cb_GetYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYear);
			return cb_GetYear;
		}

		static int n_GetYear (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Year;
		}
#pragma warning restore 0169

		static IntPtr id_GetYear;
		public virtual unsafe int Year {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='GetYear' and count(parameter)=0]"
			[Register ("GetYear", "()I", "GetGetYearHandler")]
			get {
				if (id_GetYear == IntPtr.Zero)
					id_GetYear = JNIEnv.GetMethodID (class_ref, "GetYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_GetYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetYear", "()I"));
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
			global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_getCPtr_Lio_adaptivecards_objectmodel_DateTimePreparsedToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedToken']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='io.adaptivecards.objectmodel.DateTimePreparsedToken']]"
		[Register ("getCPtr", "(Lio/adaptivecards/objectmodel/DateTimePreparsedToken;)J", "")]
		protected static unsafe long GetCPtr (global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken p0)
		{
			if (id_getCPtr_Lio_adaptivecards_objectmodel_DateTimePreparsedToken_ == IntPtr.Zero)
				id_getCPtr_Lio_adaptivecards_objectmodel_DateTimePreparsedToken_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lio/adaptivecards/objectmodel/DateTimePreparsedToken;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lio_adaptivecards_objectmodel_DateTimePreparsedToken_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
