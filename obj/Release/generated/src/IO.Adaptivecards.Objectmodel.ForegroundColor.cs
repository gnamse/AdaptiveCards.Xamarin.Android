using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ForegroundColor", DoNotGenerateAcw=true)]
	public sealed partial class ForegroundColor : global::Java.Lang.Enum {


		static IntPtr Accent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Accent']"
		[Register ("Accent")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Accent {
			get {
				if (Accent_jfieldId == IntPtr.Zero)
					Accent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Accent", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Accent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Attention_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Attention']"
		[Register ("Attention")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Attention {
			get {
				if (Attention_jfieldId == IntPtr.Zero)
					Attention_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Attention", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Attention_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Dark_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Dark']"
		[Register ("Dark")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Dark {
			get {
				if (Dark_jfieldId == IntPtr.Zero)
					Dark_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Dark", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Dark_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Default_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Default']"
		[Register ("Default")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Default {
			get {
				if (Default_jfieldId == IntPtr.Zero)
					Default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Default", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Default_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Good_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Good']"
		[Register ("Good")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Good {
			get {
				if (Good_jfieldId == IntPtr.Zero)
					Good_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Good", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Good_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Light_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Light']"
		[Register ("Light")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Light {
			get {
				if (Light_jfieldId == IntPtr.Zero)
					Light_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Light", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Light_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Warning_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/field[@name='Warning']"
		[Register ("Warning")]
		public static global::IO.Adaptivecards.Objectmodel.ForegroundColor Warning {
			get {
				if (Warning_jfieldId == IntPtr.Zero)
					Warning_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Warning", "Lio/adaptivecards/objectmodel/ForegroundColor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Warning_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ForegroundColor$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ForegroundColor$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ForegroundColor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForegroundColor); }
		}

		internal ForegroundColor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/ForegroundColor;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ForegroundColor SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/ForegroundColor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ForegroundColor;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ForegroundColor ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ForegroundColor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ForegroundColor __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ForegroundColor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ForegroundColor']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/ForegroundColor;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ForegroundColor[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/ForegroundColor;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.ForegroundColor[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.ForegroundColor));
			} finally {
			}
		}

	}
}
