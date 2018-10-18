using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ErrorStatusCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorStatusCode : global::Java.Lang.Enum {


		static IntPtr InvalidJson_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/field[@name='InvalidJson']"
		[Register ("InvalidJson")]
		public static global::IO.Adaptivecards.Objectmodel.ErrorStatusCode InvalidJson {
			get {
				if (InvalidJson_jfieldId == IntPtr.Zero)
					InvalidJson_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidJson", "Lio/adaptivecards/objectmodel/ErrorStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidJson_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidPropertyValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/field[@name='InvalidPropertyValue']"
		[Register ("InvalidPropertyValue")]
		public static global::IO.Adaptivecards.Objectmodel.ErrorStatusCode InvalidPropertyValue {
			get {
				if (InvalidPropertyValue_jfieldId == IntPtr.Zero)
					InvalidPropertyValue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidPropertyValue", "Lio/adaptivecards/objectmodel/ErrorStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidPropertyValue_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RenderFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/field[@name='RenderFailed']"
		[Register ("RenderFailed")]
		public static global::IO.Adaptivecards.Objectmodel.ErrorStatusCode RenderFailed {
			get {
				if (RenderFailed_jfieldId == IntPtr.Zero)
					RenderFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RenderFailed", "Lio/adaptivecards/objectmodel/ErrorStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RenderFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RequiredPropertyMissing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/field[@name='RequiredPropertyMissing']"
		[Register ("RequiredPropertyMissing")]
		public static global::IO.Adaptivecards.Objectmodel.ErrorStatusCode RequiredPropertyMissing {
			get {
				if (RequiredPropertyMissing_jfieldId == IntPtr.Zero)
					RequiredPropertyMissing_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RequiredPropertyMissing", "Lio/adaptivecards/objectmodel/ErrorStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RequiredPropertyMissing_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnsupportedParserOverride_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/field[@name='UnsupportedParserOverride']"
		[Register ("UnsupportedParserOverride")]
		public static global::IO.Adaptivecards.Objectmodel.ErrorStatusCode UnsupportedParserOverride {
			get {
				if (UnsupportedParserOverride_jfieldId == IntPtr.Zero)
					UnsupportedParserOverride_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnsupportedParserOverride", "Lio/adaptivecards/objectmodel/ErrorStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnsupportedParserOverride_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ErrorStatusCode$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ErrorStatusCode$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ErrorStatusCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorStatusCode); }
		}

		internal ErrorStatusCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/ErrorStatusCode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ErrorStatusCode SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/ErrorStatusCode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ErrorStatusCode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ErrorStatusCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ErrorStatusCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ErrorStatusCode __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ErrorStatusCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ErrorStatusCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/ErrorStatusCode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ErrorStatusCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/ErrorStatusCode;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.ErrorStatusCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.ErrorStatusCode));
			} finally {
			}
		}

	}
}
