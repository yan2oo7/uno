# Embedding Existing JavaScript Components Into Uno-WASM - Part 3

# Tooling

## TypeScript in Uno-WASM

### TypeScript

If you prefer to use TypeScript instead of JavaScript, you can set it up to output files in the `WasmScripts` folder. Many projects are doing this, the technique won't be covered in this article.

Here's some projects using TypeScript:

* [Uno Calculator](https://github.com/unoplatform/calculator/tree/uno/src/Calculator.Wasm) - port of Windows Calculator.  Uses TypeScriptfor analytics integration.
* [Uno Playground](https://github.com/unoplatform/Uno.Playground/tree/master/src/Uno.Playground.WASM/ts). Uses TypeScript for analytics and fragment navigation.
* [Uno Lottie integration](https://github.com/unoplatform/uno/tree/master/src/AddIns/Uno.UI.Lottie). Uses TypeScript to communicate with `lottie.js` component.



TODO - TODO - TODO

- configuration file
- modules
- async & promises

## Working with NodeJS and package manager

## Using modules

## Dom properties

You can see some of the XAML properties directely in the DOM explorer...

TODO - TODO - TODO - TODO - TODO - TODO - TODO - TODO - TODO - TODO 

```csharp
Uno.UI.FeatureConfiguration.UIElement.AssignDOMXamlProperties = true;
```

# Advanced stuff

## How to layout HTML elements

## How to deploy Wasm applications

- As a aspnet core
- As a PWA