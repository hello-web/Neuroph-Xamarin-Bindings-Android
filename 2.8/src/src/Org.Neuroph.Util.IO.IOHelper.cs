using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='IOHelper']"
	[global::Android.Runtime.Register ("org/neuroph/util/io/IOHelper", DoNotGenerateAcw=true)]
	public partial class IOHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/io/IOHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOHelper); }
		}

		protected IOHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='IOHelper']/constructor[@name='IOHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IOHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IOHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_process_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_util_io_InputAdapter_Lorg_neuroph_util_io_OutputAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='IOHelper']/method[@name='process' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.NeuralNetwork'] and parameter[2][@type='org.neuroph.util.io.InputAdapter'] and parameter[3][@type='org.neuroph.util.io.OutputAdapter']]"
		[Register ("process", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/util/io/InputAdapter;Lorg/neuroph/util/io/OutputAdapter;)V", "")]
		public static unsafe void Process (global::Org.Neuroph.Core.NeuralNetwork p0, global::Org.Neuroph.Util.IO.IInputAdapter p1, global::Org.Neuroph.Util.IO.IOutputAdapter p2)
		{
			if (id_process_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_util_io_InputAdapter_Lorg_neuroph_util_io_OutputAdapter_ == IntPtr.Zero)
				id_process_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_util_io_InputAdapter_Lorg_neuroph_util_io_OutputAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "process", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/util/io/InputAdapter;Lorg/neuroph/util/io/OutputAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_process_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_util_io_InputAdapter_Lorg_neuroph_util_io_OutputAdapter_, __args);
			} finally {
			}
		}

	}
}
