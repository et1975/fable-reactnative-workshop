## Before you begin: 
Running Native samples requires react-native CLI and target platform SDK installation.
* ReactNative CLI: https://facebook.github.io/react-native/docs/getting-started.html
* Android: https://developer.android.com/studio/index.html#downloads (23.0.1 platform and build tools)
* iOS: https://developer.apple.com/services-account/download?path=/Developer_Tools/Xcode_8/Xcode_8.xip

The samples do not have the native infrastructure checked in. Do not be alarmed, the `ios/` and `android/` subfolders can be provisioned by the react-native CLI or directly copied across the projects.

## Using the cli example:
> react-native init workshop
> cp -r workshop/ios counter
or
> cp -r workshop/android counter

Important:
Make sure the package.json `id` matches the react-native's project name. This should match the `runnable` name you register in the __`.index.js` files.


## Order of samples to do:
1) counter - basic app
2) container - parent/child composition
3) storage - working with local storage
4) webrequest - calling a web api
5) subscription - feeding a timer into the state updates

