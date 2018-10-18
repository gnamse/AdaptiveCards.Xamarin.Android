using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Layout {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/layout/FullscreenVideoLayout", DoNotGenerateAcw=true)]
	public partial class FullscreenVideoLayout : global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView, global::Android.Media.MediaPlayer.IOnPreparedListener, global::Android.Views.View.IOnClickListener, global::Android.Views.View.IOnTouchListener, global::Android.Widget.SeekBar.IOnSeekBarChangeListener {


		static IntPtr TIME_THREAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='TIME_THREAD']"
		[Register ("TIME_THREAD")]
		protected static global::Android.OS.Handler TimeThread {
			get {
				if (TIME_THREAD_jfieldId == IntPtr.Zero)
					TIME_THREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIME_THREAD", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIME_THREAD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TIME_THREAD_jfieldId == IntPtr.Zero)
					TIME_THREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIME_THREAD", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, TIME_THREAD_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_elapsedTimeView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='m_elapsedTimeView']"
		[Register ("m_elapsedTimeView")]
		protected global::Android.Widget.TextView MElapsedTimeView {
			get {
				if (m_elapsedTimeView_jfieldId == IntPtr.Zero)
					m_elapsedTimeView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_elapsedTimeView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_elapsedTimeView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_elapsedTimeView_jfieldId == IntPtr.Zero)
					m_elapsedTimeView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_elapsedTimeView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_elapsedTimeView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_playButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='m_playButton']"
		[Register ("m_playButton")]
		protected global::Android.Widget.ImageButton MPlayButton {
			get {
				if (m_playButton_jfieldId == IntPtr.Zero)
					m_playButton_jfieldId = JNIEnv.GetFieldID (class_ref, "m_playButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_playButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_playButton_jfieldId == IntPtr.Zero)
					m_playButton_jfieldId = JNIEnv.GetFieldID (class_ref, "m_playButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_playButton_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_seekBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='m_seekBar']"
		[Register ("m_seekBar")]
		protected global::Android.Widget.SeekBar MSeekBar {
			get {
				if (m_seekBar_jfieldId == IntPtr.Zero)
					m_seekBar_jfieldId = JNIEnv.GetFieldID (class_ref, "m_seekBar", "Landroid/widget/SeekBar;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_seekBar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_seekBar_jfieldId == IntPtr.Zero)
					m_seekBar_jfieldId = JNIEnv.GetFieldID (class_ref, "m_seekBar", "Landroid/widget/SeekBar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_seekBar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_totalTimeView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='m_totalTimeView']"
		[Register ("m_totalTimeView")]
		protected global::Android.Widget.TextView MTotalTimeView {
			get {
				if (m_totalTimeView_jfieldId == IntPtr.Zero)
					m_totalTimeView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_totalTimeView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_totalTimeView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_totalTimeView_jfieldId == IntPtr.Zero)
					m_totalTimeView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_totalTimeView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_totalTimeView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_touchListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='m_touchListener']"
		[Register ("m_touchListener")]
		protected global::Android.Views.View.IOnTouchListener MTouchListener {
			get {
				if (m_touchListener_jfieldId == IntPtr.Zero)
					m_touchListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_touchListener", "Landroid/view/View$OnTouchListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_touchListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnTouchListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_touchListener_jfieldId == IntPtr.Zero)
					m_touchListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_touchListener", "Landroid/view/View$OnTouchListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_touchListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_videoControlsView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='m_videoControlsView']"
		[Register ("m_videoControlsView")]
		protected global::Android.Views.ViewGroup MVideoControlsView {
			get {
				if (m_videoControlsView_jfieldId == IntPtr.Zero)
					m_videoControlsView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoControlsView", "Landroid/view/ViewGroup;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_videoControlsView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_videoControlsView_jfieldId == IntPtr.Zero)
					m_videoControlsView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoControlsView", "Landroid/view/ViewGroup;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_videoControlsView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr updateTimeRunnable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/field[@name='updateTimeRunnable']"
		[Register ("updateTimeRunnable")]
		protected global::Java.Lang.IRunnable UpdateTimeRunnable {
			get {
				if (updateTimeRunnable_jfieldId == IntPtr.Zero)
					updateTimeRunnable_jfieldId = JNIEnv.GetFieldID (class_ref, "updateTimeRunnable", "Ljava/lang/Runnable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, updateTimeRunnable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (updateTimeRunnable_jfieldId == IntPtr.Zero)
					updateTimeRunnable_jfieldId = JNIEnv.GetFieldID (class_ref, "updateTimeRunnable", "Ljava/lang/Runnable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, updateTimeRunnable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/layout/FullscreenVideoLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FullscreenVideoLayout); }
		}

		protected FullscreenVideoLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/constructor[@name='FullscreenVideoLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe FullscreenVideoLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (FullscreenVideoLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/constructor[@name='FullscreenVideoLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FullscreenVideoLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FullscreenVideoLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/constructor[@name='FullscreenVideoLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FullscreenVideoLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FullscreenVideoLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_hideControls;
#pragma warning disable 0169
		static Delegate GetHideControlsHandler ()
		{
			if (cb_hideControls == null)
				cb_hideControls = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideControls);
			return cb_hideControls;
		}

		static void n_HideControls (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideControls ();
		}
#pragma warning restore 0169

		static IntPtr id_hideControls;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='hideControls' and count(parameter)=0]"
		[Register ("hideControls", "()V", "GetHideControlsHandler")]
		public virtual unsafe void HideControls ()
		{
			if (id_hideControls == IntPtr.Zero)
				id_hideControls = JNIEnv.GetMethodID (class_ref, "hideControls", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideControls);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideControls", "()V"));
			} finally {
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onProgressChanged_Landroid_widget_SeekBar_IZ;
#pragma warning disable 0169
		static Delegate GetOnProgressChanged_Landroid_widget_SeekBar_IZHandler ()
		{
			if (cb_onProgressChanged_Landroid_widget_SeekBar_IZ == null)
				cb_onProgressChanged_Landroid_widget_SeekBar_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnProgressChanged_Landroid_widget_SeekBar_IZ);
			return cb_onProgressChanged_Landroid_widget_SeekBar_IZ;
		}

		static void n_OnProgressChanged_Landroid_widget_SeekBar_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.SeekBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onProgressChanged_Landroid_widget_SeekBar_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='onProgressChanged' and count(parameter)=3 and parameter[1][@type='android.widget.SeekBar'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onProgressChanged", "(Landroid/widget/SeekBar;IZ)V", "GetOnProgressChanged_Landroid_widget_SeekBar_IZHandler")]
		public virtual unsafe void OnProgressChanged (global::Android.Widget.SeekBar p0, int p1, bool p2)
		{
			if (id_onProgressChanged_Landroid_widget_SeekBar_IZ == IntPtr.Zero)
				id_onProgressChanged_Landroid_widget_SeekBar_IZ = JNIEnv.GetMethodID (class_ref, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressChanged_Landroid_widget_SeekBar_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStartTrackingTouch_Landroid_widget_SeekBar_;
#pragma warning disable 0169
		static Delegate GetOnStartTrackingTouch_Landroid_widget_SeekBar_Handler ()
		{
			if (cb_onStartTrackingTouch_Landroid_widget_SeekBar_ == null)
				cb_onStartTrackingTouch_Landroid_widget_SeekBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStartTrackingTouch_Landroid_widget_SeekBar_);
			return cb_onStartTrackingTouch_Landroid_widget_SeekBar_;
		}

		static void n_OnStartTrackingTouch_Landroid_widget_SeekBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.SeekBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStartTrackingTouch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStartTrackingTouch_Landroid_widget_SeekBar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='onStartTrackingTouch' and count(parameter)=1 and parameter[1][@type='android.widget.SeekBar']]"
		[Register ("onStartTrackingTouch", "(Landroid/widget/SeekBar;)V", "GetOnStartTrackingTouch_Landroid_widget_SeekBar_Handler")]
		public virtual unsafe void OnStartTrackingTouch (global::Android.Widget.SeekBar p0)
		{
			if (id_onStartTrackingTouch_Landroid_widget_SeekBar_ == IntPtr.Zero)
				id_onStartTrackingTouch_Landroid_widget_SeekBar_ = JNIEnv.GetMethodID (class_ref, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartTrackingTouch_Landroid_widget_SeekBar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStopTrackingTouch_Landroid_widget_SeekBar_;
#pragma warning disable 0169
		static Delegate GetOnStopTrackingTouch_Landroid_widget_SeekBar_Handler ()
		{
			if (cb_onStopTrackingTouch_Landroid_widget_SeekBar_ == null)
				cb_onStopTrackingTouch_Landroid_widget_SeekBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStopTrackingTouch_Landroid_widget_SeekBar_);
			return cb_onStopTrackingTouch_Landroid_widget_SeekBar_;
		}

		static void n_OnStopTrackingTouch_Landroid_widget_SeekBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.SeekBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStopTrackingTouch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStopTrackingTouch_Landroid_widget_SeekBar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='onStopTrackingTouch' and count(parameter)=1 and parameter[1][@type='android.widget.SeekBar']]"
		[Register ("onStopTrackingTouch", "(Landroid/widget/SeekBar;)V", "GetOnStopTrackingTouch_Landroid_widget_SeekBar_Handler")]
		public virtual unsafe void OnStopTrackingTouch (global::Android.Widget.SeekBar p0)
		{
			if (id_onStopTrackingTouch_Landroid_widget_SeekBar_ == IntPtr.Zero)
				id_onStopTrackingTouch_Landroid_widget_SeekBar_ = JNIEnv.GetMethodID (class_ref, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopTrackingTouch_Landroid_widget_SeekBar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_showControls;
#pragma warning disable 0169
		static Delegate GetShowControlsHandler ()
		{
			if (cb_showControls == null)
				cb_showControls = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowControls);
			return cb_showControls;
		}

		static void n_ShowControls (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowControls ();
		}
#pragma warning restore 0169

		static IntPtr id_showControls;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='showControls' and count(parameter)=0]"
		[Register ("showControls", "()V", "GetShowControlsHandler")]
		public virtual unsafe void ShowControls ()
		{
			if (id_showControls == IntPtr.Zero)
				id_showControls = JNIEnv.GetMethodID (class_ref, "showControls", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showControls);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showControls", "()V"));
			} finally {
			}
		}

		static Delegate cb_startCounter;
#pragma warning disable 0169
		static Delegate GetStartCounterHandler ()
		{
			if (cb_startCounter == null)
				cb_startCounter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartCounter);
			return cb_startCounter;
		}

		static void n_StartCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCounter ();
		}
#pragma warning restore 0169

		static IntPtr id_startCounter;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='startCounter' and count(parameter)=0]"
		[Register ("startCounter", "()V", "GetStartCounterHandler")]
		protected virtual unsafe void StartCounter ()
		{
			if (id_startCounter == IntPtr.Zero)
				id_startCounter = JNIEnv.GetMethodID (class_ref, "startCounter", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startCounter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startCounter", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopCounter;
#pragma warning disable 0169
		static Delegate GetStopCounterHandler ()
		{
			if (cb_stopCounter == null)
				cb_stopCounter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopCounter);
			return cb_stopCounter;
		}

		static void n_StopCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCounter ();
		}
#pragma warning restore 0169

		static IntPtr id_stopCounter;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='stopCounter' and count(parameter)=0]"
		[Register ("stopCounter", "()V", "GetStopCounterHandler")]
		protected virtual unsafe void StopCounter ()
		{
			if (id_stopCounter == IntPtr.Zero)
				id_stopCounter = JNIEnv.GetMethodID (class_ref, "stopCounter", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopCounter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopCounter", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateControls;
#pragma warning disable 0169
		static Delegate GetUpdateControlsHandler ()
		{
			if (cb_updateControls == null)
				cb_updateControls = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateControls);
			return cb_updateControls;
		}

		static void n_UpdateControls (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateControls ();
		}
#pragma warning restore 0169

		static IntPtr id_updateControls;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='updateControls' and count(parameter)=0]"
		[Register ("updateControls", "()V", "GetUpdateControlsHandler")]
		protected virtual unsafe void UpdateControls ()
		{
			if (id_updateControls == IntPtr.Zero)
				id_updateControls = JNIEnv.GetMethodID (class_ref, "updateControls", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateControls);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateControls", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateCounter;
#pragma warning disable 0169
		static Delegate GetUpdateCounterHandler ()
		{
			if (cb_updateCounter == null)
				cb_updateCounter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateCounter);
			return cb_updateCounter;
		}

		static void n_UpdateCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCounter ();
		}
#pragma warning restore 0169

		static IntPtr id_updateCounter;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoLayout']/method[@name='updateCounter' and count(parameter)=0]"
		[Register ("updateCounter", "()V", "GetUpdateCounterHandler")]
		protected virtual unsafe void UpdateCounter ()
		{
			if (id_updateCounter == IntPtr.Zero)
				id_updateCounter = JNIEnv.GetMethodID (class_ref, "updateCounter", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCounter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCounter", "()V"));
			} finally {
			}
		}

	}
}
