using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextWeight", DoNotGenerateAcw=true)]
	public sealed partial class TextWeight : global::Java.Lang.Enum {


		static IntPtr Bolder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/field[@name='Bolder']"
		[Register ("Bolder")]
		public static global::IO.Adaptivecards.Objectmodel.TextWeight Bolder {
			get {
				if (Bolder_jfieldId == IntPtr.Zero)
					Bolder_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Bolder", "Lio/adaptivecards/objectmodel/TextWeight;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Bolder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Default_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/field[@name='Default']"
		[Register ("Default")]
		public static global::IO.Adaptivecards.Objectmodel.TextWeight Default {
			get {
				if (Default_jfieldId == IntPtr.Zero)
					Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Default", "Lio/adaptivecards/objectmodel/TextWeight;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Default_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Lighter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/field[@name='Lighter']"
		[Register ("Lighter")]
		public static global::IO.Adaptivecards.Objectmodel.TextWeight Lighter {
			get {
				if (Lighter_jfieldId == IntPtr.Zero)
					Lighter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Lighter", "Lio/adaptivecards/objectmodel/TextWeight;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Lighter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/TextWeight$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextWeight$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/TextWeight", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextWeight); }
		}

		internal TextWeight (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/TextWeight;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextWeight SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/TextWeight;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextWeight;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextWeight ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/TextWeight;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.TextWeight __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TextWeight> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='TextWeight']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/TextWeight;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.TextWeight[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/TextWeight;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.TextWeight[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.TextWeight));
			} finally {
			}
		}

	}
}
