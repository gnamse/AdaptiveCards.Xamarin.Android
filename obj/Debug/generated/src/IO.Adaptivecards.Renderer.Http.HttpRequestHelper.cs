using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/http/HttpRequestHelper", DoNotGenerateAcw=true)]
	public abstract partial class HttpRequestHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/field[@name='HTTP_METHOD_GET']"
		[Register ("HTTP_METHOD_GET")]
		public const string HttpMethodGet = (string) "GET";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/field[@name='HTTP_METHOD_POST']"
		[Register ("HTTP_METHOD_POST")]
		public const string HttpMethodPost = (string) "POST";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/field[@name='HTTP_METHOD_PUT']"
		[Register ("HTTP_METHOD_PUT")]
		public const string HttpMethodPut = (string) "PUT";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/http/HttpRequestHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequestHelper); }
		}

		protected HttpRequestHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/constructor[@name='HttpRequestHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpRequestHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpRequestHelper)) {
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

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/util/Map;)[B", "")]
		public static unsafe byte[] Get (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_get_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/util/Map;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/method[@name='post' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("post", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Post (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, string p2)
		{
			if (id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Put (string p0, global::System.Collections.Generic.IDictionary<string, string> p1, string p2)
		{
			if (id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_put_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_query_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("query", "(Ljava/lang/String;)V", "")]
		public static unsafe void Query (string p0)
		{
			if (id_query_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "query", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_query_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_query_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.http']/class[@name='HttpRequestHelper']/method[@name='query' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("query", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void Query (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_query_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_query_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "query", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_query_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/http/HttpRequestHelper", DoNotGenerateAcw=true)]
	internal partial class HttpRequestHelperInvoker : HttpRequestHelper {

		public HttpRequestHelperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequestHelperInvoker); }
		}

	}

}
