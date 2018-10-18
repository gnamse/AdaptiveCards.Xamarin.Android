using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/HorizontalAlignment", DoNotGenerateAcw=true)]
	public sealed partial class HorizontalAlignment : global::Java.Lang.Enum {


		static IntPtr Center_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/field[@name='Center']"
		[Register ("Center")]
		public static global::IO.Adaptivecards.Objectmodel.HorizontalAlignment Center {
			get {
				if (Center_jfieldId == IntPtr.Zero)
					Center_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Center", "Lio/adaptivecards/objectmodel/HorizontalAlignment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Center_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Left_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/field[@name='Left']"
		[Register ("Left")]
		public static global::IO.Adaptivecards.Objectmodel.HorizontalAlignment Left {
			get {
				if (Left_jfieldId == IntPtr.Zero)
					Left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Left", "Lio/adaptivecards/objectmodel/HorizontalAlignment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Left_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Right_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/field[@name='Right']"
		[Register ("Right")]
		public static global::IO.Adaptivecards.Objectmodel.HorizontalAlignment Right {
			get {
				if (Right_jfieldId == IntPtr.Zero)
					Right_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Right", "Lio/adaptivecards/objectmodel/HorizontalAlignment;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Right_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/HorizontalAlignment$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/HorizontalAlignment$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/HorizontalAlignment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HorizontalAlignment); }
		}

		internal HorizontalAlignment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/HorizontalAlignment;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HorizontalAlignment SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/HorizontalAlignment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HorizontalAlignment;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HorizontalAlignment ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/HorizontalAlignment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.HorizontalAlignment __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.HorizontalAlignment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='HorizontalAlignment']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/HorizontalAlignment;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.HorizontalAlignment[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/HorizontalAlignment;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.HorizontalAlignment[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.HorizontalAlignment));
			} finally {
			}
		}

	}
}
