using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ImageSize", DoNotGenerateAcw=true)]
	public sealed partial class ImageSize : global::Java.Lang.Enum {


		static IntPtr Auto_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/field[@name='Auto']"
		[Register ("Auto")]
		public static global::IO.Adaptivecards.Objectmodel.ImageSize Auto {
			get {
				if (Auto_jfieldId == IntPtr.Zero)
					Auto_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Auto", "Lio/adaptivecards/objectmodel/ImageSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Auto_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Large_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/field[@name='Large']"
		[Register ("Large")]
		public static global::IO.Adaptivecards.Objectmodel.ImageSize Large {
			get {
				if (Large_jfieldId == IntPtr.Zero)
					Large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Large", "Lio/adaptivecards/objectmodel/ImageSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Large_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Medium_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/field[@name='Medium']"
		[Register ("Medium")]
		public static global::IO.Adaptivecards.Objectmodel.ImageSize Medium {
			get {
				if (Medium_jfieldId == IntPtr.Zero)
					Medium_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Medium", "Lio/adaptivecards/objectmodel/ImageSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Medium_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr None_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/field[@name='None']"
		[Register ("None")]
		public static global::IO.Adaptivecards.Objectmodel.ImageSize None {
			get {
				if (None_jfieldId == IntPtr.Zero)
					None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lio/adaptivecards/objectmodel/ImageSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, None_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Small_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/field[@name='Small']"
		[Register ("Small")]
		public static global::IO.Adaptivecards.Objectmodel.ImageSize Small {
			get {
				if (Small_jfieldId == IntPtr.Zero)
					Small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Small", "Lio/adaptivecards/objectmodel/ImageSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Small_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Stretch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/field[@name='Stretch']"
		[Register ("Stretch")]
		public static global::IO.Adaptivecards.Objectmodel.ImageSize Stretch {
			get {
				if (Stretch_jfieldId == IntPtr.Zero)
					Stretch_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Stretch", "Lio/adaptivecards/objectmodel/ImageSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Stretch_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ImageSize$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ImageSize$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ImageSize", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSize); }
		}

		internal ImageSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/ImageSize;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSize SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/ImageSize;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ImageSize;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSize ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ImageSize;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ImageSize __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ImageSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageSize']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/ImageSize;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ImageSize[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/ImageSize;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.ImageSize[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.ImageSize));
			} finally {
			}
		}

	}
}
