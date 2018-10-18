using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.adaptivecards.renderer']/interface[@name='IMediaDataSourceOnPreparedListener']"
	[Register ("io/adaptivecards/renderer/IMediaDataSourceOnPreparedListener", "", "IO.Adaptivecards.Renderer.IMediaDataSourceOnPreparedListenerInvoker")]
	public partial interface IMediaDataSourceOnPreparedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer']/interface[@name='IMediaDataSourceOnPreparedListener']/method[@name='prepareMediaPlayer' and count(parameter)=0]"
		[Register ("prepareMediaPlayer", "()V", "GetPrepareMediaPlayerHandler:IO.Adaptivecards.Renderer.IMediaDataSourceOnPreparedListenerInvoker, AdaptiveCards.Xamarin.Android")]
		void PrepareMediaPlayer ();

	}

	[global::Android.Runtime.Register ("io/adaptivecards/renderer/IMediaDataSourceOnPreparedListener", DoNotGenerateAcw=true)]
	internal class IMediaDataSourceOnPreparedListenerInvoker : global::Java.Lang.Object, IMediaDataSourceOnPreparedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/adaptivecards/renderer/IMediaDataSourceOnPreparedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaDataSourceOnPreparedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaDataSourceOnPreparedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaDataSourceOnPreparedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.adaptivecards.renderer.IMediaDataSourceOnPreparedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaDataSourceOnPreparedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_prepareMediaPlayer;
#pragma warning disable 0169
		static Delegate GetPrepareMediaPlayerHandler ()
		{
			if (cb_prepareMediaPlayer == null)
				cb_prepareMediaPlayer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareMediaPlayer);
			return cb_prepareMediaPlayer;
		}

		static void n_PrepareMediaPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.IMediaDataSourceOnPreparedListener __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.IMediaDataSourceOnPreparedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareMediaPlayer ();
		}
#pragma warning restore 0169

		IntPtr id_prepareMediaPlayer;
		public unsafe void PrepareMediaPlayer ()
		{
			if (id_prepareMediaPlayer == IntPtr.Zero)
				id_prepareMediaPlayer = JNIEnv.GetMethodID (class_ref, "prepareMediaPlayer", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareMediaPlayer);
		}

	}

	[global::Android.Runtime.Register ("mono/io/adaptivecards/renderer/IMediaDataSourceOnPreparedListenerImplementor")]
	internal sealed partial class IMediaDataSourceOnPreparedListenerImplementor : global::Java.Lang.Object, IMediaDataSourceOnPreparedListener {

		object sender;

		public IMediaDataSourceOnPreparedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/io/adaptivecards/renderer/IMediaDataSourceOnPreparedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void PrepareMediaPlayer ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IMediaDataSourceOnPreparedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
