using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Objectmodel {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']"
	[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/CardElementType", DoNotGenerateAcw=true)]
	public sealed partial class CardElementType : global::Java.Lang.Enum {


		static IntPtr AdaptiveCard_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='AdaptiveCard']"
		[Register ("AdaptiveCard")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType AdaptiveCard {
			get {
				if (AdaptiveCard_jfieldId == IntPtr.Zero)
					AdaptiveCard_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AdaptiveCard", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AdaptiveCard_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ChoiceInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='ChoiceInput']"
		[Register ("ChoiceInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType ChoiceInput {
			get {
				if (ChoiceInput_jfieldId == IntPtr.Zero)
					ChoiceInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ChoiceInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ChoiceInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ChoiceSetInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='ChoiceSetInput']"
		[Register ("ChoiceSetInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType ChoiceSetInput {
			get {
				if (ChoiceSetInput_jfieldId == IntPtr.Zero)
					ChoiceSetInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ChoiceSetInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ChoiceSetInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Column_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Column']"
		[Register ("Column")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Column {
			get {
				if (Column_jfieldId == IntPtr.Zero)
					Column_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Column", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Column_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ColumnSet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='ColumnSet']"
		[Register ("ColumnSet")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType ColumnSet {
			get {
				if (ColumnSet_jfieldId == IntPtr.Zero)
					ColumnSet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ColumnSet", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ColumnSet_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Container_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Container']"
		[Register ("Container")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Container {
			get {
				if (Container_jfieldId == IntPtr.Zero)
					Container_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Container", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Container_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Custom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Custom']"
		[Register ("Custom")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Custom {
			get {
				if (Custom_jfieldId == IntPtr.Zero)
					Custom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Custom", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Custom_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DateInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='DateInput']"
		[Register ("DateInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType DateInput {
			get {
				if (DateInput_jfieldId == IntPtr.Zero)
					DateInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DateInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DateInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Fact_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Fact']"
		[Register ("Fact")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Fact {
			get {
				if (Fact_jfieldId == IntPtr.Zero)
					Fact_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Fact", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Fact_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FactSet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='FactSet']"
		[Register ("FactSet")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType FactSet {
			get {
				if (FactSet_jfieldId == IntPtr.Zero)
					FactSet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FactSet", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FactSet_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Image_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Image']"
		[Register ("Image")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Image {
			get {
				if (Image_jfieldId == IntPtr.Zero)
					Image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Image", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Image_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ImageSet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='ImageSet']"
		[Register ("ImageSet")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType ImageSet {
			get {
				if (ImageSet_jfieldId == IntPtr.Zero)
					ImageSet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ImageSet", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ImageSet_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Media_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Media']"
		[Register ("Media")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Media {
			get {
				if (Media_jfieldId == IntPtr.Zero)
					Media_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Media", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Media_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NumberInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='NumberInput']"
		[Register ("NumberInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType NumberInput {
			get {
				if (NumberInput_jfieldId == IntPtr.Zero)
					NumberInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NumberInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NumberInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TextBlock_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='TextBlock']"
		[Register ("TextBlock")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType TextBlock {
			get {
				if (TextBlock_jfieldId == IntPtr.Zero)
					TextBlock_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TextBlock", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TextBlock_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TextInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='TextInput']"
		[Register ("TextInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType TextInput {
			get {
				if (TextInput_jfieldId == IntPtr.Zero)
					TextInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TextInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TextInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TimeInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='TimeInput']"
		[Register ("TimeInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType TimeInput {
			get {
				if (TimeInput_jfieldId == IntPtr.Zero)
					TimeInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TimeInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TimeInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ToggleInput_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='ToggleInput']"
		[Register ("ToggleInput")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType ToggleInput {
			get {
				if (ToggleInput_jfieldId == IntPtr.Zero)
					ToggleInput_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ToggleInput", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ToggleInput_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Unknown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Unknown {
			get {
				if (Unknown_jfieldId == IntPtr.Zero)
					Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Unsupported_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/field[@name='Unsupported']"
		[Register ("Unsupported")]
		public static global::IO.Adaptivecards.Objectmodel.CardElementType Unsupported {
			get {
				if (Unsupported_jfieldId == IntPtr.Zero)
					Unsupported_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unsupported", "Lio/adaptivecards/objectmodel/CardElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unsupported_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType.SwigNext']"
		[global::Android.Runtime.Register ("io/adaptivecards/objectmodel/CardElementType$SwigNext", DoNotGenerateAcw=true)]
		public partial class SwigNext : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/objectmodel/CardElementType$SwigNext", ref java_class_handle);
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
				return JNIEnv.FindClass ("io/adaptivecards/objectmodel/CardElementType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardElementType); }
		}

		internal CardElementType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_swigToEnum_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lio/adaptivecards/objectmodel/CardElementType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.CardElementType SwigToEnum (int p0)
		{
			if (id_swigToEnum_I == IntPtr.Zero)
				id_swigToEnum_I = JNIEnv.GetStaticMethodID (class_ref, "swigToEnum", "(I)Lio/adaptivecards/objectmodel/CardElementType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_swigToEnum_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_swigValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/method[@name='swigValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/CardElementType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.CardElementType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/objectmodel/CardElementType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Adaptivecards.Objectmodel.CardElementType __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CardElementType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CardElementType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/adaptivecards/objectmodel/CardElementType;", "")]
		public static unsafe global::IO.Adaptivecards.Objectmodel.CardElementType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/objectmodel/CardElementType;");
			try {
				return (global::IO.Adaptivecards.Objectmodel.CardElementType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Objectmodel.CardElementType));
			} finally {
			}
		}

	}
}
