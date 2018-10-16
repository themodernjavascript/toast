
# react-native-toast

## Getting started

`$ npm install react-native-toast --save`

### Mostly automatic installation

`$ react-native link react-native-toast`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-toast` and add `RNToast.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNToast.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNToastPackage;` to the imports at the top of the file
  - Add `new RNToastPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-toast'
  	project(':react-native-toast').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-toast/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-toast')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNToast.sln` in `node_modules/react-native-toast/windows/RNToast.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Toast.RNToast;` to the usings at the top of the file
  - Add `new RNToastPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNToast from 'react-native-toast';

// TODO: What to do with the module?
RNToast;
```
  