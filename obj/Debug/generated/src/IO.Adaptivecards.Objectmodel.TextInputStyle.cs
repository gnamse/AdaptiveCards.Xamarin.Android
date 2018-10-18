using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextInputStyle", DoNotGenerateAcw=true)]
	public sealed partial class TextInputStyle : global::Java.Lang.Enum {


		static IntPtr Email_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/field[@name='Email']"
		[Register ("Email")]
		public static global::IO.Adaptivecards.Objectmodel.TextInputStyle Email {
			get {
				if (Email_jfieldId == IntPtr.Zero)
					Email_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Email", "Lio/adaptivecards/objectmodel/TextInputStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Email_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Tel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/field[@name='Tel']"
		[Register ("Tel")]
		public static global::IO.Adaptivecards.Objectmodel.TextInputStyle Tel {
			get {
				if (Tel_jfieldId == IntPtr.Zero)
					Tel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Tel", "Lio/adaptivecards/objectmodel/TextInputStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Tel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Text_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/field[@name='Text']"
		[Register ("Text")]
		public static global::IO.Adaptivecards.Objectmodel.TextInputStyle Text {
			get {
				if (Text_jfieldId == IntPtr.Zero)
					Text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Text", "Lio/adaptivecards/objectmodel/TextInputStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Text_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/field[@name='Url']"
		[Register ("Url")]
		public static global::IO.Adaptivecards.Objectmodel.TextInputStyle Url {
			get {
				if (Url_jfieldId == IntPtr.Zero)
					Url_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Url", "Lio/adaptivecards/objectmodel/TextInputStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Url_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextInputStyle$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextInputStyle$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextInputStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextInputStyle); }
		}

		internal TextInputStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/TextInputStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextInputStyle SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/TextInputStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextInputStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextInputStyle ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextInputStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.TextInputStyle __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextInputStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextInputStyle']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/TextInputStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextInputStyle[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/TextInputStyle;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.TextInputStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.TextInputStyle));
			} finally {
			}
		}

	}
}
