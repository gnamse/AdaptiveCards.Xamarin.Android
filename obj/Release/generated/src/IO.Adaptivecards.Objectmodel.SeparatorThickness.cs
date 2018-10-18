using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/SeparatorThickness", DoNotGenerateAcw=true)]
	public sealed partial class SeparatorThickness : global::Java.Lang.Enum {


		static IntPtr Default_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']/field[@name='Default']"
		[Register ("Default")]
		public static global::IO.Adaptivecards.Objectmodel.SeparatorThickness Default {
			get {
				if (Default_jfieldId == IntPtr.Zero)
					Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Default", "Lio/adaptivecards/objectmodel/SeparatorThickness;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Default_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorThickness> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Thick_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']/field[@name='Thick']"
		[Register ("Thick")]
		public static global::IO.Adaptivecards.Objectmodel.SeparatorThickness Thick {
			get {
				if (Thick_jfieldId == IntPtr.Zero)
					Thick_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Thick", "Lio/adaptivecards/objectmodel/SeparatorThickness;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Thick_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorThickness> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/SeparatorThickness$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/SeparatorThickness$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/SeparatorThickness", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SeparatorThickness); }
		}

		internal SeparatorThickness (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/SeparatorThickness;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SeparatorThickness SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/SeparatorThickness;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorThickness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/SeparatorThickness;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SeparatorThickness ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/SeparatorThickness;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.SeparatorThickness __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.SeparatorThickness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='SeparatorThickness']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/SeparatorThickness;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.SeparatorThickness[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/SeparatorThickness;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.SeparatorThickness[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.SeparatorThickness));
			} finally {
			}
		}

	}
}
