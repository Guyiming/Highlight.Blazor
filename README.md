# Highlight.Blazor
Syntax highlighting for Blazor, based on highlight.js

| Build | NuGet |
|--|--|
|![](https://github.com/Guyiming/Highlight.Blazor/workflows/执行Action的Name注意转码/badge.svg)|[![](https://img.shields.io/nuget/v/HighlightBlazor.svg)](https://www.nuget.org/packages/HighlightBlazor)|


![Screenshot of component in action](screenshot.png)

# How to use
You can install the package via the NuGet package manager just search for *Highlight.Blazor*.



## 1. Add Imports
Add the following to your *_Imports.razor*

```csharp
@using HighlightBlazor
```



## 2. Add reference to style sheet(s)
Add the following line to the `head` tag of your `_Host.cshtml` (Blazor Server app) or `index.html` (Blazor WebAssembly).
```
<link href="_content/HighlightBlazor/highlight-blazor-styles.css" rel="stylesheet">
<script src="_content/HighlightBlazor/highlight-blazor.js"></script>
```
These files include the js and default style of highlight.js.

## 3. Happy to use
```html
<p>C# Without Highlight</p>
<pre>
    <code>
                private int currentCount = 0;

                private void IncrementCount()
                {
                    currentCount++;
                }
    </code>
</pre>

<p>C# with indent</p>

        <CodeHighlight>
                private int currentCount = 0;

                private void IncrementCount()
                {
                    currentCount++;
                }
        </CodeHighlight>


<p>C# without indent</p>

        <CodeHighlight Indent="false">
                private int currentCount = 0;

                private void IncrementCount()
                {
                    currentCount++;
                }
        </CodeHighlight>


<p>Json with indent</p>

        <CodeHighlight Indent="true" CodeLanguage="json">
                    {
	                    "success": true,
	                    "data": [
		                    {
			                    "billCode": "BSTPU019524859",
			                    "type": 1
		                    }
	                    ]
                    }
        </CodeHighlight>
```

### Supported Languages
Same to highlight.js. See [here](https://github.com/highlightjs/highlight.js/blob/main/SUPPORTED_LANGUAGES.md).

You can set language by `CodeLanguage` property, the default is **csharp**.


### Indent
By set `Indent` to `false`, can show the origin code. Default value is `true`.


