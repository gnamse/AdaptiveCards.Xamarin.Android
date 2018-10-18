using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ActionType", DoNotGenerateAcw=true)]
	public sealed partial class ActionType : global::Java.Lang.Enum {


		static IntPtr Custom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/field[@name='Custom']"
		[Register ("Custom")]
		public static global::IO.Adaptivecards.Objectmodel.ActionType Custom {
			get {
				if (Custom_jfieldId == IntPtr.Zero)
					Custom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Custom", "Lio/adaptivecards/objectmodel/ActionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Custom_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OpenUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/field[@name='OpenUrl']"
		[Register ("OpenUrl")]
		public static global::IO.Adaptivecards.Objectmodel.ActionType OpenUrl {
			get {
				if (OpenUrl_jfieldId == IntPtr.Zero)
					OpenUrl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OpenUrl", "Lio/adaptivecards/objectmodel/ActionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OpenUrl_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ShowCard_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/field[@name='ShowCard']"
		[Register ("ShowCard")]
		public static global::IO.Adaptivecards.Objectmodel.ActionType ShowCard {
			get {
				if (ShowCard_jfieldId == IntPtr.Zero)
					ShowCard_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ShowCard", "Lio/adaptivecards/objectmodel/ActionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ShowCard_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Submit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/field[@name='Submit']"
		[Register ("Submit")]
		public static global::IO.Adaptivecards.Objectmodel.ActionType Submit {
			get {
				if (Submit_jfieldId == IntPtr.Zero)
					Submit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Submit", "Lio/adaptivecards/objectmodel/ActionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Submit_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Unsupported_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/field[@name='Unsupported']"
		[Register ("Unsupported")]
		public static global::IO.Adaptivecards.Objectmodel.ActionType Unsupported {
			get {
				if (Unsupported_jfieldId == IntPtr.Zero)
					Unsupported_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unsupported", "Lio/adaptivecards/objectmodel/ActionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unsupported_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/ActionType$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ActionType$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/ActionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionType); }
		}

		internal ActionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/ActionType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionType SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/ActionType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/ActionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.ActionType __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ActionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ActionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/ActionType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.ActionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/ActionType;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.ActionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.ActionType));
			} finally {
			}
		}

	}
}
