using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples']/class[@name='XorMultiLayerPerceptronSample']"
	[global::Android.Runtime.Register ("org/neuroph/samples/XorMultiLayerPerceptronSample", DoNotGenerateAcw=true)]
	public partial class XorMultiLayerPerceptronSample : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/XorMultiLayerPerceptronSample", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XorMultiLayerPerceptronSample); }
		}

		protected XorMultiLayerPerceptronSample (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples']/class[@name='XorMultiLayerPerceptronSample']/constructor[@name='XorMultiLayerPerceptronSample' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XorMultiLayerPerceptronSample ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (XorMultiLayerPerceptronSample)) {
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

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples']/class[@name='XorMultiLayerPerceptronSample']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples']/class[@name='XorMultiLayerPerceptronSample']/method[@name='testNeuralNetwork' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.NeuralNetwork'] and parameter[2][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("testNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/learning/TrainingSet;)V", "")]
		public static unsafe void TestNeuralNetwork (global::Org.Neuroph.Core.NeuralNetwork p0, global::Org.Neuroph.Core.Learning.TrainingSet p1)
		{
			if (id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetStaticMethodID (class_ref, "testNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_learning_TrainingSet_, __args);
			} finally {
			}
		}

	}
}
