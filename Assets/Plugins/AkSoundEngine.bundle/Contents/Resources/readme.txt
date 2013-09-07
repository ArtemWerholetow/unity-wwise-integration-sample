The Unity C# interface is generated automatically from the C++ interface. 

You must have the Wwise SDK installed.  Make sure the WWISESDK environment variable exist and points to the right path.
The compilation requires Visual Studio 2008 on PC for Windows/XBox360 and Xcode4.2 on Mac for Mac/iOS. You must also have Python2.6 or above installed on your computer. If you would like to automatically deploy the plugin to your Unity assets folder using our provided post-build script, you need to set environment variable UNITY_PROJECT_ROOT to point to your Unity project folder root. 

If all these requirements are met, you only need to build the provided plugin project in Visual Studio or Xcode.

The code generation goes like this:

Step 1: 
The Pre-Build Event of this solution preprocesses Wwise API headers to resolve Wwise macros into standard C/C++ form and blob those headers together, with additional manipulations. The Pre-Build Event then calls SWIG to generate Unity Mono/C# bindings for Wwise SDK APIs. This will generate or update SoundEngine_wrap.cxx depending on whether it already exists or not.

Step 2: 
The C++ code generated from SWIG and manually written is compiled into a dynamically linked library for the designated platform. Note that iOS is a special case, see WwiseUnityIntegration.pdf for detail.

Step 3 (Optional): 
The post-build event tries to deploy the products of Step 1 and 2 to your Unity project's Assets folder. You can disable this step if you prefer your own deployment strategies. By default it is enabled.

You can always edit the scripts used in the above steps yourself to suit your needs.

Please read the documentation included in this distribution for more information on how to 
use the integration. Read our platform-specific documentation for your target platforms when necessary.