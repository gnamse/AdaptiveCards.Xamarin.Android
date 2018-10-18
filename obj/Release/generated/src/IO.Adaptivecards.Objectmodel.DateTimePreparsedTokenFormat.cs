using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/DateTimePreparsedTokenFormat", DoNotGenerateAcw=true)]
	public sealed partial class DateTimePreparsedTokenFormat : global::Java.Lang.Enum {


		static IntPtr DateCompact_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/field[@name='DateCompact']"
		[Register ("DateCompact")]
		public static global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat DateCompact {
			get {
				if (DateCompact_jfieldId == IntPtr.Zero)
					DateCompact_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DateCompact", "Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DateCompact_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DateLong_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/field[@name='DateLong']"
		[Register ("DateLong")]
		public static global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat DateLong {
			get {
				if (DateLong_jfieldId == IntPtr.Zero)
					DateLong_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DateLong", "Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DateLong_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DateShort_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/field[@name='DateShort']"
		[Register ("DateShort")]
		public static global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat DateShort {
			get {
				if (DateShort_jfieldId == IntPtr.Zero)
					DateShort_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DateShort", "Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DateShort_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RegularString_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/field[@name='RegularString']"
		[Register ("RegularString")]
		public static global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat RegularString {
			get {
				if (RegularString_jfieldId == IntPtr.Zero)
					RegularString_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RegularString", "Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RegularString_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Time_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/field[@name='Time']"
		[Register ("Time")]
		public static global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat Time {
			get {
				if (Time_jfieldId == IntPtr.Zero)
					Time_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Time", "Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Time_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/DateTimePreparsedTokenFormat$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/DateTimePreparsedTokenFormat$SwigNext", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SwigNext); }
			}

			protected SwigNext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/DateTimePreparsedTokenFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateTimePreparsedTokenFormat); }
		}

		internal DateTimePreparsedTokenFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/method[@name='swigValue' and count(parameter)=0]"
		[Register ("swigValue", "()I", "")]
		public unsafe int SwigValue ()
		{
			if (id_swigValue == IntPtr.Zero)
				id_swigValue = JNIEnv.GetMethodID (class_ref, "swigValue", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_swigValue);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/DateTimePreparsedTokenFormat;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.DateTimePreparsedTokenFormat));
			} finally {
			}
		}

	}
}
