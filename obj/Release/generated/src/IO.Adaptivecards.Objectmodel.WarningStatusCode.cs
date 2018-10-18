using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/WarningStatusCode", DoNotGenerateAcw=true)]
	public sealed partial class WarningStatusCode : global::Java.Lang.Enum {


		static IntPtr AssetLoadFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='AssetLoadFailed']"
		[Register ("AssetLoadFailed")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode AssetLoadFailed {
			get {
				if (AssetLoadFailed_jfieldId == IntPtr.Zero)
					AssetLoadFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AssetLoadFailed", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AssetLoadFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InteractivityNotSupported_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='InteractivityNotSupported']"
		[Register ("InteractivityNotSupported")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode InteractivityNotSupported {
			get {
				if (InteractivityNotSupported_jfieldId == IntPtr.Zero)
					InteractivityNotSupported_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InteractivityNotSupported", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InteractivityNotSupported_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidColorFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='InvalidColorFormat']"
		[Register ("InvalidColorFormat")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode InvalidColorFormat {
			get {
				if (InvalidColorFormat_jfieldId == IntPtr.Zero)
					InvalidColorFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidColorFormat", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidColorFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidDimensionSpecified_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='InvalidDimensionSpecified']"
		[Register ("InvalidDimensionSpecified")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode InvalidDimensionSpecified {
			get {
				if (InvalidDimensionSpecified_jfieldId == IntPtr.Zero)
					InvalidDimensionSpecified_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidDimensionSpecified", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidDimensionSpecified_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidMediaMix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='InvalidMediaMix']"
		[Register ("InvalidMediaMix")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode InvalidMediaMix {
			get {
				if (InvalidMediaMix_jfieldId == IntPtr.Zero)
					InvalidMediaMix_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidMediaMix", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidMediaMix_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MaxActionsExceeded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='MaxActionsExceeded']"
		[Register ("MaxActionsExceeded")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode MaxActionsExceeded {
			get {
				if (MaxActionsExceeded_jfieldId == IntPtr.Zero)
					MaxActionsExceeded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MaxActionsExceeded", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MaxActionsExceeded_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NoRendererForType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='NoRendererForType']"
		[Register ("NoRendererForType")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode NoRendererForType {
			get {
				if (NoRendererForType_jfieldId == IntPtr.Zero)
					NoRendererForType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NoRendererForType", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NoRendererForType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnknownElementType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='UnknownElementType']"
		[Register ("UnknownElementType")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode UnknownElementType {
			get {
				if (UnknownElementType_jfieldId == IntPtr.Zero)
					UnknownElementType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnknownElementType", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnknownElementType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnknownEnumValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='UnknownEnumValue']"
		[Register ("UnknownEnumValue")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode UnknownEnumValue {
			get {
				if (UnknownEnumValue_jfieldId == IntPtr.Zero)
					UnknownEnumValue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnknownEnumValue", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnknownEnumValue_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnknownPropertyOnElement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='UnknownPropertyOnElement']"
		[Register ("UnknownPropertyOnElement")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode UnknownPropertyOnElement {
			get {
				if (UnknownPropertyOnElement_jfieldId == IntPtr.Zero)
					UnknownPropertyOnElement_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnknownPropertyOnElement", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnknownPropertyOnElement_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnsupportedMediaType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='UnsupportedMediaType']"
		[Register ("UnsupportedMediaType")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode UnsupportedMediaType {
			get {
				if (UnsupportedMediaType_jfieldId == IntPtr.Zero)
					UnsupportedMediaType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnsupportedMediaType", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnsupportedMediaType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnsupportedSchemaVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/field[@name='UnsupportedSchemaVersion']"
		[Register ("UnsupportedSchemaVersion")]
		public static global::IO.Adaptivecards.Objectmodel.WarningStatusCode UnsupportedSchemaVersion {
			get {
				if (UnsupportedSchemaVersion_jfieldId == IntPtr.Zero)
					UnsupportedSchemaVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnsupportedSchemaVersion", "Lio/adaptivecards/objectmodel/WarningStatusCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnsupportedSchemaVersion_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/WarningStatusCode$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/WarningStatusCode$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/WarningStatusCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WarningStatusCode); }
		}

		internal WarningStatusCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/WarningStatusCode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.WarningStatusCode SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/WarningStatusCode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/WarningStatusCode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.WarningStatusCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/WarningStatusCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.WarningStatusCode __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.WarningStatusCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='WarningStatusCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/WarningStatusCode;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.WarningStatusCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/WarningStatusCode;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.WarningStatusCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.WarningStatusCode));
			} finally {
			}
		}

	}
}
