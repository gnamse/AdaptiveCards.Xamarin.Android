using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/Spacing", DoNotGenerateAcw=true)]
	public sealed partial class Spacing : global::Java.Lang.Enum {


		static IntPtr Default_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='Default']"
		[Register ("Default")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing Default {
			get {
				if (Default_jfieldId == IntPtr.Zero)
					Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Default", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Default_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ExtraLarge_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='ExtraLarge']"
		[Register ("ExtraLarge")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing ExtraLarge {
			get {
				if (ExtraLarge_jfieldId == IntPtr.Zero)
					ExtraLarge_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ExtraLarge", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ExtraLarge_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Large_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='Large']"
		[Register ("Large")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing Large {
			get {
				if (Large_jfieldId == IntPtr.Zero)
					Large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Large", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Large_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Medium_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='Medium']"
		[Register ("Medium")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing Medium {
			get {
				if (Medium_jfieldId == IntPtr.Zero)
					Medium_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Medium", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Medium_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr None_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='None']"
		[Register ("None")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing None {
			get {
				if (None_jfieldId == IntPtr.Zero)
					None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, None_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Padding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='Padding']"
		[Register ("Padding")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing Padding {
			get {
				if (Padding_jfieldId == IntPtr.Zero)
					Padding_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Padding", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Padding_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Small_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/field[@name='Small']"
		[Register ("Small")]
		public static global::IO.Adaptivecards.Objectmodel.Spacing Small {
			get {
				if (Small_jfieldId == IntPtr.Zero)
					Small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Small", "Lio/adaptivecards/objectmodel/Spacing;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Small_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/Spacing$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/Spacing$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/Spacing", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Spacing); }
		}

		internal Spacing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/Spacing;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Spacing SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/Spacing;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/Spacing;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Spacing ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/Spacing;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.Spacing __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Spacing> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='Spacing']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/Spacing;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.Spacing[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/Spacing;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.Spacing[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.Spacing));
			} finally {
			}
		}

	}
}
