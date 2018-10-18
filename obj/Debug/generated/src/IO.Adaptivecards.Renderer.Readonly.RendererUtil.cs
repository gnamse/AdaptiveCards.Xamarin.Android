using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Readonly {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/readonly/RendererUtil", DoNotGenerateAcw=true)]
	public partial class RendererUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil.UlTagHandler']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/readonly/RendererUtil$UlTagHandler", DoNotGenerateAcw=true)]
		public partial class UlTagHandler : global::Java.Lang.Object, global::Android.Text.Html.ITagHandler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/readonly/RendererUtil$UlTagHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UlTagHandler); }
			}

			protected UlTagHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil.UlTagHandler']/constructor[@name='RendererUtil.UlTagHandler' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UlTagHandler ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (UlTagHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_;
#pragma warning disable 0169
			static Delegate GetHandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_Handler ()
			{
				if (cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_ == null)
					cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_HandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_);
				return cb_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_;
			}

			static void n_HandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::IO.Adaptivecards.Renderer.Readonly.RendererUtil.UlTagHandler __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Readonly.RendererUtil.UlTagHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Text.IEditable p2 = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Org.Xml.Sax.IXMLReader p3 = (global::Org.Xml.Sax.IXMLReader)global::Java.Lang.Object.GetObject<global::Org.Xml.Sax.IXMLReader> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.HandleTag (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil.UlTagHandler']/method[@name='handleTag' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.text.Editable'] and parameter[4][@type='org.xml.sax.XMLReader']]"
			[Register ("handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", "GetHandleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_Handler")]
			public virtual unsafe void HandleTag (bool p0, string p1, global::Android.Text.IEditable p2, global::Org.Xml.Sax.IXMLReader p3)
			{
				if (id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_ == IntPtr.Zero)
					id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_ = JNIEnv.GetMethodID (class_ref, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleTag_ZLjava_lang_String_Landroid_text_Editable_Lorg_xml_sax_XMLReader_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/readonly/RendererUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RendererUtil); }
		}

		protected RendererUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil']/constructor[@name='RendererUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RendererUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RendererUtil)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_handleSpecialText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil']/method[@name='handleSpecialText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleSpecialText", "(Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence HandleSpecialTextFormatted (string p0)
		{
			if (id_handleSpecialText_Ljava_lang_String_ == IntPtr.Zero)
				id_handleSpecialText_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "handleSpecialText", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_handleSpecialText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static string HandleSpecialText (string p0)
		{
			global::Java.Lang.ICharSequence __result = HandleSpecialTextFormatted (p0);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

		static IntPtr id_trimHtmlString_Landroid_text_Spanned_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='RendererUtil']/method[@name='trimHtmlString' and count(parameter)=1 and parameter[1][@type='android.text.Spanned']]"
		[Register ("trimHtmlString", "(Landroid/text/Spanned;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence TrimHtmlStringFormatted (global::Android.Text.ISpanned p0)
		{
			if (id_trimHtmlString_Landroid_text_Spanned_ == IntPtr.Zero)
				id_trimHtmlString_Landroid_text_Spanned_ = JNIEnv.GetStaticMethodID (class_ref, "trimHtmlString", "(Landroid/text/Spanned;)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimHtmlString_Landroid_text_Spanned_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		public static string TrimHtmlString (global::Android.Text.ISpanned p0)
		{
			global::Java.Lang.ICharSequence __result = TrimHtmlStringFormatted (p0);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

	}
}
