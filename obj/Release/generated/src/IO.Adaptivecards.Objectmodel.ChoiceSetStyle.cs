using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ChoiceSetStyle", DoNotGenerateAcw=true)]
	public sealed partial class ChoiceSetStyle : global::Java.Lang.Enum {


		static IntPtr Compact_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']/field[@name='Compact']"
		[Register ("Compact")]
		public static global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle Compact {
			get {
				if (Compact_jfieldId == IntPtr.Zero)
					Compact_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Compact", "Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Compact_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Expanded_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']/field[@name='Expanded']"
		[Register ("Expanded")]
		public static global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle Expanded {
			get {
				if (Expanded_jfieldId == IntPtr.Zero)
					Expanded_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Expanded", "Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Expanded_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ChoiceSetStyle$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ChoiceSetStyle$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ChoiceSetStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChoiceSetStyle); }
		}

		internal ChoiceSetStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/ChoiceSetStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ChoiceSetStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceSetStyle']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/ChoiceSetStyle;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/ChoiceSetStyle;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.ChoiceSetStyle));
			} finally {
			}
		}

	}
}
