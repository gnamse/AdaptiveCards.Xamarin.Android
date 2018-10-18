using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Adaptivecards.Renderer.Layout {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']"
	[global::Android.Runtime.Register ("io/adaptivecards/renderer/layout/FullscreenVideoView", DoNotGenerateAcw=true)]
	public partial class FullscreenVideoView : global::Android.Widget.FrameLayout, global::Android.Media.MediaPlayer.IOnBufferingUpdateListener, global::Android.Media.MediaPlayer.IOnCompletionListener, global::Android.Media.MediaPlayer.IOnErrorListener, global::Android.Media.MediaPlayer.IOnInfoListener, global::Android.Media.MediaPlayer.IOnPreparedListener, global::Android.Media.MediaPlayer.IOnSeekCompleteListener, global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener, global::Android.Views.TextureView.ISurfaceTextureListener {


		static IntPtr m_bufferingUpdateListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_bufferingUpdateListener']"
		[Register ("m_bufferingUpdateListener")]
		protected global::Android.Media.MediaPlayer.IOnBufferingUpdateListener MBufferingUpdateListener {
			get {
				if (m_bufferingUpdateListener_jfieldId == IntPtr.Zero)
					m_bufferingUpdateListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_bufferingUpdateListener", "Landroid/media/MediaPlayer$OnBufferingUpdateListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_bufferingUpdateListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnBufferingUpdateListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_bufferingUpdateListener_jfieldId == IntPtr.Zero)
					m_bufferingUpdateListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_bufferingUpdateListener", "Landroid/media/MediaPlayer$OnBufferingUpdateListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_bufferingUpdateListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_completionListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_completionListener']"
		[Register ("m_completionListener")]
		protected global::Android.Media.MediaPlayer.IOnCompletionListener MCompletionListener {
			get {
				if (m_completionListener_jfieldId == IntPtr.Zero)
					m_completionListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_completionListener", "Landroid/media/MediaPlayer$OnCompletionListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_completionListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnCompletionListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_completionListener_jfieldId == IntPtr.Zero)
					m_completionListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_completionListener", "Landroid/media/MediaPlayer$OnCompletionListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_completionListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_context']"
		[Register ("m_context")]
		protected global::Android.Content.Context MContext {
			get {
				if (m_context_jfieldId == IntPtr.Zero)
					m_context_jfieldId = JNIEnv.GetFieldID (class_ref, "m_context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_context_jfieldId == IntPtr.Zero)
					m_context_jfieldId = JNIEnv.GetFieldID (class_ref, "m_context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_currentState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_currentState']"
		[Register ("m_currentState")]
		protected global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State MCurrentState {
			get {
				if (m_currentState_jfieldId == IntPtr.Zero)
					m_currentState_jfieldId = JNIEnv.GetFieldID (class_ref, "m_currentState", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_currentState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_currentState_jfieldId == IntPtr.Zero)
					m_currentState_jfieldId = JNIEnv.GetFieldID (class_ref, "m_currentState", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_currentState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_errorListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_errorListener']"
		[Register ("m_errorListener")]
		protected global::Android.Media.MediaPlayer.IOnErrorListener MErrorListener {
			get {
				if (m_errorListener_jfieldId == IntPtr.Zero)
					m_errorListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_errorListener", "Landroid/media/MediaPlayer$OnErrorListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_errorListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnErrorListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_errorListener_jfieldId == IntPtr.Zero)
					m_errorListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_errorListener", "Landroid/media/MediaPlayer$OnErrorListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_errorListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_infoListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_infoListener']"
		[Register ("m_infoListener")]
		protected global::Android.Media.MediaPlayer.IOnInfoListener MInfoListener {
			get {
				if (m_infoListener_jfieldId == IntPtr.Zero)
					m_infoListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_infoListener", "Landroid/media/MediaPlayer$OnInfoListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_infoListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnInfoListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_infoListener_jfieldId == IntPtr.Zero)
					m_infoListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_infoListener", "Landroid/media/MediaPlayer$OnInfoListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_infoListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_initialConfigOrientation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_initialConfigOrientation']"
		[Register ("m_initialConfigOrientation")]
		protected int MInitialConfigOrientation {
			get {
				if (m_initialConfigOrientation_jfieldId == IntPtr.Zero)
					m_initialConfigOrientation_jfieldId = JNIEnv.GetFieldID (class_ref, "m_initialConfigOrientation", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_initialConfigOrientation_jfieldId);
			}
			set {
				if (m_initialConfigOrientation_jfieldId == IntPtr.Zero)
					m_initialConfigOrientation_jfieldId = JNIEnv.GetFieldID (class_ref, "m_initialConfigOrientation", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_initialConfigOrientation_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_initialMovieHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_initialMovieHeight']"
		[Register ("m_initialMovieHeight")]
		protected int MInitialMovieHeight {
			get {
				if (m_initialMovieHeight_jfieldId == IntPtr.Zero)
					m_initialMovieHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "m_initialMovieHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_initialMovieHeight_jfieldId);
			}
			set {
				if (m_initialMovieHeight_jfieldId == IntPtr.Zero)
					m_initialMovieHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "m_initialMovieHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_initialMovieHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_initialMovieWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_initialMovieWidth']"
		[Register ("m_initialMovieWidth")]
		protected int MInitialMovieWidth {
			get {
				if (m_initialMovieWidth_jfieldId == IntPtr.Zero)
					m_initialMovieWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "m_initialMovieWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_initialMovieWidth_jfieldId);
			}
			set {
				if (m_initialMovieWidth_jfieldId == IntPtr.Zero)
					m_initialMovieWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "m_initialMovieWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_initialMovieWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_isAudioOnly_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_isAudioOnly']"
		[Register ("m_isAudioOnly")]
		protected bool MIsAudioOnly {
			get {
				if (m_isAudioOnly_jfieldId == IntPtr.Zero)
					m_isAudioOnly_jfieldId = JNIEnv.GetFieldID (class_ref, "m_isAudioOnly", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, m_isAudioOnly_jfieldId);
			}
			set {
				if (m_isAudioOnly_jfieldId == IntPtr.Zero)
					m_isAudioOnly_jfieldId = JNIEnv.GetFieldID (class_ref, "m_isAudioOnly", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_isAudioOnly_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_lastState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_lastState']"
		[Register ("m_lastState")]
		protected global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State MLastState {
			get {
				if (m_lastState_jfieldId == IntPtr.Zero)
					m_lastState_jfieldId = JNIEnv.GetFieldID (class_ref, "m_lastState", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_lastState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_lastState_jfieldId == IntPtr.Zero)
					m_lastState_jfieldId = JNIEnv.GetFieldID (class_ref, "m_lastState", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_lastState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_mediaPlayer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_mediaPlayer']"
		[Register ("m_mediaPlayer")]
		protected global::Android.Media.MediaPlayer MMediaPlayer {
			get {
				if (m_mediaPlayer_jfieldId == IntPtr.Zero)
					m_mediaPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "m_mediaPlayer", "Landroid/media/MediaPlayer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_mediaPlayer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_mediaPlayer_jfieldId == IntPtr.Zero)
					m_mediaPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "m_mediaPlayer", "Landroid/media/MediaPlayer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_mediaPlayer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_preparedListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_preparedListener']"
		[Register ("m_preparedListener")]
		protected global::Android.Media.MediaPlayer.IOnPreparedListener MPreparedListener {
			get {
				if (m_preparedListener_jfieldId == IntPtr.Zero)
					m_preparedListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_preparedListener", "Landroid/media/MediaPlayer$OnPreparedListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_preparedListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnPreparedListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_preparedListener_jfieldId == IntPtr.Zero)
					m_preparedListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_preparedListener", "Landroid/media/MediaPlayer$OnPreparedListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_preparedListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_seekCompleteListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_seekCompleteListener']"
		[Register ("m_seekCompleteListener")]
		protected global::Android.Media.MediaPlayer.IOnSeekCompleteListener MSeekCompleteListener {
			get {
				if (m_seekCompleteListener_jfieldId == IntPtr.Zero)
					m_seekCompleteListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_seekCompleteListener", "Landroid/media/MediaPlayer$OnSeekCompleteListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_seekCompleteListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnSeekCompleteListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_seekCompleteListener_jfieldId == IntPtr.Zero)
					m_seekCompleteListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_seekCompleteListener", "Landroid/media/MediaPlayer$OnSeekCompleteListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_seekCompleteListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_shouldAutoplay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_shouldAutoplay']"
		[Register ("m_shouldAutoplay")]
		protected bool MShouldAutoplay {
			get {
				if (m_shouldAutoplay_jfieldId == IntPtr.Zero)
					m_shouldAutoplay_jfieldId = JNIEnv.GetFieldID (class_ref, "m_shouldAutoplay", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, m_shouldAutoplay_jfieldId);
			}
			set {
				if (m_shouldAutoplay_jfieldId == IntPtr.Zero)
					m_shouldAutoplay_jfieldId = JNIEnv.GetFieldID (class_ref, "m_shouldAutoplay", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_shouldAutoplay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_surfaceIsReady_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_surfaceIsReady']"
		[Register ("m_surfaceIsReady")]
		protected bool MSurfaceIsReady {
			get {
				if (m_surfaceIsReady_jfieldId == IntPtr.Zero)
					m_surfaceIsReady_jfieldId = JNIEnv.GetFieldID (class_ref, "m_surfaceIsReady", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, m_surfaceIsReady_jfieldId);
			}
			set {
				if (m_surfaceIsReady_jfieldId == IntPtr.Zero)
					m_surfaceIsReady_jfieldId = JNIEnv.GetFieldID (class_ref, "m_surfaceIsReady", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_surfaceIsReady_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_textureView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_textureView']"
		[Register ("m_textureView")]
		protected global::Android.Views.TextureView MTextureView {
			get {
				if (m_textureView_jfieldId == IntPtr.Zero)
					m_textureView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_textureView", "Landroid/view/TextureView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_textureView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_textureView_jfieldId == IntPtr.Zero)
					m_textureView_jfieldId = JNIEnv.GetFieldID (class_ref, "m_textureView", "Landroid/view/TextureView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_textureView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_videoIsReady_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_videoIsReady']"
		[Register ("m_videoIsReady")]
		protected bool MVideoIsReady {
			get {
				if (m_videoIsReady_jfieldId == IntPtr.Zero)
					m_videoIsReady_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoIsReady", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, m_videoIsReady_jfieldId);
			}
			set {
				if (m_videoIsReady_jfieldId == IntPtr.Zero)
					m_videoIsReady_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoIsReady", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_videoIsReady_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_videoPath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_videoPath']"
		[Register ("m_videoPath")]
		protected string MVideoPath {
			get {
				if (m_videoPath_jfieldId == IntPtr.Zero)
					m_videoPath_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoPath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_videoPath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_videoPath_jfieldId == IntPtr.Zero)
					m_videoPath_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoPath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_videoPath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_videoSizeChangedListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_videoSizeChangedListener']"
		[Register ("m_videoSizeChangedListener")]
		protected global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener MVideoSizeChangedListener {
			get {
				if (m_videoSizeChangedListener_jfieldId == IntPtr.Zero)
					m_videoSizeChangedListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoSizeChangedListener", "Landroid/media/MediaPlayer$OnVideoSizeChangedListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_videoSizeChangedListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_videoSizeChangedListener_jfieldId == IntPtr.Zero)
					m_videoSizeChangedListener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoSizeChangedListener", "Landroid/media/MediaPlayer$OnVideoSizeChangedListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_videoSizeChangedListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_videoUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/field[@name='m_videoUri']"
		[Register ("m_videoUri")]
		protected global::Android.Net.Uri MVideoUri {
			get {
				if (m_videoUri_jfieldId == IntPtr.Zero)
					m_videoUri_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoUri", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_videoUri_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_videoUri_jfieldId == IntPtr.Zero)
					m_videoUri_jfieldId = JNIEnv.GetFieldID (class_ref, "m_videoUri", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_videoUri_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']"
		[global::Android.Runtime.Register ("io/adaptivecards/renderer/layout/FullscreenVideoView$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr END_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='END']"
			[Register ("END")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State End {
				get {
					if (END_jfieldId == IntPtr.Zero)
						END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IDLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='IDLE']"
			[Register ("IDLE")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Idle {
				get {
					if (IDLE_jfieldId == IntPtr.Zero)
						IDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDLE", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INITIALIZED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='INITIALIZED']"
			[Register ("INITIALIZED")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Initialized {
				get {
					if (INITIALIZED_jfieldId == IntPtr.Zero)
						INITIALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZED", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYBACKCOMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='PLAYBACKCOMPLETED']"
			[Register ("PLAYBACKCOMPLETED")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Playbackcompleted {
				get {
					if (PLAYBACKCOMPLETED_jfieldId == IntPtr.Zero)
						PLAYBACKCOMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYBACKCOMPLETED", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYBACKCOMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREPARED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='PREPARED']"
			[Register ("PREPARED")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Prepared {
				get {
					if (PREPARED_jfieldId == IntPtr.Zero)
						PREPARED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREPARED", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREPARED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREPARING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='PREPARING']"
			[Register ("PREPARING")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Preparing {
				get {
					if (PREPARING_jfieldId == IntPtr.Zero)
						PREPARING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREPARING", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREPARING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Started {
				get {
					if (STARTED_jfieldId == IntPtr.Zero)
						STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STOPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State Stopped {
				get {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/adaptivecards/renderer/layout/FullscreenVideoView$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;", "")]
			public static unsafe global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State __ret = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;", "")]
			public static unsafe global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				try {
					return (global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/adaptivecards/renderer/layout/FullscreenVideoView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FullscreenVideoView); }
		}

		protected FullscreenVideoView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/constructor[@name='FullscreenVideoView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe FullscreenVideoView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (FullscreenVideoView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/constructor[@name='FullscreenVideoView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FullscreenVideoView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FullscreenVideoView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/constructor[@name='FullscreenVideoView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FullscreenVideoView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FullscreenVideoView)) {
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

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static int n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public virtual unsafe int CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()I", "GetGetCurrentPositionHandler")]
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentState;
#pragma warning disable 0169
		static Delegate GetGetCurrentStateHandler ()
		{
			if (cb_getCurrentState == null)
				cb_getCurrentState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentState);
			return cb_getCurrentState;
		}

		static IntPtr n_GetCurrentState (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentState);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentState;
		public virtual unsafe global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State CurrentState {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='getCurrentState' and count(parameter)=0]"
			[Register ("getCurrentState", "()Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;", "GetGetCurrentStateHandler")]
			get {
				if (id_getCurrentState == IntPtr.Zero)
					id_getCurrentState = JNIEnv.GetMethodID (class_ref, "getCurrentState", "()Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView.State> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentState", "()Lio/adaptivecards/renderer/layout/FullscreenVideoView$State;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying;
		public virtual unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler")]
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlaying", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLooping;
#pragma warning disable 0169
		static Delegate GetIsLoopingHandler ()
		{
			if (cb_isLooping == null)
				cb_isLooping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLooping);
			return cb_isLooping;
		}

		static bool n_IsLooping (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Looping;
		}
#pragma warning restore 0169

		static Delegate cb_setLooping_Z;
#pragma warning disable 0169
		static Delegate GetSetLooping_ZHandler ()
		{
			if (cb_setLooping_Z == null)
				cb_setLooping_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLooping_Z);
			return cb_setLooping_Z;
		}

		static void n_SetLooping_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Looping = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isLooping;
		static IntPtr id_setLooping_Z;
		public virtual unsafe bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='isLooping' and count(parameter)=0]"
			[Register ("isLooping", "()Z", "GetIsLoopingHandler")]
			get {
				if (id_isLooping == IntPtr.Zero)
					id_isLooping = JNIEnv.GetMethodID (class_ref, "isLooping", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLooping);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLooping", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLooping", "(Z)V", "GetSetLooping_ZHandler")]
			set {
				if (id_setLooping_Z == IntPtr.Zero)
					id_setLooping_Z = JNIEnv.GetMethodID (class_ref, "setLooping", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLooping_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLooping", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShouldAutoplay;
#pragma warning disable 0169
		static Delegate GetIsShouldAutoplayHandler ()
		{
			if (cb_isShouldAutoplay == null)
				cb_isShouldAutoplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShouldAutoplay);
			return cb_isShouldAutoplay;
		}

		static bool n_IsShouldAutoplay (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldAutoplay;
		}
#pragma warning restore 0169

		static Delegate cb_setShouldAutoplay_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldAutoplay_ZHandler ()
		{
			if (cb_setShouldAutoplay_Z == null)
				cb_setShouldAutoplay_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldAutoplay_Z);
			return cb_setShouldAutoplay_Z;
		}

		static void n_SetShouldAutoplay_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldAutoplay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShouldAutoplay;
		static IntPtr id_setShouldAutoplay_Z;
		public virtual unsafe bool ShouldAutoplay {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='isShouldAutoplay' and count(parameter)=0]"
			[Register ("isShouldAutoplay", "()Z", "GetIsShouldAutoplayHandler")]
			get {
				if (id_isShouldAutoplay == IntPtr.Zero)
					id_isShouldAutoplay = JNIEnv.GetMethodID (class_ref, "isShouldAutoplay", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShouldAutoplay);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShouldAutoplay", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setShouldAutoplay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldAutoplay", "(Z)V", "GetSetShouldAutoplay_ZHandler")]
			set {
				if (id_setShouldAutoplay_Z == IntPtr.Zero)
					id_setShouldAutoplay_Z = JNIEnv.GetMethodID (class_ref, "setShouldAutoplay", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShouldAutoplay_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAutoplay", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoHeight;
#pragma warning disable 0169
		static Delegate GetGetVideoHeightHandler ()
		{
			if (cb_getVideoHeight == null)
				cb_getVideoHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoHeight);
			return cb_getVideoHeight;
		}

		static int n_GetVideoHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoHeight;
		public virtual unsafe int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()I", "GetGetVideoHeightHandler")]
			get {
				if (id_getVideoHeight == IntPtr.Zero)
					id_getVideoHeight = JNIEnv.GetMethodID (class_ref, "getVideoHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoWidth;
#pragma warning disable 0169
		static Delegate GetGetVideoWidthHandler ()
		{
			if (cb_getVideoWidth == null)
				cb_getVideoWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoWidth);
			return cb_getVideoWidth;
		}

		static int n_GetVideoWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoWidth;
		public virtual unsafe int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()I", "GetGetVideoWidthHandler")]
			get {
				if (id_getVideoWidth == IntPtr.Zero)
					id_getVideoWidth = JNIEnv.GetMethodID (class_ref, "getVideoWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_initObjects;
#pragma warning disable 0169
		static Delegate GetInitObjectsHandler ()
		{
			if (cb_initObjects == null)
				cb_initObjects = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitObjects);
			return cb_initObjects;
		}

		static void n_InitObjects (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitObjects ();
		}
#pragma warning restore 0169

		static IntPtr id_initObjects;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='initObjects' and count(parameter)=0]"
		[Register ("initObjects", "()V", "GetInitObjectsHandler")]
		protected virtual unsafe void InitObjects ()
		{
			if (id_initObjects == IntPtr.Zero)
				id_initObjects = JNIEnv.GetMethodID (class_ref, "initObjects", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initObjects);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initObjects", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBufferingUpdate_Landroid_media_MediaPlayer_I;
#pragma warning disable 0169
		static Delegate GetOnBufferingUpdate_Landroid_media_MediaPlayer_IHandler ()
		{
			if (cb_onBufferingUpdate_Landroid_media_MediaPlayer_I == null)
				cb_onBufferingUpdate_Landroid_media_MediaPlayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBufferingUpdate_Landroid_media_MediaPlayer_I);
			return cb_onBufferingUpdate_Landroid_media_MediaPlayer_I;
		}

		static void n_OnBufferingUpdate_Landroid_media_MediaPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferingUpdate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBufferingUpdate_Landroid_media_MediaPlayer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onBufferingUpdate' and count(parameter)=2 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int']]"
		[Register ("onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", "GetOnBufferingUpdate_Landroid_media_MediaPlayer_IHandler")]
		public virtual unsafe void OnBufferingUpdate (global::Android.Media.MediaPlayer p0, int p1)
		{
			if (id_onBufferingUpdate_Landroid_media_MediaPlayer_I == IntPtr.Zero)
				id_onBufferingUpdate_Landroid_media_MediaPlayer_I = JNIEnv.GetMethodID (class_ref, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferingUpdate_Landroid_media_MediaPlayer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCompletion_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnCompletion_Landroid_media_MediaPlayer_Handler ()
		{
			if (cb_onCompletion_Landroid_media_MediaPlayer_ == null)
				cb_onCompletion_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompletion_Landroid_media_MediaPlayer_);
			return cb_onCompletion_Landroid_media_MediaPlayer_;
		}

		static void n_OnCompletion_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCompletion_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
		[Register ("onCompletion", "(Landroid/media/MediaPlayer;)V", "GetOnCompletion_Landroid_media_MediaPlayer_Handler")]
		public virtual unsafe void OnCompletion (global::Android.Media.MediaPlayer p0)
		{
			if (id_onCompletion_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				id_onCompletion_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onCompletion", "(Landroid/media/MediaPlayer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletion_Landroid_media_MediaPlayer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompletion", "(Landroid/media/MediaPlayer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onError_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnError_Landroid_media_MediaPlayer_IIHandler ()
		{
			if (cb_onError_Landroid_media_MediaPlayer_II == null)
				cb_onError_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnError_Landroid_media_MediaPlayer_II);
			return cb_onError_Landroid_media_MediaPlayer_II;
		}

		static bool n_OnError_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaError p1 = (global::Android.Media.MediaError) native_p1;
			bool __ret = __this.OnError (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onError_Landroid_media_MediaPlayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onError", "(Landroid/media/MediaPlayer;II)Z", "GetOnError_Landroid_media_MediaPlayer_IIHandler")]
		public virtual unsafe bool OnError (global::Android.Media.MediaPlayer p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaError p1, int p2)
		{
			if (id_onError_Landroid_media_MediaPlayer_II == IntPtr.Zero)
				id_onError_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onError", "(Landroid/media/MediaPlayer;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onError_Landroid_media_MediaPlayer_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Landroid/media/MediaPlayer;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onInfo_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnInfo_Landroid_media_MediaPlayer_IIHandler ()
		{
			if (cb_onInfo_Landroid_media_MediaPlayer_II == null)
				cb_onInfo_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnInfo_Landroid_media_MediaPlayer_II);
			return cb_onInfo_Landroid_media_MediaPlayer_II;
		}

		static bool n_OnInfo_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaInfo p1 = (global::Android.Media.MediaInfo) native_p1;
			bool __ret = __this.OnInfo (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onInfo_Landroid_media_MediaPlayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onInfo' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onInfo", "(Landroid/media/MediaPlayer;II)Z", "GetOnInfo_Landroid_media_MediaPlayer_IIHandler")]
		public virtual unsafe bool OnInfo (global::Android.Media.MediaPlayer p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaInfo p1, int p2)
		{
			if (id_onInfo_Landroid_media_MediaPlayer_II == IntPtr.Zero)
				id_onInfo_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onInfo", "(Landroid/media/MediaPlayer;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onInfo_Landroid_media_MediaPlayer_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInfo", "(Landroid/media/MediaPlayer;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onPrepared_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnPrepared_Landroid_media_MediaPlayer_Handler ()
		{
			if (cb_onPrepared_Landroid_media_MediaPlayer_ == null)
				cb_onPrepared_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepared_Landroid_media_MediaPlayer_);
			return cb_onPrepared_Landroid_media_MediaPlayer_;
		}

		static void n_OnPrepared_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPrepared_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
		[Register ("onPrepared", "(Landroid/media/MediaPlayer;)V", "GetOnPrepared_Landroid_media_MediaPlayer_Handler")]
		public virtual unsafe void OnPrepared (global::Android.Media.MediaPlayer p0)
		{
			if (id_onPrepared_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				id_onPrepared_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onPrepared", "(Landroid/media/MediaPlayer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepared_Landroid_media_MediaPlayer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepared", "(Landroid/media/MediaPlayer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onSeekComplete_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnSeekComplete_Landroid_media_MediaPlayer_Handler ()
		{
			if (cb_onSeekComplete_Landroid_media_MediaPlayer_ == null)
				cb_onSeekComplete_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSeekComplete_Landroid_media_MediaPlayer_);
			return cb_onSeekComplete_Landroid_media_MediaPlayer_;
		}

		static void n_OnSeekComplete_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSeekComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSeekComplete_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onSeekComplete' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
		[Register ("onSeekComplete", "(Landroid/media/MediaPlayer;)V", "GetOnSeekComplete_Landroid_media_MediaPlayer_Handler")]
		public virtual unsafe void OnSeekComplete (global::Android.Media.MediaPlayer p0)
		{
			if (id_onSeekComplete_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				id_onSeekComplete_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onSeekComplete", "(Landroid/media/MediaPlayer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSeekComplete_Landroid_media_MediaPlayer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSeekComplete", "(Landroid/media/MediaPlayer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onSurfaceTextureAvailable' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureAvailable (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		}

		static bool n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSurfaceTextureDestroyed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onSurfaceTextureDestroyed' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", "GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe bool OnSurfaceTextureDestroyed (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onSurfaceTextureSizeChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureSizeChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureUpdated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onSurfaceTextureUpdated' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", "GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnSurfaceTextureUpdated (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnVideoSizeChanged_Landroid_media_MediaPlayer_IIHandler ()
		{
			if (cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II == null)
				cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnVideoSizeChanged_Landroid_media_MediaPlayer_II);
			return cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
		}

		static void n_OnVideoSizeChanged_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='onVideoSizeChanged' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", "GetOnVideoSizeChanged_Landroid_media_MediaPlayer_IIHandler")]
		public virtual unsafe void OnVideoSizeChanged (global::Android.Media.MediaPlayer p0, int p1, int p2)
		{
			if (id_onVideoSizeChanged_Landroid_media_MediaPlayer_II == IntPtr.Zero)
				id_onVideoSizeChanged_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoSizeChanged_Landroid_media_MediaPlayer_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_prepare;
#pragma warning disable 0169
		static Delegate GetPrepareHandler ()
		{
			if (cb_prepare == null)
				cb_prepare = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Prepare);
			return cb_prepare;
		}

		static void n_Prepare (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Prepare ();
		}
#pragma warning restore 0169

		static IntPtr id_prepare;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()V", "GetPrepareHandler")]
		public virtual unsafe void Prepare ()
		{
			if (id_prepare == IntPtr.Zero)
				id_prepare = JNIEnv.GetMethodID (class_ref, "prepare", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "()V"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		protected virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_releaseObjects;
#pragma warning disable 0169
		static Delegate GetReleaseObjectsHandler ()
		{
			if (cb_releaseObjects == null)
				cb_releaseObjects = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseObjects);
			return cb_releaseObjects;
		}

		static void n_ReleaseObjects (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseObjects ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseObjects;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='releaseObjects' and count(parameter)=0]"
		[Register ("releaseObjects", "()V", "GetReleaseObjectsHandler")]
		protected virtual unsafe void ReleaseObjects ()
		{
			if (id_releaseObjects == IntPtr.Zero)
				id_releaseObjects = JNIEnv.GetMethodID (class_ref, "releaseObjects", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseObjects);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseObjects", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_resize;
#pragma warning disable 0169
		static Delegate GetResizeHandler ()
		{
			if (cb_resize == null)
				cb_resize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resize);
			return cb_resize;
		}

		static void n_Resize (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resize ();
		}
#pragma warning restore 0169

		static IntPtr id_resize;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='resize' and count(parameter)=0]"
		[Register ("resize", "()V", "GetResizeHandler")]
		public virtual unsafe void Resize ()
		{
			if (id_resize == IntPtr.Zero)
				id_resize = JNIEnv.GetMethodID (class_ref, "resize", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resize", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekTo_I;
#pragma warning disable 0169
		static Delegate GetSeekTo_IHandler ()
		{
			if (cb_seekTo_I == null)
				cb_seekTo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SeekTo_I);
			return cb_seekTo_I;
		}

		static void n_SeekTo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekTo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekTo", "(I)V", "GetSeekTo_IHandler")]
		public virtual unsafe void SeekTo (int p0)
		{
			if (id_seekTo_I == IntPtr.Zero)
				id_seekTo_I = JNIEnv.GetMethodID (class_ref, "seekTo", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekTo", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDataSource_Landroid_media_MediaDataSource_Z;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Landroid_media_MediaDataSource_ZHandler ()
		{
			if (cb_setDataSource_Landroid_media_MediaDataSource_Z == null)
				cb_setDataSource_Landroid_media_MediaDataSource_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetDataSource_Landroid_media_MediaDataSource_Z);
			return cb_setDataSource_Landroid_media_MediaDataSource_Z;
		}

		static void n_SetDataSource_Landroid_media_MediaDataSource_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaDataSource p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_media_MediaDataSource_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='android.media.MediaDataSource'] and parameter[2][@type='boolean']]"
		[Register ("setDataSource", "(Landroid/media/MediaDataSource;Z)V", "GetSetDataSource_Landroid_media_MediaDataSource_ZHandler")]
		public virtual unsafe void SetDataSource (global::Android.Media.MediaDataSource p0, bool p1)
		{
			if (id_setDataSource_Landroid_media_MediaDataSource_Z == IntPtr.Zero)
				id_setDataSource_Landroid_media_MediaDataSource_Z = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/media/MediaDataSource;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_media_MediaDataSource_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Landroid/media/MediaDataSource;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_Handler ()
		{
			if (cb_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_ == null)
				cb_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_);
			return cb_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_;
		}

		static void n_SetOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnBufferingUpdateListener p0 = (global::Android.Media.MediaPlayer.IOnBufferingUpdateListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnBufferingUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBufferingUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnBufferingUpdateListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnBufferingUpdateListener']]"
		[Register ("setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V", "GetSetOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_Handler")]
		public virtual unsafe void SetOnBufferingUpdateListener (global::Android.Media.MediaPlayer.IOnBufferingUpdateListener p0)
		{
			if (id_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_ == IntPtr.Zero)
				id_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_ = JNIEnv.GetMethodID (class_ref, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnBufferingUpdateListener_Landroid_media_MediaPlayer_OnBufferingUpdateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_Handler ()
		{
			if (cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ == null)
				cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_);
			return cb_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_;
		}

		static void n_SetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnCompletionListener p0 = (global::Android.Media.MediaPlayer.IOnCompletionListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompletionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnCompletionListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnCompletionListener']]"
		[Register ("setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", "GetSetOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_Handler")]
		public virtual unsafe void SetOnCompletionListener (global::Android.Media.MediaPlayer.IOnCompletionListener p0)
		{
			if (id_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ == IntPtr.Zero)
				id_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompletionListener_Landroid_media_MediaPlayer_OnCompletionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_Handler ()
		{
			if (cb_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_ == null)
				cb_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_);
			return cb_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_;
		}

		static void n_SetOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnErrorListener p0 = (global::Android.Media.MediaPlayer.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnErrorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnErrorListener']]"
		[Register ("setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", "GetSetOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_Handler")]
		public virtual unsafe void SetOnErrorListener (global::Android.Media.MediaPlayer.IOnErrorListener p0)
		{
			if (id_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_ == IntPtr.Zero)
				id_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnErrorListener_Landroid_media_MediaPlayer_OnErrorListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_Handler ()
		{
			if (cb_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_ == null)
				cb_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_);
			return cb_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_;
		}

		static void n_SetOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnInfoListener p0 = (global::Android.Media.MediaPlayer.IOnInfoListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnInfoListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnInfoListener']]"
		[Register ("setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V", "GetSetOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_Handler")]
		public virtual unsafe void SetOnInfoListener (global::Android.Media.MediaPlayer.IOnInfoListener p0)
		{
			if (id_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_ == IntPtr.Zero)
				id_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnInfoListener_Landroid_media_MediaPlayer_OnInfoListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_Handler ()
		{
			if (cb_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_ == null)
				cb_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_);
			return cb_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_;
		}

		static void n_SetOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnPreparedListener p0 = (global::Android.Media.MediaPlayer.IOnPreparedListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnPreparedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreparedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnPreparedListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnPreparedListener']]"
		[Register ("setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", "GetSetOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_Handler")]
		public virtual unsafe void SetOnPreparedListener (global::Android.Media.MediaPlayer.IOnPreparedListener p0)
		{
			if (id_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_ == IntPtr.Zero)
				id_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_ = JNIEnv.GetMethodID (class_ref, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPreparedListener_Landroid_media_MediaPlayer_OnPreparedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_Handler ()
		{
			if (cb_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_ == null)
				cb_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_);
			return cb_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_;
		}

		static void n_SetOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnSeekCompleteListener p0 = (global::Android.Media.MediaPlayer.IOnSeekCompleteListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnSeekCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSeekCompleteListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnSeekCompleteListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnSeekCompleteListener']]"
		[Register ("setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V", "GetSetOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_Handler")]
		public virtual unsafe void SetOnSeekCompleteListener (global::Android.Media.MediaPlayer.IOnSeekCompleteListener p0)
		{
			if (id_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_ == IntPtr.Zero)
				id_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSeekCompleteListener_Landroid_media_MediaPlayer_OnSeekCompleteListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_Handler ()
		{
			if (cb_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_ == null)
				cb_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_);
			return cb_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_;
		}

		static void n_SetOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener p0 = (global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener)global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnVideoSizeChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setOnVideoSizeChangedListener' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer.OnVideoSizeChangedListener']]"
		[Register ("setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V", "GetSetOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_Handler")]
		public virtual unsafe void SetOnVideoSizeChangedListener (global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener p0)
		{
			if (id_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_ == IntPtr.Zero)
				id_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnVideoSizeChangedListener_Landroid_media_MediaPlayer_OnVideoSizeChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVideoPath_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetVideoPath_Ljava_lang_String_ZHandler ()
		{
			if (cb_setVideoPath_Ljava_lang_String_Z == null)
				cb_setVideoPath_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetVideoPath_Ljava_lang_String_Z);
			return cb_setVideoPath_Ljava_lang_String_Z;
		}

		static void n_SetVideoPath_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoPath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoPath_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setVideoPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setVideoPath", "(Ljava/lang/String;Z)V", "GetSetVideoPath_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetVideoPath (string p0, bool p1)
		{
			if (id_setVideoPath_Ljava_lang_String_Z == IntPtr.Zero)
				id_setVideoPath_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setVideoPath", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoPath_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoPath", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setVideoURI_Landroid_net_Uri_Z;
#pragma warning disable 0169
		static Delegate GetSetVideoURI_Landroid_net_Uri_ZHandler ()
		{
			if (cb_setVideoURI_Landroid_net_Uri_Z == null)
				cb_setVideoURI_Landroid_net_Uri_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetVideoURI_Landroid_net_Uri_Z);
			return cb_setVideoURI_Landroid_net_Uri_Z;
		}

		static void n_SetVideoURI_Landroid_net_Uri_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoURI (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoURI_Landroid_net_Uri_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setVideoURI' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='boolean']]"
		[Register ("setVideoURI", "(Landroid/net/Uri;Z)V", "GetSetVideoURI_Landroid_net_Uri_ZHandler")]
		public virtual unsafe void SetVideoURI (global::Android.Net.Uri p0, bool p1)
		{
			if (id_setVideoURI_Landroid_net_Uri_Z == IntPtr.Zero)
				id_setVideoURI_Landroid_net_Uri_Z = JNIEnv.GetMethodID (class_ref, "setVideoURI", "(Landroid/net/Uri;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoURI_Landroid_net_Uri_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoURI", "(Landroid/net/Uri;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVolume_FF;
#pragma warning disable 0169
		static Delegate GetSetVolume_FFHandler ()
		{
			if (cb_setVolume_FF == null)
				cb_setVolume_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetVolume_FF);
			return cb_setVolume_FF;
		}

		static void n_SetVolume_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVolume_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVolume", "(FF)V", "GetSetVolume_FFHandler")]
		public virtual unsafe void SetVolume (float p0, float p1)
		{
			if (id_setVolume_FF == IntPtr.Zero)
				id_setVolume_FF = JNIEnv.GetMethodID (class_ref, "setVolume", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVolume", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_tryToPrepare;
#pragma warning disable 0169
		static Delegate GetTryToPrepareHandler ()
		{
			if (cb_tryToPrepare == null)
				cb_tryToPrepare = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TryToPrepare);
			return cb_tryToPrepare;
		}

		static void n_TryToPrepare (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView __this = global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Renderer.Layout.FullscreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TryToPrepare ();
		}
#pragma warning restore 0169

		static IntPtr id_tryToPrepare;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.layout']/class[@name='FullscreenVideoView']/method[@name='tryToPrepare' and count(parameter)=0]"
		[Register ("tryToPrepare", "()V", "GetTryToPrepareHandler")]
		protected virtual unsafe void TryToPrepare ()
		{
			if (id_tryToPrepare == IntPtr.Zero)
				id_tryToPrepare = JNIEnv.GetMethodID (class_ref, "tryToPrepare", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tryToPrepare);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryToPrepare", "()V"));
			} finally {
			}
		}

	}
}
